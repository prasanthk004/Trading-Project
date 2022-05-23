Public Class Trading_Common_Controls
    Public dt As New DataTable

    Dim crec As Long = -1



    Public Property DataTable() As DataTable
        Get
            Return dt
        End Get
        Set(value As DataTable)
            dt = value
            If crec = -1 AndAlso dt.Rows.Count > 0 Then
                CurRecord = 0
                RaiseEvent DisplayRecord(dt.Rows(crec))

            End If
            updatestatus()
        End Set
    End Property

    Public Property CurRecord As Long
        Get
            Return crec
        End Get
        Set(value As Long)


            If dt.Rows.Count > 0 Then

                crec = value
                If crec <= 0 Then
                    lfirst.Enabled = False
                    lprevious.Enabled = False
                    llast.Enabled = True
                    lnext.Enabled = True
                ElseIf crec >= dt.Rows.Count - 1 Then
                    llast.Enabled = False
                    lnext.Enabled = False
                    lfirst.Enabled = True
                    lprevious.Enabled = True
                Else
                    llast.Enabled = True
                    lnext.Enabled = True
                    lfirst.Enabled = True
                    lprevious.Enabled = True

                End If



                RaiseEvent DisplayRecord(dt.Rows(crec))
                updatestatus()


            End If
        End Set

    End Property

    Event DisplayRecord(ByVal dr As DataRow)
    Event FindRecord(ByRef cancel As Boolean, ByRef lCrec As Long)
    Event ModifyClicked(ByVal dr As DataRow)
    Event NewClicked()
    Event SaveClicked()
    Event CancelClicked()
    Event deleteClicked(ByVal dr As DataRow)






    Private Sub updatestatus()
        lblRecord.Text = crec + 1 & "/" & dt.Rows.Count
    End Sub

    Private Sub lprevious_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lprevious.LinkClicked
        Try
            If crec <= 0 Then
                Throw New Exception("Already You are in first Record!")
            End If
            CurRecord = crec - 1
            RaiseEvent DisplayRecord(dt.Rows(crec))
            updatestatus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub lfirst_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfirst.LinkClicked
        Try
            If crec <= 0 Then
                Throw New Exception("Already You are in first Record!")
            End If

            CurRecord = 0


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lnext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnext.LinkClicked
        Try
            If crec >= dt.Rows.Count - 1 Then
                Throw New Exception("  You are in Last Record!")
            End If

            CurRecord = crec + 1


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub llast_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llast.LinkClicked
        Try
            If crec >= dt.Rows.Count - 1 Then
                Throw New Exception("  You are in Last Record!")
            End If

            CurRecord = dt.Rows.Count - 1


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lgoTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lgoTo.LinkClicked
        Try

            If Val(tbGoTo.Text) > dt.Rows.Count Or Val(tbGoTo.Text) <= 0 Then
                Throw New Exception(" No Records Available !" & vbCrLf & " Total Available Record " & dt.Rows.Count)
            End If
            CurRecord = Val(tbGoTo.Text) - 1


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub lfind_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lfind.LinkClicked
        Dim lcrec As Long
        Dim lcancel As Boolean = False

        Try
            RaiseEvent FindRecord(lcancel, lcrec)

            If Not lcancel Then
                CurRecord = lcrec

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub changeText(ByVal btnnewclicked As Boolean)

        If btnnewclicked Then
            ' Perform Users new actions
            If btnNew.Text = "New" Then
                RaiseEvent NewClicked()
            Else
                RaiseEvent SaveClicked()
                RaiseEvent DisplayRecord(dt.Rows(crec))

            End If
        Else

            If btnModify.Text = "Modify" Then
                RaiseEvent ModifyClicked(dt.Rows(crec))
            Else
                RaiseEvent CancelClicked()
                RaiseEvent DisplayRecord(dt.Rows(crec))
            End If
        End If

        If btnNew.Text = "New" Then
            btnNew.Text = "Save"
            btnModify.Text = "Cancel"
            btnDelete.Enabled = False
        Else

            btnNew.Text = "New"
            btnModify.Text = "Modify"
            btnDelete.Enabled = True
        End If



    End Sub

    Private Sub ConVisible(ByVal enabled As Boolean)
        lblRecord.Visible = enabled
        lfind.Visible = enabled
        lfirst.Visible = enabled
        llast.Visible = enabled
        lnext.Visible = enabled
        lprevious.Visible = enabled
        lgoTo.Visible = enabled
        tbGoTo.Visible = enabled

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If btnNew.Text = "New" Then
            changeText(True)
            ConVisible(False)

        Else
            ConVisible(True)
            changeText(True)

        End If

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If btnNew.Text = "New" Then
            changeText(False)
            ConVisible(False)
        Else
            changeText(False)
            ConVisible(True)

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        RaiseEvent deleteClicked(dt.Rows(crec))
        If CurRecord > 0 Then
            CurRecord = crec - 1
        Else
            CurRecord = 0


        End If
    End Sub

    Private Sub Trading_Common_Controls_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
