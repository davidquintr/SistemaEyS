Public Class frmListarCargo

    Dim carg As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter

    Sub llenarCar()

        cbCargos.DataSource = carg.GetData()
        cbCargos.DisplayMember = "nombre"
        cbCargos.ValueMember = "idCargo"
        cbCargos.Refresh()

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MessageBox.Show("Seguro que se desea eliminar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub frmListarCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCar()
    End Sub

    Private Sub cbCargos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCargos.SelectedIndexChanged

        Dim cb = DirectCast(sender, ComboBox)

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Int32)("idCargo")
            lbID.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("nombre")
            lbNombre.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("descripcion")
            rtxtDescripcion.Text = val

        End If

    End Sub
End Class