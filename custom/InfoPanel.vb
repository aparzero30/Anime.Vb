Imports System.IO

Public Class InfoPanel


    Private anime As Anime

    Private parentForm As Form1

    Private jsonService As New JsonService()

    Private isFave = False

    Private favourites As New List(Of Anime)


    Private filePath As String = Path.Combine(Application.StartupPath, "img\")


    Public Sub New(form As Form1)
        InitializeComponent()
        parentForm = form
    End Sub



    Public Sub SetAnime(anim As Anime)
        anime = anim
    End Sub

    Private Sub InfoPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Title.Text = anime.Title.ToUpper()
        AnimeUtil.SetImage(anime.Image, Banner)

        Description.Text = anime.Description


        isFave = jsonService.AnimeExistsById(anime.Id)





        HeartPic.BackgroundImageLayout = ImageLayout.Stretch


        Dim imgFileName As String

        If isFave Then
            imgFileName = "heart2.png"

        Else
            imgFileName = "heart1.png"

        End If


        Dim imgPath As String = Path.Combine(Application.StartupPath, "img", imgFileName)
        HeartPic.BackgroundImage = Image.FromFile(imgPath)






    End Sub










    Public Sub LoadEpisodes()




        For Each ep As Episode In anime.Episodes

            Dim epCard As New EpisodeCard(parentForm, Me)
            epCard.SetEpisode(ep, anime.Episodes, anime)

            EpisodePanel.Controls.Add(epCard)
        Next





    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles HeartPic.Click



        HeartPic.BackgroundImageLayout = ImageLayout.Stretch
        HeartPic.Image = Nothing

        Dim imgFileName As String

        If isFave Then
            imgFileName = "heart1.png"
            jsonService.DeleteAnimeById(anime.Id)
            isFave = False

        Else
            imgFileName = "heart2.png"
            jsonService.SaveAnime(anime)
            isFave = True

        End If
        Dim imgPath As String = Path.Combine(Application.StartupPath, "img", imgFileName)
        HeartPic.BackgroundImage = Image.FromFile(imgPath)









    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim animePanel As New AnimePanel(parentForm)
        parentForm.SetAnimePanel(animePanel)
        parentForm.Text = "Anime.ZIP"
    End Sub
End Class
