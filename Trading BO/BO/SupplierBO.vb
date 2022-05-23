Public Class SupplierBO


    Dim _suppliername As String
    Dim _supplierplace As String
    Dim _suppliercontact As String

    Public Property Suppliername As String
        Get
            Return _suppliername
        End Get
        Set(value As String)
            _suppliername = value
        End Set
    End Property

    Public Property Supplierplace As String
        Get
            Return _supplierplace
        End Get
        Set(value As String)
            _supplierplace = value
        End Set
    End Property

    Public Property Suppliercontact As String
        Get
            Return _suppliercontact
        End Get
        Set(value As String)
            _suppliercontact = value
        End Set
    End Property


End Class
