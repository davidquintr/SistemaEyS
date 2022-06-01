Public Class frmParametrosGen

    Dim modo As Integer = 0
    Dim para As Integer

    Public Sub CambiarModo(parametros As Integer)
        modo = 1
        Me.para = parametros
        btnEmpresa.Visible = True
        btnNombreEmpresa.Visible = True
        btnHorarioAlmuerzo.Visible = True
        btnTGracia.Visible = True
        btnDominio.Visible = True
        btnExtras.Visible = False
        buttonAjustes.Visible = True

    End Sub

    Private Sub btnExtras_Click(sender As Object, e As EventArgs) Handles btnExtras.Click
        CambiarModo(0)
    End Sub

    Private Sub btnHorarioAlmuerzo_Click(sender As Object, e As EventArgs)
        frmEstablcerAlmuerzo.Show()
    End Sub

    Private Sub layoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles layoutPanel.Paint

    End Sub

    Private Sub btnIng_Click(sender As Object, e As EventArgs) Handles btnIng.Click
        Me.Close()
    End Sub

End Class