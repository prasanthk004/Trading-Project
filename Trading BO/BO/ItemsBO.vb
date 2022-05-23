Public Class ItemsBO
    Dim _itemDesc As String
    Dim _itemPrice As Decimal

    Public Property itemDesc As String

        Get
            Return _itemDesc
        End Get
        Set(value As String)
            _itemDesc = value
        End Set
    End Property


    Public Property itemPrice As Decimal
        Get
            Return _itemPrice
        End Get
        Set(value As Decimal)
            _itemPrice = value
        End Set
    End Property


End Class
