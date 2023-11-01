Public Class AnimeCard
    Private Anime As Anime
    Private HttpService As New HttpService()
    Private myPanel As New Panel()




    Private parentForm As Form1


    Public Sub New(form As Form1)
        InitializeComponent()
        parentForm = form
    End Sub

    Public Sub SetAnime(anim As Anime)
        Anime = anim
    End Sub

    Private Sub AnimeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Anime.Title.Length <= 46 Then
            Title.Text = Anime.Title
        Else
            Title.Text = Anime.Title.Substring(0, 46)
        End If

        AnimeUtil.SetImage(Anime.Image, AnimePic)
    End Sub


    Private Sub AnimeCard_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        SetUpAnimeInfoPanel()

    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click

        SetUpAnimeInfoPanel()
    End Sub


    Private Async Sub SetUpAnimeInfoPanel()
        ' Set the background image of the current form
        ' Dim imagePath As String = "C:\Users\jimci\OneDrive\Desktop\Code\AnimeZIP\img\loading.gif"
        'Me.BackgroundImage = Image.FromFile(imagePath)

        Dim newAnime = Await HttpService.GetAnimeInfo(Anime.Id)
        parentForm.Text = Anime.Title
        Dim infoPanel As New InfoPanel(parentForm)
        infoPanel.SetAnime(newAnime)
        infoPanel.LoadEpisodes()
        parentForm.SetInfoPanel(infoPanel)
    End Sub

    Private Sub AnimePic_Click(sender As Object, e As EventArgs) Handles AnimePic.Click
        SetUpAnimeInfoPanel()

    End Sub
End Class
