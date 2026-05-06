
Class MainWindow

Private Sub OnAddButtonClick(sender As Object, e As RoutedEventArgs)
Dim memo As String
Dim category As String

    memo = MemoTextBox.Text
    category = ""
    If (CategoryComboBox.SelectedItem IsNot Nothing) Then
        category = (CategoryComboBox.SelectedItem).Content.ToString()
    End If

    If Not String.IsNullOrWhiteSpace(memo) Then
        MemoListView.Items.Add($"{memo} ({category})")
        MemoTextBox.Clear()
    End If
End Sub

End Class
