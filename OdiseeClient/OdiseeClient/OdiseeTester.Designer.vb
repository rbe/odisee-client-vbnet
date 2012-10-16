<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.odiseeServerURL = New System.Windows.Forms.TextBox()
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
        Me.odiseeInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.odiseeOutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.odiseeSettingsGroupBox.SuspendLayout()
        Me.odiseeInputGroupBox.SuspendLayout()
        Me.odiseeOutputGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'odiseeServerURL
        '
        Me.odiseeServerURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.odiseeServerURL.Location = New System.Drawing.Point(244, 14)
        Me.odiseeServerURL.Name = "odiseeServerURL"
        Me.odiseeServerURL.Size = New System.Drawing.Size(221, 20)
        Me.odiseeServerURL.TabIndex = 2
        Me.odiseeServerURL.Text = "127.0.0.1"
        '
        'odiseeRequestXMLTextBox
        '
        Me.odiseeRequestXMLTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.odiseeRequestXMLTextBox.Location = New System.Drawing.Point(6, 73)
        Me.odiseeRequestXMLTextBox.Multiline = True
        Me.odiseeRequestXMLTextBox.Name = "odiseeRequestXMLTextBox"
        Me.odiseeRequestXMLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.odiseeRequestXMLTextBox.Size = New System.Drawing.Size(968, 225)
        Me.odiseeRequestXMLTextBox.TabIndex = 6
        Me.odiseeRequestXMLTextBox.WordWrap = False
        '
        'makeOdiseeRequestButton
        '
        Me.makeOdiseeRequestButton.Location = New System.Drawing.Point(840, 43)
        Me.makeOdiseeRequestButton.Name = "makeOdiseeRequestButton"
        Me.makeOdiseeRequestButton.Size = New System.Drawing.Size(134, 23)
        Me.makeOdiseeRequestButton.TabIndex = 0
        Me.makeOdiseeRequestButton.Text = "Make Odisee request"
        Me.makeOdiseeRequestButton.UseVisualStyleBackColor = True
        '
        'sendOdiseeRequestButton
        '
        Me.sendOdiseeRequestButton.Location = New System.Drawing.Point(840, 17)
        Me.sendOdiseeRequestButton.Name = "sendOdiseeRequestButton"
        Me.sendOdiseeRequestButton.Size = New System.Drawing.Size(134, 23)
        Me.sendOdiseeRequestButton.TabIndex = 0
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
        Me.odiseeTemplatesLinkLabel.TabIndex = 6
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
        Me.mergeDocumentCheckBox.TabIndex = 14
        Me.mergeDocumentCheckBox.Text = "Merge document"
        Me.mergeDocumentCheckBox.UseVisualStyleBackColor = True
        '
        'mergeDocumentTextBox
        '
        Me.mergeDocumentTextBox.Location = New System.Drawing.Point(156, 41)
        Me.mergeDocumentTextBox.Name = "mergeDocumentTextBox"
        Me.mergeDocumentTextBox.Size = New System.Drawing.Size(212, 20)
        Me.mergeDocumentTextBox.TabIndex = 0
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
        Me.logTextBox.Location = New System.Drawing.Point(8, 46)
        Me.logTextBox.Name = "logTextBox"
        Me.logTextBox.ReadOnly = True
        Me.logTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.logTextBox.Size = New System.Drawing.Size(966, 184)
        Me.logTextBox.TabIndex = 0
        Me.logTextBox.Text = ""
        '
        'chooseFolderButton
        '
        Me.chooseFolderButton.Location = New System.Drawing.Point(8, 17)
        Me.chooseFolderButton.Name = "chooseFolderButton"
        Me.chooseFolderButton.Size = New System.Drawing.Size(83, 23)
        Me.chooseFolderButton.TabIndex = 0
        Me.chooseFolderButton.Text = "Directory..."
        Me.chooseFolderButton.UseVisualStyleBackColor = True
        '
        'savePathTextBox
        '
        Me.savePathTextBox.Location = New System.Drawing.Point(97, 20)
        Me.savePathTextBox.Name = "savePathTextBox"
        Me.savePathTextBox.Size = New System.Drawing.Size(206, 20)
        Me.savePathTextBox.TabIndex = 7
        '
        'odiseeSettingsGroupBox
        '
        Me.odiseeSettingsGroupBox.Controls.Add(Me.PictureBox1)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.Label2)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.passwordTextBox)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.Label1)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.usernameTextBox)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.odiseeGenerateDocumentURILabel)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.protocolCombobox)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.odiseeServiceURLLinkLabel)
        Me.odiseeSettingsGroupBox.Controls.Add(Me.odiseeServerURL)
        Me.odiseeSettingsGroupBox.Location = New System.Drawing.Point(16, 12)
        Me.odiseeSettingsGroupBox.Name = "odiseeSettingsGroupBox"
        Me.odiseeSettingsGroupBox.Size = New System.Drawing.Size(980, 86)
        Me.odiseeSettingsGroupBox.TabIndex = 21
        Me.odiseeSettingsGroupBox.TabStop = False
        Me.odiseeSettingsGroupBox.Text = "Odisee Server Settings"
        '
        'odiseeInputGroupBox
        '
        Me.odiseeInputGroupBox.Controls.Add(Me.mergeDocumentTextBox)
        Me.odiseeInputGroupBox.Controls.Add(Me.mergeDocumentCheckBox)
        Me.odiseeInputGroupBox.Controls.Add(Me.odiseeTemplatesLinkLabel)
        Me.odiseeInputGroupBox.Controls.Add(Me.templateComboBox)
        Me.odiseeInputGroupBox.Controls.Add(Me.makeOdiseeRequestButton)
        Me.odiseeInputGroupBox.Controls.Add(Me.odiseeRequestXMLTextBox)
        Me.odiseeInputGroupBox.Location = New System.Drawing.Point(16, 104)
        Me.odiseeInputGroupBox.Name = "odiseeInputGroupBox"
        Me.odiseeInputGroupBox.Size = New System.Drawing.Size(980, 304)
        Me.odiseeInputGroupBox.TabIndex = 22
        Me.odiseeInputGroupBox.TabStop = False
        Me.odiseeInputGroupBox.Text = "Input for Odisee Server"
        '
        'odiseeOutputGroupBox
        '
        Me.odiseeOutputGroupBox.Controls.Add(Me.savePathTextBox)
        Me.odiseeOutputGroupBox.Controls.Add(Me.chooseFolderButton)
        Me.odiseeOutputGroupBox.Controls.Add(Me.logTextBox)
        Me.odiseeOutputGroupBox.Controls.Add(Me.sendOdiseeRequestButton)
        Me.odiseeOutputGroupBox.Location = New System.Drawing.Point(10, 414)
        Me.odiseeOutputGroupBox.Name = "odiseeOutputGroupBox"
        Me.odiseeOutputGroupBox.Size = New System.Drawing.Size(980, 236)
        Me.odiseeOutputGroupBox.TabIndex = 23
        Me.odiseeOutputGroupBox.TabStop = False
        Me.odiseeOutputGroupBox.Text = "Output from Odisee Server"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Odisee.Client.My.Resources.Resources.Odisee_Signet_64x64
        Me.PictureBox1.Location = New System.Drawing.Point(910, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(64, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'OdiseeTester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.odiseeOutputGroupBox)
        Me.Controls.Add(Me.odiseeInputGroupBox)
        Me.Controls.Add(Me.odiseeSettingsGroupBox)
        Me.MaximizeBox = False
        Me.Name = "OdiseeTester"
        Me.Text = "Odisee(R) Client"
        Me.odiseeSettingsGroupBox.ResumeLayout(False)
        Me.odiseeSettingsGroupBox.PerformLayout()
        Me.odiseeInputGroupBox.ResumeLayout(False)
        Me.odiseeInputGroupBox.PerformLayout()
        Me.odiseeOutputGroupBox.ResumeLayout(False)
        Me.odiseeOutputGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents odiseeServerURL As System.Windows.Forms.TextBox
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
