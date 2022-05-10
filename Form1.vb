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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmVistaAdmin.Show()
    End Sub
End Class
