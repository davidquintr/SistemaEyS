Public Class frmParametrosGen

    Private WithEvents buttonEstablecerEv As New Button
    Private WithEvents buttonTiempoGracia As New Button
    Private WithEvents buttonEstablecerHorario As New Button

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmParametrosGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


End Class