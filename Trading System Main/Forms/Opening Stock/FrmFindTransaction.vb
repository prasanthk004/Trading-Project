Public Class FrmFindTransaction
    Public tid As Long
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FrmFindTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Try
            If DataGridView1.CurrentRow Is Nothing Then
                Throw New Exception("Please Select the Transaction! ")
            End If
            tid = DataGridView1.CurrentRow.DataBoundItem("TransactionID")
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            Throw
        End Try


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class