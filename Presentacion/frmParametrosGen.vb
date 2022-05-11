Public Class frmParametrosGen

    Private WithEvents buttonEstablecerEv As New Button
    Private WithEvents buttonTiempoGracia As New Button
    Private WithEvents buttonEstablecerHorario As New Button

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmParametrosGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonEstablecerEv = colocarBoton("Establecer evento con modalidad")
        buttonTiempoGracia = colocarBoton("Tiempo de gracia")
        buttonEstablecerHorario = colocarBoton("Horario de almuerzo")

        AddHandler buttonEstablecerEv.Click, AddressOf ButtonEstablecer_Click
        AddHandler buttonTiempoGracia.Click, AddressOf ButtonTiempoGracia_Click
        AddHandler buttonEstablecerHorario.Click, AddressOf buttonEstablecerHor_Click

    End Sub

    Private Sub ButtonEstablecer_Click(sender As Object, e As EventArgs) Handles buttonEstablecerEv.Click
        frmEstablecerEventos.Show()
    End Sub

    Private Sub ButtonTiempoGracia_Click(sender As Object, e As EventArgs) Handles buttonTiempoGracia.Click
        frmTiempoGracia.Show()
    End Sub

    Private Sub buttonEstablecerHor_Click(sender As Object, e As EventArgs) Handles buttonEstablecerHorario.Click
        frmEstablecerHorarios.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonEventos.Click
        layoutPanel.Controls.Clear()
        layoutPanel.Controls.Add(buttonEstablecerEv)

    End Sub

    Private Function colocarBoton(texto As String) As Button
        Dim boton As New Button()
        boton.Size = New Size(415, 45)
        boton.Text = texto
        boton.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Return boton
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles buttonAjustes.Click
        layoutPanel.Controls.Clear()
        layoutPanel.Controls.Add(buttonTiempoGracia)
        layoutPanel.Controls.Add(buttonEstablecerHorario)
    End Sub

End Class