Public Class FrmVistaAdmin
    Private Sub AñadirEntidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirEntidadToolStripMenuItem.Click
    End Sub

    Private Sub FrmVistaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

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
        Me.Close()
    End Sub
End Class