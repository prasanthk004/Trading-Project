<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbLoginID = New System.Windows.Forms.TextBox()
        Me.tbUserName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.LableLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(434, 117)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(261, 247)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(434, 77)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 54
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(434, 33)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 53
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(180, 247)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 52
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbGoTo
        '
        Me.tbGoTo.Location = New System.Drawing.Point(362, 203)
        Me.tbGoTo.Name = "tbGoTo"
        Me.tbGoTo.Size = New System.Drawing.Size(28, 23)
        Me.tbGoTo.TabIndex = 51
        '
        'lgoTo
        '
        Me.lgoTo.Location = New System.Drawing.Point(409, 203)
        Me.lgoTo.Name = "lgoTo"
        Me.lgoTo.Size = New System.Drawing.Size(55, 19)
        Me.lgoTo.TabIndex = 50
        Me.lgoTo.TabStop = True
        Me.lgoTo.Text = "GoTo"
        Me.lgoTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lfind
        '
        Me.lfind.Location = New System.Drawing.Point(458, 203)
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
        Me.lblRecord.Location = New System.Drawing.Point(188, 203)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(102, 19)
        Me.lblRecord.TabIndex = 48
        Me.lblRecord.Text = "1/10"
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llast
        '
        Me.llast.Location = New System.Drawing.Point(329, 203)
        Me.llast.Name = "llast"
        Me.llast.Size = New System.Drawing.Size(27, 19)
        Me.llast.TabIndex = 47
        Me.llast.TabStop = True
        Me.llast.Text = ">>"
        '
        'lprevious
        '
        Me.lprevious.Location = New System.Drawing.Point(154, 203)
        Me.lprevious.Name = "lprevious"
        Me.lprevious.Size = New System.Drawing.Size(28, 19)
        Me.lprevious.TabIndex = 46
        Me.lprevious.TabStop = True
        Me.lprevious.Text = "<"
        '
        'lnext
        '
        Me.lnext.Location = New System.Drawing.Point(303, 203)
        Me.lnext.Name = "lnext"
        Me.lnext.Size = New System.Drawing.Size(20, 19)
        Me.lnext.TabIndex = 45
        Me.lnext.TabStop = True
        Me.lnext.Text = ">"
        '
        'lfirst
        '
        Me.lfirst.Location = New System.Drawing.Point(121, 203)
        Me.lfirst.Name = "lfirst"
        Me.lfirst.Size = New System.Drawing.Size(27, 19)
        Me.lfirst.TabIndex = 44
        Me.lfirst.TabStop = True
        Me.lfirst.Text = "<<"
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbPassword.Location = New System.Drawing.Point(188, 117)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(190, 23)
        Me.tbPassword.TabIndex = 43
        Me.tbPassword.Visible = False
        '
        'tbLoginID
        '
        Me.tbLoginID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoginID.Enabled = False
        Me.tbLoginID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbLoginID.Location = New System.Drawing.Point(188, 77)
        Me.tbLoginID.Name = "tbLoginID"
        Me.tbLoginID.Size = New System.Drawing.Size(190, 23)
        Me.tbLoginID.TabIndex = 42
        '
        'tbUserName
        '
        Me.tbUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUserName.Enabled = False
        Me.tbUserName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbUserName.Location = New System.Drawing.Point(188, 34)
        Me.tbUserName.Name = "tbUserName"
        Me.tbUserName.Size = New System.Drawing.Size(190, 23)
        Me.tbUserName.TabIndex = 41
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(22, 117)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(100, 23)
        Me.lblPassword.TabIndex = 40
        Me.lblPassword.Text = "Password"
        Me.lblPassword.Visible = False
        '
        'LableLogin
        '
        Me.LableLogin.Location = New System.Drawing.Point(22, 77)
        Me.LableLogin.Name = "LableLogin"
        Me.LableLogin.Size = New System.Drawing.Size(100, 23)
        Me.LableLogin.TabIndex = 39
        Me.LableLogin.Text = "Login ID"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "User Name"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 289)
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
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbLoginID)
        Me.Controls.Add(Me.tbUserName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.LableLogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUsers"
        Me.Text = "frmUsers"
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
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbLoginID As TextBox
    Friend WithEvents tbUserName As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents LableLogin As Label
    Friend WithEvents Label1 As Label
End Class
