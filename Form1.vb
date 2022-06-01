Public Class Form1
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.tbl_Usuario' table. You can move, or remove it, as needed.
        Me.Tbl_UsuarioTableAdapter.Fill(Me.BDSistemaEySDataSet.tbl_Usuario)
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        BDSistemaEySDataSet.EnforceConstraints = False
    End Sub

    Private Sub btnIng_Click(sender As Object, e As EventArgs) Handles btnIng.Click
        ConfirmarCredenciales()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Tbl_UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDSistemaEySDataSet)

    End Sub

    Private Sub ConfirmarCredenciales()
        Try

            Dim idUsuario As Integer
            Dim idEmpleado As Integer
            Dim hasEmp As Boolean = False
            If Me.Tbl_UsuarioTableAdapter.BuscarUC(Me.BDSistemaEySDataSet.tbl_Usuario, UsernameTextBox.Text, PasswordTextBox.Text) = 0 Then
                MessageBox.Show("Credenciales incorrectas, verifique sus datos o consulte a un administrador", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            idUsuario = BDSistemaEySDataSet.tbl_Usuario.First.idUsuario

            If Me.Tbl_EmpleadoTableAdapter.GetEmpleado(Me.BDSistemaEySDataSet.tbl_Empleado, idUsuario) <> 0 Then
                hasEmp = True
            End If

            If hasEmp = True Then
                idEmpleado = BDSistemaEySDataSet.tbl_Empleado.First.idEmpleado
            End If

            Dim result As DialogResult = MessageBox.Show("¿Desea iniciar como administrador?", "Inicio de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                FrmVistaAdmin.Show()
                FrmVistaAdmin.AsignarUsuario(idEmpleado, idUsuario)
                Me.Hide()
                Return
            ElseIf result = DialogResult.No And hasEmp = False Then
                MessageBox.Show("No existe un empleado asignado a este usuario, consulte a un administrador", "Vista de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                frmVistaEmp.Show()
                frmVistaEmp.CargarDatos(idEmpleado)
                Me.Hide()
                Return
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ConfirmarCredenciales()
        End If
    End Sub

End Class