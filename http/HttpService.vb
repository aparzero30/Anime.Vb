Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class HttpService


    Private baseUrl = "https://api.consumet.org/anime/gogoanime"


    Public Async Function GetTopAiring() As Task(Of List(Of Anime))
        Dim httpClient As New HttpClient()
        Dim apiUrl As String = baseUrl + "/top-airing"

        Try
            Dim queryParams As New List(Of KeyValuePair(Of String, String))
            queryParams.Add(New KeyValuePair(Of String, String)("page", "1"))

            Dim uriBuilder As New UriBuilder(apiUrl)
            uriBuilder.Query = New FormUrlEncodedContent(queryParams).ReadAsStringAsync().Result

            Dim response As HttpResponseMessage = Await httpClient.GetAsync(uriBuilder.Uri)

            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize the JSON response into ApiResponse
                Dim apiResponse As ApiResponse = JsonConvert.DeserializeObject(Of ApiResponse)(responseContent)

                ' Access the "Results" list which contains the Anime objects
                Dim animeArray As List(Of Anime) = apiResponse.Results

                Return animeArray
            Else
                Console.WriteLine("API Request Failed: " & response.ReasonPhrase)
            End If
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try

        ' If there's an error or the request fails, return an empty list or handle the error as needed.
        Return New List(Of Anime)()
    End Function


    Public Async Function GetAnimeInfo(animeId As String) As Task(Of Anime)
        Dim httpClient As New HttpClient()
        Dim apiUrl As String = baseUrl + "/info/" + animeId

        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)

            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize the JSON response into the Anime object
                Dim anime As Anime = JsonConvert.DeserializeObject(Of Anime)(responseContent)

                Return anime
            Else
                Console.WriteLine("API Request Failed: " & response.ReasonPhrase)
            End If
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try

        ' If there's an error or the request fails, return Nothing or handle the error as needed.
        Return Nothing
    End Function



    Public Async Function GetStreamingSources(episodeId As String) As Task(Of List(Of Source))
        Dim httpClient As New HttpClient()
        Dim apiUrl As String = baseUrl + "/watch/" + episodeId

        ' Define the query parameters
        Dim queryParams As New List(Of KeyValuePair(Of String, String)) From {
            New KeyValuePair(Of String, String)("server", "gogocdn")
        }

        Dim uriBuilder As New UriBuilder(apiUrl)
        uriBuilder.Query = New FormUrlEncodedContent(queryParams).ReadAsStringAsync().Result

        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(uriBuilder.Uri)

            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize the JSON response into a dynamic object
                Dim responseData As Object = JsonConvert.DeserializeObject(responseContent)

                ' Extract the list of streaming sources from the response
                Dim sources As List(Of Source) = JsonConvert.DeserializeObject(Of List(Of Source))(responseData("sources").ToString())

                Return sources
            Else
                Console.WriteLine("API Request Failed: " & response.ReasonPhrase)
            End If
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try

        ' If there's an error or the request fails, return an empty list or handle the error as needed.
        Return New List(Of Source)()
    End Function






    Public Async Function SearchAnime(key As String, page As Integer) As Task(Of List(Of Anime))
        Dim httpClient As New HttpClient()
        Dim apiUrl As String = $"https://api.consumet.org/anime/gogoanime/{key}?page={page}"

        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)

            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize the JSON response into ApiResponse
                Dim apiResponse As ApiResponse = JsonConvert.DeserializeObject(Of ApiResponse)(responseContent)

                ' Access the "Results" list which contains the Anime objects
                Dim animeArray As List(Of Anime) = apiResponse.Results

                Return animeArray
            Else
                Console.WriteLine("API Request Failed: " & response.ReasonPhrase)
            End If
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try

        ' If there's an error or the request fails, return an empty list or handle the error as needed.
        Return New List(Of Anime)()
    End Function


End Class




