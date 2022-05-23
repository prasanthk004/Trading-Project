Public Class ComboItemDB
    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        Dim dtble As New DataTable
        Dim dr As DataRow

        dtble = connectDB()
        'For Each dr In dtble.Rows
        '    If dr("Item ID") = CmbItem.SelectedValue Then
        '        lblPrice.Text = dr("Sales Price")
        '    End If

        'Next

        dr = dtble.Rows(CmbItem.SelectedValue - 1)

        lblPrice.Text = dr("Sales Price") & "  RS"


        MessageBox.Show("Item ID = " & CmbItem.SelectedValue)


    End Sub

    Private Sub ComboItemDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CmbItem.DataSource = connectDB()


    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        CmbItem.SelectedValue = 2
    End Sub

    Private Function connectDB() As DataTable
        Dim o As Trading_BO.SqlServer
        Dim dt As New DataTable
        Dim query As String
        Try

            query = "select * from items"
            o = New Trading_BO.SqlServer
            dt = o.GetDataTable(query)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function
End Class