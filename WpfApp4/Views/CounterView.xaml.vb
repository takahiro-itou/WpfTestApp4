
Imports System.Windows.Controls

Imports WpfApp4.ViewModels

Public Partial Class CounterView

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub SetViewModel(ByVal viewModel As CounterViewModel)
        Me.DataContext = viewModel
    End Sub

End Class
