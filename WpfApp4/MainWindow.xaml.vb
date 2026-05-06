
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

Private m_person As Person

Public Sub New()
    InitializeComponent()

    ' データオブジェクトを作成
    Me.m_person = New Person
    With Me.m_person
        .Name = "田中太郎"
        .Age = 30
        .Job = "ソフトウェアエンジニア"
    End With

    Dim vCompany As New Company
    With vCompany
        .Name = "株式会社サンプル"
        .Department = "開発部"
    End With

    Me.DataContext = Me.m_person
    Me.CompanyGroup.DataContext = vCompany
End Sub

Private Sub OnDecrementAge(sender As Object, e As RoutedEventArgs)
    Me.m_person.Age = Me.m_person.Age - 1
End Sub

Private Sub OnIncrementAge(sender As Object, e As RoutedEventArgs)
    Me.m_person.Age = Me.m_person.Age + 1
End Sub

End Class
