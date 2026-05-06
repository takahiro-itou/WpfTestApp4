
Imports System.IO
Imports System.Text.Json

Namespace Services

    Public Class JsonCounterStorage

        Private Const FilePath As String = "counter.json"

        Public Function Load() As Integer
            If Not File.Exists(FilePath) Then
                Load = 0
                Exit Function
            End If
            Dim json As String = File.ReadAllText(FilePath)
            Load = JsonSerializer.Deserialize(Of Integer)(json)
        End Function

        Public Sub Save(ByVal value As Integer)
            Dim json As String = JsonSerializer.Serialize(value)
            File.WriteAllText(FilePath, json)
        End Sub

    End Class

End Namespace
