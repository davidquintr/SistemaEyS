Public Class frmListarCredenciales

    Dim cred As New BDSistemaEySDataSetTableAdapters.tbl_UsuarioTableAdapter
    Dim tblCred As New BDSistemaEySDataSet.tbl_UsuarioDataTable
    Dim fila As Integer = 0
    Dim cantUser As Int32

    Sub llenarCred()

        cbCredenciales.DataSource = cred.GetData()
        cbCredenciales.DisplayMember = "username"
        cbCredenciales.ValueMember = "idUsuario"
        cbCredenciales.Refresh()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        MessageBox.Show("Si se ha introducido algun dato no seran guardados, seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub frmListarCredenciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            llenarCred()
            cred.Fill(tblCred)
            If (tblCred Is Nothing) Then
                MsgBox("No hay datos")
                Me.Close()
            End If

            cantUser = cred.GetData.Count()
            MostrarDatos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If (tblCred Is Nothing) Then
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

        If (tblCred Is Nothing) Then
            MsgBox("No hay datos")
            Return
        End If

        If (fila >= cantUser - 1) Then
            Return
        End If

        fila += 1
        MostrarDatos()

    End Sub

    Private Sub MostrarDatos()
        Try
            lblCantUser.Text = (1 + fila).ToString + " / " + cantUser.ToString
            cbCredenciales.SelectedIndex = fila

            lbID.Text = tblCred.Rows(fila).Item(0)
            lbNombre.Text = tblCred.Rows(fila).Item(1)
            lbRol.Text = tblCred.Rows(fila).Item(3)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbCredenciales_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCredenciales.SelectionChangeCommitted
        fila = cbCredenciales.SelectedIndex
        MostrarDatos()
    End Sub
End Class