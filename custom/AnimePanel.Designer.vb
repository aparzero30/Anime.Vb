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
        Panel1 = New Panel()
        SearchInput = New TextBox()
        HeartPic = New PictureBox()
        Nxt = New Label()
        Prev = New Label()
        SearchBtn = New PictureBox()
        Panel1.SuspendLayout()
        CType(HeartPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(SearchBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AnimeFlowPanel
        ' 
        AnimeFlowPanel.AutoScroll = True
        AnimeFlowPanel.AutoScrollMargin = New Size(5, 5)
        AnimeFlowPanel.AutoScrollMinSize = New Size(5, 0)
        AnimeFlowPanel.Location = New Point(37, 69)
        AnimeFlowPanel.Name = "AnimeFlowPanel"
        AnimeFlowPanel.Size = New Size(843, 474)
        AnimeFlowPanel.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(SearchInput)
        Panel1.Location = New Point(37, 11)
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
        SearchInput.Location = New Point(6, 7)
        SearchInput.Name = "SearchInput"
        SearchInput.PlaceholderText = "Anime Name"
        SearchInput.Size = New Size(230, 24)
        SearchInput.TabIndex = 12
        ' 
        ' HeartPic
        ' 
        HeartPic.Cursor = Cursors.Hand
        HeartPic.Image = CType(resources.GetObject("HeartPic.Image"), Image)
        HeartPic.Location = New Point(810, 19)
        HeartPic.Name = "HeartPic"
        HeartPic.Size = New Size(35, 34)
        HeartPic.SizeMode = PictureBoxSizeMode.StretchImage
        HeartPic.TabIndex = 12
        HeartPic.TabStop = False
        ' 
        ' Nxt
        ' 
        Nxt.AutoSize = True
        Nxt.BackColor = Color.FromArgb(CByte(22), CByte(196), CByte(182))
        Nxt.Cursor = Cursors.Hand
        Nxt.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Nxt.ForeColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        Nxt.Location = New Point(386, 12)
        Nxt.Name = "Nxt"
        Nxt.Padding = New Padding(10)
        Nxt.Size = New Size(36, 40)
        Nxt.TabIndex = 13
        Nxt.Text = ">"
        ' 
        ' Prev
        ' 
        Prev.AutoSize = True
        Prev.BackColor = Color.FromArgb(CByte(22), CByte(196), CByte(182))
        Prev.Cursor = Cursors.Hand
        Prev.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Prev.ForeColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        Prev.Location = New Point(344, 12)
        Prev.Name = "Prev"
        Prev.Padding = New Padding(10)
        Prev.Size = New Size(36, 40)
        Prev.TabIndex = 14
        Prev.Text = "<"
        ' 
        ' SearchBtn
        ' 
        SearchBtn.BackColor = Color.FromArgb(CByte(22), CByte(196), CByte(182))
        SearchBtn.Cursor = Cursors.Hand
        SearchBtn.Image = CType(resources.GetObject("SearchBtn.Image"), Image)
        SearchBtn.Location = New Point(277, 11)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Padding = New Padding(10)
        SearchBtn.Size = New Size(45, 41)
        SearchBtn.SizeMode = PictureBoxSizeMode.StretchImage
        SearchBtn.TabIndex = 15
        SearchBtn.TabStop = False
        ' 
        ' AnimePanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        Controls.Add(SearchBtn)
        Controls.Add(Prev)
        Controls.Add(Nxt)
        Controls.Add(HeartPic)
        Controls.Add(Panel1)
        Controls.Add(AnimeFlowPanel)
        Name = "AnimePanel"
        Size = New Size(889, 555)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(HeartPic, ComponentModel.ISupportInitialize).EndInit()
        CType(SearchBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AnimeFlowPanel As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchInput As TextBox
    Friend WithEvents HeartPic As PictureBox
    Friend WithEvents Nxt As Label
    Friend WithEvents Prev As Label
    Friend WithEvents SearchBtn As PictureBox
End Class
