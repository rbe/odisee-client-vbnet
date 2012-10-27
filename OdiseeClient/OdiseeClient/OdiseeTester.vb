'
' Odisee(R)
' Copyright (C) 2005-2010 Informationssysteme Ralf Bensmann, http://www.bensmann.com
' Copyright (C) 2011-2012 art of coding UG, http://www.art-of-coding.eu
'

Option Strict On
Option Explicit On

Imports System.IO
Imports System.Net
Imports System.Xml
Imports Odisee.Client.Http
Imports System.Environment

''' <summary>
''' Test requests against an Odisee server.
''' </summary>
''' <remarks></remarks>
Public Class OdiseeTester

#Region "Properties"

    Private Property savePath As String

    ''' <summary>
    ''' The "simple HTTP POST" Odisee client.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property odiseeClient As OdiseeSimpleHttpClient

    ''' <summary>
    ''' Generate the Odisee service URL from UI/user input.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property odiseeServiceURL As String
        Get
            Return protocolCombobox.Text & "://" & odiseeServerURL.Text & "/odisee"
        End Get
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property odiseeGenerateDocumentURI As String
        Get
            Return protocolCombobox.Text & "://" & odiseeServerURL.Text & odiseeGenerateDocumentURILabel.Text
        End Get
    End Property

    ''' <summary>
    ''' Template, selected by user in a combobox.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property template As String
        Get
            Return templateComboBox.Text
        End Get
    End Property

    ''' <summary>
    ''' Username entered by user in a textbox.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property username As String
        Get
            Return usernameTextBox.Text
        End Get
    End Property

    ''' <summary>
    ''' Password entered by user in a textbox.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property password As String
        Get
            Return passwordTextBox.Text
        End Get
    End Property

    ''' <summary>
    ''' Odisee XML request, entered into a textbox.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property odiseeXML As String
        Get
            Return odiseeRequestXMLTextBox.Text
        End Get
    End Property

    ''' <summary>
    ''' Get file path entered by user for merging a document.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property mergeDocumentAtEndPath As String
        Get
            Return mergeDocumentTextBox.Text
        End Get
    End Property

#End Region

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        savePath = Environment.GetFolderPath(SpecialFolder.DesktopDirectory)
        savePathTextBox.Text = savePath
    End Sub

#Region "Event Listener"

    ''' <summary>
    ''' Open the Odisee Server web application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub odiseeServiceURLLinkLabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles odiseeServiceURLLinkLabel.LinkClicked
        Helper.Desktop.openURL(odiseeServiceURL)
    End Sub

#End Region

#Region "Odisee Button Events"

    ''' <summary>
    ''' Show folder chooser to select destination directory for saving generated documents locally.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chooseFolderButton_Click(sender As System.Object, e As System.EventArgs) Handles chooseFolderButton.Click
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            savePath = folderBrowserDialog.SelectedPath
            savePathTextBox.Text = savePath
        End If
    End Sub

    ''' <summary>
    ''' Set standard demonstration template, shipped with Odisee Server.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub odiseeTemplatesLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles odiseeTemplatesLinkLabel.LinkClicked
        templateComboBox.Text = "HalloOdisee"
    End Sub

    ''' <summary>
    ''' Generate an Odisee request XML document.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub makeOdiseeRequestButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles makeOdiseeRequestButton.Click
        ' Create Odisee client through factory
        odiseeClient = OdiseeSimpleHttpClient.createClient()
        ' Create a first request for a certain template
        Dim request1 As XmlElement = odiseeClient.createRequest(template)
        ' Set some values using the fluent API...
        odiseeClient.
            setUserfield("Hallo", "Welt von OdiseeClient/VB.NET").
            setTableCellValue("Tabelle1", "A4", "Dieser Text stammt vom OdiseeClient/VB.NET!")
        ' Merge document?
        If mergeDocumentCheckBox.Checked Then
            odiseeClient.mergeDocumentAtEnd(mergeDocumentAtEndPath)
        End If
        ' Show request XML in textbox
        odiseeRequestXMLTextBox.Text = Helper.Xml.prettyPrint(odiseeClient.xmlDoc)
    End Sub

    ''' <summary>
    ''' Send request to Odisee server.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub sendOdiseeRequestButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sendOdiseeRequestButton.Click
        ' If there is no XML generated by the user, generate it
        If odiseeRequestXMLTextBox.Text.Length = 0 Then
            makeOdiseeRequestButton_Click(Nothing, Nothing)
        End If
        ' Clear log textbox
        logTextBox.Clear()
        Try
            ' Create Odisee client through factory using a service URL and username/password for HTTP BASIC authentication
            odiseeClient = OdiseeSimpleHttpClient.createClient(odiseeGenerateDocumentURI, username, password)
            ' Create a first request for a certain template
            Dim request1 As XmlElement = odiseeClient.createRequest(template)
            ' Parse XML from textbox
            odiseeClient.xmlDoc.LoadXml(odiseeRequestXMLTextBox.Text)
            ' Process reponse: save document to disk
            Dim webResponse As WebResponse = odiseeClient.process()
            If Not IsNothing(webResponse) Then
                If webResponse.ContentLength > 0 Then
                    Dim filename As String = "OdiseeClientTest.pdf"
                    Dim fullPath As String = savePathTextBox.Text & "\" & filename
                    Helper.HttpPost.saveDocument(odiseeClient.xmlDoc, webResponse, fullPath)
                    Try
                        Dim process As Process = System.Diagnostics.Process.Start(fullPath)
                        'process.WaitForExit()
                    Catch ex As Exception
                        MsgBox("Saved " & webResponse.ContentLength & " bytes to " & fullPath)
                    End Try
                Else
                    MsgBox("Sorry, got no result")
                End If
            Else
                MsgBox("Sorry, got invalid response")
            End If
        Catch ex As Exception
            logTextBox.AppendText(ex.ToString())
            logTextBox.ScrollToCaret()
        End Try
    End Sub

#End Region

End Class
