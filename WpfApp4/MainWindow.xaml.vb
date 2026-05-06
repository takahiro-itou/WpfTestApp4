
Class MainWindow

' データクラス
Public Class Person
    Public Property Name As String
    Public Property Age As Integer
    Public Property Job As String
End Class

Public Class Company
    Public Property Name As String
    Public Property Department As String
End Class

Public Sub New()
    InitializeComponent()

    ' データオブジェクトを作成
    Dim vPerson As New Person
    With vPerson
        .Name = "田中太郎"
        .Age = 30
        .Job = "ソフトウェアエンジニア"
    End With

    Dim vCompany As New Company
    With vCompany
        .Name = "株式会社サンプル"
        .Department = "開発部"
    End With

    Me.DataContext = vPerson
    Me.CompanyGroup.DataContext = vCompany
End Sub

Private Sub OnAddButtonClick(sender As Object, e As RoutedEventArgs)

End Sub

End Class
