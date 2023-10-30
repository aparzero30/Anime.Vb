Public Class Anime
    Public Property Id As String
    Public Property Title As String
    Public Property Url As String
    Public Property Image As String
    Public Property ReleaseDate As String ' Can be String or Null
    Public Property Description As String ' Can be String or Null
    Public Property Genres As List(Of String)
    Public Property SubOrDub As String
    Public Property Type As String ' Can be String or Null
    Public Property Status As String
    Public Property OtherName As String ' Can be String or Null
    Public Property TotalEpisodes As Integer
    Public Property Episodes As List(Of Episode)
End Class

