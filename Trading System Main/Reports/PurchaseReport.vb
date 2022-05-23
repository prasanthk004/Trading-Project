Imports System.Drawing.Printing
Imports Trading_BO

Public Class PurchaseReport
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.ShowDialog()
        curRec = 0
        dbRec = 0
    End Sub

    Dim curRec As Long = 0
    Dim dbRec As Long = 0

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim dt As New DataTable
        Dim o As PurchaseDAL
        Dim pid As Long
        Try
            If rdSingleReport.Checked Then

                curRec += 1
                pid = cbBillNo.SelectedValue
                If chContents.Checked And chLayout.Checked Then
                    printLayout(e.MarginBounds.Left, e.MarginBounds.Top, e)
                    PrintContents(e.MarginBounds.Left, e.MarginBounds.Top, e, pid)
                ElseIf chContents.Checked Then

                    PrintContents(e.MarginBounds.Left, e.MarginBounds.Top, e, pid)
                Else
                    printLayout(e.MarginBounds.Left, e.MarginBounds.Top, e)
                End If

                e.HasMorePages = (curRec < nuCopies.Value)


            Else
                o = New PurchaseDAL()
                dt = o.list()
                pid = dt.Rows(dbRec)("PurchaseID")

                If chContents.Checked And chLayout.Checked Then
                    printLayout(e.MarginBounds.Left, e.MarginBounds.Top, e)
                    PrintContents(e.MarginBounds.Left, e.MarginBounds.Top, e, pid)
                ElseIf chContents.Checked Then

                    PrintContents(e.MarginBounds.Left, e.MarginBounds.Top, e, pid)
                Else
                    printLayout(e.MarginBounds.Left, e.MarginBounds.Top, e)
                End If

                e.HasMorePages = (dbRec < dt.Rows.Count - 1)
                dbRec += 1


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Report")
        End Try





    End Sub


    Private Sub printLayout(L As Integer, T As Integer, e As PrintPageEventArgs)

        Dim r As Rectangle
        Dim pt1, pt2 As Point
        Dim penLight As Pen
        Dim penDark As Pen
        Dim b As Brush
        Dim ph, pw
        Dim f As Font

        Try
            ph = 680
            pw = 625
            ' Printing Margins 
            r = New Rectangle(L, T, pw, ph)
            penDark = New Pen(Color.FromArgb(0.5 * 255, 0, 0, 0), 3)
            penLight = New Pen(Brushes.LightGray, 1)
            e.Graphics.DrawRectangle(penDark, r)

            DrawLine(L, T + 80, L + pw, T + 80, e)
            ' Heading 

            f = New Font("Arial", 12, FontStyle.Bold)
            DrawString("KP COMPUTERS (P) LTD", f, StringAlignment.Center, Brushes.DarkBlue, L, T + 10, pw, e)
            e.Graphics.DrawImage(My.Resources.kp2, L + 5, T + 10, 65, 65)

            f = New Font("Arial", 7, FontStyle.Regular)


            DrawString("Chengalpattu-603108", f, StringAlignment.Center, Brushes.Red, L, T + 50, pw - 5, e)

            f = New Font("Calibri", 10, FontStyle.Bold Or FontStyle.Underline)

            DrawString("BILL", f, StringAlignment.Center, L + 300, T + 100, 40, e)

            f = New Font("Calibri", 10, FontStyle.Bold)
            DrawString("Bill No : ", f, StringAlignment.Near, L + 58, T + 120, 80, e)
            DrawString("Supplier Name : ", f, StringAlignment.Near, L + 10, T + 140, 100, e)
            DrawString("Date : ", f, StringAlignment.Near, L + 500, T + 120, 80, e)


            DrawLine(L, T + 180, L + pw, T + 180, e)
            DrawLine(L, T + 210, L + pw, T + 210, e)
            DrawLine(L, T + 450, L + pw, T + 450, e)

            'S.No
            DrawLine(L + 40, T + 180, L + 40, T + 450, e)
            ' Item Desc
            DrawLine(L + 300, T + 180, L + 300, T + 450, e)
            'Qty
            DrawLine(L + 380, T + 180, L + 380, T + 480, e)
            'Rate
            DrawLine(L + 480, T + 180, L + 480, T + 480, e)

            ' TOTAL

            DrawLine(L + 380, T + 480, L + pw, T + 480, e)


            ' Heading 
            f = New Font("Calibri", 10, FontStyle.Bold)

            DrawString("S.NO", f, StringAlignment.Center, L + 3, T + 190, 40, e)

            DrawString("Item Description", f, StringAlignment.Near, L + 110, T + 190, 150, e)
            r = New Rectangle(L + 110, T + 190, L + 150, 10)
            'e.Graphics.DrawRectangle(penLight, r)

            DrawString("QTY", f, StringAlignment.Near, L + 310, T + 190, 150, e)
            DrawString("Rate", f, StringAlignment.Far, L + 370, T + 190, 100, e)
            DrawString("Amount", f, StringAlignment.Far, L + 470, T + 190, 100, e)
            DrawString("  TOTAL ", f, StringAlignment.Near, L + 390, T + 460, 200, e)
            f = New Font("Calibri", 10, FontStyle.Bold)

            DrawString(" FOR KP COMPUTERS", f, StringAlignment.Near, L + 3, T + 460, 200, e)
            DrawString("Signature", f, StringAlignment.Near, L + 3, T + 560, 200, e)
            DrawString("PRASANTH K", f, StringAlignment.Near, L + 3, T + 580, 200, e)
            DrawString("Managing Director", f, StringAlignment.Near, L + 3, T + 600, 200, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Report")
        End Try

    End Sub


    Private Sub PrintContents(L As Integer, T As Integer, e As PrintPageEventArgs, purID As Long)
        Dim o As New PurchaseDAL

        Dim pid As Long
        Dim f As New Font("Calibri", 10, FontStyle.Regular)
        Dim so As New SupplierDAL
        Dim io As New ItemDAL
        Dim i As Integer = 1
        Dim tamt As Decimal
        Dim tp As Integer

        Try
            pid = purID
            o.read(pid)
            DrawString(o.pbo.BillNo, f, StringAlignment.Near, L + 120, T + 120, 40, e)
            DrawString(o.pbo.PurchaseDate.ToString("dd/MM/yyyy"), f, StringAlignment.Near, L + 540, T + 120, 100, e)
            'DrawString(Format(o.pbo.PurchaseDate, DateFormat.GeneralDate), f, StringAlignment.Near, L + 70, T + 120, 40, e)
            so.read(o.pbo.SupplierID)
            DrawString(so.sbo.Suppliername, f, StringAlignment.Near, L + 120, T + 140, 100, e)

            ' PURCHASE DETAILS 
            tp = T + 230
            f = New Font("calibri", 9, FontStyle.Regular)
            For Each dr In o.pbo.PurchaseDetail.Rows
                io.read(dr("itemID"))
                DrawString(i & ".", f, StringAlignment.Near, L + 5, tp, 150, e)

                DrawString(io.ibo.itemDesc, f, StringAlignment.Near, L + 110, tp, 150, e)
                DrawString(dr("QTY"), f, StringAlignment.Near, L + 310, tp, 65, e)
                DrawString(dr("Rate"), f, StringAlignment.Far, L + 370, tp, 100, e)
                DrawString(dr("Amount"), f, StringAlignment.Far, L + 470, tp, 100, e)

                i += 1
                tp += 20
                tamt += dr("Amount")
            Next
            DrawString(tamt, f, StringAlignment.Far, L + 470, T + 460, 100, e)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Report")
        End Try

    End Sub
    Private Sub DrawLine(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, e As PrintPageEventArgs)

        Dim PenLight As New Pen(Color.FromArgb(0.5 * 255, 0, 0, 0), 2)
        Dim pt1, pt2 As Point

        pt1.X = x1
        pt1.Y = y1
        pt2.X = x2
        pt2.Y = y2

        e.Graphics.DrawLine(PenLight, pt1, pt2)

    End Sub

    Private Sub DrawString(s As String, f As Font, sa As StringAlignment, L As Integer, T As Integer, w As Integer, e As PrintPageEventArgs)
        Dim r As Rectangle
        Dim sf As New StringFormat
        sf.Alignment = sa
        Dim strSize As SizeF
        Dim b As Brush

        b = Brushes.Black
        strSize = e.Graphics.MeasureString(s, f, w, sf)
        r = New Rectangle(L, T, w, strSize.Height)
        e.Graphics.DrawString(s, f, b, r, sf)
    End Sub

    Private Sub DrawString(s As String, f As Font, sa As StringAlignment, bh As Brush, L As Integer, T As Integer, w As Integer, e As PrintPageEventArgs)
        Dim r As Rectangle
        Dim sf As New StringFormat
        sf.Alignment = sa
        Dim strSize As SizeF
        Dim b As Brush

        b = bh
        strSize = e.Graphics.MeasureString(s, f, w, sf)
        r = New Rectangle(L, T, w, strSize.Height)
        e.Graphics.DrawString(s, f, b, r, sf)
    End Sub

    Private Sub rdSingleReport_CheckedChanged(sender As Object, e As EventArgs) Handles rdSingleReport.CheckedChanged
        lblCopies.Visible = True
        nuCopies.Visible = True
        lblPurchase.Visible = True
        cbBillNo.Visible = True


    End Sub

    Private Sub rdAllreport_CheckedChanged(sender As Object, e As EventArgs) Handles rdAllreport.CheckedChanged
        lblCopies.Visible = False
        nuCopies.Visible = False
        lblPurchase.Visible = False
        cbBillNo.Visible = False
    End Sub

    Private Sub PurchaseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable

        Dim o As New PurchaseDAL

        Try
            dt = o.list()
            cbBillNo.DataSource = dt
            cbBillNo.DisplayMember = "BillNO"
            cbBillNo.ValueMember = "PurchaseID"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Purchase Report")
        End Try

    End Sub
End Class