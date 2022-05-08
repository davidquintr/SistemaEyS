Public Class FrmAddEntidad
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)

        Select Case ComboBox1.SelectedIndex

            Case 0
                FrmAddEmpleado.Show()
            Case 1
                FrmAddCargo.Show()
            Case 2
                FrmAddDepartamento.Show()
            Case Else

        End Select
    End Sub

    Private Sub FrmAddEntidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class