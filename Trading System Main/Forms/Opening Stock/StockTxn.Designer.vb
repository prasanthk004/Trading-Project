<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockTxn
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
        Me.tbQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dbDate = New System.Windows.Forms.DateTimePicker()
        Me.tbRefno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbBookNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbItemID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(444, 153)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(306, 318)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(444, 113)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 54
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(444, 69)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 53
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(225, 318)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 52
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbGoTo
        '
        Me.tbGoTo.Location = New System.Drawing.Point(407, 274)
        Me.tbGoTo.Name = "tbGoTo"
        Me.tbGoTo.Size = New System.Drawing.Size(28, 23)
        Me.tbGoTo.TabIndex = 51
        '
        'lgoTo
        '
        Me.lgoTo.Location = New System.Drawing.Point(454, 274)
        Me.lgoTo.Name = "lgoTo"
        Me.lgoTo.Size = New System.Drawing.Size(55, 19)
        Me.lgoTo.TabIndex = 50
        Me.lgoTo.TabStop = True
        Me.lgoTo.Text = "GoTo"
        Me.lgoTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lfind
        '
        Me.lfind.Location = New System.Drawing.Point(503, 274)
        Me.lfind.Name = "lfind"
        Me.lfind.Size = New System.Drawing.Size(34, 19)
        Me.lfind.TabIndex = 49
        Me.lfind.TabStop = True
        Me.lfind.Text = "Find"
        Me.lfind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecord
        '
        Me.lblRecord.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblRecord.Location = New System.Drawing.Point(233, 274)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(102, 19)
        Me.lblRecord.TabIndex = 48
        Me.lblRecord.Text = "1/10"
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llast
        '
        Me.llast.Location = New System.Drawing.Point(374, 274)
        Me.llast.Name = "llast"
        Me.llast.Size = New System.Drawing.Size(27, 19)
        Me.llast.TabIndex = 47
        Me.llast.TabStop = True
        Me.llast.Text = ">>"
        '
        'lprevious
        '
        Me.lprevious.Location = New System.Drawing.Point(199, 274)
        Me.lprevious.Name = "lprevious"
        Me.lprevious.Size = New System.Drawing.Size(28, 19)
        Me.lprevious.TabIndex = 46
        Me.lprevious.TabStop = True
        Me.lprevious.Text = "<"
        '
        'lnext
        '
        Me.lnext.Location = New System.Drawing.Point(348, 274)
        Me.lnext.Name = "lnext"
        Me.lnext.Size = New System.Drawing.Size(20, 19)
        Me.lnext.TabIndex = 45
        Me.lnext.TabStop = True
        Me.lnext.Text = ">"
        '
        'lfirst
        '
        Me.lfirst.Location = New System.Drawing.Point(166, 274)
        Me.lfirst.Name = "lfirst"
        Me.lfirst.Size = New System.Drawing.Size(27, 19)
        Me.lfirst.TabIndex = 44
        Me.lfirst.TabStop = True
        Me.lfirst.Text = "<<"
        '
        'tbQty
        '
        Me.tbQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbQty.Enabled = False
        Me.tbQty.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbQty.Location = New System.Drawing.Point(215, 109)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(190, 23)
        Me.tbQty.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(49, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Qty"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(49, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Item ID"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(49, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Transaction Date"
        '
        'dbDate
        '
        Me.dbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dbDate.Location = New System.Drawing.Point(215, 25)
        Me.dbDate.Name = "dbDate"
        Me.dbDate.Size = New System.Drawing.Size(190, 23)
        Me.dbDate.TabIndex = 57
        Me.dbDate.Value = New Date(2022, 1, 6, 0, 0, 0, 0)
        '
        'tbRefno
        '
        Me.tbRefno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRefno.Enabled = False
        Me.tbRefno.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbRefno.Location = New System.Drawing.Point(215, 149)
        Me.tbRefno.Name = "tbRefno"
        Me.tbRefno.Size = New System.Drawing.Size(190, 23)
        Me.tbRefno.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(49, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Reference No"
        '
        'tbBookNo
        '
        Me.tbBookNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbBookNo.Enabled = False
        Me.tbBookNo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbBookNo.Location = New System.Drawing.Point(215, 188)
        Me.tbBookNo.Name = "tbBookNo"
        Me.tbBookNo.Size = New System.Drawing.Size(190, 23)
        Me.tbBookNo.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(49, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Book No"
        '
        'tbItemID
        '
        Me.tbItemID.DisplayMember = "Item Description"
        Me.tbItemID.FormattingEnabled = True
        Me.tbItemID.Location = New System.Drawing.Point(214, 69)
        Me.tbItemID.Name = "tbItemID"
        Me.tbItemID.Size = New System.Drawing.Size(191, 23)
        Me.tbItemID.TabIndex = 62
        Me.tbItemID.ValueMember = "Item ID"
        '
        'StockTxn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 375)
        Me.Controls.Add(Me.tbItemID)
        Me.Controls.Add(Me.tbBookNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbRefno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dbDate)
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
        Me.Controls.Add(Me.tbQty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StockTxn"
        Me.Text = "Opening Stock"
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
    Friend WithEvents tbQty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dbDate As DateTimePicker
    Friend WithEvents tbRefno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbBookNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbItemID As ComboBox
End Class
