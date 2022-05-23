Public Class frmListarEmp

    Dim viewEmp As New BDSistemaEySDataSetTableAdapters.Vw_ListEmpTableAdapter
    Dim tblViewEmp As New BDSistemaEySDataSet.Vw_ListEmpDataTable

    Dim fila As Integer = 0
    Dim cantEmp As Int32

    Sub llenarEmp()
        cbEmpleado.DataSource = viewEmp.GetData()
        cbEmpleado.DisplayMember = "Nombres"
        cbEmpleado.ValueMember = "ID"
        cbEmpleado.Refresh()
    End Sub

    Private Sub frmListarEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            llenarEmp()
            viewEmp.Fill(tblViewEmp)
            If (tblViewEmp Is Nothing) Then
                MsgBox("No hay datos")
                Me.Close()
            End If

            cantEmp = viewEmp.GetData.Count()
            MostrarDatos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click

        If (tblViewEmp Is Nothing) Then
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

        If (tblViewEmp Is Nothing) Then
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
        Try
            lbCantEmp.Text = (1 + fila).ToString + " / " + cantEmp.ToString
            cbEmpleado.SelectedIndex = fila

            lblID.Text = tblViewEmp.Rows(fila).Item(0)
            lblNombres.Text = tblViewEmp.Rows(fila).Item(1)
            lblApellidos.Text = tblViewEmp.Rows(fila).Item(2)
            lblSexo.Text = tblViewEmp.Rows(fila).Item(3)
            lblCedula.Text = tblViewEmp.Rows(fila).Item(4)
            lblDepartamento.Text = tblViewEmp.Rows(fila).Item(5)
            lblCargo.Text = tblViewEmp.Rows(fila).Item(6)
            lblEmailCorp.Text = tblViewEmp.Rows(fila).Item(7)
            lblEmailPer.Text = tblViewEmp.Rows(fila).Item(8)
            lblFechaNac.Text = DateTime.Parse(tblViewEmp.Rows(fila).Item(9)).ToString("f")
            lblFechaIng.Text = DateTime.Parse(tblViewEmp.Rows(fila).Item(10)).ToString("f")
            lblActividad.Text = tblViewEmp.Rows(fila).Item(11)
            lblTelefono.Text = tblViewEmp.Rows(fila).Item(12)
            rtxtObservacion.Text = tblViewEmp.Rows(fila).Item(13).ToString
            rtxtDireccion.Text = tblViewEmp.Rows(fila).Item(14)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOpExtra_Click(sender As Object, e As EventArgs) Handles btnOpExtra.Click

    End Sub

    Private Sub cbEmpleado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEmpleado.SelectionChangeCommitted
        fila = cbEmpleado.SelectedIndex
        MostrarDatos()
    End Sub

    Private Sub btnAdministrar_Click(sender As Object, e As EventArgs) Handles btnAdministrar.Click
        FrmAddEmpleado.Show()
        FrmAddEmpleado.CambiarModo(fila)
    End Sub
End Class