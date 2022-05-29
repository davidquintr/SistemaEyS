Public Class frmAdminCredenciales

    Dim user As New BDSistemaEySDataSetTableAdapters.tbl_UsuarioTableAdapter
    Dim Rol As New BDSistemaEySDataSetTableAdapters.tbl_RolTableAdapter
    Dim emp As New BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter

    Dim vwUsr As New BDSistemaEySDataSetTableAdapters.Vw_UsuarioTableAdapter
    Dim tblVwUsr As New BDSistemaEySDataSet.Vw_UsuarioDataTable

    Dim vwEmp As New BDSistemaEySDataSetTableAdapters.Vw_ListEmpTableAdapter

    Dim idUser As Integer

    Dim mode As Integer = 0

    Sub llenarGrid()
        DgvCredenciales.DataSource = user.GetData
        DgvCredenciales.Refresh()
        DgvCredenciales.Columns(0).Visible = False
    End Sub

    Sub llenarRol()

        cbRol.DataSource = Rol.GetData()
        cbRol.DisplayMember = "Nombre"
        cbRol.ValueMember = "idRol"
        cbRol.Refresh()

    End Sub

    Sub llenarEmp()
        cbEmpleado.DataSource = emp.GetData()
        cbEmpleado.DisplayMember = "primerNombre"
        cbEmpleado.ValueMember = "idEmpleado"
        cbEmpleado.Refresh()
    End Sub

    Private Sub frmAdminCredenciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRol()
        llenarEmp()
        llenarGrid()
        gboxPrincipal.Text = "Seguridad: Agregar Usuario"
    End Sub

    Public Sub CambiarModo(idUser As Integer)
        gboxPrincipal.Text = "Seguridad: Editar Usuario"
        mode = 1
        btnEditar.Visible = True
        btnEliminar.Visible = True
        Me.idUser = idUser
        MostrarDatos()
    End Sub

    Private Sub MostrarDatos()
        Try

            vwUsr.Fill(tblVwUsr)
            txtNombre.Text = tblVwUsr.Rows(idUser).Item(1)
            txtPass.Text = tblVwUsr.Rows(idUser).Item(2)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim UserName As String = txtNombre.Text.Trim
        Dim Pass As String = txtPass.Text.Trim
        Dim PassEstado As Integer
        Dim Rol As Integer = CInt(cbRol.SelectedValue)

        user.RegistroUserAgreg(UserName, Pass, 1, Rol)
        llenarGrid()

        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim resp As VariantType

            resp = (MsgBox("Seguro que se desea eliminar?", vbQuestion + vbYesNo, "Confirmación"))
            If (resp = vbYes) Then
                user.RegistroUserElim(idUser)
                llenarGrid()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgvCredenciales_DoubleClick(sender As Object, e As EventArgs) Handles DgvCredenciales.DoubleClick

        Try

            Dim fila As Integer = DgvCredenciales.CurrentRow.Index
            idUser = DgvCredenciales.Item(0, fila).Value
            txtNombre.Text = DgvCredenciales.Item(1, fila).Value
            txtPass.Text = DgvCredenciales.Item(2, fila).Value
            cbEmpleado.Text = DgvCredenciales.Item(3, fila).Value
            cbRol.Text = DgvCredenciales.Item(4, fila).Value


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim id As Integer
        Dim usernName As String = txtNombre.Text.Trim
        Dim pass As String = txtPass.Text.Trim
        Dim rol As Integer = CInt(cbRol.SelectedValue)
        Dim estado As Integer

        user.RegistroUserAct(usernName, pass, 1, rol, idUser, id)

        llenarGrid()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNombre.Text = ""
        txtPass.Text = ""
        txtPassConfirm.Text = ""
    End Sub
    Private Sub btnCon_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCon.MouseDown
        txtPass.PasswordChar = ""
    End Sub

    Private Sub btnCon_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCon.MouseUp
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub btnConCon_MouseDown(sender As Object, e As MouseEventArgs) Handles btnConCon.MouseDown
        txtPassConfirm.PasswordChar = ""
    End Sub

    Private Sub btnConCon_MouseUp(sender As Object, e As MouseEventArgs) Handles btnConCon.MouseUp
        txtPassConfirm.PasswordChar = "*"
    End Sub
End Class