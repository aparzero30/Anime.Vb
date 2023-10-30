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
        Image = New PictureBox()
        Title = New Label()
        Description = New Label()
        EpisodePanel = New FlowLayoutPanel()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(Image, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Image
        ' 
        Image.Location = New Point(-1, 0)
        Image.Name = "Image"
        Image.Size = New Size(310, 433)
        Image.SizeMode = PictureBoxSizeMode.StretchImage
        Image.TabIndex = 0
        Image.TabStop = False
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(54), CByte(57), CByte(63))
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(2, 445)
        Label2.MaximumSize = New Size(850, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(10)
        Label2.Size = New Size(78, 41)
        Label2.TabIndex = 8
        Label2.Text = "HOME"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(90, 447)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' InfoPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(EpisodePanel)
        Controls.Add(Description)
        Controls.Add(Title)
        Controls.Add(Image)
        Name = "InfoPanel"
        Size = New Size(889, 508)
        CType(Image, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Image As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Description As Label
    Friend WithEvents EpisodePanel As FlowLayoutPanel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
