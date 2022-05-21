Public Class frmListarDept

    Dim Dept As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim tblDept As New BDSistemaEySDataSet.tbl_DepartamentoDataTable
    Dim fila As Integer = 0
    Dim cantDep As Int32
    Dim id As Int32 = 0
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
        llenarDept()
        cantDep = Dept.GetData.Count()
        lblCantDep.Text = (1 + id).ToString + " / " + cantDep.ToString
        Dept.Fill(tblDept)
    End Sub

    Private Sub cbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDept.SelectedIndexChanged
        Dim cb = DirectCast(sender, ComboBox)

        If cb.SelectedIndex >= 0 Then

            id = cb.SelectedIndex
            lblCantDep.Text = (1 + id).ToString + " / " + cantDep.ToString

            Dim idDep = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Int32)("idDepartamento")
            lbID.Text = idDep

            Dim Nombre = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("nombre")
            lbNombre.Text = Nombre

            Dim ext = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("ext")
            lbEXT.Text = ext

            Dim email = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("email")
            lbEmail.Text = email

            Dim Descripcion = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("descripcion")
            rtxtDescripcion.Text = Descripcion

        End If
    End Sub

    Private Sub btnAnt_Click(sender As Object, e As EventArgs) Handles btnAnt.Click

        Try
            fila -= 1

            If fila <= tblDept.Rows.Count Then
                cantDep = Dept.GetData.Count()
                lblCantDep.Text = (1 + id).ToString + " / " + cantDep.ToString
                lbID.Text = tblDept.Rows(fila).Item(0).ToString
                lbNombre.Text = tblDept.Rows(fila).Item(1).ToString
                lbEmail.Text = tblDept.Rows(fila).Item(3).ToString
                lbEXT.Text = tblDept.Rows(fila).Item(2).ToString
                rtxtDescripcion.Text = tblDept.Rows(fila).Item(4).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click

        Try
            fila += 1

            If fila <= tblDept.Rows.Count Then
                cantDep = Dept.GetData.Count()
                lblCantDep.Text = (1 + id).ToString + " / " + cantDep.ToString
                lbID.Text = tblDept.Rows(fila).Item(0).ToString
                lbNombre.Text = tblDept.Rows(fila).Item(1).ToString
                lbEmail.Text = tblDept.Rows(fila).Item(3).ToString
                lbEXT.Text = tblDept.Rows(fila).Item(2).ToString
                rtxtDescripcion.Text = tblDept.Rows(fila).Item(4).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class