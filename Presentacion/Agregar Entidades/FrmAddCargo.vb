Public Class FrmAddCargo

    Dim viewCar As New BDSistemaEySDataSetTableAdapters.Vw_ListCargoTableAdapter
    Dim tblViewCar As New BDSistemaEySDataSet.Vw_ListCargoDataTable

    Dim carg As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter
    Dim dep As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim modo As Integer = 0
    Dim idCargo As Integer

    Sub llenarGrid()
        dgvCargos.DataSource = carg.GetData
        dgvCargos.Refresh()
        dgvCargos.Columns(0).Visible = False
    End Sub

    Public Sub CambiarModo(idCargo As Integer)
        modo = 1
        btnEliminar.Visible = True
        btnEditar.Visible = True
        GroupBox1.Text = "Administrar Cargo"
        Me.idCargo = idCargo
        viewCar.Fill(tblViewCar)
        ColocarDatos()
    End Sub

    Private Sub ColocarDatos()
        Try
            txbNombre.Text = tblViewCar.Rows(idCargo).Item(1)
            rtxtDesc.Text = tblViewCar.Rows(idCargo).Item(3)

        Catch

        End Try
    End Sub


    Sub llenarDep()

        cbDep.DataSource = dep.GetData()
        cbDep.DisplayMember = "nombre"
        cbDep.ValueMember = "idDepartamento"
        cbDep.Refresh()

    End Sub
    Private Sub FrmAddCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDep()
        llenarGrid()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        MessageBox.Show("Si se ha introducido algun dato no seran guardados, seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNoCancel)
        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nombre As String = txbNombre.Text.Trim
        Dim dep As String = cbDep.Text.Trim
        Dim desc As String = rtxtDesc.Text.Trim
        Dim idDep As Integer = CInt(cbDep.SelectedValue)
        Dim estado As Integer = 1

        carg.RegistroCarAgreg(nombre, desc, estado, idDep)

        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)

        llenarGrid()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            Dim resp As VariantType

            resp = (MsgBox("Seguro que se desea eliminar?", vbQuestion + vbYesNo, "Confirmación"))
            If (resp = vbYes) Then
                carg.RegistroCarElim(idCargo)
                llenarGrid()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvCargos_DoubleClick(sender As Object, e As EventArgs) Handles dgvCargos.DoubleClick
        Try

            Dim fila As Integer = dgvCargos.CurrentRow.Index
            idCargo = dgvCargos.Item(0, fila).Value
            txbNombre.Text = dgvCargos.Item(1, fila).Value
            cbDep.Text = dgvCargos.Item(4, fila).Value
            rtxtDesc.Text = dgvCargos.Item(2, fila).Value


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim id As Integer
        Dim nombre As String = txbNombre.Text.Trim
        Dim departamento As Integer = CInt(cbDep.SelectedValue)
        Dim desc As String = rtxtDesc.Text.Trim
        Dim estado As Integer

        carg.RegistroCarAct(nombre, desc, estado, departamento, idCargo, id)

        llenarGrid()
    End Sub

    Private Sub btnHorario_Click(sender As Object, e As EventArgs) Handles btnHorario.Click
        frmEstablecerHorarios.Show()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txbNombre.Text = ""
        rtxtDesc.Text = ""
    End Sub

End Class