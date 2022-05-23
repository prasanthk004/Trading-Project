<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseEntry))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNetAmt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.purchaseDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGpurchaseDetail = New System.Windows.Forms.DataGridView()
        Me.ItemName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purchaseCRUD = New Trading_System_Main.Trading_Common_Controls()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGpurchaseDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNetAmt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblBillNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.purchaseDateTime)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Entry"
        '
        'lblNetAmt
        '
        Me.lblNetAmt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNetAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblNetAmt.Location = New System.Drawing.Point(430, 93)
        Me.lblNetAmt.Name = "lblNetAmt"
        Me.lblNetAmt.Size = New System.Drawing.Size(100, 23)
        Me.lblNetAmt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(341, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Net Amount"
        '
        'cbSupplier
        '
        Me.cbSupplier.DisplayMember = "Supplier Name"
        Me.cbSupplier.Enabled = False
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.Location = New System.Drawing.Point(129, 90)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(200, 23)
        Me.cbSupplier.TabIndex = 5
        Me.cbSupplier.ValueMember = "Supplier ID"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Supplier Name"
        '
        'lblBillNo
        '
        Me.lblBillNo.Location = New System.Drawing.Point(430, 33)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(68, 23)
        Me.lblBillNo.TabIndex = 3
        Me.lblBillNo.Text = "(auto)"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(341, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bill No"
        '
        'purchaseDateTime
        '
        Me.purchaseDateTime.CustomFormat = "dd-MMM-yyyy"
        Me.purchaseDateTime.Enabled = False
        Me.purchaseDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.purchaseDateTime.Location = New System.Drawing.Point(129, 33)
        Me.purchaseDateTime.Name = "purchaseDateTime"
        Me.purchaseDateTime.Size = New System.Drawing.Size(200, 23)
        Me.purchaseDateTime.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Date"
        '
        'DGpurchaseDetail
        '
        Me.DGpurchaseDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpurchaseDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemName, Me.Qty, Me.Rate, Me.Amount})
        Me.DGpurchaseDetail.Location = New System.Drawing.Point(29, 152)
        Me.DGpurchaseDetail.Name = "DGpurchaseDetail"
        Me.DGpurchaseDetail.RowTemplate.Height = 25
        Me.DGpurchaseDetail.Size = New System.Drawing.Size(569, 183)
        Me.DGpurchaseDetail.TabIndex = 1
        '
        'ItemName
        '
        Me.ItemName.DataPropertyName = "ItemID"
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Width = 150
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 120
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "Rate"
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 125
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 130
        '
        'purchaseCRUD
        '
        Me.purchaseCRUD.CurRecord = CType(-1, Long)
        Me.purchaseCRUD.Location = New System.Drawing.Point(85, 341)
        Me.purchaseCRUD.Name = "purchaseCRUD"
        Me.purchaseCRUD.Size = New System.Drawing.Size(377, 64)
        Me.purchaseCRUD.TabIndex = 2
        '
        'PurchaseEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 422)
        Me.Controls.Add(Me.purchaseCRUD)
        Me.Controls.Add(Me.DGpurchaseDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PurchaseEntry"
        Me.Text = "PurchaseEntry"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGpurchaseDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents purchaseDateTime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBillNo As Label
    Friend WithEvents cbSupplier As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGpurchaseDetail As Windows.Forms.DataGridView
    Friend WithEvents purchaseCRUD As Trading_Common_Controls
    Friend WithEvents ItemName As DataGridViewComboBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents lblNetAmt As Label
    Friend WithEvents Label5 As Label
End Class
