Public Class FrmVistaAdmin
    Private Sub AñadirEntidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirEntidadToolStripMenuItem.Click
    End Sub

    Private Sub FrmVistaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VwVistaAdminBindingSource IsNot Nothing Then
            Me.Vw_VistaAdminTableAdapter.Fill(Me.BDSistemaEySDataSet.Vw_VistaAdmin)
        End If

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ParámetrosGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParámetrosGeneralesToolStripMenuItem.Click
        frmParametrosGen.Show()
    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        FrmAddDepartamento.Show()
    End Sub

    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click
        FrmAddCargo.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        FrmAddEmpleado.Show()
    End Sub

    Private Sub DepartamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem1.Click
        frmListarDept.Show()
    End Sub

    Private Sub CargoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem1.Click
        frmListarCargo.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        frmListarEmp.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim opcion As DialogResult = MessageBox.Show("Seguro que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem.Click
        frmAddRol.Show()
    End Sub

    Private Sub RolToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem1.Click
        frmListarRoles.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem1.Click
        frmAdminCredenciales.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem2.Click
        frmListarCredenciales.Show()
    End Sub
End Class