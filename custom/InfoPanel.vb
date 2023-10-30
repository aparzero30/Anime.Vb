Public Class InfoPanel


    Private Anime As Anime

    Private parentForm As Form1


    Public Sub New(form As Form1)
        InitializeComponent()
        parentForm = form
    End Sub



    Public Sub SetAnime(anim As Anime)
        Anime = anim
    End Sub

    Private Sub InfoPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Title.Text = Anime.Title.ToUpper()
        AnimeUtil.SetImage(Anime.Image, Image)

        Description.Text = Anime.Description
        LoadEpisodes()
    End Sub
    Private Sub LoadEpisodes()



        For Each ep As Episode In Anime.Episodes

            Dim epCard As New EpisodeCard(parentForm)
            epCard.SetEpisode(ep, Anime.Episodes, Anime)

            EpisodePanel.Controls.Add(epCard)
        Next


    End Sub




    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim animePanel As New AnimePanel(parentForm)
        parentForm.SetAnimePanel(animePanel)
    End Sub


End Class
