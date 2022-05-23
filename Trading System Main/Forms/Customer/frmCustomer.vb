
Imports Trading_BO
Public Class frmCustomer

    Dim dt As New DataTable
    Dim cusID As Long = -1
    Dim crec As Long = 0

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub


    Private Sub loader()
        Dim o As New CusDAL
        Try

            If cusID = -1 Then
                crec = 0
            End If
            dt = o.list()
            displayRecord()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub displayRecord()
        Dim o As New CusDAL

        Try
            cusID = dt.Rows(crec)("Customer ID")
            o.read(cusID)
            With o.cbo
                tbCusName.Text = .CusName
                tbCusPlace.Text = .CusPlace
                tbNum.Text = .CusNum
            End With

            lblRecord.Text = crec + 1 & "/" & dt.Rows.Count

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub lnext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnext.LinkClicked
        Try

            If crec + 1 >= dt.Rows.Count Then
                Throw New Exception("Already You are in Last Record!")
            End If

            crec += 1

            displayRecord()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try



    End Sub

    Private Sub lprevious_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lprevious.LinkClicked
        Try

            If crec <= 0 Then
                Throw New Exception("Already You are in first Record!")
            End If

            crec -= 1

            displayRecord()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lfirst_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfirst.LinkClicked
        Try

            If crec <= 0 Then
                Throw New Exception("Already You are in Last Record!")
            End If

            crec = 0

            displayRecord()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub llast_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llast.LinkClicked
        Try

            If crec >= dt.Rows.Count - 1 Then
                Throw New Exception("Already You are in Last Record!")
            End If

            crec = dt.Rows.Count - 1

            displayRecord()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub



    Private Sub lgoTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lgoTo.LinkClicked
        Try

            If tbGoTo.Text > dt.Rows.Count Then
                Throw New Exception("No Records Available!")
            ElseIf tbGoTo.Text - 1 = crec Then
                Throw New Exception("Already you are in Same Record  ")
            Else

                crec = tbGoTo.Text - 1

                displayRecord()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        cusID = -1
        tbCusName.Text = ""
        tbCusPlace.Text = ""
        tbNum.Text = ""
        btnActions(True)
        conVisible(False)
    End Sub


    Private Sub btnActions(ByVal enabled As Boolean)
        tbCusName.Enabled = enabled
        tbCusPlace.Enabled = enabled
        tbNum.Enabled = enabled
        btnNew.Enabled = Not enabled
        btnDelete.Enabled = Not enabled
        btnModify.Enabled = Not enabled
        btnSave.Enabled = enabled
        btnCancel.Enabled = enabled
    End Sub

    Private Sub conVisible(ByVal enabled As Boolean)
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
        Dim o As New CusDAL
        Try

            If MessageBox.Show("Are you Sure to delete the customer " & cusID, "Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                o.delete(cusID)
                MessageBox.Show("Customer details Deleted sucessfully! " & cusID, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            If crec <= 0 Then
                crec = 0
            Else
                crec -= 1
            End If
            loader()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        btnActions(True)
        conVisible(False)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim o As New CusDAL

        Try

            With o.cbo
                .CusName = tbCusName.Text
                .CusPlace = tbCusPlace.Text
                .CusNum = tbNum.Text

            End With
            If cusID = -1 Then
                o.create()
                MessageBox.Show("Customer details Created  sucessfully! ", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                o.update(cusID)
                MessageBox.Show("Customer details Updated  sucessfully! " & cusID, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            loader()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        btnActions(False)
        conVisible(True)
    End Sub

    Private Sub lfind_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfind.LinkClicked
        Dim frm As New frmFindcus
        frm.DataGridView1.DataSource = dt

        Try

            frm.ShowDialog()
            crec = 0
            If frm.DialogResult = DialogResult.OK Then

                Do While True
                    If frm.cusID = dt.Rows(crec)("Customer ID") Then
                        displayRecord()
                        Exit Do
                    End If

                    crec += 1
                Loop


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class