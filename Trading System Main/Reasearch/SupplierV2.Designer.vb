<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierV2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierV2))
        Me.tbSupNum = New System.Windows.Forms.TextBox()
        Me.tbSupPlace = New System.Windows.Forms.TextBox()
        Me.tbSupName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Crud = New Trading_System_Main.Trading_Common_Controls()
        Me.SuspendLayout()
        '
        'tbSupNum
        '
        Me.tbSupNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSupNum.Enabled = False
        Me.tbSupNum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbSupNum.Location = New System.Drawing.Point(184, 95)
        Me.tbSupNum.Name = "tbSupNum"
        Me.tbSupNum.Size = New System.Drawing.Size(190, 23)
        Me.tbSupNum.TabIndex = 11
        '
        'tbSupPlace
        '
        Me.tbSupPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSupPlace.Enabled = False
        Me.tbSupPlace.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbSupPlace.Location = New System.Drawing.Point(184, 55)
        Me.tbSupPlace.Name = "tbSupPlace"
        Me.tbSupPlace.Size = New System.Drawing.Size(190, 23)
        Me.tbSupPlace.TabIndex = 10
        '
        'tbSupName
        '
        Me.tbSupName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSupName.Enabled = False
        Me.tbSupName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbSupName.Location = New System.Drawing.Point(184, 12)
        Me.tbSupName.Name = "tbSupName"
        Me.tbSupName.Size = New System.Drawing.Size(190, 23)
        Me.tbSupName.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Contact Number"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Place"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Supplier Name"
        '
        'Crud
        '
        'Me.Crud.CurRec = CType(-1, Long)
        Me.Crud.Location = New System.Drawing.Point(44, 140)
        Me.Crud.Name = "Crud"
        Me.Crud.Size = New System.Drawing.Size(330, 64)
        Me.Crud.TabIndex = 12
        '
        'SupplierV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 283)
        Me.Controls.Add(Me.Crud)
        Me.Controls.Add(Me.tbSupNum)
        Me.Controls.Add(Me.tbSupPlace)
        Me.Controls.Add(Me.tbSupName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SupplierV2"
        Me.Text = "SupplierV2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbSupNum As TextBox
    Friend WithEvents tbSupPlace As TextBox
    Friend WithEvents tbSupName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Crud As Trading_Common_Controls
End Class
