Public Class frmSeguridadPermisos

    Dim Rol As New BDSistemaEySDataSetTableAdapters.tbl_RolTableAdapter
    Dim OpcRol As New BDSistemaEySDataSetTableAdapters.tbl_OpcRolTableAdapter
    Dim tblOr As New BDSistemaEySDataSet.tbl_OpcRolDataTable
    Dim id As New Integer

    Public Sub CargarDatos(id As Integer)
        Me.id = id
    End Sub

    Private Sub frmSeguridadPermisos_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
        CheckBox7.Checked = True
        CheckBox8.Checked = True
        CheckBox9.Checked = True
        CheckBox10.Checked = True
        CheckBox11.Checked = True
        CheckBox12.Checked = True
        CheckBox13.Checked = True
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
    End Sub

    Private Function DefinirEstado() As Boolean
        Dim estado As Boolean
        If RadioButton2.Checked Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ComprobarRol() Then
            MessageBox.Show("Se ha guardado correctamente", "Acceso de rol actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Se ha guardado correctamente", "Acceso de rol establecido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Function ComprobarRol() As Boolean
        OpcRol.ConfirmarRol(tblOr, id)
        Try
            Dim rol As Integer = tblOr.First.idRol
            OpcRol.UpdateQuery(DefinirEstado, 1, id, rol, rol)
            Return True
        Catch ex As Exception
            OpcRol.RegistroOrAgreg(DefinirEstado, 1, id)
            Return False
        End Try
    End Function
End Class