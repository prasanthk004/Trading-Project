Public Class TestingDALS

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim o As New Trading_BO.SupplierDAL

        Try
            o.sbo.Suppliername = "yRange TechStore"
            o.sbo.Supplierplace = "US"
            o.sbo.Suppliercontact = "0001758548456"

            o.create()
            listdata()
            MessageBox.Show("Successfully Created ", "Supplier Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listdata()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim o As New Trading_BO.SupplierDAL

        Try


            o.read(tbSupplierID.Text)


            lblResult.Text = " Details of " & tbSupplierID.Text
            lblResult.Text &= vbCrLf & " Supplier Name       :  " & o.sbo.Suppliername & " "
            lblResult.Text &= vbCrLf & " Supplier Contact    :  " & o.sbo.Suppliercontact




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub listdata()

        Dim o As New Trading_BO.SupplierDAL

        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = o.list

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            o = Nothing
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim o As New Trading_BO.SupplierDAL
        Try
            o.sbo.Suppliername = "Prasanth TechStore"
            o.sbo.Supplierplace = "US"
            o.sbo.Suppliercontact = "0001758548456"

            o.update(tbSupplierID.Text)
            MessageBox.Show("Successfully Updated ", "Supplier Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            listdata()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            o = Nothing
        End Try


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim o As New Trading_BO.SupplierDAL

        Try
            o.Delete(tbSupplierID.Text)
            MessageBox.Show("Successfully Deleted Row " & tbSupplierID.Text, "Supplier Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            listdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub
End Class