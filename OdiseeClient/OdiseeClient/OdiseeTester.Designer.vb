﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OdiseeTester
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OdiseeTester))
        Me.odiseeServerURLTextBox = New System.Windows.Forms.TextBox()
        Me.odiseeRequestXMLTextBox = New System.Windows.Forms.TextBox()
        Me.makeOdiseeRequestButton = New System.Windows.Forms.Button()
        Me.sendOdiseeRequestButton = New System.Windows.Forms.Button()
        Me.templateComboBox = New System.Windows.Forms.ComboBox()
        Me.odiseeTemplatesLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.odiseeServiceURLLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.protocolCombobox = New System.Windows.Forms.ComboBox()
        Me.odiseeGenerateDocumentURILabel = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.mergeDocumentCheckBox = New System.Windows.Forms.CheckBox()
        Me.mergeDocumentTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.logTextBox = New System.Windows.Forms.RichTextBox()
        Me.folderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.chooseFolderButton = New System.Windows.Forms.Button()
        Me.savePathTextBox = New System.Windows.Forms.TextBox()
        Me.odiseeSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.odiseeLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.odiseeInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.odiseeOutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.saveFilenameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toolbarStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.toolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.toolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.toolStripWebsiteLabel = New System.Windows.Forms.ToolStripLabel()
        Me.timeoutInSecondsTextBox = New System.Windows.Forms.TextBox()
        Me.timeoutInSecondsLabel = New System.Windows.Forms.Label()
        Me.odiseeSettingsGroupBox.SuspendLayout()
        CType(Me.odiseeLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.odiseeInputGroupBox.SuspendLayout()
        Me.odiseeOutputGroupBox.SuspendLayout()
        Me.toolbarStatusStrip.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'odiseeServerURLTextBox
        '
        Me.odiseeServerURLTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.odiseeServerURLTextBox.Location = New System.Drawing.Point(244, 14)
        Me.odiseeServerURLTextBox.Name = "odiseeServerURLTextBox"
        Me.odiseeServerURLTextBox.Size = New System.Drawing.Size(221, 20)
        Me.odiseeServerURLTextBox.TabIndex = 2
        Me.odiseeServerURLTextBox.Text = "127.0.0.1"
        '
        'odiseeRequestXMLTextBox
        '
        Me.odiseeRequestXMLTextBox.AutoCompleteCustomSource.AddRange(New String() {"odisee", "request"})
        Me.odiseeRequestXMLTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.odiseeRequestXMLTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.odiseeRequestXMLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.odiseeRequestXMLTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.odiseeRequestXMLTextBox.Location = New System.Drawing.Point(6, 73)
        Me.odiseeRequestXMLTextBox.Multiline = True
        Me.odiseeRequestXMLTextBox.Name = "odiseeRequestXMLTextBox"
        Me.odiseeRequestXMLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.odiseeRequestXMLTextBox.Size = New System.Drawing.Size(968, 268)
        Me.odiseeRequestXMLTextBox.TabIndex = 8
        Me.odiseeRequestXMLTextBox.WordWrap = False
        '
        'makeOdiseeRequestButton
        '
        Me.makeOdiseeRequestButton.Location = New System.Drawing.Point(840, 43)
        Me.makeOdiseeRequestButton.Name = "makeOdiseeRequestButton"
        Me.makeOdiseeRequestButton.Size = New System.Drawing.Size(134, 23)
        Me.makeOdiseeRequestButton.TabIndex = 7
        Me.makeOdiseeRequestButton.Text = "Make Odisee request"
        Me.makeOdiseeRequestButton.UseVisualStyleBackColor = True
        '
        'sendOdiseeRequestButton
        '
        Me.sendOdiseeRequestButton.Location = New System.Drawing.Point(840, 17)
        Me.sendOdiseeRequestButton.Name = "sendOdiseeRequestButton"
        Me.sendOdiseeRequestButton.Size = New System.Drawing.Size(134, 23)
        Me.sendOdiseeRequestButton.TabIndex = 12
        Me.sendOdiseeRequestButton.Text = "Send to Odisee Server"
        Me.sendOdiseeRequestButton.UseVisualStyleBackColor = True
        '
        'templateComboBox
        '
        Me.templateComboBox.FormattingEnabled = True
        Me.templateComboBox.Location = New System.Drawing.Point(156, 13)
        Me.templateComboBox.Name = "templateComboBox"
        Me.templateComboBox.Size = New System.Drawing.Size(213, 21)
        Me.templateComboBox.TabIndex = 5
        '
        'odiseeTemplatesLinkLabel
        '
        Me.odiseeTemplatesLinkLabel.AutoSize = True
        Me.odiseeTemplatesLinkLabel.Location = New System.Drawing.Point(6, 16)
        Me.odiseeTemplatesLinkLabel.Name = "odiseeTemplatesLinkLabel"
        Me.odiseeTemplatesLinkLabel.Size = New System.Drawing.Size(51, 13)
        Me.odiseeTemplatesLinkLabel.TabIndex = 20
        Me.odiseeTemplatesLinkLabel.TabStop = True
        Me.odiseeTemplatesLinkLabel.Text = "Template"
        '
        'odiseeServiceURLLinkLabel
        '
        Me.odiseeServiceURLLinkLabel.AutoSize = True
        Me.odiseeServiceURLLinkLabel.Location = New System.Drawing.Point(6, 16)
        Me.odiseeServiceURLLinkLabel.Name = "odiseeServiceURLLinkLabel"
        Me.odiseeServiceURLLinkLabel.Size = New System.Drawing.Size(104, 13)
        Me.odiseeServiceURLLinkLabel.TabIndex = 0
        Me.odiseeServiceURLLinkLabel.TabStop = True
        Me.odiseeServiceURLLinkLabel.Text = "Odisee Service URL"
        '
        'protocolCombobox
        '
        Me.protocolCombobox.FormattingEnabled = True
        Me.protocolCombobox.Items.AddRange(New Object() {"http", "https"})
        Me.protocolCombobox.Location = New System.Drawing.Point(156, 13)
        Me.protocolCombobox.Name = "protocolCombobox"
        Me.protocolCombobox.Size = New System.Drawing.Size(56, 21)
        Me.protocolCombobox.TabIndex = 1
        Me.protocolCombobox.Text = "http"
        '
        'odiseeGenerateDocumentURILabel
        '
        Me.odiseeGenerateDocumentURILabel.AutoSize = True
        Me.odiseeGenerateDocumentURILabel.Location = New System.Drawing.Point(471, 16)
        Me.odiseeGenerateDocumentURILabel.Name = "odiseeGenerateDocumentURILabel"
        Me.odiseeGenerateDocumentURILabel.Size = New System.Drawing.Size(142, 13)
        Me.odiseeGenerateDocumentURILabel.TabIndex = 0
        Me.odiseeGenerateDocumentURILabel.Text = "/odisee/document/generate"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(156, 40)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.usernameTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username and password"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(315, 40)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(150, 20)
        Me.passwordTextBox.TabIndex = 4
        Me.passwordTextBox.UseSystemPasswordChar = True
        '
        'mergeDocumentCheckBox
        '
        Me.mergeDocumentCheckBox.AutoSize = True
        Me.mergeDocumentCheckBox.Location = New System.Drawing.Point(9, 43)
        Me.mergeDocumentCheckBox.Name = "mergeDocumentCheckBox"
        Me.mergeDocumentCheckBox.Size = New System.Drawing.Size(106, 17)
        Me.mergeDocumentCheckBox.TabIndex = 21
        Me.mergeDocumentCheckBox.Text = "Merge document"
        Me.mergeDocumentCheckBox.UseVisualStyleBackColor = True
        '
        'mergeDocumentTextBox
        '
        Me.mergeDocumentTextBox.Location = New System.Drawing.Point(156, 41)
        Me.mergeDocumentTextBox.Name = "mergeDocumentTextBox"
        Me.mergeDocumentTextBox.Size = New System.Drawing.Size(212, 20)
        Me.mergeDocumentTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "://"
        '
        'logTextBox
        '
        Me.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.logTextBox.Location = New System.Drawing.Point(8, 46)
        Me.logTextBox.Name = "logTextBox"
        Me.logTextBox.ReadOnly = True
        Me.logTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.logTextBox.Size = New System.Drawing.Size(966, 112)
        Me.logTextBox.TabIndex = 22
        Me.logTextBox.Text = ""
        '
        'chooseFolderButton
        '
        Me.chooseFolderButton.Location = New System.Drawing.Point(8, 17)
        Me.chooseFolderButton.Name = "chooseFolderButton"
        Me.chooseFolderButton.Size = New System.Drawing.Size(83, 23)
        Me.chooseFolderButton.TabIndex = 9
        Me.chooseFolderButton.Text = "Directory..."
        Me.chooseFolderButton.UseVisualStyleBackColor = True
        '
        'savePathTextBox
        '
        Me.savePathTextBox.Location = New System.Drawing.Point(97, 20)
        Me.savePathTextBox.Name = "savePathTextBox"
        Me.savePathTextBox.Size = New System.Drawing.Size(206, 20)
        Me.savePathTextBox.TabIndex = 10
        '
        'odiseeSettingsGroupBox
        '
        Me.odiseeSettingsGroupBox.Controls.Add(Me.odiseeLogoPictureBox)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.Label2)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.passwordTextBox)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.Label1)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.usernameTextBox)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.odiseeGenerateDocumentURILabel)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.protocolCombobox)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.odiseeServiceURLLinkLabel)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.odiseeServerURLTextBox)
        Me.odiseeSettingsGroupBox.Location = New System.Drawing.Point(12, 28)
        Me.odiseeSettingsGroupBox.Name = "odiseeSettingsGroupBox"
        Me.odiseeSettingsGroupBox.Size = New System.Drawing.Size(980, 86)
        Me.odiseeSettingsGroupBox.TabIndex = 21
        Me.odiseeSettingsGroupBox.TabStop = False
        Me.odiseeSettingsGroupBox.Text = "Odisee Server Settings"
        '
        'odiseeLogoPictureBox
        '
        Me.odiseeLogoPictureBox.Image = Global.Odisee.Client.My.Resources.Resources.Odisee_Signet_64x64
        Me.odiseeLogoPictureBox.Location = New System.Drawing.Point(910, 13)
        Me.odiseeLogoPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.odiseeLogoPictureBox.MaximumSize = New System.Drawing.Size(64, 64)
        Me.odiseeLogoPictureBox.Name = "odiseeLogoPictureBox"
        Me.odiseeLogoPictureBox.Size = New System.Drawing.Size(64, 64)
        Me.odiseeLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.odiseeLogoPictureBox.TabIndex = 17
        Me.odiseeLogoPictureBox.TabStop = False
        '
        'odiseeInputGroupBox
        '
        Me.odiseeInputGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.odiseeInputGroupBox.Controls.Add(Me.mergeDocumentTextBox)
        Me.odiseeInputGroupBox.Controls.Add(Me.mergeDocumentCheckBox)
        Me.odiseeInputGroupBox.Controls.Add(Me.odiseeTemplatesLinkLabel)
        Me.odiseeInputGroupBox.Controls.Add(Me.templateComboBox)
        Me.odiseeInputGroupBox.Controls.Add(Me.makeOdiseeRequestButton)
        Me.odiseeInputGroupBox.Controls.Add(Me.odiseeRequestXMLTextBox)
        Me.odiseeInputGroupBox.Location = New System.Drawing.Point(12, 120)
        Me.odiseeInputGroupBox.Name = "odiseeInputGroupBox"
        Me.odiseeInputGroupBox.Size = New System.Drawing.Size(980, 347)
        Me.odiseeInputGroupBox.TabIndex = 22
        Me.odiseeInputGroupBox.TabStop = False
        Me.odiseeInputGroupBox.Text = "Input for Odisee Server"
        '
        'odiseeOutputGroupBox
        '
        Me.odiseeOutputGroupBox.Controls.Add(Me.timeoutInSecondsLabel)
        Me.odiseeOutputGroupBox.Controls.Add(Me.timeoutInSecondsTextBox)
        Me.odiseeOutputGroupBox.Controls.Add(Me.saveFilenameTextBox)
        Me.odiseeOutputGroupBox.Controls.Add(Me.Label3)
        Me.odiseeOutputGroupBox.Controls.Add(Me.savePathTextBox)
        Me.odiseeOutputGroupBox.Controls.Add(Me.chooseFolderButton)
        Me.odiseeOutputGroupBox.Controls.Add(Me.logTextBox)
        Me.odiseeOutputGroupBox.Controls.Add(Me.sendOdiseeRequestButton)
        Me.odiseeOutputGroupBox.Location = New System.Drawing.Point(12, 473)
        Me.odiseeOutputGroupBox.Name = "odiseeOutputGroupBox"
        Me.odiseeOutputGroupBox.Size = New System.Drawing.Size(984, 164)
        Me.odiseeOutputGroupBox.TabIndex = 23
        Me.odiseeOutputGroupBox.TabStop = False
        Me.odiseeOutputGroupBox.Text = "Output from Odisee Server"
        '
        'saveFilenameTextBox
        '
        Me.saveFilenameTextBox.Location = New System.Drawing.Point(374, 19)
        Me.saveFilenameTextBox.Name = "saveFilenameTextBox"
        Me.saveFilenameTextBox.Size = New System.Drawing.Size(176, 20)
        Me.saveFilenameTextBox.TabIndex = 11
        Me.saveFilenameTextBox.Text = "OdiseeClientTest.pdf"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Dateiname"
        '
        'toolbarStatusStrip
        '
        Me.toolbarStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripProgressBar, Me.toolStripStatusLabel})
        Me.toolbarStatusStrip.Location = New System.Drawing.Point(0, 640)
        Me.toolbarStatusStrip.Name = "toolbarStatusStrip"
        Me.toolbarStatusStrip.Size = New System.Drawing.Size(1008, 22)
        Me.toolbarStatusStrip.TabIndex = 24
        Me.toolbarStatusStrip.Text = "h"
        '
        'toolStripProgressBar
        '
        Me.toolStripProgressBar.Name = "toolStripProgressBar"
        Me.toolStripProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'toolStripStatusLabel
        '
        Me.toolStripStatusLabel.Name = "toolStripStatusLabel"
        Me.toolStripStatusLabel.Size = New System.Drawing.Size(40, 17)
        Me.toolStripStatusLabel.Text = "Bereit."
        '
        'toolStrip
        '
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripWebsiteLabel})
        Me.toolStrip.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(1008, 25)
        Me.toolStrip.TabIndex = 25
        Me.toolStrip.Text = "toolStrip"
        '
        'toolStripWebsiteLabel
        '
        Me.toolStripWebsiteLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolStripWebsiteLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripWebsiteLabel.IsLink = True
        Me.toolStripWebsiteLabel.Name = "toolStripWebsiteLabel"
        Me.toolStripWebsiteLabel.Size = New System.Drawing.Size(87, 22)
        Me.toolStripWebsiteLabel.Text = "www.odisee.de"
        '
        'timeoutInSecondsTextBox
        '
        Me.timeoutInSecondsTextBox.Location = New System.Drawing.Point(794, 19)
        Me.timeoutInSecondsTextBox.Name = "timeoutInSecondsTextBox"
        Me.timeoutInSecondsTextBox.Size = New System.Drawing.Size(35, 20)
        Me.timeoutInSecondsTextBox.TabIndex = 23
        Me.timeoutInSecondsTextBox.Text = "20"
        '
        'timeoutInSecondsLabel
        '
        Me.timeoutInSecondsLabel.AutoSize = True
        Me.timeoutInSecondsLabel.Location = New System.Drawing.Point(689, 22)
        Me.timeoutInSecondsLabel.Name = "timeoutInSecondsLabel"
        Me.timeoutInSecondsLabel.Size = New System.Drawing.Size(99, 13)
        Me.timeoutInSecondsLabel.TabIndex = 24
        Me.timeoutInSecondsLabel.Text = "Timeout in seconds"
        '
        'OdiseeTester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.toolbarStatusStrip)
        Me.Controls.Add(Me.odiseeSettingsGroupBox)
        Me.Controls.Add(Me.odiseeInputGroupBox)
        Me.Controls.Add(Me.odiseeOutputGroupBox)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "OdiseeTester"
        Me.Text = "Odisee(R) Client"
        Me.odiseeSettingsGroupBox.ResumeLayout(False)
        Me.odiseeSettingsGroupBox.PerformLayout()
        CType(Me.odiseeLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.odiseeInputGroupBox.ResumeLayout(False)
        Me.odiseeInputGroupBox.PerformLayout()
        Me.odiseeOutputGroupBox.ResumeLayout(False)
        Me.odiseeOutputGroupBox.PerformLayout()
        Me.toolbarStatusStrip.ResumeLayout(False)
        Me.toolbarStatusStrip.PerformLayout()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents odiseeServerURLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents odiseeRequestXMLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents makeOdiseeRequestButton As System.Windows.Forms.Button
    Friend WithEvents sendOdiseeRequestButton As System.Windows.Forms.Button
    Friend WithEvents templateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents odiseeTemplatesLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents odiseeServiceURLLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents protocolCombobox As System.Windows.Forms.ComboBox
    Friend WithEvents odiseeGenerateDocumentURILabel As System.Windows.Forms.Label
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents mergeDocumentCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents mergeDocumentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents logTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents folderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chooseFolderButton As System.Windows.Forms.Button
    Friend WithEvents savePathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents odiseeSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents odiseeInputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents odiseeOutputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents odiseeLogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents saveFilenameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents toolbarStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents toolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents toolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripWebsiteLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents timeoutInSecondsLabel As System.Windows.Forms.Label
    Friend WithEvents timeoutInSecondsTextBox As System.Windows.Forms.TextBox

End Class
