<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WatchPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Title = New Label()
        Prev = New Label()
        Nxt = New Label()
        Label1 = New Label()
        SourcePanel = New FlowLayoutPanel()
        Label2 = New Label()
        Label3 = New Label()
        JumpLabel = New Label()
        JumpInput = New TextBox()
        Panel1 = New Panel()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Cursor = Cursors.Hand
        Title.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.FromArgb(CByte(22), CByte(196), CByte(182))
        Title.Location = New Point(11, 9)
        Title.MaximumSize = New Size(850, 0)
        Title.Name = "Title"
        Title.Size = New Size(848, 56)
        Title.TabIndex = 2
        Title.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        ' 
        ' Prev
        ' 
        Prev.AutoSize = True
        Prev.Cursor = Cursors.Hand
        Prev.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Prev.ForeColor = Color.White
        Prev.Location = New Point(20, 503)
        Prev.MaximumSize = New Size(850, 0)
        Prev.Name = "Prev"
        Prev.Size = New Size(76, 19)
        Prev.TabIndex = 3
        Prev.Text = "PREVIOUS"
        ' 
        ' Nxt
        ' 
        Nxt.AutoSize = True
        Nxt.Cursor = Cursors.Hand
        Nxt.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Nxt.ForeColor = Color.White
        Nxt.Location = New Point(827, 503)
        Nxt.MaximumSize = New Size(850, 0)
        Nxt.Name = "Nxt"
        Nxt.Size = New Size(44, 19)
        Nxt.TabIndex = 4
        Nxt.Text = "NEXT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(54), CByte(57), CByte(63))
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 77)
        Label1.MaximumSize = New Size(850, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(5)
        Label1.Size = New Size(115, 31)
        Label1.TabIndex = 5
        Label1.Text = "ANIME INFO"
        ' 
        ' SourcePanel
        ' 
        SourcePanel.BorderStyle = BorderStyle.FixedSingle
        SourcePanel.Location = New Point(53, 389)
        SourcePanel.Name = "SourcePanel"
        SourcePanel.Padding = New Padding(10)
        SourcePanel.Size = New Size(769, 75)
        SourcePanel.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(54), CByte(57), CByte(63))
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(143, 77)
        Label2.MaximumSize = New Size(850, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(5)
        Label2.Size = New Size(68, 31)
        Label2.TabIndex = 7
        Label2.Text = "HOME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(22), CByte(196), CByte(182))
        Label3.Location = New Point(65, 380)
        Label3.MaximumSize = New Size(850, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 19)
        Label3.TabIndex = 8
        Label3.Text = "SOURCES"
        ' 
        ' JumpLabel
        ' 
        JumpLabel.AutoSize = True
        JumpLabel.Cursor = Cursors.Hand
        JumpLabel.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point)
        JumpLabel.ForeColor = Color.White
        JumpLabel.Location = New Point(53, 325)
        JumpLabel.MaximumSize = New Size(850, 0)
        JumpLabel.Name = "JumpLabel"
        JumpLabel.Size = New Size(38, 13)
        JumpLabel.TabIndex = 9
        JumpLabel.Text = "JUMP"
        ' 
        ' JumpInput
        ' 
        JumpInput.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        JumpInput.BorderStyle = BorderStyle.None
        JumpInput.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        JumpInput.ForeColor = Color.White
        JumpInput.Location = New Point(62, 344)
        JumpInput.Name = "JumpInput"
        JumpInput.PlaceholderText = "1"
        JumpInput.Size = New Size(62, 24)
        JumpInput.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(53, 340)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(78, 34)
        Panel1.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(22), CByte(196), CByte(182))
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        Label4.Location = New Point(138, 339)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(8)
        Label4.Size = New Size(49, 37)
        Label4.TabIndex = 13
        Label4.Text = "GO"
        ' 
        ' WatchPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        Controls.Add(Label4)
        Controls.Add(JumpLabel)
        Controls.Add(JumpInput)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(SourcePanel)
        Controls.Add(Label1)
        Controls.Add(Nxt)
        Controls.Add(Prev)
        Controls.Add(Title)
        Name = "WatchPanel"
        Size = New Size(889, 532)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Prev As Label
    Friend WithEvents Nxt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SourcePanel As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents JumpLabel As Label
    Friend WithEvents JumpInput As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
End Class
