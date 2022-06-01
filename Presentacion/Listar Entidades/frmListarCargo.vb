Public Class frmListarCargo

    Dim viewCar As New BDSistemaEySDataSetTableAdapters.Vw_ListCargoTableAdapter
    Dim tblViewCar As New BDSistemaEySDataSet.Vw_ListCargoDataTable
    Dim fila As Integer = 0
    Dim cantCarg As Int32

    Sub llenarCar()

        cbCargos.DataSource = viewCar.GetData()
        cbCargos.DisplayMember = "Nombre"
        cbCargos.ValueMember = "ID"
        cbCargos.Refresh()

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Seguro que se desea eliminar?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub frmListarCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            llenarCar()
            viewCar.Fill(tblViewCar)
            If (tblViewCar Is Nothing) Then
                MsgBox("No hay datos")
                Me.Close()
            End If

            cantCarg = viewCar.GetData.Count()
            MostrarDatos()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MostrarDatos()
        Try
            lblCantCarg.Text = (1 + fila).ToString + " / " + cantCarg.ToString
            cbCargos.SelectedIndex = fila

            lbID.Text = tblViewCar.Rows(fila).Item(0)
            lbNombre.Text = tblViewCar.Rows(fila).Item(1)
            lbDept.Text = tblViewCar.Rows(fila).Item(2)
            rtxtDescripcion.Text = tblViewCar.Rows(fila).Item(3)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If (tblViewCar Is Nothing) Then
            MsgBox("No hay datos")
            Return
        End If

        If (fila < 1) Then
            Return
        End If

        fila -= 1
        MostrarDatos()

    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        If (tblViewCar Is Nothing) Then
            MsgBox("No hay datos")
            Return
        End If

        If (fila >= cantCarg - 1) Then
            Return
        End If

        fila += 1
        MostrarDatos()
    End Sub

    Private Sub cbCargos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCargos.SelectionChangeCommitted
        fila = cbCargos.SelectedIndex
        MostrarDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FrmAddCargo.Show()
        FrmAddCargo.CambiarModo(fila)

    End Sub
End Class