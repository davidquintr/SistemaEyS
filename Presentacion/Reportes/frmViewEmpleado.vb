Public Class frmViewEmpleado
    Private Sub frmViewEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rptEmpleado.RefreshReport()

    End Sub

    Private Sub rptEmpleado_Load(sender As Object, e As EventArgs) Handles rptEmpleado.Load
        Me.rptEmpleado.Show()
    End Sub
End Class