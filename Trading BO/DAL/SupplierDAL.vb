
Imports Microsoft.Data.SqlClient
Public Class SupplierDAL
    'Create 
    'Read
    'Update 
    'Delete 

    Public sbo As New SupplierBO

    Public Function create() As Boolean
        Dim cmd As SqlCommand
        Dim query As String
        Dim o As New SqlServer



        Try


            query = "insert into Supplier ([Supplier Name] , Place , [Contact Number])" & "values(@suppliername,@place,@contact)"
            cmd = New SqlCommand(query)
            cmd.Parameters.AddWithValue("@suppliername", sbo.Suppliername)
            cmd.Parameters.AddWithValue("@place", sbo.Supplierplace)
            cmd.Parameters.AddWithValue("@contact", sbo.Suppliercontact)

            o.ExecuteNonQuery(cmd)
            Return True

        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
            o = Nothing
        End Try


    End Function


    Public Function read(ByVal supplierID As String)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim db As New SqlServer
        Dim query As String
        Dim cmd As New SqlCommand

        Try

            query = "Select * from Supplier where [supplier ID]=@supplierID"
            cmd.Parameters.AddWithValue("@supplierID", supplierID)
            cmd.CommandText = query
            dt = db.GetDataTable(cmd)


            dr = dt.Rows(0)
            If supplierID <> dr("Supplier ID") Then
                Throw New Exception(" Unable to fetch details of supplier ID " & supplierID)
            End If
            If dt.Rows.Count = 1 Then

                sbo.Suppliername = dr("Supplier Name")
                sbo.Supplierplace = dr("Place")
                sbo.Suppliercontact = "" & dr("Contact Number")
            End If

        Catch ex As Exception
            Throw

        End Try


    End Function


    Public Function list() As DataTable
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim db As New SqlServer
        Dim query As String
        Dim cmd As New SqlCommand

        Try

            query = "Select * from Supplier orderby"

            cmd.CommandText = query
            dt = db.GetDataTable(cmd)
            Return dt

        Catch ex As Exception
            Throw

        End Try


    End Function

    Public Function update(ByVal supplierID As String)

        Dim cmd As New SqlCommand
        Dim query As String
        Dim db As New SqlServer

        Try
            query = "update Supplier set [Supplier Name]=@supplierName ,
                     [Contact Number]=@Contact  , 
                      Place=@place
                    Where [Supplier ID]=@SupplierID"

            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@supplierName", sbo.Suppliername)
            cmd.Parameters.AddWithValue("@place", sbo.Supplierplace)
            cmd.Parameters.AddWithValue("@contact", sbo.Suppliercontact)
            cmd.Parameters.AddWithValue("@SupplierID", supplierID)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
        End Try
    End Function


    Public Function Delete(ByVal supplierID As String)

        Dim cmd As New SqlCommand
        Dim query As String
        Dim db As New SqlServer

        Try
            query = " delete from Supplier where [supplier ID]=@supplierID"

            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@SupplierID", supplierID)

            db.ExecuteNonQuery(cmd)


        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
        End Try

        Return True
    End Function
End Class
