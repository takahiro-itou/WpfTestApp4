
Imports System.Windows.Controls

Imports WpfApp4.ViewModels

Public Class EvenOddView

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub SetViewModel(ByVal viewModel As EvenOddViewModel)
        Me.DataContext = viewModel
    End Sub

End Class
