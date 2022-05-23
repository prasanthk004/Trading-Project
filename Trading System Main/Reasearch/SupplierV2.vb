
Imports Trading_BO

Public Class SupplierV2
    Dim dt As New DataTable
    Dim supplierID As Long = -1
    Dim crec As Long

    Private Sub SupplierV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub loader()

        Dim o As New SupplierDAL

        Try
            Crud.DataTable = o.list()
            dt = Crud.DataTable

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            o = Nothing
        End Try

    End Sub

    Private Sub Crud_DisplayRecord(dr As DataRow) Handles Crud.DisplayRecord
        Dim o As New SupplierDAL


        Try
            supplierID = dr("Supplier ID")
            o.read(supplierID)

            With o.sbo
                tbSupName.Text = .Suppliername
                tbSupPlace.Text = .Supplierplace
                tbSupNum.Text = .Suppliercontact
            End With


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            o = Nothing
            Debug.Print(crec)
        End Try
    End Sub

    Private Sub Crud_FindRecord(ByRef cancel As Boolean, ByRef lCrec As Long) Handles Crud.FindRecord
        Dim frm As New frmFindSupplier
        Dim ldt As New DataTable
        ldt = Crud.DataTable
        frm.DataGridView1.AutoGenerateColumns = False
        frm.DataGridView1.DataSource = ldt
        Try
            If frm.ShowDialog = DialogResult.OK Then

                Dim fsupplierID As Long = frm.supplierID
                crec = 0

                Do While True
                    If fsupplierID = ldt.Rows(crec)("Supplier ID") Then
                        Exit Do
                    End If
                    crec += 1
                Loop
                lCrec = crec
            Else
                cancel = True
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




        frm.Dispose()
    End Sub

    Private Sub Crud_NewClicked() Handles Crud.NewClicked
        btnActions(True)
        tbSupName.Text = ""
        tbSupPlace.Text = ""
        tbSupNum.Text = ""
        supplierID = -1
    End Sub


    Private Sub btnActions(ByVal enabled As Boolean)


        tbSupName.Enabled = enabled
        tbSupPlace.Enabled = enabled
        tbSupNum.Enabled = enabled


    End Sub

    Private Sub Crud_SaveClicked() Handles Crud.SaveClicked
        Dim o As New SupplierDAL


        Try
            With o.sbo
                .Suppliername = tbSupName.Text
                .Suppliercontact = tbSupNum.Text
                .Supplierplace = tbSupPlace.Text
            End With

            If supplierID = -1 Then
                o.create()
                loader()
                supplierID = dt.Rows(dt.Rows.Count - 1)("Supplier ID")
                MessageBox.Show("New Data Has been Created on ID " & supplierID, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                o.update(supplierID)
                MessageBox.Show("Data Has been Updated  on ID " & supplierID, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            btnActions(False)
        End Try


    End Sub

    Private Sub Crud_ModifyClicked(dr As DataRow) Handles Crud.ModifyClicked
        supplierID = dr("Supplier ID")
        btnActions(True)
    End Sub

    Private Sub Crud_CancelClicked() Handles Crud.CancelClicked
        btnActions(False)
    End Sub

    Private Sub Crud_deleteClicked(dr As DataRow) Handles Crud.deleteClicked
        Dim d As DialogResult
        Dim o As New SupplierDAL
        d = MessageBox.Show("Are You Sure to Delete ?", "Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        supplierID = dr("Supplier ID")
        If d = DialogResult.OK Then
            o.Delete(supplierID)
            MessageBox.Show("Data Has been Updated  on ID " & supplierID, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loader()
        Else
            Exit Sub
        End If
    End Sub
End Class