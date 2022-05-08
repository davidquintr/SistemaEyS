Public Class Form1
    Private Sub btnInicio_Click(sender As Object, e As EventArgs)
        FrmVistaAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
