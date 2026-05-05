
Class MainWindow

Private Sub OnClearButtonClick(sender As Object, e As RoutedEventArgs)
Dim title As String
Dim content As String

    title = TitleTextBox.Text
    content = ContentTextBox.Text

End Sub

Private Sub OnSaveButtonClick(sender As Object, e As RoutedEventArgs)
Dim result As MessageBoxResult

    result = MessageBox.Show("内容をクリアしますか？", "確認",
        MessageBoxButton.YesNo, MessageBoxImage.Question)
    If (result = MessageBoxResult.Yes) Then
        TitleTextBox.Clear()
        ContentTextBox.Clear()
    End If
End Sub

End Class
