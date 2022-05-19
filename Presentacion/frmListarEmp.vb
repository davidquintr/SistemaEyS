Public Class frmListarEmp

    Dim emp As New BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter
    Dim tblEmp As New BDSistemaEySDataSet.tbl_EmpleadoDataTable
    Dim car As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter
    Dim tblCar As New BDSistemaEySDataSet.tbl_CargoDataTable
    Dim dep As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim tblDep As New BDSistemaEySDataSet.tbl_EmpleadoDataTable
    Dim fila As Integer = 0
    Dim cantEmp As Int32
    Dim id As Int32 = 0
    Dim tblMostar As New BindingSource

    Sub llenarEmp()

        cbEmpleado.DataSource = emp.GetData()
        cbEmpleado.DisplayMember = "primerNombre"
        cbEmpleado.ValueMember = "idEmpleado"
        cbEmpleado.Refresh()
    End Sub

    Private Sub frmListarEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarEmp()
        cantEmp = emp.GetData.Count()
        lbCantEmp.Text = (1 + id).ToString + " / " + cantEmp.ToString
        emp.Fill(tblEmp)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub cbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleado.SelectedIndexChanged

        Dim cb = DirectCast(sender, ComboBox)


        If cb.SelectedIndex >= 0 Then

            id = cb.SelectedIndex
            lbCantEmp.Text = (1 + id).ToString + " / " + cantEmp.ToString

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

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click

        Try
            fila += 1

            If fila <= tblEmp.Rows.Count Then

                lblID.Text = tblEmp.Rows(fila).Item(0).ToString
                lblNombres.Text = tblEmp.Rows(fila).Item(2).ToString
                lblApellidos.Text = tblEmp.Rows(fila).Item(4).ToString
                lblSexo.Text = tblEmp.Rows(fila).Item(11).ToString
                lblCedula.Text = tblEmp.Rows(fila).Item(1).ToString
                lblCargo.Text = tblEmp.Rows(fila).Item(17).ToString
                lblEmailCorp.Text = tblEmp.Rows(fila).Item(10).ToString
                lblEmailPer.Text = tblEmp.Rows(fila).Item(9).ToString
                lblFechaNac.Text = tblEmp.Rows(fila).Item(14).ToString
                lblFechaIng.Text = tblEmp.Rows(fila).Item(15).ToString
                lblTelefono.Text = tblEmp.Rows(fila).Item(8).ToString
                rtxtObservacion.Text = tblEmp.Rows(fila).Item(7).ToString
                rtxtDireccion.Text = tblEmp.Rows(fila).Item(6).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAnt_Click(sender As Object, e As EventArgs) Handles btnAnt.Click
        Try
            fila -= 1

            If fila <= tblEmp.Rows.Count Then

                lblID.Text = tblEmp.Rows(fila).Item(0).ToString
                lblNombres.Text = tblEmp.Rows(fila).Item(2).ToString
                lblApellidos.Text = tblEmp.Rows(fila).Item(4).ToString
                lblSexo.Text = tblEmp.Rows(fila).Item(11).ToString
                lblCedula.Text = tblEmp.Rows(fila).Item(1).ToString
                lblCargo.Text = tblEmp.Rows(fila).Item(17).ToString
                lblEmailCorp.Text = tblEmp.Rows(fila).Item(10).ToString
                lblEmailPer.Text = tblEmp.Rows(fila).Item(9).ToString
                lblFechaNac.Text = tblEmp.Rows(fila).Item(14).ToString
                lblFechaIng.Text = tblEmp.Rows(fila).Item(15).ToString
                lblTelefono.Text = tblEmp.Rows(fila).Item(8).ToString
                rtxtObservacion.Text = tblEmp.Rows(fila).Item(7).ToString
                rtxtDireccion.Text = tblEmp.Rows(fila).Item(6).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class