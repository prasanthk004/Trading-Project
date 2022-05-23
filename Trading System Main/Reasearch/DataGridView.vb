Public Class DataGridView
    Private Sub tbQuery_TextChanged(sender As Object, e As EventArgs) Handles tbQuery.TextChanged

    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Dim o As New Trading_BO.SqlServer
        Dim dt As New DataTable


        Try
            dt = o.GetDataTable(tbQuery.Text)
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If Not DataGridView1.Focused Then
            Exit Sub
        End If

        ' MessageBox.Show(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        ' MessageBox.Show(DataGridView1.CurrentCell.Value)
    End Sub

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        Dim lsale As String


        Try
            DataGridView1.Rows(e.RowIndex).ErrorText = ""
        Catch ex As Exception
            MessageBox.Show(" Thorwn from cell validate")
        End Try

        Select Case DataGridView1.Columns(e.ColumnIndex).HeaderText
            Case "Sales Price"
                lsale = e.FormattedValue
                If Val(lsale) <= 0 Then
                    DataGridView1.Rows(e.RowIndex).ErrorText = " Invalid Sales Price Please enter value above 0"
                    e.Cancel = True
                End If

        End Select

    End Sub

    Private Sub DataGridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbQuery.Text = "Select * from items"
        btnExecute.PerformClick()
    End Sub


    Private Sub DataGridView1_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating
        Dim litmdes As String
        Dim lprice As String

        litmdes = DataGridView1.Rows(e.RowIndex).Cells("dcItemDesc").FormattedValue
        lprice = "0" & DataGridView1.Rows(e.RowIndex).Cells("dcSalesPrice").Value

        DataGridView1.Rows(e.RowIndex).ErrorText = ""
        Debug.Print(lprice)
        If litmdes.Trim.Length <= 0 Then
            ' DataGridView1.Rows(e.RowIndex).Cells("dcItemDesc").FormattedValue = "Null"

            DataGridView1.Rows(e.RowIndex).ErrorText = "Item Description Empty "
            e.Cancel = True
        End If
        If lprice = "0" Then
            DataGridView1.Rows(e.RowIndex).ErrorText = "Item sales price is invalid  "
            e.Cancel = True
        End If

    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Dim drv As DataRowView

        If Not DataGridView1.Focused Then
            Exit Sub
        End If
        drv = DataGridView1.Rows(e.RowIndex).DataBoundItem()
            MessageBox.Show(drv("Item ID"))


    End Sub
End Class