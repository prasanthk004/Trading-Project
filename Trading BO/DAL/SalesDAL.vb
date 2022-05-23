Imports Microsoft.Data.SqlClient

Public Class SalesDAL

    Public sabo As New SalesBO
    Dim query As String
    Dim dt As New DataTable


    Public Function create()
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Try

            query = "insert into SalesEntry(SalesDate,CustomerID,BillNo,NetAmount) Values(@SalesDate,@CustomerID,@BillNo,@NetAmount)"
            cmd.CommandText = query
            sabo.BillNo = GetNextBillno()
            cmd.Parameters.AddWithValue("@SalesDate", sabo.SalesDate)
            cmd.Parameters.AddWithValue("@CustomerID", sabo.CustomerID)
            cmd.Parameters.AddWithValue("@BillNo", sabo.BillNo)
            cmd.Parameters.AddWithValue("@NetAmount", sabo.NetAmount)
            o.ExecuteNonQuery(cmd, sabo.SalesID)

            UpdateDetailTable()
        Catch ex As Exception
            Throw
        Finally
            o = Nothing
            cmd.Dispose()
        End Try
    End Function

    Public Function list() As DataTable
        Dim dt As New DataTable
        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "Select * from SalesEntry"
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

    Public Function read(ByVal SalesID As Long)
        Dim dt As New DataTable
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Dim dr As DataRow

        Try
            query = "Select * from SalesEntry Where SalesID=@SalesID"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@SalesID", SalesID)
            dt = o.GetDataTable(cmd)



            If dt.Rows.Count = 1 Then
                If dt.Rows(0)("SalesID") <> SalesID Then
                    Throw New Exception("Unble fetch the data for Sales ID " & SalesID)
                End If
                dr = dt.Rows(0)
                With sabo
                    .SalesDate = dr("SalesDate")
                    .CustomerID = dr("CustomerID")
                    .BillNo = dr("BillNo")
                    .NetAmount = dr("NetAmount")

                End With
            End If

            cmd.CommandText = "Select * from SalesDetail Where SalesID=@SalesID"
            sabo.SalesDetail = o.GetDataTable(cmd)




        Catch ex As Exception
            Throw
        End Try

        Return True
    End Function

    Public Function update(ByVal SalesId As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "update SalesEntry set SalesDate=@SalesDate, CustomerID=@CustomerID,
                                       BillNo=@BillNo,NetAmount=@NetAmount
                                        Where SalesID=@SalesID"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@SalesDate", sabo.SalesDate)
            cmd.Parameters.AddWithValue("@CustomerID", sabo.CustomerID)
            cmd.Parameters.AddWithValue("@BillNo", sabo.BillNo)
            cmd.Parameters.AddWithValue("@NetAmount", sabo.NetAmount)
            cmd.Parameters.AddWithValue("@SalesID ", SalesId)

            o.ExecuteNonQuery(cmd)



            UpdateDetailTable()

        Catch ex As Exception
            Throw
        End Try

    End Function



    Public Function delete(ByVal SalesId As Long)
        Dim o As New SqlServer
        Dim cmd As New SqlCommand

        Try
            query = "Delete SalesEntry Where SalesID=@salesID"
            cmd.CommandText = query

            cmd.Parameters.AddWithValue("@SalesID ", SalesId)

            o.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function GetNextBillno() As Long
        Dim o As New SqlServer
        Dim q As String
        Dim nextbillno As Long
        Try
            q = "Select max(BillNo) from SalesEntry"

            nextbillno = o.ExecuteScaler(q) + 1
            Return nextbillno

        Catch ex As Exception
            Throw
        End Try
    End Function



    Public Function UpdateDetailTable()

        Dim o As New SqlServer

        Try

            For Each dr as DataRow In sabo.SalesDetail.Rows
                If dr.RowState = DataRowState.Added Then
                    dr("SalesID") = sabo.SalesID
                End If

            Next

            o.UpdateDataTable(sabo.SalesDetail, "SalesDetail")

        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
