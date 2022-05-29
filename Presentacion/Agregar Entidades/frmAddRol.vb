Public Class frmAddRol

    Dim Rol As New BDSistemaEySDataSetTableAdapters.tbl_RolTableAdapter
    Dim tblRol As New BDSistemaEySDataSet.tbl_RolDataTable

    Dim idRol As Integer
    Dim modo As Int16 = 0

    Sub llenarGrid()
        DgvRol.DataSource = Rol.GetData
        DgvRol.Refresh()
        DgvRol.Columns(0).Visible = False
    End Sub

    Public Sub CambiarModo(idRol As Integer)
        modo = 1
        btnEliminar.Visible = True
        btnEditar.Visible = True
        GroupBox1.Text = "Administrar Rol"
        Rol.Fill(tblRol)
        Me.idRol = idRol
        OrdenarDatos()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub OrdenarDatos()
        txbNombre.Text = tblRol.Rows(Me.idRol).Item(1)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim Nombre As String = txbNombre.Text.Trim
        Dim estado As Integer

        Rol.RegistroRolAgreg(Nombre, estado)

        llenarGrid()

        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim resp As VariantType

            resp = (MsgBox("Seguro que se desea eliminar?", vbQuestion + vbYesNo, "Confirmación"))
            If (resp = vbYes) Then
                Rol.RegistroRolElim(idRol)
                llenarGrid()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmAddRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        GroupBox1.Text = "Agregar Rol"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txbNombre.Text = ""
    End Sub

    Private Sub DgvRol_DoubleClick(sender As Object, e As EventArgs) Handles DgvRol.DoubleClick
        Try

            Dim fila As Integer = DgvRol.CurrentRow.Index
            idRol = DgvRol.Item(0, fila).Value
            txbNombre.Text = DgvRol.Item(1, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim id As Integer
        Dim nombre As String = txbNombre.Text.Trim

        Rol.RegistroRolAct(nombre, 1, idRol, id)

        llenarGrid()
    End Sub
End Class