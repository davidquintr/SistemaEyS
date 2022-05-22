Public Class FrmAddCargo

    Dim carg As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter
    Dim dep As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim modo As Int16 = 0

    Public Sub CambiarModo()
        modo = 1
        btnEliminar.Visible = True
        GroupBox1.Text = "Administrar Cargo"
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
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nombre As String = txbNombre.Text.Trim
        Dim dep As String = cbDep.Text.Trim
        Dim desc As String = rtxtDesc.Text.Trim
        Dim estado As Integer = CInt(checkAdmin.CheckState)
        Dim idDep As Integer = CInt(cbDep.SelectedValue)


        carg.RegistroCarAgreg(nombre, desc, estado, idDep)

        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MessageBox.Show("Seguro que se desea eliminar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

End Class