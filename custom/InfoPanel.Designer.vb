<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoPanel
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(InfoPanel))
        Banner = New PictureBox()
        Title = New Label()
        Description = New Label()
        EpisodePanel = New FlowLayoutPanel()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        HeartPic = New PictureBox()
        PictureBox1 = New PictureBox()
        Install = New Label()
        CType(Banner, ComponentModel.ISupportInitialize).BeginInit()
        CType(HeartPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Banner
        ' 
        Banner.Location = New Point(-1, 0)
        Banner.Name = "Banner"
        Banner.Size = New Size(310, 433)
        Banner.SizeMode = PictureBoxSizeMode.StretchImage
        Banner.TabIndex = 0
        Banner.TabStop = False
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.FromArgb(CByte(22), CByte(196), CByte(182))
        Title.Location = New Point(317, 2)
        Title.MaximumSize = New Size(560, 0)
        Title.Name = "Title"
        Title.Size = New Size(48, 17)
        Title.TabIndex = 1
        Title.Text = "Label1"
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.ForeColor = Color.White
        Description.Location = New Point(316, 48)
        Description.MaximumSize = New Size(560, 0)
        Description.Name = "Description"
        Description.Size = New Size(559, 150)
        Description.TabIndex = 2
        Description.Text = resources.GetString("Description.Text")
        ' 
        ' EpisodePanel
        ' 
        EpisodePanel.AutoScroll = True
        EpisodePanel.Location = New Point(316, 259)
        EpisodePanel.Name = "EpisodePanel"
        EpisodePanel.Size = New Size(573, 238)
        EpisodePanel.TabIndex = 3
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' HeartPic
        ' 
        HeartPic.Cursor = Cursors.Hand
        HeartPic.Location = New Point(58, 447)
        HeartPic.Name = "HeartPic"
        HeartPic.Size = New Size(35, 34)
        HeartPic.SizeMode = PictureBoxSizeMode.StretchImage
        HeartPic.TabIndex = 13
        HeartPic.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 447)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Install
        ' 
        Install.AutoSize = True
        Install.BackColor = Color.FromArgb(CByte(54), CByte(57), CByte(63))
        Install.Cursor = Cursors.Hand
        Install.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Install.ForeColor = Color.White
        Install.Location = New Point(101, 447)
        Install.MaximumSize = New Size(850, 0)
        Install.Name = "Install"
        Install.Padding = New Padding(5, 7, 5, 7)
        Install.Size = New Size(191, 34)
        Install.TabIndex = 16
        Install.Text = "WATCH LATEST EPISODE"
        ' 
        ' InfoPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        Controls.Add(Install)
        Controls.Add(PictureBox1)
        Controls.Add(HeartPic)
        Controls.Add(EpisodePanel)
        Controls.Add(Description)
        Controls.Add(Title)
        Controls.Add(Banner)
        Name = "InfoPanel"
        Size = New Size(889, 508)
        CType(Banner, ComponentModel.ISupportInitialize).EndInit()
        CType(HeartPic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Banner As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Description As Label
    Friend WithEvents EpisodePanel As FlowLayoutPanel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HeartPic As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Install As Label
End Class
