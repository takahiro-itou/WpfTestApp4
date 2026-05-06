
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Class MainWindow

' データクラス
Public Class Person
        Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private m_name As String
    Private m_age As Integer
    Private m_job As String

    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(ByVal value As String)
            If (m_name <> value) Then
                m_name = value
                OnPropertyChanged()
            End If
        End Set
    End Property

    Public Property Age() As Integer
        Get
            Return m_age
        End Get
        Set(ByVal value As Integer)
            If (m_age <> value) Then
                m_age = value
                OnPropertyChanged()
            End If
        End Set
    End Property

    Public Property Job() As String
        Get
            Return m_job
        End Get
        Set(ByVal value As String)
            If (m_job <> value) Then
                m_job = value
                OnPropertyChanged()
            End If
        End Set
    End Property

    Protected Sub OnPropertyChanged(
            <CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

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
