<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnimeCard
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
        AnimePic = New PictureBox()
        CType(AnimePic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.BackColor = Color.FromArgb(CByte(54), CByte(57), CByte(63))
        Title.ForeColor = Color.White
        Title.Location = New Point(2, 187)
        Title.MaximumSize = New Size(153, 0)
        Title.MinimumSize = New Size(153, 0)
        Title.Name = "Title"
        Title.Size = New Size(153, 30)
        Title.TabIndex = 1
        Title.Text = "TitleTitleTitleTitleTitleTitleTitle"
        ' 
        ' AnimePic
        ' 
        AnimePic.BackColor = Color.FromArgb(CByte(54), CByte(57), CByte(63))
        AnimePic.Location = New Point(1, 0)
        AnimePic.Name = "AnimePic"
        AnimePic.Size = New Size(160, 183)
        AnimePic.SizeMode = PictureBoxSizeMode.StretchImage
        AnimePic.TabIndex = 2
        AnimePic.TabStop = False
        ' 
        ' AnimeCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(54), CByte(57), CByte(63))
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(AnimePic)
        Controls.Add(Title)
        Cursor = Cursors.Hand
        Name = "AnimeCard"
        Size = New Size(157, 224)
        CType(AnimePic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Title As Label
    Friend WithEvents AnimePic As PictureBox
End Class
