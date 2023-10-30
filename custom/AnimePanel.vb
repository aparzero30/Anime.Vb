Public Class AnimePanel

    Private httpService As New HttpService()

    Private airingAnime As List(Of Anime)
    Private searchAnime As List(Of Anime)



    Private parentForm As Form1


    Public Sub New(form As Form1)
        InitializeComponent()
        parentForm = form
    End Sub







    Private Async Sub AnimePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        airingAnime = Await httpService.GetTopAiring()
        SetAnime(airingAnime)
    End Sub

    Private Async Sub SearchClick()

        If SearchInput.Text.Equals("") Then
            SetAnime(airingAnime)
        Else
            searchAnime = Await httpService.SearchAnime(SearchInput.Text, 1)


            SetAnime(searchAnime)

        End If

    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        SearchClick()
    End Sub






    Private Sub SetAnime(listAnime As List(Of Anime))
        AnimeFlowPanel.Controls.Clear()

        For Each anime As Anime In listAnime

            Dim animeCard As New AnimeCard(parentForm)
            animeCard.SetAnime(anime)

            AnimeFlowPanel.Controls.Add(animeCard)
        Next


    End Sub



    Public Sub CallSetUpInfoPanel(infoPanel As InfoPanel)
        parentForm.SetInfoPanel(infoPanel)
    End Sub



End Class
