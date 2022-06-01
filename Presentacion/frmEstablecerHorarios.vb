Public Class frmEstablecerHorarios

    Dim Horario As New BDSistemaEySDataSetTableAdapters.tbl_HorarioTableAdapter

    Dim idCargo As Integer
    Dim flagHor As Boolean = False

    Dim idHorario(3) As Integer


    Private Sub frmEstablecerHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub CargarDatos(idCargo As Integer)
        Me.idCargo = idCargo
        If (Me.Tbl_HorarioTableAdapter.ExisteHorario(idCargo) > 0) Then
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If checkReg.Checked = False And checkSab.Checked = False And checkDom.Checked = False Then
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

    Private Sub checkReg_CheckedChanged(sender As Object, e As EventArgs) Handles checkReg.CheckedChanged
        RecargarNumeric()
    End Sub

    Private Sub checkSab_CheckedChanged(sender As Object, e As EventArgs) Handles checkSab.CheckedChanged
        RecargarNumeric()

    End Sub

    Private Sub checkDom_CheckedChanged(sender As Object, e As EventArgs) Handles checkDom.CheckedChanged
        RecargarNumeric()
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

        If Not checkSab.Checked Then
            npH1S.Enabled = False
            npM1S.Enabled = False

            npH2S.Enabled = False
            npM2S.Enabled = False
        Else
            npH1S.Enabled = True
            npM1S.Enabled = True

            npH2S.Enabled = True
            npM2S.Enabled = True
        End If

        If Not checkDom.Checked Then
            npH1D.Enabled = False
            npM1D.Enabled = False

            npH2D.Enabled = False
            npM2D.Enabled = False
        Else
            npH1D.Enabled = True
            npM1D.Enabled = True

            npH2D.Enabled = True
            npM2D.Enabled = True
        End If

        MessageBox.Show(checkReg.Checked.ToString + " " + checkSab.Checked.ToString + " " + checkDom.Checked.ToString + " ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Question)

    End Sub

    Private Sub ConvertirHorarios()
        Dim horaEntradaR, horaEntradaS, horaEntradaD As DateTime
        Dim horaSalidaR, horaSalidaS, horaSalidaD As DateTime

        Dim horarioBuilder As String

        horarioBuilder = "11-09-2001 " + npH1R.Value.ToString + ":" + npM1R.Value.ToString + ":00"
        horaEntradaR = DateTime.Parse(horarioBuilder)

        horarioBuilder = "11-09-2001 " + npH2R.Value.ToString + ":" + npM2R.Value.ToString + ":00"
        horaSalidaR = DateTime.Parse(horarioBuilder)

        horarioBuilder = "11-09-2001 " + npH1S.Value.ToString + ":" + npM1S.Value.ToString + ":00"
        horaEntradaS = DateTime.Parse(horarioBuilder)

        horarioBuilder = "11-09-2001 " + npH2S.Value.ToString + ":" + npM2S.Value.ToString + ":00"
        horaSalidaS = DateTime.Parse(horarioBuilder)


        horarioBuilder = "11-09-2001 " + npH1D.Value.ToString + ":" + npM1D.Value.ToString + ":00"
        horaEntradaD = DateTime.Parse(horarioBuilder)

        horarioBuilder = "11-09-2001 " + npH2D.Value.ToString + ":" + npM2D.Value.ToString + ":00"
        horaSalidaD = DateTime.Parse(horarioBuilder)


        If flagHor = False Then
            Tbl_HorarioTableAdapter.InsertarHorario(horaEntradaR, horaSalidaR, 1, idCargo, checkReg.Checked)
            Tbl_HorarioTableAdapter.InsertarHorario(horaEntradaS, horaSalidaS, 2, idCargo, checkSab.Checked)
            Tbl_HorarioTableAdapter.InsertarHorario(horaEntradaD, horaSalidaD, 3, idCargo, checkDom.Checked)
        Else
            Tbl_HorarioTableAdapter.ActualizarHorario(horaEntradaR, horaSalidaR, 1, idCargo, checkReg.Checked, idHorario(0), idHorario(0))
            Tbl_HorarioTableAdapter.ActualizarHorario(horaEntradaS, horaSalidaS, 2, idCargo, checkSab.Checked, idHorario(1), idHorario(1))
            Tbl_HorarioTableAdapter.ActualizarHorario(horaEntradaD, horaSalidaD, 3, idCargo, checkDom.Checked, idHorario(2), idHorario(2))
        End If

    End Sub

    Private Sub ColocarHorario()
        Dim horaEntradaR, horaEntradaS, horaEntradaD As DateTime
        Dim horaSalidaR, horaSalidaS, horaSalidaD As DateTime

        Me.Tbl_HorarioTableAdapter.ObtenerHorario(BDSistemaEySDataSet.tbl_Horario, idCargo, 1)
        Me.idHorario(0) = BDSistemaEySDataSet.tbl_Horario.First.idHorario

        horaEntradaR = BDSistemaEySDataSet.tbl_Horario.First.horarioIn
        horaSalidaR = BDSistemaEySDataSet.tbl_Horario.First.horarioOut
        checkReg.Checked = BDSistemaEySDataSet.tbl_Horario.First.activo

        Me.Tbl_HorarioTableAdapter.ObtenerHorario(BDSistemaEySDataSet.tbl_Horario, idCargo, 2)
        Me.idHorario(1) = BDSistemaEySDataSet.tbl_Horario.First.idHorario

        horaEntradaS = BDSistemaEySDataSet.tbl_Horario.First.horarioIn
        horaSalidaS = BDSistemaEySDataSet.tbl_Horario.First.horarioOut
        checkSab.Checked = BDSistemaEySDataSet.tbl_Horario.First.activo

        Me.Tbl_HorarioTableAdapter.ObtenerHorario(BDSistemaEySDataSet.tbl_Horario, idCargo, 3)
        Me.idHorario(2) = BDSistemaEySDataSet.tbl_Horario.First.idHorario

        horaEntradaD = BDSistemaEySDataSet.tbl_Horario.First.horarioIn
        horaSalidaD = BDSistemaEySDataSet.tbl_Horario.First.horarioOut
        checkDom.Checked = BDSistemaEySDataSet.tbl_Horario.First.activo

        npH1R.Value = horaEntradaR.Hour
        npM1R.Value = horaEntradaR.Minute

        npH2R.Value = horaSalidaR.Hour
        npM2R.Value = horaSalidaR.Minute

        npH1S.Value = horaEntradaS.Hour
        npM1S.Value = horaEntradaS.Minute

        npH2S.Value = horaSalidaS.Hour
        npM2S.Value = horaSalidaS.Minute

        npH1D.Value = horaEntradaD.Hour
        npM1D.Value = horaEntradaD.Minute

        npH2D.Value = horaSalidaD.Hour
        npM2D.Value = horaSalidaD.Minute
    End Sub

End Class