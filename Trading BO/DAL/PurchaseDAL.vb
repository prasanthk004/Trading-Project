
Imports Microsoft.Data.SqlClient
Public Class PurchaseDAL

    Public pbo As New PurchaseBO

    Dim query As String


    Public Function create() As Long

        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Dim laffected As Long

        Try
            query = "insert into Purchase(PurchaseDate,SupplierID,BillNo,NetAmount) values(@purchasDate,@SupplierID,@BillNo,@NetAmount)"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@purchasDate", pbo.PurchaseDate)
            cmd.Parameters.AddWithValue("@SupplierID", pbo.SupplierID)
            cmd.Parameters.AddWithValue("@BillNo", pbo.BillNo)
            cmd.Parameters.AddWithValue("@NetAmount", pbo.NetAmount)
            laffected = o.ExecuteNonQuery(cmd, pbo.PurchaseID)

            UpdateDetailRecord()

            Return laffected

        Catch ex As Exception
            Throw
        Finally
            o = Nothing
            cmd.Dispose()
            cmd = Nothing
        End Try

    End Function


    Public Function read(ByVal purchaseID As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim dr As DataRow

        Try
            query = "Select*from Purchase where PurchaseID=@purchaseID"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@purchaseID", purchaseID)

            dt = o.GetDataTable(cmd)

            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
                pbo.PurchaseDate = dr("PurchaseDate")
                pbo.SupplierID = dr("SupplierID")
                pbo.BillNo = dr("BillNo")
                pbo.NetAmount = dr("NetAmount")

            End If

            cmd.CommandText = "Select*from PurchaseDetail where PurchaseID=@purchaseID "
            pbo.PurchaseDetail = o.GetDataTable(cmd)

        Catch ex As Exception
            Throw

        Finally
            o = Nothing
            cmd.Dispose()
            cmd = Nothing
        End Try


    End Function




    Public Function update(ByVal purchaseID As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Try
            query = "Update Purchase set PurchaseDate=@purchaseDate,SupplierID=@supplierID ,
                                           BillNo=@billno ,
                                           NetAmount=@netAmount
                                     Where PurchaseID=@purchaseID "
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@purchaseDate", pbo.PurchaseDate)
            cmd.Parameters.AddWithValue("@SupplierID", pbo.SupplierID)
            cmd.Parameters.AddWithValue("@BillNo", pbo.BillNo)
            cmd.Parameters.AddWithValue("@NetAmount", pbo.NetAmount)
            cmd.Parameters.AddWithValue("@purchaseID", purchaseID)
            o.ExecuteNonQuery(cmd)

            UpdateDetailRecord()

        Catch ex As Exception
            Throw

        End Try
    End Function


    Public Function delete(ByVal purchaseID As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Dim affected As Long

        Try
            query = "Delete Purchase Where PurchaseID=@purchaseID"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@purchaseID", purchaseID)
            affected = o.ExecuteNonQuery(cmd)
            Return affected

        Catch ex As Exception
            Throw

        Finally
            o = Nothing
            cmd.Dispose()
            cmd = Nothing
        End Try
    End Function

    Public Function list() As DataTable
        Dim o As New SqlServer
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            query = "select * from Purchase"
            cmd.CommandText = query
            dt = o.GetDataTable(cmd)
            Return dt

        Catch ex As Exception
            Throw


        Finally
            o = Nothing
            cmd.Dispose()
            cmd = Nothing
        End Try





    End Function

    Public Function GetNextBillNo() As Long
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Dim billno As Long

        Try
            query = "select max(BillNo) from purchase"
            cmd.CommandText = query

            billno = o.ExecuteScaler(cmd)
            Return billno
        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Sub UpdateDetailRecord()
        Dim o As New SqlServer

        Try
            For Each dr As DataRow In pbo.PurchaseDetail.Rows
                dr("PurchaseID") = pbo.PurchaseID
            Next
            o.UpdateDataTable(pbo.PurchaseDetail, "PurchaseDetail")
        Catch ex As Exception
            Throw
        End Try



    End Sub

End Class
