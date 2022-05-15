Public Class FrmAddEmpleado

    Dim emp As New BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter

    Private Sub FrmAddEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        MessageBox.Show("Si se ha introducido algun dato no seran guardados, seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim cedula As String = txtCedula.Text.Trim
        Dim primerNom As String = txtNombre.Text.Trim
        Dim segundoNom As String = txtNombre.Text.Trim
        Dim primerApell As String = txtApellidos.Text.Trim
        Dim segundoApell As String = txtApellidos.Text.Trim
        Dim car As Integer = CInt(cbCar.Text.Trim)
        Dim emailCorporativo As String = txtEmailC.Text.Trim
        Dim emailPersonal As String = txtEmailP.Text.Trim
        Dim Telefono As String = txtTelefono.Text.Trim
        Dim sexoM As Boolean = CBool(rbMasculino.Checked)
        Dim sexoF As Boolean = CBool(rbFemenino.Checked)
        Dim observacion As String = rtxtObservacion.Text.Trim
        Dim direccion As String = rtxtDireccion.Text.Trim






        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        MessageBox.Show("Se desea dar de baja?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub
End Class