<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MYPrintDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MYPrintDocument))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkPrintLayout = New System.Windows.Forms.CheckBox()
        Me.chkPrintContents = New System.Windows.Forms.CheckBox()
        Me.nuPage = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDirect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdAll = New System.Windows.Forms.RadioButton()
        Me.rdSingle = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbSid = New System.Windows.Forms.TextBox()
        Me.lblsts = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.nuPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(176, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print Preview"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 367)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 36)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Print Sales Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkPrintLayout
        '
        Me.chkPrintLayout.AutoSize = True
        Me.chkPrintLayout.Location = New System.Drawing.Point(198, 160)
        Me.chkPrintLayout.Name = "chkPrintLayout"
        Me.chkPrintLayout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPrintLayout.Size = New System.Drawing.Size(109, 19)
        Me.chkPrintLayout.TabIndex = 3
        Me.chkPrintLayout.Text = "Print Bill Layout"
        Me.chkPrintLayout.UseVisualStyleBackColor = True
        '
        'chkPrintContents
        '
        Me.chkPrintContents.AutoSize = True
        Me.chkPrintContents.Location = New System.Drawing.Point(198, 205)
        Me.chkPrintContents.Name = "chkPrintContents"
        Me.chkPrintContents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPrintContents.Size = New System.Drawing.Size(100, 19)
        Me.chkPrintContents.TabIndex = 4
        Me.chkPrintContents.Text = "Print contents"
        Me.chkPrintContents.UseVisualStyleBackColor = True
        '
        'nuPage
        '
        Me.nuPage.Location = New System.Drawing.Point(311, 258)
        Me.nuPage.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nuPage.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuPage.Name = "nuPage"
        Me.nuPage.Size = New System.Drawing.Size(59, 23)
        Me.nuPage.TabIndex = 5
        Me.nuPage.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(190, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No.Of.Copies"
        '
        'btnDirect
        '
        Me.btnDirect.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnDirect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDirect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnDirect.Location = New System.Drawing.Point(319, 322)
        Me.btnDirect.Name = "btnDirect"
        Me.btnDirect.Size = New System.Drawing.Size(122, 23)
        Me.btnDirect.TabIndex = 7
        Me.btnDirect.Text = "Direct Print"
        Me.btnDirect.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdAll)
        Me.GroupBox1.Controls.Add(Me.rdSingle)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 82)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reports"
        '
        'rdAll
        '
        Me.rdAll.AutoSize = True
        Me.rdAll.Location = New System.Drawing.Point(26, 49)
        Me.rdAll.Name = "rdAll"
        Me.rdAll.Size = New System.Drawing.Size(79, 19)
        Me.rdAll.TabIndex = 1
        Me.rdAll.Text = "All reports"
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'rdSingle
        '
        Me.rdSingle.AutoSize = True
        Me.rdSingle.Checked = True
        Me.rdSingle.Location = New System.Drawing.Point(26, 24)
        Me.rdSingle.Name = "rdSingle"
        Me.rdSingle.Size = New System.Drawing.Size(123, 19)
        Me.rdSingle.TabIndex = 0
        Me.rdSingle.TabStop = True
        Me.rdSingle.Text = "Print Single Report"
        Me.rdSingle.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(384, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sales ID"
        '
        'tbSid
        '
        Me.tbSid.Location = New System.Drawing.Point(439, 82)
        Me.tbSid.Name = "tbSid"
        Me.tbSid.Size = New System.Drawing.Size(69, 23)
        Me.tbSid.TabIndex = 10
        '
        'lblsts
        '
        Me.lblsts.AutoSize = True
        Me.lblsts.Location = New System.Drawing.Point(439, 115)
        Me.lblsts.Name = "lblsts"
        Me.lblsts.Size = New System.Drawing.Size(10, 15)
        Me.lblsts.TabIndex = 11
        Me.lblsts.Text = " "
        '
        'MYPrintDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 365)
        Me.Controls.Add(Me.lblsts)
        Me.Controls.Add(Me.tbSid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDirect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nuPage)
        Me.Controls.Add(Me.chkPrintContents)
        Me.Controls.Add(Me.chkPrintLayout)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MYPrintDocument"
        Me.Text = "PrintDocument"
        Me.Panel2.ResumeLayout(False)
        CType(Me.nuPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents chkPrintLayout As CheckBox
    Friend WithEvents chkPrintContents As CheckBox
    Friend WithEvents nuPage As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDirect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdAll As RadioButton
    Friend WithEvents rdSingle As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSid As TextBox
    Friend WithEvents lblsts As Label
End Class
