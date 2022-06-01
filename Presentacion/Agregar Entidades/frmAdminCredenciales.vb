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
        DgvCredenciales.Refresh()
        DgvCredenciales.Columns(0).Visible = False
        DgvCredenciales.Columns(5).Visible = False

    End Sub

    Sub llenarRol()

        cbRol.DataSource = Rol.GetData()
        cbRol.DisplayMember = "Nombre"
        cbRol.ValueMember = "idRol"
        cbRol.Refresh()

    End Sub

    Private Sub frmAdminCredenciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDSistemaEySDataSet.Vw_Usuario' Puede moverla o quitarla según sea necesario.
        Me.Vw_UsuarioTableAdapter.Fill(Me.BDSistemaEySDataSet.Vw_Usuario)
        llenarRol()
        llenarGrid()
        AlternarButton(0)
    End Sub

    Public Sub CambiarModo(idUser As Integer)
        mode = 1
        Me.idUser = idUser
        AlternarButton(1)
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtNombre.Text = String.Empty Then
            MessageBox.Show("Se necesita llenar el nombre del usuario", "Advertencia", MessageBoxButtons.OK)
            Return
        End If

        If txtPass.Text <> txtPassConfirm.Text Then
            MessageBox.Show("Las contraseñas deben ser iguales", "Advertencia", MessageBoxButtons.OK)
            Return
        End If

        Dim UserName As String = txtNombre.Text.Trim
        Dim Pass As String = txtPass.Text.Trim
        Dim PassEstado As Integer
        Dim Rol As Integer = CInt(cbRol.SelectedValue)

        user.RegistroUserAgreg(UserName, Pass, 1, Rol)

        MessageBox.Show("Se ha eliminado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        llenarGrid()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MessageBox.Show($"¿Deseas eliminar al usuario{txtNombre.Text}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                Return
            End If

            user.RegistroUserElim(idUser)

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error, es probable que su usuario esté asignado a un empleado, reasigne el empleado antes de eliminar el usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        MessageBox.Show("Se ha eliminado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub DgvCredenciales_DoubleClick(sender As Object, e As EventArgs) Handles DgvCredenciales.DoubleClick

        Try

            Dim fila As Integer = DgvCredenciales.CurrentRow.Index
            idUser = DgvCredenciales.Item(0, fila).Value
            txtNombre.Text = DgvCredenciales.Item(1, fila).Value
            txtPass.Text = DgvCredenciales.Item(2, fila).Value
            cbRol.SelectedValue = DgvCredenciales.Item(6, fila).Value

            'MessageBox.Show(DgvCredenciales.Item(6, fila).Value, "Advertencia", MessageBoxButtons.OK)

            AlternarButton(1)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtPass.Text = ""
        txtPassConfirm.Text = ""
        AlternarButton(0)
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

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombre.Text = String.Empty Then
            MessageBox.Show("Se necesita llenar el nombre del usuario", "Advertencia", MessageBoxButtons.OK)
            Return
        End If

        If txtPass.Text <> txtPassConfirm.Text Then
            MessageBox.Show("Las contraseñas deben ser iguales", "Advertencia", MessageBoxButtons.OK)
            Return
        End If

        Dim id As Integer
        Dim usernName As String = txtNombre.Text.Trim
        Dim pass As String = txtPass.Text.Trim
        Dim rol As Integer = CInt(cbRol.SelectedValue)
        Dim estado As Integer

        user.RegistroUserAct(usernName, pass, 1, rol, idUser, id)
        llenarGrid()

        MessageBox.Show("Se ha guardado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub AlternarButton(mode As Integer)

        If mode = 0 Then
            gboxPrincipal.Text = "Seguridad: Agregar Usuario"
            btnAgregar.Enabled = True
            btnGuardar.Enabled = False
            btnEliminar.Enabled = False
        Else
            gboxPrincipal.Text = "Seguridad: Administrar Usuario"
            btnAgregar.Enabled = False
            btnGuardar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub

End Class