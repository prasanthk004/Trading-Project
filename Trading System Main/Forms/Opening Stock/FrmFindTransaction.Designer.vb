<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindTransaction
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Itemid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Refno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bookno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(662, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LIST OF TRANSACTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dat, Me.Itemid, Me.Qty, Me.Refno, Me.Bookno})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(660, 224)
        Me.DataGridView1.TabIndex = 2
        '
        'dat
        '
        Me.dat.DataPropertyName = "Date"
        Me.dat.HeaderText = "Date"
        Me.dat.Name = "dat"
        Me.dat.ReadOnly = True
        Me.dat.Width = 150
        '
        'Itemid
        '
        Me.Itemid.DataPropertyName = "Item ID"
        Me.Itemid.HeaderText = "Item ID"
        Me.Itemid.Name = "Itemid"
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'Refno
        '
        Me.Refno.DataPropertyName = "Ref No"
        Me.Refno.HeaderText = "Ref No"
        Me.Refno.Name = "Refno"
        Me.Refno.ReadOnly = True
        Me.Refno.Width = 120
        '
        'Bookno
        '
        Me.Bookno.DataPropertyName = "Book No"
        Me.Bookno.HeaderText = "Book No"
        Me.Bookno.Name = "Bookno"
        Me.Bookno.Width = 150
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(205, 289)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(325, 289)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmFindTransaction
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(662, 360)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFindTransaction"
        Me.Text = "FrmFindTransaction"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents dat As DataGridViewTextBoxColumn
    Friend WithEvents Itemid As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Refno As DataGridViewTextBoxColumn
    Friend WithEvents Bookno As DataGridViewTextBoxColumn
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
End Class
