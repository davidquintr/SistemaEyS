Public Class FrmAddDepartamento

    Dim Dept As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim tblDept As New BDSistemaEySDataSet.tbl_DepartamentoDataTable
    Dim mode As Int16 = 0
    Dim idDept As Integer

    Sub llenarGrid()
        DgvDepartamentos.DataSource = Dept.GetData
        DgvDepartamentos.Refresh()
        DgvDepartamentos.Columns(0).Visible = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        MessageBox.Show("Si se ha introducido algun dato no seran guardados, seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nombre As String = txtNombre.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim ext As String = txtExt.Text.Trim()
        Dim Desc As String = rtxtDesc.Text.Trim()

        If txtNombre.Text = String.Empty Then
            MessageBox.Show("No puedes dejar el nombre en blanco", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("¿Deseas el nuevo departamento?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            Return
        End If

        Dept.RegistroDepAgreg(nombre, ext, email, Desc, 1)

        MessageBox.Show("Se ha guardado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        llenarGrid()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            If MessageBox.Show("¿Deseas eliminar el departamento?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                Return
            End If

            Dept.RegistroDepElim(idDept)
            llenarGrid()

            MessageBox.Show("Se ha eliminado con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try

    End Sub

    Public Sub CambiarModo(idDept As Integer)
        mode = 1
        Me.idDept = idDept
        Dept.Fill(tblDept)
        OrdenaDatos()
        AlternarBotones(0)
    End Sub

    Private Sub OrdenaDatos()
        Try
            txtNombre.Text = tblDept.Rows(idDept).Item(1)
            txtEmail.Text = tblDept.Rows(idDept).Item(3)
            txtExt.Text = tblDept.Rows(idDept).Item(2)
            rtxtDesc.Text = tblDept.Rows(idDept).Item(4)
        Catch

        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim id As Integer
        Dim nombre As String = txtNombre.Text.Trim
        Dim email As String = txtEmail.Text.Trim
        Dim ext As String = txtExt.Text.Trim
        Dim desc As String = rtxtDesc.Text.Trim
        Dim estado As Integer

        If txtNombre.Text = String.Empty Then
            MessageBox.Show("No puedes dejar el nombre en blanco", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("¿Deseas editar el departamento?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            Return
        End If


        Dept.RegistroDepAct(nombre, ext, email, desc, estado, idDept, id)

        MessageBox.Show("Se ha guardado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        llenarGrid()
    End Sub

    Private Sub FrmAddDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        AlternarBotones(1)
    End Sub

    Private Sub DgvDepartamentos_DoubleClick(sender As Object, e As EventArgs) Handles DgvDepartamentos.DoubleClick
        Try

            Dim fila As Integer = DgvDepartamentos.CurrentRow.Index
            idDept = DgvDepartamentos.Item(0, fila).Value
            txtNombre.Text = DgvDepartamentos.Item(1, fila).Value
            txtEmail.Text = DgvDepartamentos.Item(3, fila).Value
            txtExt.Text = DgvDepartamentos.Item(2, fila).Value
            rtxtDesc.Text = DgvDepartamentos.Item(4, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        AlternarBotones(0)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNombre.Text = ""
        txtEmail.Text = ""
        txtExt.Text = ""
        rtxtDesc.Text = ""
        AlternarBotones(1)
    End Sub

    Private Sub AlternarBotones(modo As Integer)

        If modo = 0 Then
            GroupBox1.Text = "Administrar Departamento"
            btnGuardar.Enabled = False
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Else
            GroupBox1.Text = "Agregar Departamento"
            btnGuardar.Enabled = True
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
        End If

    End Sub

End Class