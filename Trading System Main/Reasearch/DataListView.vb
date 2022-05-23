Public Class DataListView
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click

        Dim o As New Trading_BO.SqlServer
        Dim dt As New DataTable
        Dim id As Integer
        Dim ldescr As String
        Dim price As Decimal
        Try
            dt = o.GetDataTable(tbQuery.Text)

            Dim dr As DataRow
            Dim lvi As ListViewItem



            ListViewMain.Items.Clear()
            For Each dr In dt.Rows

                id = dr("item ID")
                ldescr = dr("item Description")
                price = dr("Sales Price")

                lvi = New ListViewItem()
                lvi.Text = id
                lvi.SubItems.Add(ldescr)
                lvi.SubItems.Add(price)
                ListViewMain.Items.Add(lvi)




            Next


        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbQuery_TextChanged(sender As Object, e As EventArgs) Handles tbQuery.TextChanged

    End Sub

    Private Sub lblQuery_Click(sender As Object, e As EventArgs) Handles lblQuery.Click

    End Sub

    Private Sub DataListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class