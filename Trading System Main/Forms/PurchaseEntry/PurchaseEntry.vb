Imports System.ComponentModel
Imports Trading_BO

Public Class PurchaseEntry

    Dim PurchaseID As Long
    Dim pdt As New DataTable
    Dim ntamt As Decimal


    Private Sub PurchaseEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loader()

    End Sub

    Private Sub loader()

        Dim o As New PurchaseDAL
        Dim sup As New SupplierDAL
        Dim sdt As New DataTable
        Dim itm As New ItemDAL

        Try
            purchaseCRUD.DataTable = o.list()
            sdt = sup.list()
            cbSupplier.DataSource = sdt
            sdt = itm.list

            ItemName.DisplayMember = "Item Description"
            ItemName.ValueMember = "Item ID"
            ItemName.DataSource = sdt


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub



    Private Sub purchaseCRUD_DisplayRecord(dr As DataRow) Handles purchaseCRUD.DisplayRecord
        Dim o As New PurchaseDAL

        Dim dt As New DataTable

        lblNetAmt.Text = ""
        Try
            dt = purchaseCRUD.DataTable
            PurchaseID = dr("PurchaseID")

            o.read(PurchaseID)

            With o.pbo
                purchaseDateTime.Value = .PurchaseDate
                cbSupplier.SelectedValue = .SupplierID
                lblBillNo.Text = .BillNo
                lblNetAmt.Text = .NetAmount

            End With


            DGpurchaseDetail.AutoGenerateColumns = False
            DGpurchaseDetail.DataSource = o.pbo.PurchaseDetail


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub purchaseCRUD_deleteClicked(dr As DataRow) Handles purchaseCRUD.deleteClicked
        Dim o As New PurchaseDAL
        Try
            o.delete(PurchaseID)

            MessageBox.Show("Record " & PurchaseID & " Has been Deleted ", "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            loader()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGpurchaseDetail_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGpurchaseDetail.DataError
        'If e.ThrowException = True Then
        '    e.ThrowException = False
        'End If
    End Sub


    Private Sub updateAmount()
        Dim lamt As Decimal
        Dim lqty As Decimal
        Dim lrate As Decimal
        Dim itm As New ItemDAL
        Dim idt As New DataTable
        Dim itemID As Long
        Try

            itemID = DGpurchaseDetail.CurrentRow.Cells(0).Value
            itm.read(itemID)
            lqty = DGpurchaseDetail.CurrentRow.Cells(1).Value
            lrate = itm.ibo.itemPrice
            lamt = lqty * lrate
            DGpurchaseDetail.CurrentRow.Cells(2).Value = lrate
            DGpurchaseDetail.CurrentRow.Cells(3).Value = lamt


            Debug.Print(lblNetAmt.Text)
            ntamt = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub DGpurchaseDetail_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGpurchaseDetail.CellValueChanged
        Debug.Print("Cell value changed")

        If Not DGpurchaseDetail.Focused Then
            Exit Sub
        End If

        Select Case e.ColumnIndex
            Case 1
                updateAmount()

            Case 2
                updateAmount()


        End Select
    End Sub

    Private Sub purchaseCRUD_NewClicked() Handles purchaseCRUD.NewClicked

        Dim o As New PurchaseDAL

        Try
            purchaseDateTime.Value = DateTime.Today
            lblBillNo.Text = o.GetNextBillNo() + 1
            PurchaseID = -1
            BtnActions(True)
            o.read(PurchaseID)
            DGpurchaseDetail.DataSource = o.pbo.PurchaseDetail


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub purchaseCRUD_SaveClicked() Handles purchaseCRUD.SaveClicked
        Dim o As New PurchaseDAL

        Try
            With o.pbo
                .PurchaseDate = purchaseDateTime.Value
                .SupplierID = cbSupplier.SelectedValue
                .BillNo = lblBillNo.Text
                .PurchaseID = PurchaseID
                .PurchaseDetail = DGpurchaseDetail.DataSource
                .NetAmount = Val(lblNetAmt.Text)
            End With

            If PurchaseID = -1 Then
                o.create()
                loader()
                PurchaseID = purchaseCRUD.dt(purchaseCRUD.dt.Rows.Count - 1)("PurchaseID")
                MessageBox.Show(" New Record has been created on  Purchase ID " & PurchaseID, "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                o.update(PurchaseID)
                loader()
                MessageBox.Show("Record Has been updated on Purchase ID  " & PurchaseID, "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            BtnActions(False)
        End Try
    End Sub


    Private Sub BtnActions(ByVal enabled As Boolean)
        cbSupplier.Enabled = enabled
        purchaseDateTime.Enabled = enabled

    End Sub

    Private Sub purchaseCRUD_ModifyClicked(dr As DataRow) Handles purchaseCRUD.ModifyClicked
        PurchaseID = dr("PurchaseID")
        BtnActions(True)
    End Sub

    Private Sub purchaseCRUD_CancelClicked() Handles purchaseCRUD.CancelClicked
        BtnActions(False)
    End Sub

    Private Sub UpdateNetAmount()
        Dim dr As DataRow
        Dim lamt As Decimal
        Dim dt As New DataTable

        Try
            dt = DGpurchaseDetail.DataSource
            lamt = 0
            For Each dr In dt.Rows
                lamt += dr("Amount")
            Next

            lblNetAmt.Text = lamt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try


    End Sub

    Private Sub DGpurchaseDetail_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGpurchaseDetail.RowEnter
        If Not DGpurchaseDetail.Focused() Then
            Exit Sub
        End If

        UpdateNetAmount()

    End Sub

    Private Sub DGpurchaseDetail_Validated(sender As Object, e As EventArgs) Handles DGpurchaseDetail.Validated

    End Sub

    Private Sub DGpurchaseDetail_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DGpurchaseDetail.CellValidated
        Debug.Print("Cell validated")
        If Not DGpurchaseDetail.Focused() Then
            Exit Sub
        End If
        If e.ColumnIndex = 1 Then
            UpdateNetAmount()
        End If

    End Sub

    Private Sub DGpurchaseDetail_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DGpurchaseDetail.RowValidated
        If Not DGpurchaseDetail.Focused() Then
            Exit Sub
        End If
        UpdateNetAmount()
        Debug.Print("Row validated")
    End Sub

    Private Sub DGpurchaseDetail_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGpurchaseDetail.RowValidating
        If Not DGpurchaseDetail.Focused() Then
            Exit Sub
        End If
        Dim lqty As String
        Debug.Print("row validating rowindex=" & e.RowIndex)
        DGpurchaseDetail.Rows(e.RowIndex).ErrorText = ""

        lqty = DGpurchaseDetail.Rows(e.RowIndex).Cells("Qty").FormattedValue
        If lqty = "" Then
            DGpurchaseDetail.Rows(e.RowIndex).ErrorText = "Please enter the Qty! "
            e.Cancel = True
        ElseIf Val(lqty) <= 0 Then
            DGpurchaseDetail.Rows(e.RowIndex).ErrorText = "Please enter the qty grater than 0 "
            e.Cancel = True
        End If

    End Sub

    Private Sub purchaseCRUD_Load(sender As Object, e As EventArgs) Handles purchaseCRUD.Load

    End Sub
End Class