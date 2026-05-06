
Imports System.Windows.Input

Public Class SimpleCommand
        Implements ICommand

    Private ReadOnly m_execute As Action(Of Object)
    Private ReadOnly m_canExecute As Predicate(Of Object)

    Public Sub New(
            execute As Action(Of Object),
            Optional canExecute As Predicate(Of Object) = Nothing)
        Me.m_execute = execute
        Me.m_canExecute = canExecute
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean _
            Implements ICommand.CanExecute
        Return If(m_canExecute Is Nothing, True, m_canExecute.Invoke(parameter))
    End Function

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        Me.m_execute(parameter)
    End Sub

    Public Event CanExecuteChanged As EventHandler _
            Implements ICommand.CanExecuteChanged

    Public Sub RaiseCanExecuteChanged()
        RaiseEvent CanExecuteChanged(Me, EventArgs.Empty)
    End Sub

End Class
