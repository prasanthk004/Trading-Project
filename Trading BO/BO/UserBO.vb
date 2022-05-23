Public Class UserBO

    Dim _userName As String
    Dim _loginID As String
    Dim _password As String



    Public Property UserName As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property


    Public Property LoginID As String
        Get
            Return _loginID
        End Get
        Set(value As String)
            _loginID = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property




End Class
