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
        Me.SuspendLayout()
        '
        'lvFilesSource
        '
        Me.lvFilesSource.HideSelection = False
        Me.lvFilesSource.Location = New System.Drawing.Point(12, 182)
        Me.lvFilesSource.Name = "lvFilesSource"
        Me.lvFilesSource.Size = New System.Drawing.Size(776, 256)
        Me.lvFilesSource.TabIndex = 0
        Me.lvFilesSource.UseCompatibleStateImageBehavior = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(621, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(156, 32)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 17)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(592, 22)
        Me.txtPath.TabIndex = 2
        Me.txtPath.Text = "(Click Browse)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lvFilesSource)
        Me.Name = "Form1"
        Me.Text = "Duplicates"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvFilesSource As ListView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents fbdSelectFolder As FolderBrowserDialog
End Class
