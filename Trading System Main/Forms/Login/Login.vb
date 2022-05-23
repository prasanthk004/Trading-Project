Imports Trading_BO
Public Class Login

    Dim UDT As New DataTable
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub loader()
        Dim o As New UserDAL
        Try
            UDT = o.list()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim o As New UserDAL
        Dim uid, pf, uf As Integer
        Try
            uid = 0
            pf = 0
            uf = 0
            For Each dr In UDT.Rows
                If tbUsername.Text = dr("UserName") Then
                    uid = dr("UserID")
                    o.read(uid)
                    uf = 1
                    Exit For
                End If
            Next


            If tbPassword.Text = o.ubo.Password Then
                pf = 1
            End If


            If uf = 1 And pf = 1 Then
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
            ElseIf uf = 1 And pf = 0 Then
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Incorrect Password !"
            Else
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Invalid User Name &  Password !"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Me.DialogResult = DialogResult.Cancel
    End Sub


End Class