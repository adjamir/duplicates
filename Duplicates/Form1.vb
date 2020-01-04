Public Class Form1
    Public Shared sSelectedPath As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If (fbdSelectFolder.ShowDialog() = DialogResult.OK) Then
            txtPath.Text = fbdSelectFolder.SelectedPath
            sSelectedPath = txtPath.Text
        End If
        ExamineFolder()
        FillListView()
    End Sub

    Private Sub ExamineFolder()
        Dim oFiles = My.Computer.FileSystem.GetFiles(sSelectedPath)
        Dim sDuplicateList As Array Of String
        Dim sdupSuffix As String = "(1)"
        Dim sfilenamecurrentfile As String

        txtFileCount.Text = oFiles.Count

        Dim i As Integer = 0
        For Each oFile In oFiles
            i = i + 1
            sfilenamecurrentfile = oFile
            sfilenameCFnoExt = Get
            For Each oFile In oFiles
                If Trim(sfilenamecurrentfile) & sdupSuffix = oFile Then

                End If
            Next
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lvFilesSource.View = View.Details
        lvFilesSource.Columns.Add("Name", 120, HorizontalAlignment.Left)
        lvFilesSource.Columns.Add("Path", 160, HorizontalAlignment.Left)
            lvFilesSource.Columns.Add("Size", 80, HorizontalAlignment.Left)
            lvFilesSource.Columns.Add("Created", 120, HorizontalAlignment.Left)
            lvFilesSource.Columns.Add("Extension", 80, HorizontalAlignment.Left)

    End Sub
    Private Sub FillListView()
        Dim oFiles = My.Computer.FileSystem.GetFiles(sSelectedPath)
        Dim oFile As Object



        For Each oFile In oFiles
            Dim oFileInfo As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(oFile)
            Dim lvi As ListViewItem = lvFilesSource.Items.Add(oFileInfo.Name)

            lvi.SubItems.Add(oFileInfo.DirectoryName)
            If oFileInfo.Length >= 1024 Then
                lvi.SubItems.Add((oFile.Length / 1024).ToString() & " kb")
            Else
                lvi.SubItems.Add(oFile.Length.ToString & " bytes")
            End If
            ''lvi.SubItems.Add(fi.CreationTime.ToString)
            ''lvi.SubItems.Add(fi.Extension)
        Next


    End Sub

    Private Sub lvFilesSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvFilesSource.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click

    End Sub
End Class

