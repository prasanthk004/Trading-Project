<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trading_Common_Controls
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.tbGoTo = New System.Windows.Forms.TextBox()
        Me.lgoTo = New System.Windows.Forms.LinkLabel()
        Me.lfind = New System.Windows.Forms.LinkLabel()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.llast = New System.Windows.Forms.LinkLabel()
        Me.lprevious = New System.Windows.Forms.LinkLabel()
        Me.lnext = New System.Windows.Forms.LinkLabel()
        Me.lfirst = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(185, 38)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(97, 38)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 28
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(3, 38)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 27
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'tbGoTo
        '
        Me.tbGoTo.Location = New System.Drawing.Point(202, 7)
        Me.tbGoTo.Name = "tbGoTo"
        Me.tbGoTo.Size = New System.Drawing.Size(28, 23)
        Me.tbGoTo.TabIndex = 26
        '
        'lgoTo
        '
        Me.lgoTo.Location = New System.Drawing.Point(236, 9)
        Me.lgoTo.Name = "lgoTo"
        Me.lgoTo.Size = New System.Drawing.Size(42, 23)
        Me.lgoTo.TabIndex = 25
        Me.lgoTo.TabStop = True
        Me.lgoTo.Text = "GoTo"
        Me.lgoTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lfind
        '
        Me.lfind.Location = New System.Drawing.Point(284, 9)
        Me.lfind.Name = "lfind"
        Me.lfind.Size = New System.Drawing.Size(35, 23)
        Me.lfind.TabIndex = 24
        Me.lfind.TabStop = True
        Me.lfind.Text = "Find"
        Me.lfind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecord
        '
        Me.lblRecord.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblRecord.Location = New System.Drawing.Point(66, 11)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(60, 19)
        Me.lblRecord.TabIndex = 23
        Me.lblRecord.Text = "1/10"
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llast
        '
        Me.llast.Location = New System.Drawing.Point(169, 10)
        Me.llast.Name = "llast"
        Me.llast.Size = New System.Drawing.Size(27, 23)
        Me.llast.TabIndex = 22
        Me.llast.TabStop = True
        Me.llast.Text = ">>"
        '
        'lprevious
        '
        Me.lprevious.Location = New System.Drawing.Point(41, 12)
        Me.lprevious.Name = "lprevious"
        Me.lprevious.Size = New System.Drawing.Size(28, 23)
        Me.lprevious.TabIndex = 21
        Me.lprevious.TabStop = True
        Me.lprevious.Text = "<"
        '
        'lnext
        '
        Me.lnext.Location = New System.Drawing.Point(143, 10)
        Me.lnext.Name = "lnext"
        Me.lnext.Size = New System.Drawing.Size(20, 23)
        Me.lnext.TabIndex = 20
        Me.lnext.TabStop = True
        Me.lnext.Text = ">"
        '
        'lfirst
        '
        Me.lfirst.Location = New System.Drawing.Point(3, 12)
        Me.lfirst.Name = "lfirst"
        Me.lfirst.Size = New System.Drawing.Size(27, 23)
        Me.lfirst.TabIndex = 19
        Me.lfirst.TabStop = True
        Me.lfirst.Text = "<<"
        '
        'Trading_Common_Controls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.tbGoTo)
        Me.Controls.Add(Me.lgoTo)
        Me.Controls.Add(Me.lfind)
        Me.Controls.Add(Me.lblRecord)
        Me.Controls.Add(Me.llast)
        Me.Controls.Add(Me.lprevious)
        Me.Controls.Add(Me.lnext)
        Me.Controls.Add(Me.lfirst)
        Me.Name = "Trading_Common_Controls"
        Me.Size = New System.Drawing.Size(329, 64)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents tbGoTo As TextBox
    Friend WithEvents lgoTo As LinkLabel
    Friend WithEvents lfind As LinkLabel
    Friend WithEvents lblRecord As Label
    Friend WithEvents llast As LinkLabel
    Friend WithEvents lprevious As LinkLabel
    Friend WithEvents lnext As LinkLabel
    Friend WithEvents lfirst As LinkLabel
End Class
