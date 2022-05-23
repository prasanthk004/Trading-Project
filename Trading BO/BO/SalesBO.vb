Public Class SalesBO


    Dim _salesdate As Date
    Dim _cusid As Long
    Dim _billno As Long
    Dim _salesID As Long

    Dim _netamount As Decimal
    Dim _salesdetail As New DataTable


    Public Property SalesDate As Date
        Get
            Return _salesdate
        End Get
        Set(value As Date)
            _salesdate = value
        End Set
    End Property

    Public Property CustomerID As Long
        Get
            Return _cusid
        End Get
        Set(value As Long)
            _cusid = value
        End Set
    End Property

    Public Property BillNo As Long
        Get
            Return _billno
        End Get
        Set(value As Long)
            _billno = value
        End Set
    End Property

    Public Property NetAmount As Decimal
        Get
            Return _netamount
        End Get
        Set(value As Decimal)
            _netamount = value
        End Set
    End Property

    Public Property SalesDetail As DataTable
        Get
            Return _salesdetail
        End Get
        Set(value As DataTable)
            _salesdetail = value
        End Set
    End Property


    Public Property SalesID As Long
        Get
            Return _salesID
        End Get
        Set(value As Long)
            _salesID = value
        End Set
    End Property

End Class
