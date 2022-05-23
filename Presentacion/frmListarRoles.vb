Public Class frmListarRoles

    Dim Rol As New BDSistemaEySDataSetTableAdapters.tbl_RolTableAdapter
    Dim tblRol As New BDSistemaEySDataSet.tbl_RolDataTable
    Dim fila As Integer = 0
    Dim cantRol As Int32

    Sub llenarRol()
        cbRoles.DataSource = Rol.GetData()
        cbRoles.DisplayMember = "nombre"
        cbRoles.ValueMember = "idRol"
        cbRoles.Refresh()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmListarRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarRol()
            Rol.Fill(tblRol)
            If (tblRol Is Nothing) Then
                MsgBox("No hay datos")
                Me.Close()
            End If

            cantRol = Rol.GetData.Count()
            MostrarDatos()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAnt_Click(sender As Object, e As EventArgs) Handles btnAnt.Click

        If (tblRol Is Nothing) Then
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

        If (tblRol Is Nothing) Then
            MsgBox("No hay datos")
            Return
        End If

        If (fila >= cantRol - 1) Then
            Return
        End If

        fila += 1
        MostrarDatos()

    End Sub

    Private Sub cbRoles_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbRoles.SelectionChangeCommitted

        fila = cbRoles.SelectedIndex
        MostrarDatos()

    End Sub

    Private Sub MostrarDatos()
        Try
            lblCantRol.Text = (1 + fila).ToString + " / " + cantRol.ToString
            cbRoles.SelectedIndex = fila

            lbID.Text = tblRol.Rows(fila).Item(0)
            lbNombre.Text = tblRol.Rows(fila).Item(1)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdministrar_Click(sender As Object, e As EventArgs) Handles btnAdministrar.Click
        frmAddRol.Show()
        frmAddRol.CambiarModo(fila)
    End Sub
End Class