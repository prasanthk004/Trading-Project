Public Class CusBO


    Dim _cusname As String
    Dim _cusplace As String
    Dim _cusnum As String

    Public Property CusName As String
        Get
            Return _cusname
        End Get
        Set(value As String)
            _cusname = value
        End Set
    End Property

    Public Property CusPlace As String
        Get
            Return _cusplace
        End Get
        Set(value As String)
            _cusplace = value
        End Set
    End Property

    Public Property CusNum As String
        Get
            Return _cusnum
        End Get
        Set(value As String)
            _cusnum = value
        End Set
    End Property


End Class

