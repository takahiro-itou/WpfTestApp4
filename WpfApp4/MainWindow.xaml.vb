
Class MainWindow

Private Sub OnClearButtonClick(sender As Object, e As RoutedEventArgs)
Dim title As String
Dim content As String

    title = TitleTextBox.Text
    content = ContentTextBox.Text

    MessageBox.Show(
        "メモを保存しました! (ダミーです)" & vbCrLf & vbCrLf &
        $"タイトル: {title}{vbCrLf}内容: {content}",
        "保存完了", MessageBoxButton.OK, MessageBoxImage.Information)
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
