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
        car.Fill(tblCar)

        MostrarDatos()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click

        If (tblEmp Is Nothing) Then
            MsgBox("No hay datos")
            Return
        End If

        If (fila >= cantEmp - 1) Then
            Return
        End If


        fila += 1
        MostrarDatos()
    End Sub

    Private Sub btnAnt_Click(sender As Object, e As EventArgs) Handles btnAnt.Click

        If (tblEmp Is Nothing) Then
            MsgBox("No hay datos")
            Return
        End If

        If (fila < 1) Then
            Return
        End If

        fila -= 1
        MostrarDatos()

    End Sub

    Private Sub MostrarDatos()
        lbCantEmp.Text = (1 + fila).ToString + " / " + cantEmp.ToString
        cbEmpleado.SelectedIndex = fila
        lbCantEmp.Text = (1 + fila).ToString + " / " + cantEmp.ToString
        lblCargo.Text = tblCar.Rows(tblEmp.Rows(fila).Item(17) - 1).Item(2)
        cbEmpleado.SelectedIndex = fila
        lblID.Text = tblEmp.Rows(fila).Item(0).ToString
        lblNombres.Text = tblEmp.Rows(fila).Item(2).ToString + " " + tblEmp.Rows(fila).Item(3).ToString
        lblApellidos.Text = tblEmp.Rows(fila).Item(4).ToString + " " + tblEmp.Rows(fila).Item(5).ToString
        lblSexo.Text = tblEmp.Rows(fila).Item(11).ToString
        lblCedula.Text = tblEmp.Rows(fila).Item(1).ToString
        lblEmailCorp.Text = tblEmp.Rows(fila).Item(10).ToString
        lblEmailPer.Text = tblEmp.Rows(fila).Item(9).ToString
        lblFechaNac.Text = tblEmp.Rows(fila).Item(14).ToString
        lblFechaIng.Text = tblEmp.Rows(fila).Item(15).ToString
        lblTelefono.Text = tblEmp.Rows(fila).Item(8).ToString
        rtxtObservacion.Text = tblEmp.Rows(fila).Item(7).ToString
        rtxtDireccion.Text = tblEmp.Rows(fila).Item(6).ToString
    End Sub

    Private Sub btnOpExtra_Click(sender As Object, e As EventArgs) Handles btnOpExtra.Click

    End Sub

    Private Sub cbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleado.SelectedIndexChanged


    End Sub

    Private Sub cbEmpleado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEmpleado.SelectionChangeCommitted

        fila = cbEmpleado.SelectedIndex
        MostrarDatos()

    End Sub
End Class