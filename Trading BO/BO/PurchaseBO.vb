Public Class PurchaseBO


    Dim _purchaseId As Long
    Dim _purchasedate As Date
    Dim _supplierID As Long
    Dim _biilNo As Long
    Dim _netAmount As Decimal
    Dim _purchaseDetail As DataTable


    Public Property PurchaseID As Long
        Get
            Return _purchaseId
        End Get
        Set(value As Long)
            _purchaseId = value
        End Set
    End Property


    Public Property PurchaseDate As Date
        Get
            Return _purchasedate
        End Get
        Set(value As Date)
            _purchasedate = value

        End Set
    End Property


    Public Property SupplierID As Long
        Get
            Return _supplierID
        End Get
        Set(value As Long)
            _supplierID = value
        End Set
    End Property


    Public Property BillNo As Long
        Get
            Return _biilNo
        End Get
        Set(value As Long)
            _biilNo = value

        End Set
    End Property


    Public Property NetAmount As Decimal
        Get
            Return _netAmount
        End Get
        Set(value As Decimal)
            _netAmount = value
        End Set
    End Property


    Public Property PurchaseDetail As DataTable
        Get
            Return _purchaseDetail
        End Get
        Set(value As DataTable)
            _purchaseDetail = value
        End Set
    End Property
End Class
