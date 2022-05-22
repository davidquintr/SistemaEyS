Public Class frmAdminCredenciales

    Dim user As New BDSistemaEySDataSetTableAdapters.tbl_UsuarioTableAdapter
    Dim Rol As New BDSistemaEySDataSetTableAdapters.tbl_RolTableAdapter

    Sub llenarRol()

        cbRol.DataSource = Rol.GetData()
        cbRol.DisplayMember = "Nombre"
        cbRol.ValueMember = "idRol"
        cbRol.Refresh()

    End Sub
    Private Sub frmAdminCredenciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRol()
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
        Me.Close()
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        MessageBox.Show("Se desea dar de baja?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub
End Class