<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierNavigatefind
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbSupName = New System.Windows.Forms.TextBox()
        Me.tbSupPlace = New System.Windows.Forms.TextBox()
        Me.tbSupNum = New System.Windows.Forms.TextBox()
        Me.lfirst = New System.Windows.Forms.LinkLabel()
        Me.lnext = New System.Windows.Forms.LinkLabel()
        Me.lprevious = New System.Windows.Forms.LinkLabel()
        Me.llast = New System.Windows.Forms.LinkLabel()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.lfind = New System.Windows.Forms.LinkLabel()
        Me.lgoTo = New System.Windows.Forms.LinkLabel()
        Me.tbGoTo = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(73, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(73, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Place"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(73, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact Number"
        '
        'tbSupName
        '
        Me.tbSupName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSupName.Enabled = False
        Me.tbSupName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbSupName.Location = New System.Drawing.Point(239, 40)
        Me.tbSupName.Name = "tbSupName"
        Me.tbSupName.Size = New System.Drawing.Size(190, 23)
        Me.tbSupName.TabIndex = 3
        '
        'tbSupPlace
        '
        Me.tbSupPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSupPlace.Enabled = False
        Me.tbSupPlace.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbSupPlace.Location = New System.Drawing.Point(239, 83)
        Me.tbSupPlace.Name = "tbSupPlace"
        Me.tbSupPlace.Size = New System.Drawing.Size(190, 23)
        Me.tbSupPlace.TabIndex = 4
        '
        'tbSupNum
        '
        Me.tbSupNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSupNum.Enabled = False
        Me.tbSupNum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbSupNum.Location = New System.Drawing.Point(239, 123)
        Me.tbSupNum.Name = "tbSupNum"
        Me.tbSupNum.Size = New System.Drawing.Size(190, 23)
        Me.tbSupNum.TabIndex = 5
        '
        'lfirst
        '
        Me.lfirst.Location = New System.Drawing.Point(180, 164)
        Me.lfirst.Name = "lfirst"
        Me.lfirst.Size = New System.Drawing.Size(27, 19)
        Me.lfirst.TabIndex = 6
        Me.lfirst.TabStop = True
        Me.lfirst.Text = "<<"
        '
        'lnext
        '
        Me.lnext.Location = New System.Drawing.Point(362, 164)
        Me.lnext.Name = "lnext"
        Me.lnext.Size = New System.Drawing.Size(20, 19)
        Me.lnext.TabIndex = 7
        Me.lnext.TabStop = True
        Me.lnext.Text = ">"
        '
        'lprevious
        '
        Me.lprevious.Location = New System.Drawing.Point(213, 164)
        Me.lprevious.Name = "lprevious"
        Me.lprevious.Size = New System.Drawing.Size(28, 19)
        Me.lprevious.TabIndex = 8
        Me.lprevious.TabStop = True
        Me.lprevious.Text = "<"
        '
        'llast
        '
        Me.llast.Location = New System.Drawing.Point(388, 164)
        Me.llast.Name = "llast"
        Me.llast.Size = New System.Drawing.Size(27, 19)
        Me.llast.TabIndex = 9
        Me.llast.TabStop = True
        Me.llast.Text = ">>"
        '
        'lblRecord
        '
        Me.lblRecord.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblRecord.Location = New System.Drawing.Point(247, 164)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(102, 19)
        Me.lblRecord.TabIndex = 10
        Me.lblRecord.Text = "1/10"
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lfind
        '
        Me.lfind.Location = New System.Drawing.Point(517, 164)
        Me.lfind.Name = "lfind"
        Me.lfind.Size = New System.Drawing.Size(34, 19)
        Me.lfind.TabIndex = 11
        Me.lfind.TabStop = True
        Me.lfind.Text = "Find"
        Me.lfind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lgoTo
        '
        Me.lgoTo.Location = New System.Drawing.Point(468, 164)
        Me.lgoTo.Name = "lgoTo"
        Me.lgoTo.Size = New System.Drawing.Size(55, 19)
        Me.lgoTo.TabIndex = 12
        Me.lgoTo.TabStop = True
        Me.lgoTo.Text = "GoTo"
        Me.lgoTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbGoTo
        '
        Me.tbGoTo.Location = New System.Drawing.Point(421, 164)
        Me.tbGoTo.Name = "tbGoTo"
        Me.tbGoTo.Size = New System.Drawing.Size(28, 23)
        Me.tbGoTo.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(239, 208)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(485, 39)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(485, 83)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 16
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(320, 208)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(485, 123)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmSupplierNavigatefind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 271)
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
        Me.Controls.Add(Me.tbSupNum)
        Me.Controls.Add(Me.tbSupPlace)
        Me.Controls.Add(Me.tbSupName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSupplierNavigatefind"
        Me.Text = "frmSupplierNavigatefind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSupName As TextBox
    Friend WithEvents tbSupPlace As TextBox
    Friend WithEvents tbSupNum As TextBox
    Friend WithEvents lfirst As LinkLabel
    Friend WithEvents lnext As LinkLabel
    Friend WithEvents lprevious As LinkLabel
    Friend WithEvents llast As LinkLabel
    Friend WithEvents lblRecord As Label
    Friend WithEvents lfind As LinkLabel
    Friend WithEvents lgoTo As LinkLabel
    Friend WithEvents tbGoTo As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
End Class
