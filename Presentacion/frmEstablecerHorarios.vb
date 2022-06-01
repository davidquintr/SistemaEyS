Public Class frmEstablecerHorarios

    Dim Horario As New BDSistemaEySDataSetTableAdapters.tbl_HorarioTableAdapter
    Dim idHorario As Integer

    Dim idCargo As Integer

    Private Sub frmEstablecerHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub CargarDatos(idCargo As Integer)
        Me.idCargo = idCargo
        Dim flagHor As Boolean = False
        Try
            If Not IsNothing(Me.Tbl_HorarioTableAdapter.ObtenerHorario(BDSistemaEySDataSet.tbl_Horario, idCargo, 1)) Then
                flagHor = True
            End If
        Catch ex As Exception
        End Try

        If flagHor = False Then

        End If


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MessageBox.Show("Desea guardar el horario?", "Confirmación", MessageBoxButtons.YesNoCancel)
    End Sub

    Private Sub checkReg_CheckedChanged(sender As Object, e As EventArgs) Handles checkReg.CheckedChanged
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

    End Sub

    Private Sub checkSab_CheckedChanged(sender As Object, e As EventArgs) Handles checkSab.CheckedChanged

    End Sub

    Private Sub checkDom_CheckedChanged(sender As Object, e As EventArgs) Handles checkDom.CheckedChanged

    End Sub

End Class