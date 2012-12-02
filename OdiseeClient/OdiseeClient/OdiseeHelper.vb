'
' Odisee(R)
' Copyright (C) 2005-2010 Informationssysteme Ralf Bensmann, http://www.bensmann.com
' Copyright (C) 2011-2012 art of coding UG, http://www.art-of-coding.eu
'

Option Strict On
Option Explicit On

Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Xml

Namespace Helper

    ''' <summary>
    ''' Helper for desktop applications.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Desktop

        ''' <summary>
        ''' Open an URL, e.g. http://... in a browser.
        ''' </summary>
        ''' <param name="url"></param>
        ''' <remarks></remarks>
        Public Shared Sub openURL(ByVal url As String)
            System.Diagnostics.Process.Start(url)
        End Sub

    End Class

    ''' <summary>
    ''' Helper for processing XML.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Xml

        ''' <summary>
        ''' Pretty print a XML document.
        ''' </summary>
        ''' <param name="xmlDocument"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function prettyPrint(ByRef xmlDocument As XmlDocument) As String
            Dim xmlReader As XmlNodeReader = New XmlNodeReader(xmlDocument)
            Dim stringWriter As StringWriter = New StringWriter()
            Dim xmlWriter As XmlTextWriter = New XmlTextWriter(stringWriter)
            ' Set formatting options
            xmlWriter.Formatting = Formatting.Indented
            xmlWriter.Indentation = 1
            xmlWriter.IndentChar = CChar("  ")
            ' Write the document formatted
            xmlWriter.WriteNode(xmlReader, True)
            '
            Return stringWriter.ToString
        End Function

        ''' <summary>
        ''' Append an instruction to //request/instructions element.
        ''' </summary>
        ''' <param name="requestElement">XmlElement</param>
        ''' <param name="xmlElement">The XmlElement to append to requestElement's last instruction element</param>
        ''' <remarks></remarks>
        Public Shared Sub appendToLastInstruction(ByRef requestElement As XmlElement, ByRef xmlElement As XmlElement)
            Dim nodes As XmlNodeList = requestElement.SelectNodes(OdiseeConstant.LAST_INSTRUCTION_OF_REQUEST)
            Dim item As XmlNode = nodes.Item(0)
            item.AppendChild(xmlElement)
        End Sub

        ''' <summary>
        ''' Append an instruction to request's //request[last()]/post-process/instructions[last()] element. 
        ''' </summary>
        ''' <param name="requestElement"></param>
        ''' <param name="xmlElement"></param>
        ''' <remarks></remarks>
        Public Shared Sub appendPostProcessInstruction(ByRef requestElement As XmlElement, ByRef xmlElement As XmlElement)
            ' Get (or create) <post-process> element
            Dim postProcessNode As XmlNode = requestElement.SelectSingleNode("post-process")
            If IsNothing(postProcessNode) Then
                postProcessNode = requestElement.OwnerDocument.CreateElement("post-process")
                requestElement.AppendChild(postProcessNode)
            End If
            ' Get (or create) <instructions> element
            Dim nodes As XmlNodeList = postProcessNode.SelectNodes(OdiseeConstant.LAST_INSTRUCTION_OF_POSTPROCESS)
            Dim instructionsElement As XmlNode
            If nodes.Count > 0 Then
                instructionsElement = nodes.Item(0)
            Else
                instructionsElement = postProcessNode.OwnerDocument.CreateElement("instructions")
                postProcessNode.AppendChild(instructionsElement)
            End If
            ' Append instruction
            instructionsElement.AppendChild(xmlElement)
        End Sub

    End Class

    ''' <summary>
    ''' Helper for HTTP POSTs to Odisee servers.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class HttpPost

        ''' <summary>
        ''' Did we already initialize the HTTP digest authentication process?
        ''' </summary>
        ''' <remarks></remarks>
        Private Shared initializedHttpDigestAuth As Boolean = False

        ''' <summary>
        ''' Create a HttpWebRequest object which can be used with Odisee server.
        ''' </summary>
        ''' <param name="serviceURL"></param>
        ''' <param name="username"></param>
        ''' <param name="password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Shared Function makeHttpWebRequest(ByRef serviceURL As Uri, Optional ByVal username As String = Nothing, Optional ByVal password As String = Nothing) As HttpWebRequest
            ' Create instance of WebRequest
            Dim httpWebRequest As HttpWebRequest = CType(httpWebRequest.Create(serviceURL), Net.HttpWebRequest)
            ' Authentication!?
            Dim cc As CredentialCache = New CredentialCache()
            If Not IsNothing(username) And Not IsNothing(password) Then
                ' HTTP Digest Authentication
                cc.Add(serviceURL, "Digest", New NetworkCredential(username, password))
                httpWebRequest.Credentials = cc
                httpWebRequest.PreAuthenticate = True
            End If
            Return httpWebRequest
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="xmlDocument"></param>
        ''' <param name="serviceURL"></param>
        ''' <param name="username"></param>
        ''' <param name="password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function doBasicAuthPost(ByRef xmlDocument As XmlDocument, ByRef serviceURL As Uri, Optional ByVal username As String = Nothing, Optional ByVal password As String = Nothing) As WebResponse
            ' Create instance of WebRequest
            Dim webRequest As WebRequest = webRequest.Create(serviceURL)
            webRequest.Method = "POST"
            webRequest.ContentType = "text/xml"
            ' Authentication?
            If Not IsNothing(username) And Not IsNothing(password) Then
                ' BASIC
                Dim authInfo As String = username & ":" & password
                authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo))
                webRequest.Headers.Set("Authorization", "Basic " & authInfo)
            End If
            ' Create byte buffer from XML string
            Dim byteBuffer() As Byte = Encoding.UTF8.GetBytes(xmlDocument.OuterXml)
            webRequest.ContentLength = byteBuffer.Length()
            ' Send request
            Try
                Dim stream As Stream = webRequest.GetRequestStream()
                stream.Write(byteBuffer, 0, byteBuffer.Length)
                stream.Close()
                stream.Dispose()
                ' Return response
                Return webRequest.GetResponse()
            Catch ex As Exception
                ' Handle exceptions
                ' HTTP 401: Not authorized, check username/password if any
                ' HTTP 404: Not found, maybe Odisee Server URL or XML request is empty or corrupt
                Throw ex
            End Try
        End Function

        ''' <summary>
        ''' Post a XML request to Odisee server using HTTP digest authentication.
        ''' </summary>
        ''' <param name="xmlDocument"></param>
        ''' <param name="serviceURL"></param>
        ''' <param name="username"></param>
        ''' <param name="password"></param>
        ''' <param name="timeout">In Milliseconds</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function doPost(ByRef xmlDocument As XmlDocument, ByRef serviceURL As Uri, Optional ByVal username As String = Nothing, Optional ByVal password As String = Nothing, Optional ByVal timeout As Integer = 30000) As HttpWebResponse
            Dim httpWebRequest As HttpWebRequest
            If Not initializedHttpDigestAuth Then
                ' Create instance of WebRequest
                httpWebRequest = makeHttpWebRequest(serviceURL, username, password)
                ' Make first request because we will receive HTTP 505
                ' Result of first request is a HTTP 401 Not authorized, this is due to HTTP digest authentication
                httpWebRequest.Method = "GET"
                Try
                    Dim firstResponse As WebResponse = httpWebRequest.GetResponse()
                    firstResponse.Close()
                    initializedHttpDigestAuth = True
                Catch ex As Exception
                    ' HTTP 401 Not authorized, ok in first step of Digest authentication
                End Try
            End If
            ' Create new instance of WebRequest
            httpWebRequest = makeHttpWebRequest(serviceURL, username, password)
            httpWebRequest.Method = "POST"
            httpWebRequest.ContentType = "text/xml"
            ' Create byte buffer from XML string
            Dim byteBuffer() As Byte = Encoding.UTF8.GetBytes(xmlDocument.OuterXml)
            ' Send request
            Dim httpWebResponse As HttpWebResponse = Nothing
            Try
                ' Set content length
                httpWebRequest.ContentLength = byteBuffer.Length()
                ' Timeout
                httpWebRequest.Timeout = timeout
                ' Write to request stream
                Dim stream As Stream = httpWebRequest.GetRequestStream()
                stream.Write(byteBuffer, 0, byteBuffer.Length)
                ' Do not: stream.Close() and stream.Dispose(), subsequent requests will die at .GetRequestStream()
                ' Return response
                httpWebResponse = CType(httpWebRequest.GetResponse(), Net.HttpWebResponse)
            Catch ex As Exception
                ' Handle exceptions
                ' HTTP 401: Not authorized, check username/password if any
                ' HTTP 404: Not found, maybe Odisee Server URL or XML request is empty or corrupt
                Throw ex
            End Try
            Return httpWebResponse
        End Function

        ''' <summary>
        ''' Save a document to disk. Process Odisee server's response and save the returned byte stream to a file.
        ''' </summary>
        ''' <param name="xmlDocument"></param>
        ''' <param name="httpWebResponse"></param>
        ''' <param name="filepath"></param>
        ''' <remarks></remarks>
        Public Shared Sub saveDocument(ByRef xmlDocument As XmlDocument, ByRef httpWebResponse As HttpWebResponse, Optional ByVal filepath As String = Nothing)
            ' Set filepath from request name
            If IsNothing(filepath) Then
                filepath = xmlDocument.SelectSingleNode(OdiseeConstant.REQUEST_NAME).InnerText
            End If
            ' Get response code
            Dim status As String = HttpWebResponse.StatusDescription.ToString()
            ' Open file handle
            Dim fileStream As FileStream = New FileStream(filepath, FileMode.Create)
            ' Buffer for reading response stream
            Dim bufferSize As Integer = 8 * 1024
            Dim byteBuffer(bufferSize) As Byte
            Dim responseStream As Stream = Nothing
            Try
                ' Get response stream
                responseStream = HttpWebResponse.GetResponseStream()
                ' Read bytes and write them to file
                Dim readCount As Integer = responseStream.Read(byteBuffer, 0, bufferSize)
                Dim totalReadCount As Long
                While (readCount > 0)
                    fileStream.Write(byteBuffer, 0, readCount)
                    readCount = responseStream.Read(byteBuffer, 0, bufferSize)
                    totalReadCount = totalReadCount + readCount
                End While
                ' Compare read byte count with content-length header
                If totalReadCount <> HttpWebResponse.ContentLength Then
                Else
                    ' Error handling
                End If
            Catch ex As Exception
                Throw ex
            Finally
                ' Close streams
                If Not IsNothing(responseStream) Then
                    responseStream.Close()
                    responseStream.Dispose()
                End If
                If Not IsNothing(fileStream) Then
                    fileStream.Close()
                    fileStream.Dispose()
                End If
            End Try
        End Sub

    End Class

End Namespace
