Public Class frmEstablecerHorarios

    Dim Horario As New BDSistemaEySDataSetTableAdapters.tbl_HorarioTableAdapter
    Dim idHorario As Integer

    Private Sub frmEstablecerHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MessageBox.Show("Desea guardar el horario?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub
End Class