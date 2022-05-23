<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoopingADOobjects
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.btnColumns = New System.Windows.Forms.Button()
        Me.btnSumloop = New System.Windows.Forms.Button()
        Me.btnSumCompute = New System.Windows.Forms.Button()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DVfindItems = New System.Windows.Forms.Button()
        Me.SumDvLoop = New System.Windows.Forms.Button()
        Me.filterG100 = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(146, 167)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 25
        Me.DataGridView.Size = New System.Drawing.Size(432, 181)
        Me.DataGridView.TabIndex = 0
        '
        'btnColumns
        '
        Me.btnColumns.Location = New System.Drawing.Point(219, 40)
        Me.btnColumns.Name = "btnColumns"
        Me.btnColumns.Size = New System.Drawing.Size(75, 23)
        Me.btnColumns.TabIndex = 1
        Me.btnColumns.Text = "Columns"
        Me.btnColumns.UseVisualStyleBackColor = True
        '
        'btnSumloop
        '
        Me.btnSumloop.Location = New System.Drawing.Point(328, 40)
        Me.btnSumloop.Name = "btnSumloop"
        Me.btnSumloop.Size = New System.Drawing.Size(90, 23)
        Me.btnSumloop.TabIndex = 2
        Me.btnSumloop.Text = "Sum Looping"
        Me.btnSumloop.UseVisualStyleBackColor = True
        '
        'btnSumCompute
        '
        Me.btnSumCompute.Location = New System.Drawing.Point(457, 40)
        Me.btnSumCompute.Name = "btnSumCompute"
        Me.btnSumCompute.Size = New System.Drawing.Size(119, 23)
        Me.btnSumCompute.TabIndex = 3
        Me.btnSumCompute.Text = "Sum Compute"
        Me.btnSumCompute.UseVisualStyleBackColor = True
        '
        'btnFetch
        '
        Me.btnFetch.Location = New System.Drawing.Point(12, 40)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(75, 23)
        Me.btnFetch.TabIndex = 4
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data Table"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Data View"
        '
        'DVfindItems
        '
        Me.DVfindItems.Location = New System.Drawing.Point(457, 96)
        Me.DVfindItems.Name = "DVfindItems"
        Me.DVfindItems.Size = New System.Drawing.Size(119, 23)
        Me.DVfindItems.TabIndex = 8
        Me.DVfindItems.Text = "DV FInd Items"
        Me.DVfindItems.UseVisualStyleBackColor = True
        '
        'SumDvLoop
        '
        Me.SumDvLoop.Location = New System.Drawing.Point(328, 97)
        Me.SumDvLoop.Name = "SumDvLoop"
        Me.SumDvLoop.Size = New System.Drawing.Size(108, 23)
        Me.SumDvLoop.TabIndex = 7
        Me.SumDvLoop.Text = "Sum DV Looping"
        Me.SumDvLoop.UseVisualStyleBackColor = True
        '
        'filterG100
        '
        Me.filterG100.Location = New System.Drawing.Point(219, 96)
        Me.filterG100.Name = "filterG100"
        Me.filterG100.Size = New System.Drawing.Size(94, 23)
        Me.filterG100.TabIndex = 6
        Me.filterG100.Text = "Filter >100 RS"
        Me.filterG100.UseVisualStyleBackColor = True
        '
        'LoopingADOobjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 375)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DVfindItems)
        Me.Controls.Add(Me.SumDvLoop)
        Me.Controls.Add(Me.filterG100)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.btnSumCompute)
        Me.Controls.Add(Me.btnSumloop)
        Me.Controls.Add(Me.btnColumns)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "LoopingADOobjects"
        Me.Text = "LoopingADOobjects"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView As Windows.Forms.DataGridView
    Friend WithEvents btnColumns As Button
    Friend WithEvents btnSumloop As Button
    Friend WithEvents btnSumCompute As Button
    Friend WithEvents btnFetch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DVfindItems As Button
    Friend WithEvents SumDvLoop As Button
    Friend WithEvents filterG100 As Button
End Class
