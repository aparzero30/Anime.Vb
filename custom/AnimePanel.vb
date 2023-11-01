Imports System.IO

Public Class AnimePanel

    Private httpService As New HttpService()
    Private jsonService As New JsonService()

    Private airingAnime As List(Of Anime)
    Private searchAnime As List(Of Anime)
    Private page As Integer = 1
    Private searchRes As New ApiResponse()
    Private favourites As List(Of Anime)

    Private isFave = True
    Private filePath As String = Path.Combine(Application.StartupPath, "img\")
    Private searchOn = True
    Private srchEnable = False



    Private parentForm As Form1


    Public Sub New(form As Form1)
        InitializeComponent()
        parentForm = form
    End Sub







    Private Async Sub AnimePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim imgPath As String = Path.Combine(Application.StartupPath, "img", "zip.png")

        ' Load the image
        Dim img As Image = Image.FromFile(imgPath)

        ' Convert the image to an icon
        Dim icon As Icon = Icon.FromHandle(CType(img, Bitmap).GetHicon())

        ' Set the parent form's icon
        parentForm.Icon = icon

        ' Dispose of the original image and icon to free up resources
        img.Dispose()
        icon.Dispose()


        Prev.Visible = False

        Nxt.Visible = False
        Dim apiRes = Await httpService.GetTopAiring(page)
        airingAnime = apiRes.Results
        SetAnime(airingAnime)


    End Sub

    Private Async Sub SearchClick()

        Prev.Visible = False

        If SearchInput.Text.Equals("") Then

            Nxt.Visible = False
            SetAnime(airingAnime)
        Else
            searchRes = Await httpService.SearchAnime(SearchInput.Text, 1)

            Nxt.Visible = searchRes.HasNextPage




            searchAnime = searchRes.Results
            SetAnime(searchAnime)

        End If

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

    Private Async Sub Nxt_Click(sender As Object, e As EventArgs) Handles Nxt.Click
        page = page + 1

        searchRes = Await httpService.SearchAnime(SearchInput.Text, page)

        searchAnime = searchRes.Results
        SetAnime(searchAnime)
        Prev.Visible = True
        Nxt.Visible = searchRes.HasNextPage
    End Sub

    Private Async Sub Prev_Click(sender As Object, e As EventArgs) Handles Prev.Click
        page = page - 1
        searchRes = Await httpService.SearchAnime(SearchInput.Text, page)

        searchAnime = searchRes.Results
        SetAnime(searchAnime)
        Prev.Visible = page > 1
        Nxt.Visible = searchRes.HasNextPage

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles HeartPic.Click
        Nxt.Visible = False
        Prev.Visible = False
        favourites = jsonService.GetAllAnime()

        Dim imgFileName As String

        HeartPic.BackgroundImageLayout = ImageLayout.Stretch
        HeartPic.Image = Nothing
        Dim listOfAnime As List(Of Anime)

        If isFave Then
            imgFileName = "home.png"

            listOfAnime = favourites
            isFave = False
        Else
            imgFileName = "heart2.png"
            listOfAnime = airingAnime
            isFave = True
        End If

        Dim imgPath As String = Path.Combine(Application.StartupPath, "img", imgFileName)
        HeartPic.BackgroundImage = Image.FromFile(imgPath)
        SetAnime(listOfAnime)



    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles SearchBtn.Click

        If srchEnable Or Not searchOn Then
            Dim imgFileName As String
            Nxt.Visible = False
            Prev.Visible = False

            Dim imgPath As String = Path.Combine(Application.StartupPath, "img", "loading.gif")

            If searchOn Then
                SearchBtn.Image = Image.FromFile(imgPath)
                imgFileName = "xclose.png"
                SearchClick()
                srchEnable = True
            Else
                imgFileName = "search.png"
                SetAnime(airingAnime)
            End If

            searchOn = Not searchOn


            imgPath = Path.Combine(Application.StartupPath, "img", imgFileName)
            SearchBtn.Image = Image.FromFile(imgPath)
        End If





    End Sub





    Private Sub SearchInput_TextChanged(sender As Object, e As EventArgs) Handles SearchInput.TextChanged

        srchEnable = Not String.IsNullOrEmpty(SearchInput.Text)

    End Sub
End Class
