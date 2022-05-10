Public Class frmVistaEmp
    Private Sub frmVistaEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Desea marcar su entrada?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Desea marcar su salida?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Desea iniciar el almuerzo?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub
End Class