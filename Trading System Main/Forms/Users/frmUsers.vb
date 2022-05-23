Imports Trading_BO

Public Class frmUsers

    Dim dt As New DataTable
    Dim uid As Long = -1
    Dim crec As Long
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loader()
    End Sub
    Private Sub Loader()
        Dim o As New UserDAL
        Try
            If uid = -1 Then
                crec = 0
            End If

            dt = o.list()
            displayrecord()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub displayrecord()
        Dim o As New UserDAL

        Try
            uid = dt.Rows(crec)("UserID")
            o.read(uid)
            With o.ubo
                tbUserName.Text = .UserName
                tbLoginID.Text = .LoginID
                tbPassword.Text = .Password
            End With
            lblRecord.Text = crec + 1 & "/" & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lnext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnext.LinkClicked

        Try
            If crec >= dt.Rows.Count - 1 Then
                Throw New Exception("Already You are in Last Record !")
            End If
            crec += 1
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub llast_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llast.LinkClicked

        Try
            If crec >= dt.Rows.Count - 1 Then
                Throw New Exception("Already You are in Last Record !")
            End If
            crec = dt.Rows.Count - 1
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lprevious_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lprevious.LinkClicked

        Try
            If crec <= 0 Then
                Throw New Exception("Already You are in First Record !")
            End If
            crec = dt.Rows.Count - 1
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub lfirst_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfirst.LinkClicked

        Try
            If crec <= 0 Then
                Throw New Exception("Already You are in First Record !")
            End If
            crec -= 1
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnActions(ByVal enabled As Boolean)
        tbUserName.Enabled = enabled
        tbLoginID.Enabled = enabled

        btnNew.Enabled = Not enabled
        btnDelete.Enabled = Not enabled
        btnModify.Enabled = Not enabled
        btnSave.Enabled = enabled
        btnCancel.Enabled = enabled
    End Sub

    Private Sub conVisible(ByVal enabled As Boolean)

        tbPassword.Visible = Not enabled
        lblPassword.Visible = Not enabled
        tbGoTo.Visible = enabled
        lblRecord.Visible = enabled
        lfind.Visible = enabled
        lprevious.Visible = enabled
        lgoTo.Visible = enabled
        lfirst.Visible = enabled
        lnext.Visible = enabled
        llast.Visible = enabled

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim o As New OsDAL
        Try
            If MessageBox.Show("Are You sure to Delete ?", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then

                o.delete(uid)
                If crec <= 0 Then
                    crec = 0
                End If
            Else
                crec = -1
            End If
            displayrecord()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        tbLoginID.Text = ""
        tbUserName.Text = ""
        tbPassword.Text = ""
        uid = -1
        conVisible(False)
        btnActions(True)


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        conVisible(True)
        btnActions(False)
        displayrecord()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim o As New UserDAL
        Try
            With o.ubo
                .UserName = tbUserName.Text
                .LoginID = tbLoginID.Text
                .Password = tbPassword.Text
            End With
            If uid = -1 Then
                o.create()
                Loader()
                MessageBox.Show("New User has been created User ID " & dt.Rows(dt.Rows.Count - 1)("UserID"), "Users", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                o.update(uid)
                MessageBox.Show("User Record has been updated on User ID " & uid, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conVisible(True)
        btnActions(False)
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        conVisible(False)
        btnActions(True)
    End Sub
    Private Sub lgoTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lgoTo.LinkClicked
        Try

            If tbGoTo.Text > dt.Rows.Count Then
                Throw New Exception("No Records Available!")
            ElseIf tbGoTo.Text <= 0 Then
                Throw New Exception("No Records Available!")
            ElseIf tbGoTo.Text - 1 = crec Then
                Throw New Exception("Already you are in Same Record  ")

            Else

                crec = tbGoTo.Text - 1

                displayrecord()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lfind_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfind.LinkClicked
        Dim frm As New FrmFindUsers
        frm.DataGridView1.AutoGenerateColumns = False
        frm.DataGridView1.DataSource = dt

        Try
            crec = 0
            frm.ShowDialog()

            If frm.DialogResult = DialogResult.OK Then

                Do While True
                    If frm.uid = dt.Rows(crec)("UserID") Then
                        displayrecord()
                        Exit Do
                    End If
                    crec += 1
                Loop

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub
End Class