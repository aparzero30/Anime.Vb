Public Class Form1


    Private animePanel As New AnimePanel(Me)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetAnimePanel(animePanel)
        Me.Text = "Anime.ZIP"
    End Sub

    Public Sub SetAnimePanel(animPanel As AnimePanel)
        Panel.Controls.Clear()
        animPanel.Dock = DockStyle.Fill
        Panel.Controls.Add(animePanel)
    End Sub

    Public Sub SetInfoPanel(infoPanel As InfoPanel)
        Panel.Controls.Clear()
        infoPanel.Dock = DockStyle.Fill
        Panel.Controls.Add(infoPanel)

    End Sub
    Public Sub SetWatchPanel(watchPanel As WatchPanel)
        Panel.Controls.Clear()
        watchPanel.Dock = DockStyle.Fill
        Panel.Controls.Add(watchPanel)

    End Sub
End Class

'in animePanel i want to pass the methods  SetInfoPanel SetWatchPanel and call them from animePnel how to do that