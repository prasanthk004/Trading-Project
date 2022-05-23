Public Class osBO

    Public _dt As New Date
    Dim _itemId As Long
    Dim _qty As Long
    Dim _refno As Long
    Dim _bookno As String
    Dim _mf As Integer = -1


    Public Property dat As Date
        Get
            Return _dt
        End Get
        Set(value As Date)
            _dt = value
        End Set
    End Property


    Public Property ItemId As Long
        Get
            Return _itemId
        End Get
        Set(value As Long)
            _itemId = value
        End Set
    End Property

    Public Property qty As Long
        Get
            Return _qty
        End Get
        Set(value As Long)
            _qty = value
        End Set
    End Property

    Public Property refno As Long
        Get
            Return _refno
        End Get
        Set(value As Long)
            _refno = value
        End Set
    End Property


    Public Property bookno As String
        Get
            Return _bookno
        End Get
        Set(value As String)
            _bookno = value
        End Set
    End Property

    Public Property mf As Integer
        Get
            Return _mf
        End Get
        Set(value As Integer)
            _mf = value
        End Set

    End Property
End Class
