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

    ''' <summary>
    ''' Path for generated file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property savePath As String
        Set(value As String)
            savePathTextBox.Text = value
            My.Settings.odiseeOutputDirectory = value
        End Set
        Get
            Return savePathTextBox.Text
        End Get
    End Property

    ''' <summary>
    ''' Name for generated file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property saveFilename As String
        Set(value As String)
            saveFilenameTextBox.Text = value
            My.Settings.odiseeOutputFilename = value
        End Set
        Get
            Return saveFilenameTextBox.Text
        End Get
    End Property

    ''' <summary>
    ''' The "simple HTTP POST" Odisee client.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property odiseeClient As OdiseeSimpleHttpClient

    Property odiseeServer As String
        Set(value As String)
            odiseeServerURLTextBox.Text = value
            My.Settings.odiseeServer = value
        End Set
        Get
            Return odiseeServerURLTextBox.Text
        End Get
    End Property

    ''' <summary>
    ''' Generate the Odisee service URL from UI/user input.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property odiseeServiceURL As String
        Get
            Return protocolCombobox.Text & "://" & odiseeServer & "/odisee"
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
            Return protocolCombobox.Text & "://" & odiseeServer & odiseeGenerateDocumentURILabel.Text
        End Get
    End Property

    ''' <summary>
    ''' Template, selected by user in a combobox.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property template As String
        Set(value As String)
            templateComboBox.Text = value
            My.Settings.odiseeTemplate = value
        End Set
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
    Property username As String
        Set(value As String)
            usernameTextBox.Text = value
            My.Settings.odiseeUsername = value
        End Set
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
    Property odiseeRequestXML As String
        Set(value As String)
            odiseeRequestXMLTextBox.Text = value
            My.Settings.odiseeRequestXML = value
        End Set
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

    ''' <summary>
    ''' Timeout in seconds.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property timeout As Integer
        Get
            Return CInt(timeoutInSecondsTextBox.Text) * 1000
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
        '
        Text = "Odisee(R) Client " & My.Application.Info.Version.ToString
        ' User settings
        loadUserSettings()
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

#Region "User Interface"

    ''' <summary>
    ''' Load user settings.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub loadUserSettings()
        odiseeServer = My.Settings.odiseeServer
        username = My.Settings.odiseeUsername
        template = My.Settings.odiseeTemplate
        If template = "" Then
            template = "HalloOdisee"
        End If
        savePath = My.Settings.odiseeOutputDirectory
        If savePath = "" Then
            savePath = Environment.GetFolderPath(SpecialFolder.DesktopDirectory)
        End If
        saveFilename = My.Settings.odiseeOutputFilename
        If saveFilename = "" Then
            saveFilename = "OdiseeClientTest.pdf"
        End If
        odiseeRequestXML = My.Settings.odiseeRequestXML
    End Sub

    ''' <summary>
    ''' Save user settings.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub saveUserSettings()
        My.Settings.odiseeServer = odiseeServer
        My.Settings.odiseeTemplate = template
        My.Settings.odiseeUsername = username
        My.Settings.odiseeOutputDirectory = savePath
        My.Settings.odiseeOutputFilename = saveFilename
        My.Settings.odiseeRequestXML = odiseeRequestXML
        'My.Settings.Reset()
        My.Settings.Save()
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
            setUserfield("Hallo", "Welt von " & My.User.Name).
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
        toolStripProgressBar.Style = ProgressBarStyle.Continuous
        toolStripProgressBar.Value = 10
        ' If there is no XML generated by the user, generate it
        If odiseeRequestXML.Length = 0 Then
            makeOdiseeRequestButton_Click(Nothing, Nothing)
        End If
        If odiseeServer = "" Or username = "" Or password = "" Then
            MsgBox("Bitte geben Sie einen Server, Benutzername und Passwort ein!")
        Else
            ' Save user input
            toolStripStatusLabel.Text = "Saving settings..."
            saveUserSettings()
            toolStripProgressBar.Value = 20
            ' Clear log textbox
            logTextBox.Clear()
            Try
                toolStripStatusLabel.Text = "Sending request..."
                toolStripProgressBar.Value = 50
                ' Create Odisee client through factory using a service URL and username/password for HTTP BASIC authentication
                odiseeClient = OdiseeSimpleHttpClient.createClient(odiseeGenerateDocumentURI, username, password)
                ' Create a first request for a certain template
                Dim request1 As XmlElement = odiseeClient.createRequest(template)
                ' Parse XML from textbox
                odiseeClient.xmlDoc.LoadXml(odiseeRequestXML)
                ' Process reponse
                Dim webResponse As HttpWebResponse
                If timeout > 0 Then
                    webResponse = odiseeClient.process(timeout)
                Else
                    webResponse = odiseeClient.process()
                End If
                If Not IsNothing(webResponse) Then
                    If webResponse.ContentLength > 0 Then
                        Dim fullPath As String = savePath & "\" & saveFilename
                        Helper.HttpPost.saveDocument(odiseeClient.xmlDoc, webResponse, fullPath)
                        Try
                            ' Save document to disk
                            Dim process As Process = System.Diagnostics.Process.Start(fullPath)
                            toolStripStatusLabel.Text = "Opening generated document..."
                        Catch ex As Exception
                            MsgBox("Saved " & webResponse.ContentLength & " bytes to " & fullPath)
                        End Try
                    Else
                        MsgBox("Sorry, got no result")
                    End If
                Else
                    MsgBox("Sorry, got invalid response")
                End If
                '
                webResponse.Close()
                toolStripStatusLabel.Text = "Success!"
                toolStripProgressBar.Value = 100
            Catch ex As Exception
                logTextBox.AppendText(ex.ToString())
                logTextBox.ScrollToCaret()
                toolStripStatusLabel.Text = "Failed."
            Finally
                toolStripProgressBar.Value = 0
            End Try
        End If
    End Sub

#End Region

    Private Sub toolStripWebsiteLabel_Click(sender As System.Object, e As System.EventArgs) Handles toolStripWebsiteLabel.Click
        System.Diagnostics.Process.Start("http://www.odisee.de")
    End Sub

End Class
