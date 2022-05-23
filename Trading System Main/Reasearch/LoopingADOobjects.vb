
Imports Trading_BO
Imports Microsoft.Data.SqlClient
Public Class LoopingADOobjects
    Dim dt As New DataTable
    Dim query As String
    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Dim o As New SqlServer
        Dim cmd As New SqlCommand
        Try
            query = "Select * from Items"
            cmd.CommandText = query
            dt = o.GetDataTable(cmd)
            DataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnColumns_Click(sender As Object, e As EventArgs) Handles btnColumns.Click
        Dim dc As New DataColumn
        Dim coloum As String = ""

        Try
            For Each dc In dt.Columns
                If coloum.Length > 0 Then
                    coloum &= ","
                End If
                coloum &= dc.Caption
            Next
            MessageBox.Show("Available Coloums " & coloum, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub btnSumloop_Click(sender As Object, e As EventArgs) Handles btnSumloop.Click
        Dim dr As DataRow
        Dim amount As Decimal = 0
        Try
            For Each dr In dt.Rows
                If dr("Sales price") Is DBNull.Value Then
                    amount += 0
                Else
                    amount += dr("Sales Price")
                End If

            Next

            MessageBox.Show("Total Amounts " & amount, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LoopingADOobjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnFetch.PerformClick()
    End Sub

    Private Sub btnSumCompute_Click(sender As Object, e As EventArgs) Handles btnSumCompute.Click
        Dim amount As Decimal
        Try
            amount = dt.Compute("sum([Sales Price])", "([Sales Price])>5000")
            MessageBox.Show("Total Amounts " & amount, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub filterG100_Click(sender As Object, e As EventArgs) Handles filterG100.Click
        Dim dv As New DataView(dt)
        Try
            dv.RowFilter = "[Sales Price]<1000"
            DataGridView.DataSource = dv
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub SumDvLoop_Click(sender As Object, e As EventArgs) Handles SumDvLoop.Click
        Dim dv As New DataView(dt)
        Try
            Dim amount As Decimal
            DataGridView.DataSource = dv

            For Each dr As DataRowView In dv
                If dr("Sales price") Is DBNull.Value Then
                    amount += 0
                Else
                    amount += dr("Sales Price")
                End If
            Next



            MessageBox.Show("Total Amounts DV Loop" & amount, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DVfindItems_Click(sender As Object, e As EventArgs) Handles DVfindItems.Click
        Dim dv As New DataView(dt)
        dv.Sort = "Item ID"
        Try
            Dim pos As Long
            Dim item As Long = InputBox("Item ID : ")

            pos = dv.Find(item)

            If pos = -1 Then

                MessageBox.Show("Invalid Item", "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                MessageBox.Show("Item Name : " & dv(pos)("Item Description"), "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADO object Test", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class