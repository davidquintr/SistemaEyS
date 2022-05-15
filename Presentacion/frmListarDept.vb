Public Class frmListarDept

    Dim Dept As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter

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
    End Sub

    Private Sub cbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDept.SelectedIndexChanged
        Dim cb = DirectCast(sender, ComboBox)

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of Int32)("idDepartamento")
            lbID.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("nombre")
            lbNombre.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("ext")
            lbEXT.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("email")
            lbEmail.Text = val

        End If

        If cb.SelectedIndex >= 0 Then
            Dim val = DirectCast(cb.SelectedItem, DataRowView).Row.Field(Of String)("descripcion")
            rtxtDescripcion.Text = val

        End If
    End Sub
End Class