Imports Microsoft.Data.SqlClient

Public Class CusDAL

    Public cbo As New CusBO
    Dim query As String



    Public Function create()
        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "insert into Customer([Customer Name],place,Contact) values(@cusname,@cusplace,@cusnum)"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@cusname", cbo.CusName)
            cmd.Parameters.AddWithValue("@cusplace", cbo.CusPlace)
            cmd.Parameters.AddWithValue("@cusnum", cbo.CusNum)
            o.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw
        Finally
            o = Nothing
            cmd.Dispose()
        End Try

        Return True

    End Function

    Public Function update(ByVal cusID As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "update  Customer set[Customer Name]=@cusname,place=@cusplace,Contact=@cusnum 
                                                                          where [Customer ID]=@cusID"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@cusname", cbo.CusName)
            cmd.Parameters.AddWithValue("@cusplace", cbo.CusPlace)
            cmd.Parameters.AddWithValue("@cusnum", cbo.CusNum)
            cmd.Parameters.AddWithValue("@cusID", cusID)
            o.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw
        Finally
            o = Nothing
            cmd.Dispose()
        End Try

        Return True

    End Function



    Public Function delete(ByVal cusID As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "delete  Customer  where [Customer ID]=@cusID"
            cmd.CommandText = query

            cmd.Parameters.AddWithValue("@cusID", cusID)
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
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            query = "select * from Customer"
            cmd.CommandText = query
            dt = o.GetDataTable(cmd)
            Return dt

        Catch ex As Exception
            Throw
        End Try


    End Function


    Public Function read(ByVal cusID As Long)

        Dim o As New SqlServer
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            query = "select * from Customer where [Customer ID]=@cusID"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@cusID", cusID)
            dt = o.GetDataTable(cmd)

            If cusID <> dt.Rows(0)("Customer ID") Then
                Throw New Exception("Unable to find Customer Details for customer" & cusID)
            End If

            If dt.Rows.Count = 1 Then
                Dim dr As DataRow
                dr = dt.Rows(0)
                cbo.CusName = dr("Customer Name")
                cbo.CusPlace = dr("Place")
                cbo.CusNum = dr("Contact")
            End If
        Catch ex As Exception
            Throw

        Finally
            o = Nothing
            cmd.Dispose()
            dt.Dispose()
        End Try


    End Function



End Class
