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
        Label1 = New Label()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Label4 = New Label()
        soa = New TextBox()
        sob = New TextBox()
        soc = New TextBox()
        ketqua = New TextBox()
        input = New Label()
        cmdketqua = New Button()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(156, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.Location = New Point(171, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(213, 25)
        Label4.TabIndex = 3
        Label4.Text = "A^2x   +   Bx     +    C   =  0"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' soa
        ' 
        soa.Location = New Point(194, 115)
        soa.Name = "soa"
        soa.Size = New Size(37, 27)
        soa.TabIndex = 4
        ' 
        ' sob
        ' 
        sob.Location = New Point(255, 115)
        sob.Name = "sob"
        sob.Size = New Size(37, 27)
        sob.TabIndex = 5
        ' 
        ' soc
        ' 
        soc.Location = New Point(308, 115)
        soc.Name = "soc"
        soc.Size = New Size(37, 27)
        soc.TabIndex = 6
        ' 
        ' ketqua
        ' 
        ketqua.Location = New Point(194, 256)
        ketqua.Multiline = True
        ketqua.Name = "ketqua"
        ketqua.Size = New Size(190, 99)
        ketqua.TabIndex = 7
        ' 
        ' input
        ' 
        input.AutoSize = True
        input.ForeColor = SystemColors.MenuHighlight
        input.Location = New Point(106, 115)
        input.Name = "input"
        input.Size = New Size(50, 20)
        input.TabIndex = 9
        input.Text = "INPUT"
        ' 
        ' cmdketqua
        ' 
        cmdketqua.Location = New Point(194, 179)
        cmdketqua.Name = "cmdketqua"
        cmdketqua.Size = New Size(76, 38)
        cmdketqua.TabIndex = 10
        cmdketqua.Text = "Kết quả"
        cmdketqua.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmdketqua)
        Controls.Add(input)
        Controls.Add(ketqua)
        Controls.Add(soc)
        Controls.Add(sob)
        Controls.Add(soa)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "GiaiPTB2"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdketqua As Button
    Friend WithEvents input As Label
    Friend WithEvents ketqua As TextBox
    Friend WithEvents soc As TextBox
    Friend WithEvents sob As TextBox
    Friend WithEvents soa As TextBox
End Class
