Imports Microsoft.Data.SqlClient

Public Class ItemDAL

    'CRUD 

    Public ibo As New ItemsBO

    Private query As String


    Public Function create()

        Dim o As SqlServer
        Dim cmd As New SqlCommand



        Try

            o = New SqlServer()
            query = "insert into Items([Item Description] , [Sales Price] ) values (@itemDesc,@SalesPrice) "
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@itemDesc", ibo.itemDesc)
            cmd.Parameters.AddWithValue("@salesPrice", ibo.itemPrice)

            o.ExecuteNonQuery(cmd)

            Return True
        Catch ex As Exception
            Throw
        End Try


    End Function


    Public Function delete(ByVal ItemID As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand


        Try

            query = "Delete from items where [item ID]= @itemID"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@itemID", ItemID)
            o.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw

        End Try
        Return True
    End Function

    Public Function list() As DataTable
        Dim o As New SqlServer
        Dim dt As New DataTable
        Dim cmd As New SqlCommand


        Try
            query = "Select * from Items "
            cmd.CommandText = query
            dt = o.GetDataTable(cmd)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function read(ByVal ItemID As Long) As DataTable


        Dim o As New SqlServer
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim cmd As New SqlCommand


        Try
            query = "Select * from Items where [Item ID]=@itemID"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@ItemID", ItemID)
            dt = o.GetDataTable(cmd)
            dr = dt.Rows(0)

            If dr("Item ID") <> ItemID Then
                Throw New Exception(" Unable fetch the details of ItemID " & ItemID)

            End If

            If dt.Rows.Count = 1 Then
                With ibo
                    .itemDesc = dr("Item Description")
                    If dr("Sales Price") Is DBNull.Value Then
                        .itemPrice = 0
                    Else
                        .itemPrice = dr("Sales Price")
                    End If



                End With
            End If

            Return dt
        Catch ex As Exception
            Throw
        End Try



    End Function


    Public Function update(itemID As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "update Items set [Item Description]=@itemname ,
                                  [Sales Price]=@price
                                  where [Item ID]=@itemid"

            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@itemname", ibo.itemDesc)
            cmd.Parameters.AddWithValue("@price", ibo.itemPrice)
            cmd.Parameters.AddWithValue("@itemid", itemID)
            o.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw
        End Try
        Return True
    End Function


End Class
