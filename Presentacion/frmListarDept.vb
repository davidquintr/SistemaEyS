Public Class frmListarDept

    Dim Dept As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim tblDept As New BDSistemaEySDataSet.tbl_DepartamentoDataTable
    Dim fila As Integer = 0
    Dim cantDep As Int32

    Sub llenarDept()
        cbDept.DataSource = Dept.GetData()
        cbDept.DisplayMember = "nombre"
        cbDept.ValueMember = "idDepartamento"
        cbDept.Refresh()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmListarDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            llenarDept()
            Dept.Fill(tblDept)
            If (tblDept Is Nothing) Then
                MsgBox("No hay datos")
                Me.Close()
            End If

            cantDep = Dept.GetData.Count()
            MostrarDatos()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAnt_Click(sender As Object, e As EventArgs) Handles btnAnt.Click

        If (tblDept Is Nothing) Then
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

        If (tblDept Is Nothing) Then
            MsgBox("No hay datos")
            Return
        End If

        If (fila >= cantDep - 1) Then
            Return
        End If

        fila += 1
        MostrarDatos()

    End Sub

    Private Sub cbDept_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbDept.SelectionChangeCommitted

        fila = cbDept.SelectedIndex
        MostrarDatos()

    End Sub

    Private Sub MostrarDatos()
        Try
            lblCantDep.Text = (1 + fila).ToString + " / " + cantDep.ToString
            cbDept.SelectedIndex = fila

            lbID.Text = tblDept.Rows(fila).Item(0)
            lbNombre.Text = tblDept.Rows(fila).Item(1)
            lbEmail.Text = tblDept.Rows(fila).Item(3)
            lbEXT.Text = tblDept.Rows(fila).Item(2)
            rtxtDescripcion.Text = tblDept.Rows(fila).Item(4)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdministrar_Click(sender As Object, e As EventArgs) Handles btnAdministrar.Click
        FrmAddDepartamento.Show()
        FrmAddDepartamento.CambiarModo()
    End Sub
End Class