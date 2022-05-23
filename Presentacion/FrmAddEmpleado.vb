Public Class FrmAddEmpleado

    Dim emp As New BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter
    Dim dep As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim car As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter

    Dim viewEmp As New BDSistemaEySDataSetTableAdapters.Vw_ListEmpTableAdapter
    Dim tblViewEmp As New BDSistemaEySDataSet.Vw_ListEmpDataTable

    Dim modo As Integer = 0
    Dim idEmp As Integer

    Public Sub CambiarModo(idEmp As Integer)
        modo = 1
        btnDarDeBaja.Visible = True
        GroupBox1.Text = "Administrar Empleado"
        Me.idEmp = idEmp
        OrdenarDatos()
    End Sub

    Private Sub OrdenarDatos()
        viewEmp.Fill(tblViewEmp)
        Try
            txtCedula.Text = tblViewEmp.Rows(idEmp).Item(4)
            txtNombre.Text = tblViewEmp.Rows(idEmp).Item(1)
            txtApellidos.Text = tblViewEmp.Rows(idEmp).Item(2)
            txtEmailC.Text = tblViewEmp.Rows(idEmp).Item(7)
            txtEmailP.Text = tblViewEmp.Rows(idEmp).Item(8)
            txtTelefono.Text = tblViewEmp.Rows(idEmp).Item(12)

            If tblViewEmp.Rows(idEmp).Item(13) Is Nothing Then
                rtxtObservacion.Text = ""
            Else
                rtxtObservacion.Text = tblViewEmp.Rows(idEmp).Item(13)
            End If



            rtxtDireccion.Text = tblViewEmp.Rows(idEmp).Item(14)

            If (tblViewEmp.Rows(idEmp).Item(3) = "Masculino") Then
                rbMasculino.Checked = True
                rbFemenino.Checked = False
            Else
                rbMasculino.Checked = False
                rbFemenino.Checked = True
            End If
        Catch
        End Try

    End Sub

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
        Dim fechaIngreso As DateTime = dtpFechaIngreso.Value.Date.ToString
        Dim fechaAgregado As DateTime = DateTime.Now
        Dim fechaNac As DateTime = dtpNac.Value.Date.ToString
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