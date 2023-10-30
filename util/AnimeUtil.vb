Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net

Public Class AnimeUtil
    Public Shared Sub SetImage(imageUrl As String, PictureBox As PictureBox)
        Dim webClient As New WebClient()
        Try
            ' Download the image as a byte array
            Dim imageBytes As Byte() = webClient.DownloadData(imageUrl)

            ' Create a MemoryStream from the byte array
            Dim imageStream As New MemoryStream(imageBytes)

            ' Set the PictureBox's image from the MemoryStream
            PictureBox.Image = Image.FromStream(imageStream)
        Catch ex As Exception
            ' Handle any errors that may occur when downloading the image
            MessageBox.Show("Failed to load the image: " & ex.Message)
        End Try

    End Sub
    Public Shared Sub SetBg(imageUrl As String, userControl As UserControl)
        Dim webClient As New WebClient()
        Try
            ' Download the image as a byte array
            Dim imageBytes As Byte() = webClient.DownloadData(imageUrl)

            ' Create a MemoryStream from the byte array
            Dim imageStream As New MemoryStream(imageBytes)

            ' Set the PictureBox's image from the MemoryStream
            userControl.BackgroundImage = Image.FromStream(imageStream)
        Catch ex As Exception
            ' Handle any errors that may occur when downloading the image
            MessageBox.Show("Failed to load the image: " & ex.Message)
        End Try

    End Sub






End Class
