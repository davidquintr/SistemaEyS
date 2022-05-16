Public Class FrmAddEmpleado

    Dim emp As New BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter
    Dim dep As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim car As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter

    Sub llenarDep()

        cbDep.DataSource = dep.GetData()
        cbDep.DisplayMember = "nombre"
        cbDep.ValueMember = "idDepartamento"
        cbDep.Refresh()

    End Sub

    Sub llenarCar()

        cbCar.DataSource = car.GetData()
        cbCar.DisplayMember = "nombre"
        cbCar.ValueMember = "idCargo"
        cbCar.Refresh()

    End Sub


    Private Sub FrmAddEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDep()
        llenarCar()
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
        Dim car As String = cbCar.Text.Trim
        Dim emailCorporativo As String = txtEmailC.Text.Trim
        Dim emailPersonal As String = txtEmailP.Text.Trim
        Dim Telefono As String = txtTelefono.Text.Trim
        Dim sexo As Boolean = CBool(rbMasculino.Checked)
        Dim fechaIngreso As DateTime = DateTime.Now
        Dim fechaAgregado As DateTime = DateTime.Now
        Dim fechaNac As DateTime = DateTime.Now
        Dim observacion As String = rtxtObservacion.Text.Trim
        Dim direccion As String = rtxtDireccion.Text.Trim
        Dim idCar As Integer = CInt(cbCar.SelectedValue)

        emp.RegistroEmpAgreg(cedula, primerNom, segundoNom, primerApell, segundoApell, direccion, observacion, Telefono, emailPersonal, emailCorporativo, sexo, 1, 1, fechaNac, fechaIngreso, fechaAgregado, idCar)






        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        MessageBox.Show("Se desea dar de baja?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub
End Class