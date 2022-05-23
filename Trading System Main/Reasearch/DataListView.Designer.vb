<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataListView
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
        Me.lblQuery = New System.Windows.Forms.Label()
        Me.ListViewMain = New System.Windows.Forms.ListView()
        Me.chID = New System.Windows.Forms.ColumnHeader()
        Me.chDescription = New System.Windows.Forms.ColumnHeader()
        Me.chPrice = New System.Windows.Forms.ColumnHeader()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.tbQuery = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblQuery
        '
        Me.lblQuery.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblQuery.Location = New System.Drawing.Point(23, 20)
        Me.lblQuery.Name = "lblQuery"
        Me.lblQuery.Size = New System.Drawing.Size(114, 23)
        Me.lblQuery.TabIndex = 0
        Me.lblQuery.Text = "Query "
        '
        'ListViewMain
        '
        Me.ListViewMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chID, Me.chDescription, Me.chPrice})
        Me.ListViewMain.HideSelection = False
        Me.ListViewMain.Location = New System.Drawing.Point(12, 98)
        Me.ListViewMain.Name = "ListViewMain"
        Me.ListViewMain.Size = New System.Drawing.Size(601, 340)
        Me.ListViewMain.TabIndex = 1
        Me.ListViewMain.UseCompatibleStateImageBehavior = False
        Me.ListViewMain.View = System.Windows.Forms.View.Details
        '
        'chID
        '
        Me.chID.Text = "Item ID"
        '
        'chDescription
        '
        Me.chDescription.Text = "Item Description"
        Me.chDescription.Width = 200
        '
        'chPrice
        '
        Me.chPrice.Text = "Item Price"
        Me.chPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(342, 20)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 2
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'tbQuery
        '
        Me.tbQuery.Location = New System.Drawing.Point(99, 20)
        Me.tbQuery.Name = "tbQuery"
        Me.tbQuery.Size = New System.Drawing.Size(207, 23)
        Me.tbQuery.TabIndex = 3
        '
        'DataListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 450)
        Me.Controls.Add(Me.tbQuery)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.ListViewMain)
        Me.Controls.Add(Me.lblQuery)
        Me.Name = "DataListView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DataListView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuery As Label
    Friend WithEvents ListViewMain As ListView
    Friend WithEvents btnExecute As Button
    Friend WithEvents tbQuery As TextBox
    Friend WithEvents chID As ColumnHeader
    Friend WithEvents chDescription As ColumnHeader
    Friend WithEvents chPrice As ColumnHeader
End Class
