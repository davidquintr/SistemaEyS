Public Class frmParametrosGen

    Dim botonEstablecer As New Button()
    Dim tiempoGracia As New Button()
    Dim establecerHorario As New Button()


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmParametrosGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonEventos.Click
        layoutPanel.Controls.Clear()
        botonEstablecer = colocarBoton("Establecer evento con modalidad")
        layoutPanel.Controls.Add(botonEstablecer)
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
        tiempoGracia = colocarBoton("Tiempo de gracia")
        establecerHorario = colocarBoton("Horario de almuerzo")
        layoutPanel.Controls.Add(tiempoGracia)
        layoutPanel.Controls.Add(establecerHorario)
    End Sub
End Class