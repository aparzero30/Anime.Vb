Public Class WatchPanel


    Private parentForm As Form1
    Private episodes As List(Of Episode)
    Private sources As List(Of Source)
    Private episode As New Episode()
    Private httpService As New HttpService()
    Private anime As Anime
    Private episodeCount = 0


    Public Sub SetUpObject(eps As List(Of Episode), srcs As List(Of Source), ep As Episode, anim As Anime)
        episodes = eps
        sources = srcs
        episode = ep
        anime = anim

    End Sub


    Public Sub New(form As Form1)
        InitializeComponent()
        parentForm = form
    End Sub

    Private Sub WatchPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        parentForm.Text = episode.Id.ToUpper()

        episodeCount = anime.Episodes.Count()
        JumpLabel.Text = JumpLabel.Text + "  MAX(" + episodeCount.ToString() + ")"

        Title.Text = episode.Id.ToUpper()
        If episodes IsNot Nothing AndAlso episodes.IndexOf(episode) = 0 Then
            Prev.Visible = False
        End If

        ' Check if the episode is the last one, if so, hide the "Next" button
        If episodes IsNot Nothing AndAlso episodes.IndexOf(episode) = episodes.Count - 1 Then
            Nxt.Visible = False
        End If

        LoadSources()
    End Sub



    Private Sub Prev_Click(sender As Object, e As EventArgs) Handles Prev.Click
        Dim index = GetIndexOfEpisode(episode) - 1
        MoveEpisode(index)

    End Sub

    Private Sub Nxt_Click(sender As Object, e As EventArgs) Handles Nxt.Click
        Dim index = GetIndexOfEpisode(episode) + 1
        MoveEpisode(index)
    End Sub


    Private Async Sub MoveEpisode(index As Integer)

        If index >= 0 AndAlso index < episodes.Count Then
            MessageBox.Show("loading")
            Dim targetEpisode As Episode = episodes(index)

            Dim watchPanel As New WatchPanel(parentForm)
            Dim sources = Await httpService.GetStreamingSources(targetEpisode.Id)
            watchPanel.SetUpObject(episodes, sources, targetEpisode, anime)
            parentForm.SetWatchPanel(watchPanel)

        End If
    End Sub





    Private Function GetIndexOfEpisode(targetEpisode As Episode) As Integer
        If episodes IsNot Nothing AndAlso targetEpisode IsNot Nothing Then
            For i As Integer = 0 To episodes.Count - 1
                If episodes(i) Is targetEpisode Then
                    ' Found the target episode, return its index
                    Return i
                End If
            Next
        End If

        ' If the episode is not found or episodes list is not initialized, return -1 as an indication of not found.
        Return -1
    End Function

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click
        SetUpAnimeInfoPanel()
    End Sub

    Private Sub SetUpAnimeInfoPanel()
        Dim infoPanel As New InfoPanel(parentForm)
        infoPanel.SetAnime(anime)
        parentForm.SetInfoPanel(infoPanel)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        SetUpAnimeInfoPanel()
    End Sub



    Private Sub LoadSources()
        For Each src As Source In sources

            Dim srcCard As New SourceCard()
            srcCard.SetSource(src)

            SourcePanel.Controls.Add(srcCard)



        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim animePanel As New AnimePanel(parentForm)
        parentForm.SetAnimePanel(animePanel)
    End Sub



    Private Sub JumpInput_TextChanged(sender As Object, e As EventArgs) Handles JumpInput.TextChanged
        Dim inputText As String = JumpInput.Text
        Dim enteredNumber As Integer

        ' Create a flag to check if the latest input character is a number
        Dim isLatestCharacterNumeric As Boolean = True






        ' Check if the input text contains non-numeric characters
        For Each c As Char In inputText
            If Not Char.IsDigit(c) Then
                isLatestCharacterNumeric = False
                Exit For
            End If
        Next

        Try
            If Integer.TryParse(inputText, enteredNumber) Then
                If enteredNumber > episodeCount Then
                    JumpInput.Text = episodeCount.ToString()
                End If
            ElseIf Not isLatestCharacterNumeric Then
                ' The latest input character is not a number, so keep only the previous inputted characters
                JumpInput.Text = JumpInput.Text.Substring(0, JumpInput.Text.Length - 1)
            Else
                ' Handle the case where the input is not a valid number
                JumpInput.Text = ""
            End If
        Catch ex As Exception
            ' Handle the exception (e.g., display an error message)
            JumpInput.Text = ""
        End Try

        If Integer.Parse(JumpInput.Text) < 1 Then
            JumpInput.Text = 1
        End If

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        MoveEpisode(Integer.Parse(JumpInput.Text) - 1)
    End Sub
End Class
