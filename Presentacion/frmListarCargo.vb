Public Class frmListarCargo

    Dim carg As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter
    Dim tblCar As New BDSistemaEySDataSet.tbl_CargoDataTable
    Dim fila As Integer = 0
    Dim cantCarg As Int32
    Dim id As Int32 = 0

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
        cantCarg = carg.GetData.Count()
        lblCantCarg.Text = (1 + id).ToString + " / " + cantCarg.ToString
        carg.Fill(tblCar)
    End Sub

    Private Sub cbCargos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCargos.SelectedIndexChanged

        Dim cb = DirectCast(sender, ComboBox)

        If cb.SelectedIndex >= 0 Then
            id = cb.SelectedIndex
            lblCantCarg.Text = (1 + id).ToString + " / " + cantCarg.ToString

            Dim idCarg = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Int32)("idCargo")
            lbID.Text = idCarg

            Dim Nombre = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("nombre")
            lbNombre.Text = Nombre

            Dim Descripcion = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("descripcion")
            rtxtDescripcion.Text = Descripcion

        End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Try
            fila -= 1

            If fila <= tblCar.Rows.Count Then
                cantCarg = carg.GetData.Count()
                lblCantCarg.Text = (1 + id).ToString + " / " + cantCarg.ToString
                lbID.Text = tblCar.Rows(fila).Item(0).ToString
                lbNombre.Text = tblCar.Rows(fila).Item(1).ToString
                rtxtDescripcion.Text = tblCar.Rows(fila).Item(2).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        Try
            fila += 1

            If fila <= tblCar.Rows.Count Then
                cantCarg = carg.GetData.Count()
                lblCantCarg.Text = (1 + id).ToString + " / " + cantCarg.ToString
                lbID.Text = tblCar.Rows(fila).Item(0).ToString
                lbNombre.Text = tblCar.Rows(fila).Item(1).ToString
                rtxtDescripcion.Text = tblCar.Rows(fila).Item(2).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class