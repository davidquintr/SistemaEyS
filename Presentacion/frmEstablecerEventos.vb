Public Class frmEstablecerEventos

    Dim emp As New BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter
    Dim Evento As New BDSistemaEySDataSetTableAdapters.tbl_EventoTableAdapter

    Dim idEvento As Integer

    Sub llenarGrid()
        dgvEventos.DataSource = evento.GetData
        dgvEventos.Refresh()
        dgvEventos.Columns(0).Visible = False
    End Sub


    Sub llenarEmp()
        cbEmpleado.DataSource = emp.GetData()
        cbEmpleado.DisplayMember = "primerNombre"
        cbEmpleado.ValueMember = "idEmpleado"
        cbEmpleado.Refresh()
    End Sub

    Sub limpiar()
        txtEvento.Text = ""
        txtRazon.Text = ""
        rtbDescripcion.Text = ""
        dtpFechaInicio.Value = DateTime.Now
        dtpFechaFinal.Value = DateTime.Now
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim even As String = txtEvento.Text.Trim
        Dim fechaInicio As DateTime = dtpFechaInicio.Value.Date.ToString
        Dim fechaFinal As DateTime = dtpFechaFinal.Value.Date.ToString
        Dim Razon As String = txtRazon.Text.Trim
        Dim Desc As String = rtbDescripcion.Text.Trim
        Dim emp As Integer = CInt(cbEmpleado.SelectedValue)

        Evento.RegistroEventoAgreg(even, fechaInicio, fechaFinal, Razon, Desc, 1, emp)


        MessageBox.Show("Desea guardar el horario?", "Confirmación", MessageBoxButtons.YesNoCancel)

        llenarGrid()
        limpiar()
    End Sub

    Private Sub frmEstablecerEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarEmp()
        llenarGrid()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim resp As VariantType

            resp = (MsgBox("Seguro que se desea eliminar?", vbQuestion + vbYesNo, "Confirmación"))
            If (resp = vbYes) Then
                Evento.RegistroEventoElim(idEvento)
                llenarGrid()
                limpiar()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvEventos_DoubleClick(sender As Object, e As EventArgs) Handles dgvEventos.DoubleClick
        Try

            Dim fila As Integer = dgvEventos.CurrentRow.Index
            idEvento = dgvEventos.Item(0, fila).Value
            txtEvento.Text = dgvEventos.Item(7, fila).Value
            dtpFechaInicio.Value = dgvEventos.Item(1, fila).Value
            dtpFechaFinal.Value = dgvEventos.Item(2, fila).Value
            txtRazon.Text = dgvEventos.Item(3, fila).Value
            cbEmpleado.Text = dgvEventos.Item(6, fila).Value
            rtbDescripcion.Text = dgvEventos.Item(4, fila).Value


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim id As Integer
        Dim even As String = txtEvento.Text.Trim
        Dim fechaInicio As DateTime = dtpFechaInicio.Value.Date.ToString
        Dim fechaFinal As DateTime = dtpFechaFinal.Value.Date.ToString
        Dim Razon As String = txtRazon.Text.Trim
        Dim Desc As String = rtbDescripcion.Text.Trim
        Dim emp As Integer = CInt(cbEmpleado.SelectedValue)

        Evento.RegistroEventoAct(even, fechaInicio, fechaFinal, Razon, Desc, 1, emp, idEvento, id)

        llenarGrid()
    End Sub
End Class