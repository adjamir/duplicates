<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lvFilesSource = New System.Windows.Forms.ListView()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.fbdSelectFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileCount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDuplicateCount = New System.Windows.Forms.TextBox()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvFilesSource
        '
        Me.lvFilesSource.HideSelection = False
        Me.lvFilesSource.Location = New System.Drawing.Point(9, 148)
        Me.lvFilesSource.Margin = New System.Windows.Forms.Padding(2)
        Me.lvFilesSource.Name = "lvFilesSource"
        Me.lvFilesSource.Size = New System.Drawing.Size(1065, 314)
        Me.lvFilesSource.TabIndex = 0
        Me.lvFilesSource.UseCompatibleStateImageBehavior = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(466, 10)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(117, 26)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(9, 14)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(445, 20)
        Me.txtPath.TabIndex = 2
        Me.txtPath.Text = "(Click Browse)"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Files Found"
        '
        'txtFileCount
        '
        Me.txtFileCount.Location = New System.Drawing.Point(113, 49)
        Me.txtFileCount.Name = "txtFileCount"
        Me.txtFileCount.Size = New System.Drawing.Size(100, 20)
        Me.txtFileCount.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Duplicates Found"
        '
        'txtDuplicateCount
        '
        Me.txtDuplicateCount.Location = New System.Drawing.Point(113, 80)
        Me.txtDuplicateCount.Name = "txtDuplicateCount"
        Me.txtDuplicateCount.Size = New System.Drawing.Size(100, 20)
        Me.txtDuplicateCount.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 473)
        Me.Controls.Add(Me.txtDuplicateCount)
        Me.Controls.Add(Me.txtFileCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lvFilesSource)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Duplicates"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvFilesSource As ListView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents fbdSelectFolder As FolderBrowserDialog
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDuplicateCount As TextBox
    Friend WithEvents txtFileCount As TextBox
    Friend WithEvents Label2 As Label
End Class
