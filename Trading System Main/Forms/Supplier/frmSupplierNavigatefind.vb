
Imports Trading_BO
Public Class frmSupplierNavigatefind

    Dim dt As New DataTable
    Dim supplierID As Long = -1
    Dim crec As Long


    Private Sub frmSupplierNavigatefind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
        btnActions(False)


    End Sub


    Private Sub loader()

        Dim o As New SupplierDAL
        Try
            dt = o.list()
            If supplierID = -1 Then
                crec = 0
            End If
            displayRecord()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            o = Nothing
        End Try



    End Sub


    Private Sub displayRecord()
        Dim o As New SupplierDAL


        Try
            supplierID = dt.Rows(crec)("Supplier ID")
            o.read(supplierID)

            With o.sbo
                tbSupName.Text = .Suppliername
                tbSupPlace.Text = .Supplierplace
                tbSupNum.Text = .Suppliercontact
            End With
            lblRecord.Text = crec + 1 & "/" & dt.Rows.Count

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            o = Nothing
            Debug.Print(crec)
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
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

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
            If crec + 1 >= dt.Rows.Count Then
                Throw New Exception("Already You are in Last Record!")
            End If

            crec = dt.Rows.Count - 1
            displayRecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub lfind_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfind.LinkClicked
        Dim frm As New frmFindSupplier
        frm.DataGridView1.AutoGenerateColumns = False
        frm.DataGridView1.DataSource = dt



        If frm.ShowDialog = DialogResult.OK Then

            Dim fsupplierID As Long = frm.supplierID
            crec = 0

            Do While True
                If fsupplierID = dt.Rows(crec)("Supplier ID") Then
                    displayRecord()
                    Exit Do
                End If
                crec += 1
            Loop
        Else

        End If

        frm.Dispose()

    End Sub

    Private Sub lgoTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lgoTo.LinkClicked

        Try

            If Val(tbGoTo.Text) > dt.Rows.Count Then
                Throw New Exception(" No Records Available !" & vbCrLf & " Total Available Record " & dt.Rows.Count)
            End If
            crec = Val(tbGoTo.Text) - 1

            displayRecord()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub


    Private Sub btnActions(ByVal enabled As Boolean)

        btnSave.Enabled = enabled
        btnCancel.Enabled = enabled
        btnNew.Enabled = Not enabled
        btnModify.Enabled = Not enabled
        btnDelete.Enabled = Not enabled
        tbSupName.Enabled = enabled
        tbSupPlace.Enabled = enabled
        tbSupNum.Enabled = enabled


    End Sub

    Private Sub lVisible(ByVal enabled As Boolean)
        lblRecord.Visible = enabled
        lfind.Visible = enabled
        lfirst.Visible = enabled
        llast.Visible = enabled
        lnext.Visible = enabled
        lprevious.Visible = enabled
        lgoTo.Visible = enabled
        tbGoTo.Visible = enabled

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        btnActions(True)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim o As New SupplierDAL
        Try

            With o.sbo
                .Suppliername = tbSupName.Text
                .Supplierplace = tbSupPlace.Text
                .Suppliercontact = tbSupNum.Text

            End With

            If supplierID = -1 Then
                o.create()
                loader()
                crec = dt.Rows.Count - 1
                supplierID = dt.Rows(crec)("Supplier ID")
                MessageBox.Show("Details Created Successfully on Supplier ID " & supplierID, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                o.update(supplierID)
                loader()
                MessageBox.Show("Details Updated Successfully on Supplier ID " & supplierID, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnActions(True)
        End Try


        btnActions(False)
        lVisible(True)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim o As New SupplierDAL

        Try
            If MessageBox.Show("Are you sure to delete " & supplierID, "Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then

                o.Delete(supplierID)
                If crec <= 0 Then
                    crec = 0
                Else
                    crec -= 1
                End If

                loader()
                MessageBox.Show("Record Has been Deleted Successfully", "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub


    Private Function validData() As Boolean
        Try
            If tbSupName.Text = "" Then
                Throw New Exception(" Enter Supplier Name !")
            End If
        Catch ex As Exception
            Throw
        End Try

        Return True


    End Function

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        tbSupName.Text = ""
        tbSupNum.Text = ""
        tbSupPlace.Text = ""
        btnActions(True)
        lVisible(False)

        supplierID = -1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnActions(False)
        lVisible(True)

    End Sub
End Class