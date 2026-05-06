
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Class MainWindow

Public Sub New()
    InitializeComponent()
    Me.DataContext = New CounterViewModel()
End Sub

End Class
