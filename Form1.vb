Public Class Form1
    Private Sub btnInicio_Click(sender As Object, e As EventArgs)
        FrmVistaAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.tbl_Usuario' table. You can move, or remove it, as needed.
        Me.Tbl_UsuarioTableAdapter.Fill(Me.BDSistemaEySDataSet.tbl_Usuario)
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""


    End Sub

    Private Sub btnIng_Click(sender As Object, e As EventArgs) Handles btnIng.Click
        If Me.Tbl_UsuarioTableAdapter.BuscarUC(Me.BDSistemaEySDataSet.tbl_Usuario, UsernameTextBox.Text, PasswordTextBox.Text) Then
            Me.Hide()
            FrmVistaAdmin.Show()
            MessageBox.Show("Inicio de sesión autorizado", "Confirmación")
        Else
            MessageBox.Show("Usuario o contraseña incorrecta", "Advertencia")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Tbl_UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDSistemaEySDataSet)

    End Sub
End Class
