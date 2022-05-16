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
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Int32)("idEmpleado")
            lblID.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("primerNombre")
            lblNombres.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("segundoNombre")
            lblNombres.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("primerApellido")
            lblApellidos.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("segundoApellido")
            lblApellidos.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Boolean)("sexo")
            lblSexo.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("cedula")
            lblCedula.Text = val

        End If

        'If cb.SelectedIndex >= 0 Then
        'Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("departamento")
        'lblDepartamento.Text = val

        ' End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Int32)("idCargo")
            lblCargo.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("emailCorporativo")
            lblEmailCorp.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("emailPersonal")
            lblEmailPer.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Date)("fechaNac")
            lblFechaNac.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Date)("fechaIngreso")
            lblFechaIng.Text = val

        End If

        'If cb.SelectedIndex >= 0 Then
        'Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Int32)("estadoActividad")
        'lblActividad.Text = val

        'End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("telefono")
            lblTelefono.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("observacion")
            rtxtObservacion.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("direccion")
            rtxtDireccion.Text = val

        End If
    End Sub
End Class