<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EpisodeCard
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
        EpNumber = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' EpNumber
        ' 
        EpNumber.AutoSize = True
        EpNumber.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        EpNumber.ForeColor = Color.FromArgb(CByte(47), CByte(49), CByte(54))
        EpNumber.Location = New Point(-1, 18)
        EpNumber.MinimumSize = New Size(56, 0)
        EpNumber.Name = "EpNumber"
        EpNumber.Size = New Size(56, 15)
        EpNumber.TabIndex = 0
        EpNumber.Text = "9999"
        EpNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(10, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 11)
        Label1.TabIndex = 1
        Label1.Text = "EPISODE"
        ' 
        ' EpisodeCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(196), CByte(182))
        Controls.Add(Label1)
        Controls.Add(EpNumber)
        Cursor = Cursors.Hand
        Name = "EpisodeCard"
        Size = New Size(58, 41)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EpNumber As Label
    Friend WithEvents Label1 As Label
End Class
