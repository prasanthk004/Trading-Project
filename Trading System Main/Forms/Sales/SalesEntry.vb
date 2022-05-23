
Imports Trading_BO
Public Class SalesEntry
    Dim cdt As New DataTable
    Dim Salesid As Long


    Private Sub loader()
        Dim o As New SalesDAL
        Dim cbo As New CusDAL
        Dim ibo As New ItemDAL


        Try
            CrudSales.DataTable = o.list
            cdt = cbo.list()
            cbCusName.DataSource = cdt
            cdt = ibo.list()
            cbItem.DataSource = cdt
            cbItem.DisplayMember = "Item Description"
            cbItem.ValueMember = "Item ID"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            cdt = Nothing
        End Try


    End Sub

    Private Sub CrudSales_DisplayRecord(dr As DataRow) Handles CrudSales.DisplayRecord
        Dim o As New SalesDAL

        Try
            Salesid = dr("SalesID")

            o.read(Salesid)

            With o.sabo
                DateTimePicker.Value = .SalesDate
                cbCusName.SelectedValue = .CustomerID
                lblBillno.Text = .BillNo
                lblNetAmt.Text = .NetAmount

            End With

            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = o.sabo.SalesDetail
        Catch ex As Exception
            Debug.Print(ex.Message)
            MessageBox.Show(ex.Message, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub SalesEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub btnActions(ByVal enabled As Boolean)
        DateTimePicker.Enabled = enabled
        cbCusName.Enabled = enabled

    End Sub

    Private Sub CrudSales_NewClicked() Handles CrudSales.NewClicked
        Dim sdt As New DataTable

        Dim o As New SalesDAL

        Try

            sdt = CrudSales.DataTable
            Salesid = -1

            DateTimePicker.Value = DateTime.Now
            btnActions(True)
            o.read(Salesid)
            lblBillno.Text = o.GetNextBillno()
            lblNetAmt.Text = ""
            DataGridView1.DataSource = o.sabo.SalesDetail


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub CrudSales_ModifyClicked(dr As DataRow) Handles CrudSales.ModifyClicked
        Salesid = dr("SalesID")
        btnActions(True)
    End Sub

    Private Sub CrudSales_CancelClicked() Handles CrudSales.CancelClicked
        btnActions(False)
    End Sub

    Private Sub CrudSales_SaveClicked() Handles CrudSales.SaveClicked
        Dim o As New SalesDAL


        Try

            With o.sabo
                .CustomerID = cbCusName.SelectedValue
                .SalesDate = DateTimePicker.Value
                .SalesID = Salesid
                .SalesDetail = DataGridView1.DataSource
                .NetAmount = lblNetAmt.Text
                .BillNo = lblBillno.Text
            End With

            If Salesid = -1 Then
                o.sabo.SalesID = -1
                o.create()
                loader()
                Salesid = CrudSales.dt.Rows(CrudSales.dt.Rows.Count - 1)("SalesID")
                MessageBox.Show("Data has been created Sales ID " & Salesid, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                o.update(Salesid)
                loader()
                MessageBox.Show("Data has been Updated  Sales ID " & Salesid, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            btnActions(False)
        End Try
    End Sub


    Private Sub CrudSales_deleteClicked(dr As DataRow) Handles CrudSales.deleteClicked
        Dim o As New SalesDAL
        Salesid = dr("SalesID")
        Try
            o.delete(Salesid)
            loader()
            MessageBox.Show("Data has been deleted  Sales ID " & Salesid, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        'If e.ThrowException = True Then
        '    e.ThrowException = False
        'End If
    End Sub


    Private Sub getRate()

        Dim lqty As Decimal
        Dim lamount As Decimal
        Dim rate As Decimal
        Dim ibo As New ItemDAL

        Dim itmid As Long

        Try
            itmid = DataGridView1.CurrentRow.Cells(0).FormattedValue
            ibo.read(itmid)
            lqty = DataGridView1.CurrentRow.Cells(1).Value
            rate = ibo.ibo.itemPrice
            DataGridView1.CurrentRow.Cells(2).Value = rate
            lamount = lqty * rate
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub UpdateAmount()

        Dim lqty As Decimal
        ' Dim lamount As Decimal
        Dim rate As Decimal
        Dim ibo As New ItemDAL

        Dim itmid As Long

        Try
            If DataGridView1.Focused() Then


                itmid = DataGridView1.CurrentRow.Cells(0).Value
                ibo.read(itmid)
                lqty = Val(DataGridView1.CurrentRow.Cells(1).FormattedValue & "")
                rate = ibo.ibo.itemPrice
                DataGridView1.CurrentRow.Cells(2).Value = rate
                DataGridView1.CurrentRow.Cells(3).Value = rate * lqty
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            ibo = Nothing
        End Try

    End Sub


    Private Sub updateNetAmount()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim tamt As Decimal = 0
        Try
            dt = DataGridView1.DataSource

            For Each dr In dt.Rows

                tamt += dr("Amount")

            Next

            lblNetAmt.Text = Format(tamt, "0.00")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sales Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If Not DataGridView1.Focused Then
            Exit Sub
        End If
        Select Case e.ColumnIndex
            Case 1
                'Updating Amount
                UpdateAmount()
            Case 2
                UpdateAmount()
        End Select
        Debug.Print("Cell Value Changed" & DataGridView1.Rows.Count)
    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter

        If Not DataGridView1.Focused Then
            Exit Sub
        End If

        updateNetAmount()

    End Sub

    Private Sub DataGridView1_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValidated
        If Not DataGridView1.Focused Then
            Exit Sub
        End If


        updateNetAmount()
    End Sub
End Class