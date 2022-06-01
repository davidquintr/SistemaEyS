Public Class frmEstablcerAlmuerzo

    Dim config As New BDSistemaEySDataSetTableAdapters.tbl_ConfigTableAdapter

    Dim flagHor As Boolean = False
    Dim idConfig As Integer

    Private Sub frmEstablcerAlmuerzo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Me.Tbl_ConfigTableAdapter1.ExisteAlmuerzo(BDSistemaEySDataSet.tbl_Config, idConfig) > 0) Then
            flagHor = True
        Else
            flagHor = False
        End If

        MessageBox.Show(flagHor.ToString, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Question)


        If flagHor = False Then
            ConvertirHorarios() 'Esto para crear los datos
            flagHor = True
        Else
            ColocarHorario()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ConvertirHorarios()
        Dim horaEntradaR As DateTime
        Dim horaSalidaR As DateTime

        Dim horarioBuilder As String

        horarioBuilder = "11-09-2001 " + npH1R.Value.ToString + ":" + npM1R.Value.ToString + ":00"
        horaEntradaR = DateTime.Parse(horarioBuilder)

        horarioBuilder = "11-09-2001 " + npH2R.Value.ToString + ":" + npM2R.Value.ToString + ":00"
        horaSalidaR = DateTime.Parse(horarioBuilder)

        If flagHor = False Then

            Tbl_ConfigTableAdapter1.InsertarAlmuerzo(horaEntradaR, horaSalidaR)
        Else
            Tbl_ConfigTableAdapter1.ActualizarAlmuerzo(horaEntradaR, horaSalidaR, idConfig, idConfig)
        End If

    End Sub

    Private Sub ColocarHorario()

        Dim horaEntradaR As DateTime
        Dim horaSalidaR As DateTime

        Me.Tbl_ConfigTableAdapter1.ObtenerAlmuerzo(BDSistemaEySDataSet.tbl_Config, horaEntradaR, horaSalidaR)
        Me.idConfig = BDSistemaEySDataSet.tbl_Config.First.idConfig

        horaEntradaR = BDSistemaEySDataSet.tbl_Config.First.horarioAlmuerzoIn
        horaSalidaR = BDSistemaEySDataSet.tbl_Horario.First.horarioOut


        npH1R.Value = horaEntradaR.Hour
        npM1R.Value = horaEntradaR.Minute

        npH2R.Value = horaSalidaR.Hour
        npM2R.Value = horaSalidaR.Minute

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If (MessageBox.Show("¿Deseas cambiar el horario?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
            Return
        End If
        ConvertirHorarios()

        MessageBox.Show("Se ha guardado el horario", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Me.Close()
    End Sub
End Class