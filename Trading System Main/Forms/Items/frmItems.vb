
Imports Trading_BO
Public Class frmItems

    Dim crec As Long
    Dim ItemId As Long
    Dim dt As New DataTable


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ItemId = -1
        tbItemName.Text = ""
        tbSalesPrice.Text = ""
        btnActions(True)
        conVisible(False)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim o As New ItemDAL


        Try

            o.delete(ItemId)
            MessageBox.Show(" Record Deleted", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub displayRecord()
        Dim o As New ItemDAL

        Try

            ItemId = dt.Rows(crec)("Item ID")

            o.read(ItemId)
            With o.ibo
                tbItemName.Text = " " & .itemDesc
                tbSalesPrice.Text = " " & .itemPrice
            End With
            lblRecord.Text = crec + 1 & "/" & dt.Rows.Count


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try



    End Sub

    Private Sub loader()
        Dim o As New ItemDAL
        Try

            If ItemId = -1 Then
                crec = 0
            End If

            dt = o.list()
            displayRecord()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        btnActions(True)
        conVisible(False)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim o As New ItemDAL

        Try

            With o.ibo
                .itemDesc = tbItemName.Text
                .itemPrice = Val(tbSalesPrice.Text)

            End With
            If ItemId = -1 Then

                o.create()
                loader()
                MessageBox.Show("New Record Created ", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loader()
            Else

                o.update(ItemId)
                MessageBox.Show(" Details Updated on Item ID " & ItemId, "Items", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            o = Nothing
        End Try

        btnActions(False)
        conVisible(True)

    End Sub

    Private Sub btnActions(ByVal enabled As Boolean)
        tbItemName.Enabled = enabled
        tbSalesPrice.Enabled = enabled
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnActions(False)
        conVisible(True)
    End Sub

    Private Sub lfirst_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfirst.LinkClicked
        Try
            If crec <= 0 Then
                Throw New Exception("Already You are in first Record!")
            End If

            crec = 0
            displayRecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub llast_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llast.LinkClicked
        Try
            If crec > dt.Rows.Count - 1 Then
                Throw New Exception("Already You are in Last Record!")
            End If

            crec = dt.Rows.Count - 1
            displayRecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lnext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnext.LinkClicked
        Try
            If crec >= dt.Rows.Count - 1 Then
                Throw New Exception("Already You are in Last Record!")
            End If

            crec += 1
            displayRecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lprevious_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lprevious.LinkClicked
        Try
            If crec <= 0 Then
                Throw New Exception("Already You are in First Record!")
            End If

            crec -= 1
            displayRecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lgoTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lgoTo.LinkClicked
        Try
            If crec + 1 = tbGoTo.Text Then
                Throw New Exception("Already You are in same Record!")
            End If

            crec = tbGoTo.Text - 1

            displayRecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lfind_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfind.LinkClicked
        Dim frm As New frmFinditems

        frm.DataGridView1.AutoGenerateColumns = False

        Try
            frm.DataGridView1.DataSource = dt
            frm.ShowDialog()

            If frm.DialogResult = DialogResult.OK Then
                crec = 0
                Do While True

                    ItemId = dt.Rows(crec)("Item ID")

                    If ItemId = frm.itemID Then
                        displayRecord()
                        Exit Do
                    End If

                    crec += 1

                Loop

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
End Class