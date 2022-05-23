Imports System.ComponentModel
Imports System.Drawing.Printing
Imports Trading_BO

Public Class MYPrintDocument


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.ShowDialog()
        curRec = 0
        dbCrec = 0
    End Sub

    Dim curRec As Integer = 0
    Dim dbCrec As Integer = 0
    Dim dt As New DataTable
    'Dim dr As DataRow
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim L, T As Integer
        Dim o As New SalesDAL

        Dim saleID As Long = 0

        Try

            If rdAll.Checked Then
                saleID = dt.Rows(dbCrec)("SalesID")
                L = e.MarginBounds.Left
                T = e.MarginBounds.Top
                If chkPrintLayout.Checked And chkPrintContents.Checked Then
                    PrintBill(e, L, T)
                    PrintContents(e, L, T, saleID)
                ElseIf chkPrintContents.Checked Then
                    PrintContents(e, L, T, saleID)
                ElseIf chkPrintLayout.Checked Then
                    PrintBill(e, L, T)
                End If
                If (dbCrec < dt.Rows.Count - 1) Then
                    e.HasMorePages = True

                    dbCrec += 1
                Else
                    e.HasMorePages = False
                    dbCrec = 0
                End If

            Else
                curRec += 1
                L = e.MarginBounds.Left
                T = e.MarginBounds.Top
                If chkPrintLayout.Checked And chkPrintContents.Checked Then
                    PrintBill(e, L, T)
                    PrintContents(e, L, T, tbSid.Text)
                ElseIf chkPrintContents.Checked Then
                    PrintContents(e, L, T, tbSid.Text)
                ElseIf chkPrintLayout.Checked Then
                    PrintBill(e, L, T)
                End If
                If (curRec < nuPage.Value) Then
                    e.HasMorePages = True
                Else
                    e.HasMorePages = False
                    curRec = 0
                End If
            End If




            Debug.Print(curRec)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Private Sub PrintBill(e As PrintPageEventArgs, ByVal Left As Integer, ByVal Top As Integer)


        ' Draw Rectangle margin
        Dim b As Brush
        b = Brushes.Black

        ' Rectangle 

        Dim penThik As New Pen(Color.FromArgb(0.5 * 255, 0, 0, 0), 3)
        Dim L, T As Integer
        Dim pw As Integer = 625
        Dim ph As Integer = 650
        L = Left
        T = Top
        Dim r As New Rectangle(L, T, pw, ph)
        e.Graphics.DrawRectangle(penThik, r)


        'Draw Line 

        Dim pt1, pt2 As Point
        pt1 = New Point(L, T + 50)
        pt2 = New Point(L + pw, T + 50)
        Dim penLight As New Pen(Color.FromArgb(0.5 * 255, 0, 0, 0), 2)
        e.Graphics.DrawLine(penLight, pt1, pt2)

        ' Heading Text 

        Dim f As New Font("Calibri", 12, FontStyle.Bold)
        Dim s As String = "KP COMPUTERS (P) LTD  "
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        Dim StrSize As SizeF
        StrSize = e.Graphics.MeasureString(s, f, pw, sf)
        r = New Rectangle(L, T + 5, pw, StrSize.Height)
        'e.Graphics.FillRectangle(Brushes.LightGray, r)
        e.Graphics.DrawString(s, f, Brushes.Blue, r, sf)
        e.Graphics.DrawImage(My.Resources.kp2, L + 20, T + 5, 65, 40)

        'Address Text 
        f = New Font("Calibri", 8, FontStyle.Regular)
        s = "Chengalpattu  - 603108 . "
        sf.Alignment = StringAlignment.Center
        StrSize = e.Graphics.MeasureString(s, f, pw, sf)
        r = New Rectangle(L - 10, T + 30, pw, StrSize.Height)
        e.Graphics.DrawString(s, f, b, r, sf)


        'BILL Text 
        f = New Font("Calibri", 10, FontStyle.Bold Or FontStyle.Underline)
        s = "BILL"
        sf.Alignment = StringAlignment.Center
        StrSize = e.Graphics.MeasureString(s, f, pw, sf)
        r = New Rectangle(L - 10, T + 60, pw, StrSize.Height)
        e.Graphics.DrawString(s, f, b, r, sf)

        'Bill NO 

        f = New Font("Callibri", 7, FontStyle.Regular)
        s = "Bill No :-  "
        sf.Alignment = StringAlignment.Near
        StrSize = e.Graphics.MeasureString(s, f, 200, sf)
        r = New Rectangle(L + 55, T + 100, StrSize.Width, StrSize.Height)
        e.Graphics.DrawString(s, f, b, r, sf)

        ' Date 

        f = New Font("Callibri", 7, FontStyle.Regular)
        s = "Date :-  "
        sf.Alignment = StringAlignment.Far
        StrSize = e.Graphics.MeasureString(s, f, 150, sf)
        r = New Rectangle(L + 480, T + 100, StrSize.Width, StrSize.Height)
        e.Graphics.DrawString(s, f, b, r, sf)


        'Customer name 

        f = New Font("Callibri", 7, FontStyle.Regular)
        s = "Customer Name :- "
        sf.Alignment = StringAlignment.Near
        StrSize = e.Graphics.MeasureString(s, f, 200, sf)
        r = New Rectangle(L + 10, T + 120, StrSize.Width, StrSize.Height)
        e.Graphics.DrawString(s, f, b, r, sf)

        ' Draw top line for Box 
        LineDraw(L, T + 150, L + pw, T + 150, e)
        ' Draw down line for Box 
        LineDraw(L, T + 180, L + pw, T + 180, e)
        ' Draw Bottom Line 
        LineDraw(L, T + 450, L + pw, T + 450, e)

        '------------------------------------------'
        ' Draw line for SN 
        LineDraw(L + 40, T + 150, L + 40, T + 450, e)
        ' Draw line for ItemDesc
        LineDraw(L + 300, T + 150, L + 300, T + 450, e)
        ' Draw line for Qty
        LineDraw(L + 380, T + 150, L + 380, T + 480, e)
        ' Draw line for Rate
        LineDraw(L + 480, T + 150, L + 480, T + 480, e)
        ' Draw line for Amount

        'TOTAL LINE
        LineDraw(L + 380, T + 480, L + pw, T + 480, e)

        'Heading S.no 
        f = New Font("Callibri", 7, FontStyle.Bold)

        StringDraw("S.NO", f, StringAlignment.Near, L + 2, T + 160, 50, e)
        ' Heading ItemDesc
        StringDraw("Item Description", f, StringAlignment.Near, L + 110, T + 160, L + 300, e)
        'Heading Qty 
        StringDraw("Qty", f, StringAlignment.Near, L + 310, T + 160, L + 380, e)
        'Heading Rate 
        StringDraw("Rate ", f, StringAlignment.Far, L + 360, T + 160, 100, e)
        'Heading Amount 
        StringDraw("Amount ", f, StringAlignment.Far, L + 480, T + 160, 100, e)
        'Total
        f = New Font("Callibri", 7, FontStyle.Bold)
        StringDraw("Total ", f, StringAlignment.Near, L + 450, T + 460, 100, e)
        ' For authority
        StringDraw("For   KP COMPUTERS ", f, StringAlignment.Near, L + 10, T + 460, L + 480, e)
        'Signature
        StringDraw("Signature", f, StringAlignment.Near, L + 10, T + 580, L + 480, e)
        StringDraw("Prasanth K ", f, StringAlignment.Near, L + 10, T + 600, L + 480, e)
        StringDraw("Managing Director ", f, StringAlignment.Near, L + 10, T + 620, L + 480, e)





        'Print Contents 



    End Sub

    Private Sub PrintContents(e As PrintPageEventArgs, ByVal Left As Integer, ByVal Top As Integer, ByVal sid As Long)
        Dim L, T As Integer
        Dim pw As Integer = 625
        Dim ph As Integer = 650
        L = Left
        T = Top
        Dim o As SalesDAL
        Dim salesID As Long
        Dim r As Rectangle
        Dim fB As New Font("Calibri", 7, FontStyle.Bold)
        Dim fl As New Font("Calibri", 7, FontStyle.Regular)
        Dim p As New Pen(Brushes.LightGray)
        Dim cd As New CusDAL
        Dim sdr As DataRow
        Dim i As Integer = 0
        Dim tp As Integer
        Dim id As New ItemDAL
        Dim tamount As Decimal
        Try
            o = New SalesDAL()

            salesID = 30
            o.read(sid)
            'BILL NO
            r = New Rectangle(L + 90, T + 100, 40, 10)
            StringDraw(o.sabo.BillNo, fB, StringAlignment.Center, L + 90, T + 100, 40, e)
            ' e.Graphics.DrawRectangle(p, r)


            ' Date
            r = New Rectangle(L + 510, T + 100, 100, 10)
            StringDraw(o.sabo.SalesDate.ToString("dd/MM/yyyy"), fB, StringAlignment.Near, L + 510, T + 100, 100, e)
            ' e.Graphics.DrawRectangle(p, r)

            'Customer name 
            r = New Rectangle(L + 60, T + 120, 100, 10)
            cd.read(o.sabo.CustomerID)
            StringDraw(cd.cbo.CusName, fB, StringAlignment.Center, L + 65, T + 120, 100, e)

            'e.Graphics.DrawRectangle(p, r)

            tp = T + 190

            For Each sdr In o.sabo.SalesDetail.Rows
                i += 1
                ' S.No 

                StringDraw(i & ".", fl, StringAlignment.Center, L + 2, tp, 40, e)
                id.read(sdr("ItemID"))
                '  r = New Rectangle(L + 480, tp, 100, 20)
                StringDraw(id.ibo.itemDesc, fl, StringAlignment.Near, L + 110, tp, 260, e)
                StringDraw(sdr("Qty"), fl, StringAlignment.Near, L + 310, tp, 80, e)
                StringDraw(sdr("Rate"), fl, StringAlignment.Far, L + 360, tp, 100, e)
                StringDraw(sdr("Amount"), fl, StringAlignment.Far, L + 482, tp, 100, e)

                ' e.Graphics.DrawRectangle(p, r)
                tp += 20
                tamount += sdr("Amount")
            Next
            '  r = New Rectangle(L + 480, T + 460, 100, 20)
            StringDraw(tamount, fB, StringAlignment.Far, L + 482, T + 460, 100, e)

            'e.Graphics.DrawRectangle(p, r)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Report")
        End Try
    End Sub

    Private Sub StringDraw(ByVal s As String, f As Font, sa As StringAlignment, L As Integer, T As Integer, w As Integer, e As PrintPageEventArgs)
        Dim b As Brush
        Dim sf As New StringFormat
        Dim StrSize As SizeF
        b = Brushes.Black
        sf.Alignment = sa
        StrSize = e.Graphics.MeasureString(s, f, w, sf)
        Dim r As New Rectangle(L, T, w, StrSize.Height)

        e.Graphics.DrawString(s, f, b, r, sf)

    End Sub
    Private Sub LineDraw(ByVal x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, e As PrintPageEventArgs)
        Dim penLight As New Pen(Color.FromArgb(0.5 * 255, 0, 0, 0), 2)

        Dim pt1, pt2 As New Point
        pt1.X = x1
        pt1.Y = y1
        pt2.X = x2
        pt2.Y = y2

        e.Graphics.DrawLine(penLight, pt1, pt2)


    End Sub

    Private Sub PrintNames(e As PrintPageEventArgs)
        Dim f As Font
        Dim b As Brush = Brushes.DeepSkyBlue
        Dim s As String = " INDIA "
        Dim p As New Point(300, 80)
        ' e.Graphics.DrawString(s, f, b, p)

        e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.MarginBounds)
        f = New Font("Calibri", 45, FontStyle.Bold Or FontStyle.Underline)
        Dim bounds As Rectangle = e.MarginBounds
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        Dim strsize As SizeF = e.Graphics.MeasureString(s, f, p, sf)
        Dim Strheight As Integer = strsize.Height
        Dim ypos As Integer = (bounds.Height - Strheight) / 2
        Dim xpos As Long = bounds.Left
        Dim r As Rectangle = New Rectangle(xpos, ypos, bounds.Width, Strheight)
        e.Graphics.DrawString(s, f, b, r, sf)
        e.Graphics.DrawRectangle(New Pen(Brushes.LightGray), r)

        f = New Font("Arial", 18, FontStyle.Bold Or FontStyle.Underline)
        sf.Alignment = StringAlignment.Far
        s = "Virat Kohli"
        strsize = e.Graphics.MeasureString(s, f, p, sf)
        Strheight = strsize.Height
        ypos = bounds.Top
        xpos = bounds.Left
        r = New Rectangle(xpos, ypos + 2, bounds.Width, Strheight)
        e.Graphics.DrawString(s, f, Brushes.Red, r, sf)

        f = New Font("Callibri", 18, FontStyle.Bold)
        s = "Dhoni"
        sf.Alignment = StringAlignment.Near
        strsize = e.Graphics.MeasureString(s, f, p, sf)
        Strheight = strsize.Height
        xpos = bounds.Left
        ypos = bounds.Top + 2
        r = New Rectangle(xpos, ypos, bounds.Width, Strheight)
        e.Graphics.DrawString(s, f, Brushes.Green, r, sf)


        f = New Font("Callibri", 18, FontStyle.Bold)
        s = "Wordl Cup 2022"
        sf.Alignment = StringAlignment.Near
        strsize = e.Graphics.MeasureString(s, f, p, sf)
        Strheight = strsize.Height
        xpos = bounds.Left
        ypos = bounds.Bottom - 100
        r = New Rectangle(xpos, ypos, bounds.Width, Strheight)
        e.Graphics.DrawString(s, f, Brushes.DarkMagenta, r, sf)



        f = New Font("Callibri", 18, FontStyle.Bold)
        s = "All The Best "
        sf.Alignment = StringAlignment.Far
        strsize = e.Graphics.MeasureString(s, f, p, sf)
        Strheight = strsize.Height
        xpos = bounds.Left
        ypos = bounds.Bottom - 100
        r = New Rectangle(xpos, ypos, bounds.Width, Strheight)
        e.Graphics.DrawString(s, f, Brushes.Orange, r, sf)
    End Sub

    Private Sub MYPrintDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Button1.PerformClick()

        Dim o As New SalesDAL
        Try
            dt = o.list
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        chkPrintContents.Checked = True
        chkPrintLayout.Checked = True

    End Sub

    Private Sub btnDirect_Click(sender As Object, e As EventArgs) Handles btnDirect.Click
        'PrintDocument1.PrinterSettings.Copies = nuPage.Value 
        PrintDocument1.Print() ' Printing directly to printer

    End Sub



    Private Sub rdAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdAll.CheckedChanged
        If rdAll.Checked = True Then
            nuPage.Enabled = False
            Label3.Visible = False
            tbSid.Visible = False
        End If
    End Sub

    Private Sub rdSingle_CheckedChanged(sender As Object, e As EventArgs) Handles rdSingle.CheckedChanged
        If rdSingle.Checked = True Then
            nuPage.Enabled = True
            Label3.Visible = True
            tbSid.Visible = True
        End If
    End Sub

    Private Sub tbSid_TextChanged(sender As Object, e As EventArgs) Handles tbSid.TextChanged

    End Sub

    Private Sub tbSid_Validating(sender As Object, e As CancelEventArgs) Handles tbSid.Validating

        If (tbSid.Text = "") Then

            lblsts.ForeColor = Color.Red
            lblsts.Text = "Please enter sales ID  "
            e.Cancel = True
        End If
    End Sub
End Class