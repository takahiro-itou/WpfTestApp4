
Namespace Models

Public Class CounterModel

    Private m_value As Integer

    Public Sub New(Optional ByVal initialValue = 0)
        m_value = initialValue
    End Sub

    Public Property Value() As Integer
        Get
            Return  Me.m_value
        End Get
        Private Set(ByVal value As Integer)
            Me.m_value = value
        End Set
    End Property

    Public Sub Increment()
        Me.m_value = Me.m_value + 1
    End Sub

    Public Function CanDecrement() As Boolean
        CanDecrement = (Me.m_value > 0)
    End Function

    Public Sub Decrement()
        If (CanDecrement()) Then
            Me.m_value = Me.m_value - 1
        End If
    End Sub

End Class

End Namespace
