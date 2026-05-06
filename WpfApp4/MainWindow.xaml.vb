
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Class MainWindow

Public Sub New()
    InitializeComponent()
    Me.DataContext = New Counter()
End Sub

End Class
