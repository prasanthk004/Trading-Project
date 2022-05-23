Imports Microsoft.Data.SqlClient
Imports Trading_BO

Public Class StockTxn

    Dim dt As New DataTable
    Dim idt As New DataTable
    Dim tid As Long = -1
    Dim crec As Long
    Private Sub StockTxn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
        Dim o As New ItemDAL
        Try
            idt = o.list
            tbItemID.DataSource = idt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub loader()
        Dim o As New OsDAL

        Try
            If tid = -1 Then
                crec = 0
            End If
            dt = o.list()
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub displayrecord()
        Dim o As New OsDAL
        Try
            tid = dt.Rows(crec)("TransactionID")
            o.read(tid)
            With o.tbo
                dbDate.Value = ._dt
                tbItemID.SelectedValue = .ItemId
                tbQty.Text = .qty
                tbRefno.Text = .refno
                tbBookNo.Text = .bookno
            End With
            lblRecord.Text = crec + 1 & "/" & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub lprevious_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lprevious.LinkClicked
        Try
            If crec <= 0 Then
                Throw New Exception("Aleardy you are in first record !")
            End If
            crec -= 1
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lfirst_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfirst.LinkClicked
        Try
            If crec <= 0 Then
                Throw New Exception("Aleardy you are in first record !")
            End If
            crec = 0
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lnext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnext.LinkClicked
        Try
            If crec >= dt.Rows.Count - 1 Then
                Throw New Exception("Aleardy you are in last record !")
            End If
            crec += 1
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub llast_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llast.LinkClicked
        Try
            If crec >= dt.Rows.Count - 1 Then
                Throw New Exception("Aleardy you are in last record !")
            End If
            crec = dt.Rows.Count - 1
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lgoTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lgoTo.LinkClicked
        Try
            If tbGoTo.Text > dt.Rows.Count Then
                Throw New Exception(" Total Available records" & dt.Rows.Count)
            ElseIf tbGoTo.Text - 1 = crec Then
                Throw New Exception("Already you are in same record!")
            End If
            crec = tbGoTo.Text - 1
            displayrecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnActions(ByVal enabled As Boolean)
        dbDate.Enabled = enabled
        tbItemID.Enabled = enabled
        tbQty.Enabled = enabled
        tbBookNo.Enabled = enabled
        tbRefno.Enabled = enabled
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
        Dim o As New OsDAL
        Try
            Dim ds As New DialogResult
            ds = MessageBox.Show("Are you sure to delete ? " & tid, "Opening Stock", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            o.delete(tid)
            MessageBox.Show("Record Has been deleted", "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If crec <= 0 Then
                crec = 0
            Else
                crec -= 1
            End If
            loader()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim trans As String
        Dim c As Char
        Dim tran As String

        trans = dt.Rows(dt.Rows.Count - 1)("Book No")
        tran = ""
        For Each c In trans
            If Char.IsDigit(c) Then
                tran &= c
            End If

        Next


        dbDate.Value = DateTime.Today
        tbItemID.Text = ""
        tbQty.Text = ""
        tbBookNo.Text = "TRAN" & tran + 1
        tbRefno.Text = dt.Rows(dt.Rows.Count - 1)("Ref No") + 1
        tid = -1
        btnActions(True)
        conVisible(False)
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        btnActions(True)
        conVisible(False)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim o As New OsDAL

        Try
            With o.tbo
                .dat = dbDate.Value
                .ItemId = tbItemID.SelectedValue
                .qty = tbQty.Text
                .bookno = tbBookNo.Text
                .refno = tbRefno.Text
            End With

            If tid = -1 Then
                o.create()
                loader()
                tid = dt.Rows(dt.Rows.Count - 1)("TransactionID")
                MessageBox.Show("New Record Has been Created " & vbCrLf & " Transaction ID " & tid, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                o.update(tid)
                MessageBox.Show("Record has been modified ! " & vbCrLf & " Transaction ID  " & tid, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        btnActions(False)
        conVisible(True)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        btnActions(False)
        conVisible(True)
        displayrecord()
    End Sub

    Private Sub lfind_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfind.LinkClicked
        Dim frm As New FrmFindTransaction
        frm.DataGridView1.DataSource = dt
        frm.ShowDialog()
        crec = 0
        Try
            If frm.DialogResult = DialogResult.OK Then

                Do While True
                    tid = dt.Rows(crec)("TransactionID")
                    If frm.tid = tid Then
                        displayrecord()
                        Exit Do
                    End If

                    crec += 1
                Loop

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Opening Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tbItemID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbItemID.SelectedIndexChanged

    End Sub
End Class