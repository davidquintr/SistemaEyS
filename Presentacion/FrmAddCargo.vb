Public Class FrmAddCargo

    Dim viewCar As New BDSistemaEySDataSetTableAdapters.Vw_ListCargoTableAdapter
    Dim tblViewCar As New BDSistemaEySDataSet.Vw_ListCargoDataTable

    Dim carg As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter
    Dim dep As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim modo As Integer = 0
    Dim idCargo As Integer

    Public Sub CambiarModo(idCargo As Integer)
        modo = 1
        btnEliminar.Visible = True
        GroupBox1.Text = "Administrar Cargo"
        Me.idCargo = idCargo
        viewCar.Fill(tblViewCar)
        ColocarDatos()
    End Sub

    Private Sub ColocarDatos()
        Try
            txbID.Text = tblViewCar.Rows(idCargo).Item(0)
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

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MessageBox.Show("Seguro que se desea eliminar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

End Class