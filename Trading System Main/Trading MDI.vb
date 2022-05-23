Public Class Trading_MDI
    Private Sub DBConnectAppSettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBConnectAppSettingToolStripMenuItem.Click
        Dim o As Trading_BO.SqlServer
        Dim query As String
        Dim dtable As New DataTable
        Try
            o = New Trading_BO.SqlServer
            query = "Select * from items"
            MessageBox.Show("My Name : " & My.Settings.Myname)
            MessageBox.Show(Configuration.ConfigurationManager.AppSettings("Connectionstring"))
            dtable = o.GetDataTable(query)
            MessageBox.Show(" Data Base Connected Sucessfully", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Visual Studio Execption")
        End Try

    End Sub

    Private Sub ReasearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReasearchToolStripMenuItem.Click

    End Sub

    Private Sub DBDataListViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBDataListViewToolStripMenuItem.Click
        Dim frm As New DataListView
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DBDataGridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBDataGridViewToolStripMenuItem.Click
        Dim frm As New DataGridView
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized

        frm.Show()

    End Sub

    Private Sub DBItemComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBItemComboBoxToolStripMenuItem.Click
        Dim frm As New ComboItemDB
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized

        frm.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim frm As New frmSupplierNavigatefind
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem.Click
        Dim frm As New frmItems
        frm.MdiParent = Me
        ' frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim frm As New frmCustomer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub OpeningStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpeningStockToolStripMenuItem.Click
        Dim frm As New StockTxn
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Dim frm As New frmUsers
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()

    End Sub

    Private Sub ADOObjectTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADOObjectTestToolStripMenuItem.Click
        Dim frm As New LoopingADOobjects
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub UserControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserControlToolStripMenuItem.Click
        Dim frm As New SupplierV2
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Dim frm As New SalesEntry
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        Dim frm As New PurchaseEntry
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub Trading_MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim frm As New Login
        ''frm.MdiParent = Me
        'frm.StartPosition = FormStartPosition.CenterScreen
        'frm.ShowDialog()

        'If frm.DialogResult = DialogResult.OK Then
        '    MenuActions(True)
        'Else
        '    MenuActions(False)
        'End If

    End Sub


    Private Sub MenuActions(ByVal enabled As Boolean)
        MenuStrip1.Enabled = enabled


    End Sub

    Private Sub PrintDocsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintDocsToolStripMenuItem.Click
        Dim frm As New MYPrintDocument
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem1.Click
        Dim frm As New MYPrintDocument
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem1.Click
        Dim frm As New PurchaseReport
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub


End Class