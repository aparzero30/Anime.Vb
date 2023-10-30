<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SourceCard
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
        Quality = New Label()
        SuspendLayout()
        ' 
        ' Quality
        ' 
        Quality.AutoSize = True
        Quality.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Quality.ForeColor = Color.White
        Quality.Location = New Point(9, 13)
        Quality.Name = "Quality"
        Quality.Size = New Size(48, 17)
        Quality.TabIndex = 0
        Quality.Text = "Label1"
        ' 
        ' SourceCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(54), CByte(57), CByte(63))
        Controls.Add(Quality)
        Cursor = Cursors.Hand
        Name = "SourceCard"
        Size = New Size(118, 43)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Quality As Label
End Class
