
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Imports WpfApp4.Models

Namespace ViewModels

Public Class EvenOddViewModel
        Implements INotifyPropertyChanged

    Private ReadOnly m_model As CounterModel

    Public Sub New(ByVal model As CounterModel)
        Me.m_model = model

        AddHandler  Me.m_model.ValueChanged, AddressOf OnCountChanged
    End Sub

    Public ReadOnly Property EvenOddText() As String
        Get
            If (Me.m_model.Value Mod 2 = 0) Then
                EvenOddText = "Even"
            Else
                EvenOddText = "Odd"
            End If
        End Get
    End Property

    Private Sub OnCountChanged()
        OnPropertyChanged(nameof(EvenOddText))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler _
            Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(
            <CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent  PropertyChanged(
            Me, New PropertyChangedEventArgs(propertyName)
        )
    End Sub

End Class

End Namespace
