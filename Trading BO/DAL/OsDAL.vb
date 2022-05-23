
Imports Microsoft.Data.SqlClient
Public Class OsDAL
    'CRUD
    'CREATE
    'READ
    'UPDATE
    'DELETE
    Dim query As String
    Public tbo As New osBO
    Public Function create()
        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "insert into [Stock Transaction](Date,[Item ID],qty,[Ref No],[Book No],MF) values(@date,@itemId,@qty,@refno,@bookno,@mf)"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@date", tbo.dat)
            cmd.Parameters.AddWithValue("@itemId", tbo.ItemId)
            cmd.Parameters.AddWithValue("@qty", tbo.qty)
            cmd.Parameters.AddWithValue("@refno", tbo.refno)
            cmd.Parameters.AddWithValue("@bookno", tbo.bookno)
            cmd.Parameters.AddWithValue("@mf", tbo.mf)
            o.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
            o = Nothing
        End Try
    End Function

    Public Function list() As DataTable
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Try
            query = "select * from [Stock Transaction]"
            cmd.CommandText = query
            dt = o.GetDataTable(cmd)

            Return dt

        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
            o = Nothing
        End Try

    End Function

    Public Function read(ByVal tid As Long)

        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim dr As DataRow


        Try
            query = "select * from  [Stock Transaction] where TransactionID=@tid"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@tid", tid)
            dt = o.GetDataTable(cmd)

            dr = dt.Rows(0)

            If tid <> dr("TransactionID") Then
                Throw New Exception("No records found for transaction id " & tid)
            End If
            If dt.Rows.Count = 1 Then

                With tbo
                    ._dt = dt.Rows(0)("Date")
                    .ItemId = dr("Item ID")
                    .qty = dr("qty")
                    .refno = dr("Ref No")
                    .bookno = dr("Book No")
                    .mf = dr("MF")
                End With
            End If


        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
            o = Nothing
        End Try
        Return True
    End Function

    Public Function update(ByVal tid As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Try
            query = "update [Stock Transaction] set Date=@dt,
                    [Item ID]=@itemid,qty=@qty,[Ref No]=@refno,[Book No]=@bookno,MF=@mf
                                                              where   TransactionID=@tid"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@dt", tbo.dat)
            cmd.Parameters.AddWithValue("@itemid", tbo.ItemId)
            cmd.Parameters.AddWithValue("@qty", tbo.qty)
            cmd.Parameters.AddWithValue("@refno", tbo.refno)
            cmd.Parameters.AddWithValue("@bookno", tbo.bookno)
            cmd.Parameters.AddWithValue("@mf", tbo.mf)
            cmd.Parameters.AddWithValue("@tid", tid)
            o.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
            o = Nothing
        End Try

        Return True
    End Function
    Public Function delete(ByVal tid As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "delete [Stock Transaction]   where   TransactionID=@tid"
            cmd.CommandText = query
            o.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
            o = Nothing
        End Try

        Return True

    End Function
End Class
