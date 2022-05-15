Public Class FrmAddCargo

    Dim carg As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter
    Private Sub FrmAddCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        MessageBox.Show("Si se ha introducido algun dato no seran guardados, seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nombre As String = txbNombre.Text.Trim
        Dim dep As Integer = cbDep.Text.Trim
        Dim desc As String = rtxtDesc.Text.Trim

        carg.RegistroCarAgreg(nombre, desc, 1, 2)

        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MessageBox.Show("Seguro que se desea eliminar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub
End Class