Public Class frmListarEmp

    Dim emp As New BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter

    Sub llenarEmp()

        cbEmpleado.DataSource = emp.GetData()
        cbEmpleado.DisplayMember = "primerNombre"
        cbEmpleado.ValueMember = "idEmpleado"
        cbEmpleado.Refresh()
    End Sub
    Private Sub frmListarEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarEmp()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub cbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleado.SelectedIndexChanged
        Dim cb = DirectCast(sender, ComboBox)

        If cb.SelectedIndex >= 0 Then
            Dim empleado = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Int32)("idEmpleado")
            lblID.Text = empleado
            Dim nombre = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("primerNombre")
            lblNombres.Text = nombre
            Dim nombre2 = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("segundoNombre")
            lblNombres.Text = nombre2
            Dim apellido = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("primerApellido")
            lblApellidos.Text = apellido
            Dim apellido2 = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("segundoApellido")
            lblApellidos.Text = apellido2
            Dim sexo = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Boolean)("sexo")
            lblSexo.Text = sexo
            Dim cedula = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("cedula")
            lblCedula.Text = cedula
            Dim cargo = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Int32)("idCargo")
            lblCargo.Text = cargo
            Dim emailCorp = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("emailCorporativo")
            lblEmailCorp.Text = emailCorp
            Dim emailPer = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("emailPersonal")
            lblEmailPer.Text = emailPer
            Dim fechaNac = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Date)("fechaNac")
            lblFechaNac.Text = fechaNac
            Dim fechaIng = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Date)("fechaIngreso")
            lblFechaIng.Text = fechaIng
            Dim telefono = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("telefono")
            lblTelefono.Text = telefono
            Dim observacion = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("observacion")
            rtxtObservacion.Text = observacion
            Dim direccion = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("direccion")
            rtxtDireccion.Text = direccion
        End If
    End Sub
End Class