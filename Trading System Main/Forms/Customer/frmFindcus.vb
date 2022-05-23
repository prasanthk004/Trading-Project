Public Class frmFindcus

    Public cusID As Long
    Private Sub frmFindcus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
    End Sub



    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If DataGridView1.CurrentRow Is Nothing Then

            MessageBox.Show("Please select the customer", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        cusID = DataGridView1.CurrentRow.DataBoundItem("Customer ID")
        Me.DialogResult = DialogResult.OK


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class