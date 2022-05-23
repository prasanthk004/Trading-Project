<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbGoTo = New System.Windows.Forms.TextBox()
        Me.lgoTo = New System.Windows.Forms.LinkLabel()
        Me.lfind = New System.Windows.Forms.LinkLabel()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.llast = New System.Windows.Forms.LinkLabel()
        Me.lprevious = New System.Windows.Forms.LinkLabel()
        Me.lnext = New System.Windows.Forms.LinkLabel()
        Me.lfirst = New System.Windows.Forms.LinkLabel()
        Me.tbSalesPrice = New System.Windows.Forms.TextBox()
        Me.tbItemName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(380, 96)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(251, 177)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(380, 56)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 32
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(380, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 31
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(170, 177)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbGoTo
        '
        Me.tbGoTo.Location = New System.Drawing.Point(371, 133)
        Me.tbGoTo.Name = "tbGoTo"
        Me.tbGoTo.Size = New System.Drawing.Size(28, 23)
        Me.tbGoTo.TabIndex = 29
        '
        'lgoTo
        '
        Me.lgoTo.Location = New System.Drawing.Point(418, 133)
        Me.lgoTo.Name = "lgoTo"
        Me.lgoTo.Size = New System.Drawing.Size(55, 19)
        Me.lgoTo.TabIndex = 28
        Me.lgoTo.TabStop = True
        Me.lgoTo.Text = "GoTo"
        Me.lgoTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lfind
        '
        Me.lfind.Location = New System.Drawing.Point(467, 133)
        Me.lfind.Name = "lfind"
        Me.lfind.Size = New System.Drawing.Size(34, 19)
        Me.lfind.TabIndex = 27
        Me.lfind.TabStop = True
        Me.lfind.Text = "Find"
        Me.lfind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecord
        '
        Me.lblRecord.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblRecord.Location = New System.Drawing.Point(197, 133)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(102, 19)
        Me.lblRecord.TabIndex = 26
        Me.lblRecord.Text = "1/10"
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llast
        '
        Me.llast.Location = New System.Drawing.Point(338, 133)
        Me.llast.Name = "llast"
        Me.llast.Size = New System.Drawing.Size(27, 19)
        Me.llast.TabIndex = 25
        Me.llast.TabStop = True
        Me.llast.Text = ">>"
        '
        'lprevious
        '
        Me.lprevious.Location = New System.Drawing.Point(163, 133)
        Me.lprevious.Name = "lprevious"
        Me.lprevious.Size = New System.Drawing.Size(28, 19)
        Me.lprevious.TabIndex = 24
        Me.lprevious.TabStop = True
        Me.lprevious.Text = "<"
        '
        'lnext
        '
        Me.lnext.Location = New System.Drawing.Point(312, 133)
        Me.lnext.Name = "lnext"
        Me.lnext.Size = New System.Drawing.Size(20, 19)
        Me.lnext.TabIndex = 23
        Me.lnext.TabStop = True
        Me.lnext.Text = ">"
        '
        'lfirst
        '
        Me.lfirst.Location = New System.Drawing.Point(130, 133)
        Me.lfirst.Name = "lfirst"
        Me.lfirst.Size = New System.Drawing.Size(27, 19)
        Me.lfirst.TabIndex = 22
        Me.lfirst.TabStop = True
        Me.lfirst.Text = "<<"
        '
        'tbSalesPrice
        '
        Me.tbSalesPrice.BackColor = System.Drawing.Color.Linen
        Me.tbSalesPrice.Enabled = False
        Me.tbSalesPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbSalesPrice.Location = New System.Drawing.Point(171, 58)
        Me.tbSalesPrice.Name = "tbSalesPrice"
        Me.tbSalesPrice.Size = New System.Drawing.Size(190, 23)
        Me.tbSalesPrice.TabIndex = 20
        '
        'tbItemName
        '
        Me.tbItemName.BackColor = System.Drawing.Color.Linen
        Me.tbItemName.Enabled = False
        Me.tbItemName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbItemName.Location = New System.Drawing.Point(171, 15)
        Me.tbItemName.Name = "tbItemName"
        Me.tbItemName.Size = New System.Drawing.Size(190, 23)
        Me.tbItemName.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(44, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Item Name "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(44, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Sales Price"
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 248)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbGoTo)
        Me.Controls.Add(Me.lgoTo)
        Me.Controls.Add(Me.lfind)
        Me.Controls.Add(Me.lblRecord)
        Me.Controls.Add(Me.llast)
        Me.Controls.Add(Me.lprevious)
        Me.Controls.Add(Me.lnext)
        Me.Controls.Add(Me.lfirst)
        Me.Controls.Add(Me.tbSalesPrice)
        Me.Controls.Add(Me.tbItemName)
        Me.Name = "frmItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmItems"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents tbGoTo As TextBox
    Friend WithEvents lgoTo As LinkLabel
    Friend WithEvents lfind As LinkLabel
    Friend WithEvents lblRecord As Label
    Friend WithEvents llast As LinkLabel
    Friend WithEvents lprevious As LinkLabel
    Friend WithEvents lnext As LinkLabel
    Friend WithEvents lfirst As LinkLabel
    Friend WithEvents tbSalesPrice As TextBox
    Friend WithEvents tbItemName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
