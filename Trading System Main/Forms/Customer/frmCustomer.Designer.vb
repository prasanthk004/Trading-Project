<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.tbNum = New System.Windows.Forms.TextBox()
        Me.tbCusPlace = New System.Windows.Forms.TextBox()
        Me.tbCusName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(450, 111)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 37
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(285, 196)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(450, 71)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 35
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(450, 27)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 34
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(204, 196)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 33
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbGoTo
        '
        Me.tbGoTo.Location = New System.Drawing.Point(386, 152)
        Me.tbGoTo.Name = "tbGoTo"
        Me.tbGoTo.Size = New System.Drawing.Size(28, 23)
        Me.tbGoTo.TabIndex = 32
        '
        'lgoTo
        '
        Me.lgoTo.Location = New System.Drawing.Point(433, 152)
        Me.lgoTo.Name = "lgoTo"
        Me.lgoTo.Size = New System.Drawing.Size(55, 19)
        Me.lgoTo.TabIndex = 31
        Me.lgoTo.TabStop = True
        Me.lgoTo.Text = "GoTo"
        Me.lgoTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lfind
        '
        Me.lfind.Location = New System.Drawing.Point(482, 152)
        Me.lfind.Name = "lfind"
        Me.lfind.Size = New System.Drawing.Size(34, 19)
        Me.lfind.TabIndex = 30
        Me.lfind.TabStop = True
        Me.lfind.Text = "Find"
        Me.lfind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecord
        '
        Me.lblRecord.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblRecord.Location = New System.Drawing.Point(212, 152)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(102, 19)
        Me.lblRecord.TabIndex = 29
        Me.lblRecord.Text = "1/10"
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llast
        '
        Me.llast.Location = New System.Drawing.Point(353, 152)
        Me.llast.Name = "llast"
        Me.llast.Size = New System.Drawing.Size(27, 19)
        Me.llast.TabIndex = 28
        Me.llast.TabStop = True
        Me.llast.Text = ">>"
        '
        'lprevious
        '
        Me.lprevious.Location = New System.Drawing.Point(178, 152)
        Me.lprevious.Name = "lprevious"
        Me.lprevious.Size = New System.Drawing.Size(28, 19)
        Me.lprevious.TabIndex = 27
        Me.lprevious.TabStop = True
        Me.lprevious.Text = "<"
        '
        'lnext
        '
        Me.lnext.Location = New System.Drawing.Point(327, 152)
        Me.lnext.Name = "lnext"
        Me.lnext.Size = New System.Drawing.Size(20, 19)
        Me.lnext.TabIndex = 26
        Me.lnext.TabStop = True
        Me.lnext.Text = ">"
        '
        'lfirst
        '
        Me.lfirst.Location = New System.Drawing.Point(145, 152)
        Me.lfirst.Name = "lfirst"
        Me.lfirst.Size = New System.Drawing.Size(27, 19)
        Me.lfirst.TabIndex = 25
        Me.lfirst.TabStop = True
        Me.lfirst.Text = "<<"
        '
        'tbNum
        '
        Me.tbNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNum.Enabled = False
        Me.tbNum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbNum.Location = New System.Drawing.Point(204, 111)
        Me.tbNum.Name = "tbNum"
        Me.tbNum.Size = New System.Drawing.Size(190, 23)
        Me.tbNum.TabIndex = 24
        '
        'tbCusPlace
        '
        Me.tbCusPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCusPlace.Enabled = False
        Me.tbCusPlace.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbCusPlace.Location = New System.Drawing.Point(204, 71)
        Me.tbCusPlace.Name = "tbCusPlace"
        Me.tbCusPlace.Size = New System.Drawing.Size(190, 23)
        Me.tbCusPlace.TabIndex = 23
        '
        'tbCusName
        '
        Me.tbCusName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCusName.Enabled = False
        Me.tbCusName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbCusName.Location = New System.Drawing.Point(204, 28)
        Me.tbCusName.Name = "tbCusName"
        Me.tbCusName.Size = New System.Drawing.Size(190, 23)
        Me.tbCusName.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(38, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Contact Number"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(38, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Place"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(38, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Customer Name"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 247)
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
        Me.Controls.Add(Me.tbNum)
        Me.Controls.Add(Me.tbCusPlace)
        Me.Controls.Add(Me.tbCusName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCustomer"
        Me.Text = "frmCustomer"
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
    Friend WithEvents tbNum As TextBox
    Friend WithEvents tbCusPlace As TextBox
    Friend WithEvents tbCusName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
