<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataGridView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbQuery = New System.Windows.Forms.TextBox()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.lblQuery = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dcItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcSalesPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbQuery
        '
        Me.tbQuery.Location = New System.Drawing.Point(118, 1)
        Me.tbQuery.Multiline = True
        Me.tbQuery.Name = "tbQuery"
        Me.tbQuery.Size = New System.Drawing.Size(453, 85)
        Me.tbQuery.TabIndex = 6
        '
        'btnExecute
        '
        Me.btnExecute.BackgroundImage = Global.Trading_System_Main.My.Resources.Resources.play_green
        Me.btnExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExecute.Image = Global.Trading_System_Main.My.Resources.Resources.play_green
        Me.btnExecute.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExecute.Location = New System.Drawing.Point(577, 12)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(120, 25)
        Me.btnExecute.TabIndex = 5
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnExecute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'lblQuery
        '
        Me.lblQuery.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblQuery.Image = Global.Trading_System_Main.My.Resources.Resources.play_green
        Me.lblQuery.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblQuery.Location = New System.Drawing.Point(-2, 22)
        Me.lblQuery.Name = "lblQuery"
        Me.lblQuery.Size = New System.Drawing.Size(114, 34)
        Me.lblQuery.TabIndex = 4
        Me.lblQuery.Text = "Query "
        Me.lblQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dcItemDesc, Me.dcSalesPrice})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(0, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(745, 348)
        Me.DataGridView1.TabIndex = 7
        '
        'dcItemDesc
        '
        Me.dcItemDesc.DataPropertyName = "Item Description"
        Me.dcItemDesc.HeaderText = "Item Description"
        Me.dcItemDesc.Name = "dcItemDesc"
        Me.dcItemDesc.Width = 200
        '
        'dcSalesPrice
        '
        Me.dcSalesPrice.DataPropertyName = "Sales Price"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow
        Me.dcSalesPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.dcSalesPrice.HeaderText = "Sales Price"
        Me.dcSalesPrice.Name = "dcSalesPrice"
        Me.dcSalesPrice.Width = 150
        '
        'DataGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 445)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tbQuery)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.lblQuery)
        Me.Name = "DataGridView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DataGridView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbQuery As TextBox
    Friend WithEvents btnExecute As Button
    Friend WithEvents lblQuery As Label
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents dcItemDesc As DataGridViewTextBoxColumn
    Friend WithEvents dcSalesPrice As DataGridViewTextBoxColumn
End Class
