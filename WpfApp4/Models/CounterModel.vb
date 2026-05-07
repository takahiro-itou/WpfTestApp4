
Namespace Models

Public Class CounterModel

    Private m_value As Integer
    Public Event ValueChanged As Action

    Public Sub New(Optional ByVal initialValue = 0)
        m_value = initialValue
    End Sub

    Private Sub Notify()
        RaiseEvent  ValueChanged()
    End Sub

    Public Property Value() As Integer
        Get
            Return  Me.m_value
        End Get
        Private Set(ByVal value As Integer)
            Me.m_value = value
        End Set
    End Property

    Public Sub SetValue(ByVal value As Integer)
        Me.m_value = value
        Notify()
    End Sub

    Public Sub Increment()
        Me.m_value = Me.m_value + 1
        Notify()
    End Sub

    Public Function CanDecrement() As Boolean
        CanDecrement = (Me.m_value > 0)
    End Function

    Public Sub Decrement()
        If (Not CanDecrement()) Then
            Exit Sub
        End If
        Me.m_value = Me.m_value - 1
        Notify()
    End Sub

End Class

End Namespace
