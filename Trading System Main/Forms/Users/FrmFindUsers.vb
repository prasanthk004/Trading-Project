Public Class FrmFindUsers
    Public uid As Long
    Private Sub FrmFindUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.AutoGenerateColumns = False

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            If DataGridView1.CurrentRow Is Nothing Then
                MessageBox.Show("Please select the user")
            End If
            uid = DataGridView1.CurrentRow.DataBoundItem("UserID")
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class