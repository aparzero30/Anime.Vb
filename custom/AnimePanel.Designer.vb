<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnimePanel
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AnimePanel))
        AnimeFlowPanel = New FlowLayoutPanel()
        Label2 = New Label()
        Panel1 = New Panel()
        SearchInput = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AnimeFlowPanel
        ' 
        AnimeFlowPanel.AutoScroll = True
        AnimeFlowPanel.AutoScrollMargin = New Size(5, 5)
        AnimeFlowPanel.AutoScrollMinSize = New Size(5, 0)
        AnimeFlowPanel.Location = New Point(7, 69)
        AnimeFlowPanel.Name = "AnimeFlowPanel"
        AnimeFlowPanel.Size = New Size(873, 474)
        AnimeFlowPanel.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(22), CByte(196), CByte(182))
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        Label2.Location = New Point(265, 11)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(10)
        Label2.Size = New Size(91, 41)
        Label2.TabIndex = 9
        Label2.Text = "SEARCH"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(SearchInput)
        Panel1.Location = New Point(10, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(241, 41)
        Panel1.TabIndex = 11
        ' 
        ' SearchInput
        ' 
        SearchInput.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        SearchInput.BorderStyle = BorderStyle.None
        SearchInput.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        SearchInput.ForeColor = Color.White
        SearchInput.Location = New Point(5, 7)
        SearchInput.Name = "SearchInput"
        SearchInput.PlaceholderText = "Anime Name"
        SearchInput.Size = New Size(230, 24)
        SearchInput.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(838, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' AnimePanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(AnimeFlowPanel)
        Name = "AnimePanel"
        Size = New Size(889, 555)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AnimeFlowPanel As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchInput As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
