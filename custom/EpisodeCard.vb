Public Class EpisodeCard

    Private httpService As New HttpService()

    Private ep As Episode
    Private episodes As List(Of Episode)
    Private anime As Anime


    Private parentForm As Form1


    Public Sub New(form As Form1)
        InitializeComponent()
        parentForm = form
    End Sub

    Public Sub SetEpisode(epis As Episode, episs As List(Of Episode), ani As Anime)
        ep = epis
        episodes = episs
        anime = ani
    End Sub



    Private Sub EpisodeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'separate string ep.Id BY '-' and set it to
        Dim parts As String() = ep.Id.Split("-"c) ' Split the string by hyphen
        If parts.Length > 0 Then
            ' Set the first part to the Episode control's text property
            EpNumber.Text = parts(parts.Length - 1)
        End If

    End Sub

    Private Async Sub LoadEpisode()

        Dim sources = Await httpService.GetStreamingSources(ep.Id)
        Dim watchPanel As New WatchPanel(parentForm)
        watchPanel.SetUpObject(episodes, sources, ep, anime)
        parentForm.SetWatchPanel(watchPanel)
    End Sub


    Private Sub Episode_Click(sender As Object, e As EventArgs) Handles EpNumber.Click
        LoadEpisode()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        LoadEpisode()
    End Sub

    Private Sub EpisodeCard_Click(sender As Object, e As EventArgs)
        ' This method will be called when the EpisodeCard is clicked
        LoadEpisode()
    End Sub
End Class
