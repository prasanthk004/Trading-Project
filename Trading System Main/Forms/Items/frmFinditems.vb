
Imports Trading_BO
Public Class frmFinditems

    Public itemID As Long
    Private Sub frmFinditems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.AutoGenerateColumns = False

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            If DataGridView1.CurrentRow Is Nothing Then
                MessageBox.Show("Please Select the item from the table")
            End If

            itemID = DataGridView1.CurrentRow.DataBoundItem("Item ID")
            Me.DialogResult = DialogResult.OK

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class