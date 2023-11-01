Imports Newtonsoft.Json
Imports System.IO

Public Class JsonService




    Private filePath As String = Path.Combine(Application.StartupPath, "data\otp-state.json")


    Public Sub SaveAnime(anime As Anime)
        Dim animeList As List(Of Anime)

        ' Check if the JSON file exists
        If File.Exists(filePath) Then
            ' If the file exists, read the JSON data from the file
            Dim json As String = File.ReadAllText(filePath)
            animeList = JsonConvert.DeserializeObject(Of List(Of Anime))(json)
        Else
            ' If the file doesn't exist, create a new empty list
            animeList = New List(Of Anime)()
        End If

        ' Add the new anime to the list
        animeList.Add(anime)

        ' Serialize the updated list back to JSON
        Dim updatedJson As String = JsonConvert.SerializeObject(animeList, Formatting.Indented)

        ' Write the JSON data back to the file
        File.WriteAllText(filePath, updatedJson)


    End Sub



    Public Function GetAllAnime() As List(Of Anime)
        Dim animeList As List(Of Anime)

        ' Check if the JSON file exists
        If File.Exists(filePath) Then
            ' If the file exists, read the JSON data from the file
            Dim json As String = File.ReadAllText(filePath)
            animeList = JsonConvert.DeserializeObject(Of List(Of Anime))(json)
        Else
            ' If the file doesn't exist, return an empty list
            animeList = New List(Of Anime)()
        End If

        Return animeList
    End Function


    Public Sub DeleteAnimeById(animeId As String)
        Dim animeList As List(Of Anime)

        ' Check if the JSON file exists
        If File.Exists(filePath) Then
            ' If the file exists, read the JSON data from the file
            Dim json As String = File.ReadAllText(filePath)
            animeList = JsonConvert.DeserializeObject(Of List(Of Anime))(json)

            ' Find and remove the specific anime by ID from the list
            Dim animeToRemove = animeList.Find(Function(a) a.Id = animeId)
            If animeToRemove IsNot Nothing Then
                animeList.Remove(animeToRemove)
            End If

            ' Serialize the updated list back to JSON
            Dim updatedJson As String = JsonConvert.SerializeObject(animeList, Formatting.Indented)

            ' Write the JSON data back to the file
            File.WriteAllText(filePath, updatedJson)
        End If
    End Sub


    Public Function AnimeExistsById(id As String) As Boolean
        Dim animeList As List(Of Anime)

        ' Check if the JSON file exists
        If File.Exists(filePath) Then
            ' If the file exists, read the JSON data from the file
            Dim json As String = File.ReadAllText(filePath)
            animeList = JsonConvert.DeserializeObject(Of List(Of Anime))(json)

            ' Check if there is an anime with the specified id
            Return animeList.Any(Function(a) a.Id = id)
        Else
            ' If the file doesn't exist, return false
            Return False
        End If
    End Function

End Class
