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
        labelTitulo.Text = "Administrar Rol"
        Rol.Fill(tblRol)
        Me.idRol = idRol
        OrdenarDatos()
        AlternarBotones(0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub OrdenarDatos()
        txbNombre.Text = tblRol.Rows(Me.idRol).Item(1)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txbNombre.Text = String.Empty Then
            MessageBox.Show("No puedes dejar el nombre vacío", "Giardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Nombre As String = txbNombre.Text.Trim
        Dim estado As Integer

        If MessageBox.Show("¿Deseas guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            Return
        End If

        Rol.RegistroRolAgreg(Nombre, estado)

        llenarGrid()

        MessageBox.Show("Se ha guardado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If (MessageBox.Show($"¿Deseas eliminar el rol {txbNombre.Text}?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Rol.RegistroRolElim(idRol)
        End If
        MessageBox.Show("Se ha eliminado éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        llenarGrid()
    End Sub

    Private Sub frmAddRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        AlternarBotones(1)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txbNombre.Text = ""
        AlternarBotones(1)
    End Sub

    Private Sub DgvRol_DoubleClick(sender As Object, e As EventArgs) Handles DgvRol.DoubleClick
        Try

            Dim fila As Integer = DgvRol.CurrentRow.Index
            idRol = DgvRol.Item(0, fila).Value
            txbNombre.Text = DgvRol.Item(1, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        AlternarBotones(0)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If txbNombre.Text = String.Empty Then
            MessageBox.Show("No puedes dejar el nombre vacío", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer
        Dim nombre As String = txbNombre.Text.Trim

        If (MessageBox.Show("¿Deseas guardar el rol?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Rol.RegistroRolAct(nombre, 1, idRol, id)
        End If
        MessageBox.Show("Se ha guardado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        llenarGrid()
    End Sub

    Private Sub AlternarBotones(modo As Integer)

        If modo = 0 Then
            labelTitulo.Text = "Administrar Rol"

            btnGuardar.Enabled = False
            btnEliminar.Enabled = True
            btnEditar.Enabled = True
        Else
            labelTitulo.Text = "Agregar Rol"
            btnGuardar.Enabled = True
            btnEliminar.Enabled = False
            btnEditar.Enabled = False
        End If

    End Sub

End Class