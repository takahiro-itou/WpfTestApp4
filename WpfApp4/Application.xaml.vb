
Imports System.Windows

Imports WpfApp4.Models
Imports WpfApp4.Services
Imports WpfApp4.ViewModels

Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

Protected Overrides Sub OnStartup(e As StartupEventArgs)

    MyBase.OnStartup(e)

    Dim storage As New JsonCounterStorage()

    Dim model As New CounterModel()

    Dim counterViewModel As New CounterViewModel(model, storage)
    Dim evenOddViewModel As New EvenOddViewModel(model)

    Dim mainWindow As New MainWindow()

    ' ウィンドウを表示
    mainWindow.Show()
End Sub

End Class
