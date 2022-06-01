
Public Class FrmAddEmpleado
    Dim emp As New BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter
    Dim dep As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim car As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter

    Dim user As New BDSistemaEySDataSetTableAdapters.tbl_UsuarioTableAdapter

    Dim viewEmp As New BDSistemaEySDataSetTableAdapters.Vw_ListEmpTableAdapter
    Dim tblViewEmp As New BDSistemaEySDataSet.Vw_ListEmpDataTable

    Dim viewUser As New BDSistemaEySDataSetTableAdapters.Vw_UsuarioTableAdapter
    Dim tblViewUser As New BDSistemaEySDataSet.Vw_UsuarioDataTable

    Dim modo As Integer = 0
    Dim idEmp As Integer

    Dim fila As Integer


    Public Sub CambiarModo(idEmp As Integer)
        gbAll.Text = "Editar empleado"

        If cbUsuario.Items.Count < 1 Then
            cbUsuario.Enabled = False
        End If

        btnGuardarCamb.Enabled = True
        btnGuardar.Enabled = False
        btnDarDeBaja.Enabled = True
        Me.idEmp = idEmp
        OrdenarDatos()
    End Sub

    Sub llenarGrid()
        Try
            DgvEmpleado.DataSource = emp.GetData
            DgvEmpleado.Refresh()
            DgvEmpleado.Columns(0).Visible = False
        Catch ex As Exception

        End Try

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

    Sub llenarUser()
        cbUsuario.DataSource = viewUser.GetUsuariosDisp()
        cbUsuario.DisplayMember = "Username"
        cbUsuario.ValueMember = "ID"
        cbUsuario.Refresh()
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
        Limpiar()
        viewUser.Fill(tblViewUser)
        llenarDep()
        llenarCar()
        llenarUser()
        llenarGrid()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If (MessageBox.Show("¿Deseas cerrar? si hay cambios pendientes no se guardarán", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Me.Close()
        End If

    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        Try
            If (MessageBox.Show("¿Deseas eliminar el empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                emp.RegistroEmpElim(idEmp)
                llenarGrid()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub EnviarDatos(tipo As Integer)
        Dim idUser As Integer

        If (RealizaComprobaciones() = False) Then
            Return
        End If

        Tbl_UsuarioTableAdapter.GetUsuarioID(BDSistemaEySDataSet.tbl_Usuario, cbUsuario.Text)

        Try
            idUser = BDSistemaEySDataSet.tbl_Usuario.First.idUsuario
        Catch ex As Exception
            idUser = 5
        End Try

        Dim cedula As String = txtCedula.Text.Trim
        Dim Separador() As String
        Separador = txtNombre.Text.Split(" ")
        Dim primerNombre As String = Separador(0)
        Dim segundoNombre As String

        For i As Integer = 1 To Separador.Length - 1
            If (i <> Separador.Length - 1) Then
                segundoNombre += Separador(i) + " "
            Else
                segundoNombre += Separador(i)
            End If
        Next

        Separador = txtApellidos.Text.Split(" ")

        Dim primerApellido As String = Separador(0)
        Dim segundoApellido As String

        If Separador.Length > 1 Then
            segundoApellido = Separador(1)
        End If

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
        Dim idCar As Integer = cbCar.SelectedIndex + 1
        Dim id As Integer ' Y esto de donde salió??? XDDD

        Dim result As DialogResult = DialogResult.No

        If tipo = 0 And cbUsuario.Text <> String.Empty Then

            result = MessageBox.Show($"¿Deseas reasignar este usuario a {cbUsuario.Text}?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        End If


        If tipo = 1 Then
            emp.RegistroEmpAgreg(cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, direccion, observacion, Telefono, emailPersonal, emailCorporativo, sexo, 0, 1, fechaNac, fechaIngreso, fechaAgregado, idCar, idUser)
        Else
            If result = DialogResult.Yes Then
                emp.RegistroEmpAct(cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, direccion, observacion, Telefono, emailPersonal, emailCorporativo, sexo, 0, 2, fechaNac, fechaIngreso, fechaAgregado, idCar, idUser, idEmp, id)
            Else
                emp.RegistroEmpActSU(cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, direccion, observacion, Telefono, emailPersonal, emailCorporativo, sexo, 0, 1, fechaNac, fechaIngreso, fechaAgregado, idCar, idEmp, idEmp)
            End If
        End If
        MessageBox.Show("Se ha guardado exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        llenarUser()
        Limpiar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnGuardarCamb.Click
        If (MessageBox.Show("¿Deseas guardar los cambios?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            EnviarDatos(0)
        End If
        llenarGrid()
    End Sub

    Private Function RealizaComprobaciones() As Boolean

        If (txtCedula.Text = String.Empty) Then
            MessageBox.Show("La cédula no puede quedar vacía", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtNombre.Text = String.Empty) Then
            MessageBox.Show("El nombre no puede quedar vacío", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtApellidos.Text = String.Empty) Then
            MessageBox.Show("El apellido no puede quedar vacío", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtEmailP.Text = String.Empty) Then
            MessageBox.Show("El email personal no puede quedar vacío", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (dtpNac.Value.Date.ToString("d") = DateTime.Now.ToString("d")) Then
            MessageBox.Show("Cambie la fecha de Nacimiento", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub DgvEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles DgvEmpleado.DoubleClick
        Try

            If cbUsuario.Items.Count < 1 Then
                cbUsuario.Enabled = False
            End If

            gbAll.Text = "Editar empleado"
            btnGuardarCamb.Enabled = True
            btnGuardar.Enabled = False
            btnDarDeBaja.Enabled = True

            fila = DgvEmpleado.CurrentRow.Index

            idEmp = DgvEmpleado.Item(0, fila).Value
            txtCedula.Text = DgvEmpleado.Item(1, fila).Value
            txtNombre.Text = DgvEmpleado.Item(2, fila).Value
            txtNombre.Text += " " + DgvEmpleado.Item(3, fila).Value
            txtApellidos.Text = DgvEmpleado.Item(4, fila).Value
            txtApellidos.Text += " " + DgvEmpleado.Item(5, fila).Value
            rtxtDireccion.Text = DgvEmpleado.Item(6, fila).Value
            rtxtObservacion.Text = DgvEmpleado.Item(7, fila).Value
            txtTelefono.Text = DgvEmpleado.Item(8, fila).Value
            txtEmailP.Text = DgvEmpleado.Item(9, fila).Value
            txtEmailC.Text = DgvEmpleado.Item(10, fila).Value
            rbFemenino.Checked = DgvEmpleado.Item(11, fila).Value
            rbMasculino.Checked = DgvEmpleado.Item(11, fila).Value
            dtpNac.Value = DgvEmpleado.Item(14, fila).Value
            dtpFechaIngreso.Value = DgvEmpleado.Item(15, fila).Value
            btnGuardar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (MessageBox.Show("¿Deseas guardar el nuevo empleado?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            EnviarDatos(1)
        End If
    End Sub

    Private Sub gbAll_Enter(sender As Object, e As EventArgs) Handles gbAll.Enter

    End Sub

    Private Sub Limpiar()
        gbAll.Text = "Agregar empleado"
        btnGuardar.Enabled = True
        btnDarDeBaja.Enabled = False
        btnGuardarCamb.Enabled = False
        txtCedula.Text = ""
        txtNombre.Text = ""
        txtApellidos.Text = ""
        txtEmailC.Text = ""
        txtEmailP.Text = ""
        txtTelefono.Text = ""
        dtpFechaIngreso.Value = DateTime.Now
        dtpNac.Value = DateTime.Now
        rtxtDireccion.Text = ""
        rtxtObservacion.Text = ""
    End Sub
End Class