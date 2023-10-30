Public Class SourceCard


    Private source As Source
    Private EnablerUrl = "https://m3u8-theta.vercel.app/cors?url="

    Public Sub SetSource(src As Source)
        source = src
    End Sub





    Private Sub SourceCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quality.Text = source.quality.ToUpper()
    End Sub

    Private Sub SourceCard_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        LaunchVLC(EnablerUrl + source.url + "&origin=aninin")

    End Sub





    Private Sub Quality_Click(sender As Object, e As EventArgs) Handles Quality.Click
        LaunchVLC(EnablerUrl + source.url + "&origin=aninin")
    End Sub
    Private Sub LaunchVLC(videoURL As String)
        Dim vlcPath As String = "C:\Program Files\VideoLAN\VLC\vlc.exe"

        ' Start VLC and play the video stream
        System.Diagnostics.Process.Start(vlcPath, videoURL)
    End Sub



End Class
