
Imports System.Windows

Imports WpfApp4.ViewModels

Class MainWindow

Public Sub New()
    InitializeComponent()
    Me.DataContext = New CounterViewModel()
End Sub

End Class
