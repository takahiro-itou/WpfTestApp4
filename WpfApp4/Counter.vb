
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Public Class Counter
        Implements INotifyPropertyChanged

    Private m_count As Integer

    Public Property Count() As Integer
        Get
            Return  m_count
        End Get
        Set(ByVal value As Integer)
            If (m_count <> value) Then
                m_count = value
                OnPropertyChanged()
            End If
        End Set
    End Property

    Public ReadOnly Property IncrementCommand() As ICommand
        Get
            Return  Me.m_incrementCommand
        End Get
    End Property

    Public ReadOnly Property DecrementCommand() As ICommand
        Get
            Return  Me.m_decrementCommand
        End Get
    End Property

    Private ReadOnly m_incrementCommand As SimpleCommand
    Private ReadOnly m_decrementCommand As SimpleCommand

    Public Sub New()
        Me.m_incrementCommand = New SimpleCommand(
            Sub(ByVal parameter As Object)
                Count = Count + 1
            End Sub
        )
        Me.m_decrementCommand = New SimpleCommand(
            Sub(ByVal parameter As Object)
                Count = Count - 1
            End Sub,
            Function(ByVal parameter As Object) As Boolean
                Return  (Count > 0)
            End Function
        )
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler _
            Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(
            <CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(
                Me, New PropertyChangedEventArgs(propertyName)
        )
        If (propertyName = nameof(Count)) Then
            Me.m_decrementCommand.RaiseCanExecuteChanged()
        End If
    End Sub

End Class
