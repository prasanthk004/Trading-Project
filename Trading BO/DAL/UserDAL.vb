Imports Microsoft.Data.SqlClient

Public Class UserDAL

    Public ubo As New UserBO
    Dim query As String

    Public Function create()

        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "insert into Users (UserName,LoginID,Password) values(@username,@loginId,@password)"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@username", ubo.UserName)
            cmd.Parameters.AddWithValue("@loginId", ubo.LoginID)
            cmd.Parameters.AddWithValue("@password", ubo.Password)
            o.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw
        Finally
            o = Nothing
            cmd.Dispose()
        End Try
        Return True

    End Function

    Public Function list() As DataTable
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Try
            query = "select * from Users"
            cmd.CommandText = query
            dt = o.GetDataTable(cmd)
            Return dt

        Catch ex As Exception
            Throw

        Finally
            o = Nothing
            cmd.Dispose()

        End Try
    End Function

    Public Function read(uid As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim dr As DataRow
        Try
            query = "select * from Users where UserID=@uid "
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@uid", uid)
            dt = o.GetDataTable(cmd)
            dr = dt.Rows(0)
            If uid <> dr("UserID") Then
                Throw New Exception("No Records Available for User ID " & uid)
            End If
            If dt.Rows.Count = 1 Then
                With ubo
                    .UserName = "" & dr("UserName")
                    .LoginID = "" & dr("LoginID")
                    .Password = "" & dr("Password")
                End With
            End If
        Catch ex As Exception
            Throw
        Finally
            o = Nothing
            cmd.Dispose()
        End Try
        Return True
    End Function

    Public Function update(ByVal uid As Long)

        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "update Users set UserName=@username,LoginID=@loginId" & " Where UserID=@uid"

            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@username", ubo.UserName)
            cmd.Parameters.AddWithValue("@loginId", ubo.LoginID)
            cmd.Parameters.AddWithValue("@password", ubo.Password)
            cmd.Parameters.AddWithValue("@uid", uid)
            o.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw
        Finally
            o = Nothing
            cmd.Dispose()
        End Try
        Return True

    End Function


    Public Function delete(ByVal uid As Long)

        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "Delete Users  Where UserID=@uid"

            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@username", ubo.UserName)
            cmd.Parameters.AddWithValue("@loginId", ubo.LoginID)
            cmd.Parameters.AddWithValue("@password", ubo.Password)
            o.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw
        Finally
            o = Nothing
            cmd.Dispose()
        End Try
        Return True

    End Function

End Class
