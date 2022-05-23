<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesEntry))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNetAmt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBillno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCusName = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrudSales = New Trading_System_Main.Trading_Common_Controls()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbItem = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNetAmt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblBillno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbCusName)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Sales Entry"
        '
        'lblNetAmt
        '
        Me.lblNetAmt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNetAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblNetAmt.Location = New System.Drawing.Point(437, 68)
        Me.lblNetAmt.Name = "lblNetAmt"
        Me.lblNetAmt.Size = New System.Drawing.Size(109, 23)
        Me.lblNetAmt.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(336, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Net Amount"
        '
        'lblBillno
        '
        Me.lblBillno.Location = New System.Drawing.Point(459, 32)
        Me.lblBillno.Name = "lblBillno"
        Me.lblBillno.Size = New System.Drawing.Size(70, 23)
        Me.lblBillno.TabIndex = 22
        Me.lblBillno.Text = "(auto)"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(336, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "BillNo"
        '
        'cbCusName
        '
        Me.cbCusName.DisplayMember = "Customer Name"
        Me.cbCusName.Enabled = False
        Me.cbCusName.FormattingEnabled = True
        Me.cbCusName.Location = New System.Drawing.Point(130, 72)
        Me.cbCusName.Name = "cbCusName"
        Me.cbCusName.Size = New System.Drawing.Size(158, 23)
        Me.cbCusName.TabIndex = 19
        Me.cbCusName.ValueMember = "Customer ID"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.HighlightText
        Me.DateTimePicker.CustomFormat = ""
        Me.DateTimePicker.Enabled = False
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker.Location = New System.Drawing.Point(130, 32)
        Me.DateTimePicker.MaxDate = New Date(2600, 6, 1, 0, 0, 0, 0)
        Me.DateTimePicker.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(158, 23)
        Me.DateTimePicker.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Customer Name"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Sales Date"
        '
        'CrudSales
        '
        Me.CrudSales.CurRecord = CType(-1, Long)
        Me.CrudSales.Location = New System.Drawing.Point(118, 317)
        Me.CrudSales.Name = "CrudSales"
        Me.CrudSales.Size = New System.Drawing.Size(378, 64)
        Me.CrudSales.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cbItem, Me.qty, Me.rate, Me.Amount})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(563, 155)
        Me.DataGridView1.TabIndex = 2
        '
        'cbItem
        '
        Me.cbItem.DataPropertyName = "ItemID"
        Me.cbItem.HeaderText = "Item Name"
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Width = 150
        '
        'qty
        '
        Me.qty.DataPropertyName = "Qty"
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.Width = 120
        '
        'rate
        '
        Me.rate.DataPropertyName = "Rate"
        Me.rate.HeaderText = "Rate"
        Me.rate.Name = "rate"
        Me.rate.Width = 150
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'SalesEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 403)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CrudSales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SalesEntry"
        Me.Text = "Sales Entry"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblBillno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCusName As ComboBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CrudSales As Trading_Common_Controls
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents cbItem As DataGridViewComboBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents rate As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents lblNetAmt As Label
    Friend WithEvents Label5 As Label
End Class
