<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestingDALS
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSupplierID = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgSupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(57, 81)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(123, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(195, 81)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(108, 23)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Supplier ID "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbSupplierID
        '
        Me.tbSupplierID.Location = New System.Drawing.Point(195, 36)
        Me.tbSupplierID.Name = "tbSupplierID"
        Me.tbSupplierID.Size = New System.Drawing.Size(197, 23)
        Me.tbSupplierID.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblResult.Location = New System.Drawing.Point(49, 117)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(271, 121)
        Me.lblResult.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgSupplierName, Me.dgContact})
        Me.DataGridView1.Location = New System.Drawing.Point(107, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(442, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'dgSupplierName
        '
        Me.dgSupplierName.DataPropertyName = "Supplier Name"
        Me.dgSupplierName.HeaderText = "Supplier Name "
        Me.dgSupplierName.Name = "dgSupplierName"
        Me.dgSupplierName.Width = 200
        '
        'dgContact
        '
        Me.dgContact.DataPropertyName = "Contact Number"
        Me.dgContact.HeaderText = "Contact Number"
        Me.dgContact.Name = "dgContact"
        Me.dgContact.Width = 200
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(453, 81)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(326, 81)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(108, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 450)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.tbSupplierID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "FrmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSupplier"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSupplierID As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents dgSupplierName As DataGridViewTextBoxColumn
    Friend WithEvents dgContact As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
End Class
