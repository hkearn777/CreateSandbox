<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    txtSandboxFolderName = New TextBox()
    FolderBrowserDialog1 = New FolderBrowserDialog()
    btnFindSandboxFolder = New Button()
    txtMessage = New TextBox()
    Label1 = New Label()
    txtApplicationName = New TextBox()
    btnCreate = New Button()
    btnClose = New Button()
    Label2 = New Label()
    SuspendLayout()
    ' 
    ' txtSandboxFolderName
    ' 
    txtSandboxFolderName.Location = New Point(24, 143)
    txtSandboxFolderName.Name = "txtSandboxFolderName"
    txtSandboxFolderName.Size = New Size(806, 31)
    txtSandboxFolderName.TabIndex = 5
    ' 
    ' btnFindSandboxFolder
    ' 
    btnFindSandboxFolder.Location = New Point(252, 103)
    btnFindSandboxFolder.Name = "btnFindSandboxFolder"
    btnFindSandboxFolder.Size = New Size(217, 34)
    btnFindSandboxFolder.TabIndex = 4
    btnFindSandboxFolder.Text = "Find Sandbox Folder"
    btnFindSandboxFolder.UseVisualStyleBackColor = True
    ' 
    ' txtMessage
    ' 
    txtMessage.Location = New Point(23, 12)
    txtMessage.Multiline = True
    txtMessage.Name = "txtMessage"
    txtMessage.ReadOnly = True
    txtMessage.Size = New Size(806, 69)
    txtMessage.TabIndex = 3
    txtMessage.Text = "The following Application folders will be created under Sandbox Folder: JOBS, JOBTEST, OUTPUT, OUTPUT/DEBUG, OUTPUT/PUML, OUTPUT/SVG, PROCS, SOURCES, SCREENS, TELON"
    ' 
    ' Label1
    ' 
    Label1.AutoSize = True
    Label1.Location = New Point(24, 201)
    Label1.Name = "Label1"
    Label1.Size = New Size(201, 25)
    Label1.TabIndex = 4
    Label1.Text = "New Application Folder:"
    ' 
    ' txtApplicationName
    ' 
    txtApplicationName.Location = New Point(231, 198)
    txtApplicationName.Name = "txtApplicationName"
    txtApplicationName.Size = New Size(238, 31)
    txtApplicationName.TabIndex = 1
    ' 
    ' btnCreate
    ' 
    btnCreate.Location = New Point(511, 196)
    btnCreate.Name = "btnCreate"
    btnCreate.Size = New Size(112, 34)
    btnCreate.TabIndex = 2
    btnCreate.Text = "Create"
    btnCreate.UseVisualStyleBackColor = True
    ' 
    ' btnClose
    ' 
    btnClose.Location = New Point(717, 196)
    btnClose.Name = "btnClose"
    btnClose.Size = New Size(112, 34)
    btnClose.TabIndex = 3
    btnClose.Text = "Close"
    btnClose.UseVisualStyleBackColor = True
    ' 
    ' Label2
    ' 
    Label2.AutoSize = True
    Label2.Location = New Point(24, 108)
    Label2.Name = "Label2"
    Label2.Size = New Size(213, 25)
    Label2.TabIndex = 6
    Label2.Text = "Sandbox Folder Location:"
    ' 
    ' Form1
    ' 
    AutoScaleDimensions = New SizeF(10F, 25F)
    AutoScaleMode = AutoScaleMode.Font
    ClientSize = New Size(852, 265)
    Controls.Add(Label2)
    Controls.Add(btnClose)
    Controls.Add(btnCreate)
    Controls.Add(txtApplicationName)
    Controls.Add(Label1)
    Controls.Add(txtMessage)
    Controls.Add(btnFindSandboxFolder)
    Controls.Add(txtSandboxFolderName)
    Name = "Form1"
    Text = "Create Sandbox"
    ResumeLayout(False)
    PerformLayout()
  End Sub
  Friend WithEvents txtSandboxFolderName As TextBox
  Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
  Friend WithEvents btnFindSandboxFolder As Button
  Friend WithEvents txtMessage As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents txtApplicationName As TextBox
  Friend WithEvents btnCreate As Button
  Friend WithEvents btnClose As Button
  Friend WithEvents Label2 As Label

End Class
