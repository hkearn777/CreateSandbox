Public Class Form1
  'CreateSandBox.
  ' This will create all the sub folders for a given project. 
  ' Written by Howard Kearney, IBM
  Dim ProgramVersion As String = "v0.3"
  'Change-history.
  ' 2024-09-28 hk  v0.3 New folder PROCS
  ' 2024-02-13 hk  v0.2 New folder IMSMAPS
  ' 2024-01-24 hk  v0.1 New code

  Dim RootDirectory As String = My.Application.GetEnvironmentVariable("USERPROFILE")
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Text &= " " & ProgramVersion
    txtSandboxFolderName.Text = RootDirectory
  End Sub
  Private Sub btnFindSandboxFolder_Click(sender As Object, e As EventArgs) Handles btnFindSandboxFolder.Click
    Dim ofd_ProjectFolder As New FolderBrowserDialog With
      {
        .InitialDirectory = RootDirectory
      }
    If ofd_ProjectFolder.ShowDialog() = DialogResult.OK Then
      txtSandboxFolderName.Text = ofd_ProjectFolder.SelectedPath
    Else
      Exit Sub
    End If
  End Sub

  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub

  Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
    ' Main logic. Create the folders.

    If txtApplicationName.TextLength = 0 Then
      MessageBox.Show("Application Folder Name must have a value")
      Exit Sub
    End If
    If txtSandboxFolderName.TextLength = 0 Then
      MessageBox.Show("Sandbox Folder Name must have a value")
      Exit Sub
    End If

    Dim BaseFolder As String = txtSandboxFolderName.Text & "\" & txtApplicationName.Text

    If My.Computer.FileSystem.DirectoryExists(BaseFolder) Then
      MessageBox.Show("Directory " & BaseFolder & " already exists.")
      Exit Sub
    End If

    If MakeFolder(BaseFolder & "\JOBS") = -1 Then Exit Sub
    If MakeFolder(BaseFolder & "\JOBTEST") = -1 Then Exit Sub
    If MakeFolder(BaseFolder & "\SOURCES") = -1 Then Exit Sub
    If MakeFolder(BaseFolder & "\OUTPUT") = -1 Then Exit Sub
    If MakeFolder(BaseFolder & "\OUTPUT\DEBUG") = -1 Then Exit Sub
    If MakeFolder(BaseFolder & "\OUTPUT\PUML") = -1 Then Exit Sub
    If MakeFolder(BaseFolder & "\OUTPUT\SVG") = -1 Then Exit Sub
    If MakeFolder(BaseFolder & "\TELON") = -1 Then Exit Sub
    If MakeFolder(BaseFolder & "\SCREENS") = -1 Then Exit Sub
    If MakeFolder(BaseFolder & "\PROCS") = -1 Then Exit Sub

    MessageBox.Show("Sandbox Folders Created")
  End Sub
  Function MakeFolder(ByVal FOLDER As String) As Integer
    Try
      My.Computer.FileSystem.CreateDirectory(FOLDER)
      Return 0
    Catch ex As Exception
      MessageBox.Show("Error Creating folder:" & FOLDER & " : " & ex.Message)
      Return -1
    End Try
  End Function
End Class
