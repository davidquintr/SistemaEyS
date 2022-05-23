Public Class frmAddRol

    Dim Rol As New BDSistemaEySDataSetTableAdapters.tbl_RolTableAdapter
    Dim tblRol As New BDSistemaEySDataSet.tbl_RolDataTable

    Dim idRol As Integer
    Dim modo As Int16 = 0

    Public Sub CambiarModo(idRol As Integer)
        modo = 1
        btnEliminar.Visible = True
        GroupBox1.Text = "Administrar Rol"
        Rol.Fill(tblRol)
        Me.idRol = idRol
        OrdenarDatos()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub OrdenarDatos()
        txbID.Text = tblRol.Rows(Me.idRol).Item(0)
        txbNombre.Text = tblRol.Rows(Me.idRol).Item(1)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim Nombre As String = txbNombre.Text.Trim
        Dim estado As Integer

        Rol.RegistroRolAgreg(Nombre, estado)

        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MessageBox.Show("Seguro que se desea eliminar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub frmAddRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = "Agregar Rol"
        btnCerrar.Visible = False
    End Sub
End Class