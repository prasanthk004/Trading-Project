Public Class frmFindSupplier
    Public supplierID As Long
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Please choose the supplier Name")
            Exit Sub
        End If
        supplierID = DataGridView1.CurrentRow.DataBoundItem("Supplier ID")
        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmFindSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class