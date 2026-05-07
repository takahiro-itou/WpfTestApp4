
Imports System.Windows.Controls

Imports WpfApp4.ViewModels

Namespace WpfApp4.Views

Public Class EvenOddView

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub SetViewModel(ByVal viewModel As EvenOddViewModel)
        Me.DataContext = viewModel
    End Sub

End Class

End Namespace
