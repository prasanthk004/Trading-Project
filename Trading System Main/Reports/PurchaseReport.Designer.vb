<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseReport))
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chContents = New System.Windows.Forms.CheckBox()
        Me.chLayout = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdSingleReport = New System.Windows.Forms.RadioButton()
        Me.rdAllreport = New System.Windows.Forms.RadioButton()
        Me.lblCopies = New System.Windows.Forms.Label()
        Me.nuCopies = New System.Windows.Forms.NumericUpDown()
        Me.lblPurchase = New System.Windows.Forms.Label()
        Me.cbBillNo = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nuCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(154, 288)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(146, 23)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(111, 382)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 44)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Print Purchase Report"
        '
        'chContents
        '
        Me.chContents.AutoSize = True
        Me.chContents.Checked = True
        Me.chContents.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chContents.Location = New System.Drawing.Point(38, 62)
        Me.chContents.Name = "chContents"
        Me.chContents.Size = New System.Drawing.Size(102, 19)
        Me.chContents.TabIndex = 3
        Me.chContents.Text = "Print Contents"
        Me.chContents.UseVisualStyleBackColor = True
        '
        'chLayout
        '
        Me.chLayout.AutoSize = True
        Me.chLayout.Checked = True
        Me.chLayout.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chLayout.Location = New System.Drawing.Point(38, 22)
        Me.chLayout.Name = "chLayout"
        Me.chLayout.Size = New System.Drawing.Size(90, 19)
        Me.chLayout.TabIndex = 4
        Me.chLayout.Text = "Print Layout"
        Me.chLayout.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chLayout)
        Me.GroupBox1.Controls.Add(Me.chContents)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 106)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print Options"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdSingleReport)
        Me.GroupBox2.Controls.Add(Me.rdAllreport)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 113)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Print Options"
        '
        'rdSingleReport
        '
        Me.rdSingleReport.AutoSize = True
        Me.rdSingleReport.Checked = True
        Me.rdSingleReport.Location = New System.Drawing.Point(29, 22)
        Me.rdSingleReport.Name = "rdSingleReport"
        Me.rdSingleReport.Size = New System.Drawing.Size(95, 19)
        Me.rdSingleReport.TabIndex = 1
        Me.rdSingleReport.TabStop = True
        Me.rdSingleReport.Text = "Single Report"
        Me.rdSingleReport.UseVisualStyleBackColor = True
        '
        'rdAllreport
        '
        Me.rdAllreport.AutoSize = True
        Me.rdAllreport.Location = New System.Drawing.Point(29, 62)
        Me.rdAllreport.Name = "rdAllreport"
        Me.rdAllreport.Size = New System.Drawing.Size(105, 19)
        Me.rdAllreport.TabIndex = 0
        Me.rdAllreport.Text = "Print All Report"
        Me.rdAllreport.UseVisualStyleBackColor = True
        '
        'lblCopies
        '
        Me.lblCopies.AutoSize = True
        Me.lblCopies.Location = New System.Drawing.Point(154, 225)
        Me.lblCopies.Name = "lblCopies"
        Me.lblCopies.Size = New System.Drawing.Size(76, 15)
        Me.lblCopies.TabIndex = 7
        Me.lblCopies.Text = "No of Copies"
        '
        'nuCopies
        '
        Me.nuCopies.Location = New System.Drawing.Point(252, 223)
        Me.nuCopies.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nuCopies.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuCopies.Name = "nuCopies"
        Me.nuCopies.Size = New System.Drawing.Size(48, 23)
        Me.nuCopies.TabIndex = 8
        Me.nuCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblPurchase
        '
        Me.lblPurchase.AutoSize = True
        Me.lblPurchase.Location = New System.Drawing.Point(314, 225)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(42, 15)
        Me.lblPurchase.TabIndex = 9
        Me.lblPurchase.Text = "Bill No"
        '
        'cbBillNo
        '
        Me.cbBillNo.FormattingEnabled = True
        Me.cbBillNo.Location = New System.Drawing.Point(362, 222)
        Me.cbBillNo.Name = "cbBillNo"
        Me.cbBillNo.Size = New System.Drawing.Size(81, 23)
        Me.cbBillNo.TabIndex = 10
        '
        'PurchaseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 385)
        Me.Controls.Add(Me.cbBillNo)
        Me.Controls.Add(Me.lblPurchase)
        Me.Controls.Add(Me.nuCopies)
        Me.Controls.Add(Me.lblCopies)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPrint)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PurchaseReport"
        Me.Text = "PurchaseReport"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nuCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chContents As CheckBox
    Friend WithEvents chLayout As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdSingleReport As RadioButton
    Friend WithEvents rdAllreport As RadioButton
    Friend WithEvents lblCopies As Label
    Friend WithEvents nuCopies As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPurchase As Label
    Friend WithEvents cbBillNo As ComboBox
End Class
