Public Class frmListarCredenciales

    Dim vwUsr As New BDSistemaEySDataSetTableAdapters.Vw_UsuarioTableAdapter
    Dim tblVwUsr As New BDSistemaEySDataSet.Vw_UsuarioDataTable

    Dim editUser As New frmAdminCredenciales

    Dim fila As Integer = 0
    Dim cantUser As Int32

    Sub llenarCred()
        cbCredenciales.DataSource = vwUsr.GetData()
        cbCredenciales.DisplayMember = "Username"
        cbCredenciales.ValueMember = "ID"
        cbCredenciales.Refresh()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmListarCredenciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            llenarCred()
            vwUsr.Fill(tblVwUsr)
            If (tblVwUsr Is Nothing) Then
                MsgBox("No hay datos")
                Me.Close()
            End If

            cantUser = vwUsr.GetData.Count()
            MostrarDatos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If (tblVwUsr Is Nothing) Then
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

        If (tblVwUsr Is Nothing) Then
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

        lblCantUser.Text = (1 + fila).ToString + " / " + cantUser.ToString
        cbCredenciales.SelectedIndex = fila
        Dim emp As String = tblVwUsr.Rows(fila).Item(3).ToString
        lbID.Text = tblVwUsr.Rows(fila).Item(0)
        lbNombre.Text = tblVwUsr.Rows(fila).Item(1)
        lblContraseña.Text = tblVwUsr.Rows(fila).Item(2)
        lbRol.Text = tblVwUsr.Rows(fila).Item(4)

        If emp = String.Empty Then
            lblEmp.Text = "Sin empleado asignado"
            Return
        End If
        lblEmp.Text = emp
    End Sub

    Private Sub cbCredenciales_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCredenciales.SelectionChangeCommitted
        fila = cbCredenciales.SelectedIndex
        MostrarDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editUser = New frmAdminCredenciales()
        editUser.CambiarModo(fila)
        editUser.Show()
    End Sub
End Class