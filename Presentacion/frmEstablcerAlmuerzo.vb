Public Class frmEstablcerAlmuerzo

    Dim flagHor As Boolean = False
    Dim idHorario(3) As Integer

    Private Sub frmEstablcerAlmuerzo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub RecargarNumeric()

        If Not checkReg.Checked Then
            npH1R.Enabled = False
            npM1R.Enabled = False

            npH2R.Enabled = False
            npM2R.Enabled = False
        Else
            npH1R.Enabled = True
            npM1R.Enabled = True

            npH2R.Enabled = True
            npM2R.Enabled = True
        End If

        'MessageBox.Show(checkReg.Checked.ToString, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Question)

    End Sub

    Private Sub ConvertirHorarios()
        Dim horaEntradaR As DateTime
        Dim horaSalidaR As DateTime

        Dim horarioBuilder As String

        horarioBuilder = "11-09-2001 " + npH1R.Value.ToString + ":" + npM1R.Value.ToString + ":00"
        horaEntradaR = DateTime.Parse(horarioBuilder)

        horarioBuilder = "11-09-2001 " + npH2R.Value.ToString + ":" + npM2R.Value.ToString + ":00"
        horaSalidaR = DateTime.Parse(horarioBuilder)

    End Sub

    Private Sub ColocarHorario()
        Dim horaEntradaR, horaEntradaS, horaEntradaD As DateTime
        Dim horaSalidaR, horaSalidaS, horaSalidaD As DateTime


        npH1R.Value = horaEntradaR.Hour
        npM1R.Value = horaEntradaR.Minute

        npH2R.Value = horaSalidaR.Hour
        npM2R.Value = horaSalidaR.Minute

    End Sub

    Private Sub checkReg_CheckedChanged(sender As Object, e As EventArgs) Handles checkReg.CheckedChanged
        RecargarNumeric()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If checkReg.Checked = False Then
            MessageBox.Show("Tiene que haber al menos un horario", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return
        End If

        If (MessageBox.Show("¿Deseas cambiar el horario?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
            Return
        End If
        ConvertirHorarios()

        MessageBox.Show("Se ha guardado el horario", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Me.Close()
    End Sub
End Class