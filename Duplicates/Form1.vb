Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If (fbdSelectFolder.ShowDialog() = DialogResult.OK) Then
            txtPath.Text = fbdSelectFolder.SelectedPath
        End If
        FillListView()
    End Sub

    Private Sub txtPath_TextChanged(sender As Object, e As EventArgs) Handles txtPath.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvFilesSource.Columns.Add("Name", 120, HorizontalAlignment.Left)
        lvFilesSource.Columns.Add("Path", 160, HorizontalAlignment.Left)
        lvFilesSource.Columns.Add("Size", 80, HorizontalAlignment.Left)
        lvFilesSource.Columns.Add("Created", 120, HorizontalAlignment.Left)
        lvFilesSource.Columns.Add("Extension", 80, HorizontalAlignment.Left)
    End Sub
    Private Sub FillListView()
        Using ofd As New OpenFileDialog
            ofd.Multiselect = True
            If ofd.ShowDialog = DialogResult.OK Then
                For Each fn As String In ofd.FileNames
                    Dim fi As New IO.FileInfo(fn)
                    Dim lvi As ListViewItem = lvFilesSource.Items.Add(fi.Name)
                    lvi.SubItems.Add(fi.DirectoryName)
                    If fi.Length >= 1024 Then
                        lvi.SubItems.Add((fi.Length / 1024).ToString("F2") & " kb")
                    Else
                        lvi.SubItems.Add(fi.Length.ToString & " bytes")
                    End If
                    lvi.SubItems.Add(fi.CreationTime.ToString)
                    lvi.SubItems.Add(fi.Extension)
                Next
            End If
        End Using
    End Sub
End Class

