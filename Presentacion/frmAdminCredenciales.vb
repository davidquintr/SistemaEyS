Public Class frmAdminCredenciales

    Dim user As New BDSistemaEySDataSetTableAdapters.tbl_UsuarioTableAdapter
    Dim Rol As New BDSistemaEySDataSetTableAdapters.tbl_RolTableAdapter

    Dim vwUsr As New BDSistemaEySDataSetTableAdapters.Vw_UsuarioTableAdapter
    Dim tblVwUsr As New BDSistemaEySDataSet.Vw_UsuarioDataTable

    Dim idUser As Integer

    Dim mode As Integer

    Sub llenarRol()

        cbRol.DataSource = Rol.GetData()
        cbRol.DisplayMember = "Nombre"
        cbRol.ValueMember = "idRol"
        cbRol.Refresh()

    End Sub
    Private Sub frmAdminCredenciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRol()
        btnDarDeBaja.Visible = False
        gboxPrincipal.Text = "Seguridad: Agregar Usuario"
    End Sub

    Public Sub CambiarModo(idUser As Integer)
        gboxPrincipal.Text = "Seguridad: Editar Usuario"
        mode = 1
        btnDarDeBaja.Visible = True
        Me.idUser = idUser
        MostrarDatos()
    End Sub

    Private Sub MostrarDatos()
        vwUsr.Fill(tblVwUsr)
        txtID.Text = tblVwUsr.Rows(idUser).Item(0)
        txtNombre.Text = tblVwUsr.Rows(idUser).Item(1)
        txtPass.Text = tblVwUsr.Rows(idUser).Item(2)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click



        Dim UserName As String = txtNombre.Text.Trim
        Dim Pass As String = txtPass.Text.Trim
        Dim PassEstado As Integer
        Dim Rol As Integer = CInt(cbRol.SelectedValue)

        user.RegistroUserAgreg(UserName, Pass, 1, Rol)

        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        MessageBox.Show("Se desea dar de baja?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub
End Class