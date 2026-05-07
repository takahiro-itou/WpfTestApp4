
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Imports WpfApp4.Models
Imports WpfApp4.Services

Namespace ViewModels

Public Class CounterViewModel
        Implements INotifyPropertyChanged

    Private ReadOnly m_model As CounterModel
    Private ReadOnly m_storage As JsonCounterStorage
    Private ReadOnly m_incrementCommand As SimpleCommand
    Private ReadOnly m_decrementCommand As SimpleCommand

    Public Sub New(
            ByVal model As CounterModel, ByVal storage As JsonCounterStorage)

        Me.m_model = model
        Me.m_storage = storage

        Dim initialValue As Integer = Me.m_storage.Load()
        Me.m_model.SetValue(initialValue)

        AddHandler Me.m_model.ValueChanged, AddressOf OnCountChanged

        Me.m_incrementCommand = New SimpleCommand(
            Sub(ByVal parameter As Object)
                ExecuteIncrement()
            End Sub
        )
        Me.m_decrementCommand = New SimpleCommand(
            Sub(ByVal parameter As Object)
                ExecuteDecrement()
            End Sub,
            Function(ByVal parameter As Object) As Boolean
                Return  m_model.CanDecrement()
            End Function
        )
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return  Me.m_model.Value
        End Get
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

    Private Sub ExecuteIncrement()
        Me.m_model.Increment()
        Me.m_storage.Save(Me.m_model.Value)
    End Sub

    Private Sub ExecuteDecrement()
        Me.m_model.Decrement()
        Me.m_storage.Save(Me.m_model.Value)
    End Sub

    Private Sub OnCountChanged()
        OnPropertyChanged(nameof(Count))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler _
            Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(
            <CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent  PropertyChanged(
                Me, New PropertyChangedEventArgs(propertyName)
        )
        If (propertyName = nameof(Count)) Then
            Me.m_decrementCommand.RaiseCanExecuteChanged()
        End If
    End Sub

End Class

End Namespace
