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

        Dept.RegistroDepAgreg(nombre, ext, email, Desc, 1)

        MessageBox.Show("Seguro que se desea guardar?", "Confirmación", MessageBoxButtons.YesNoCancel)

        llenarGrid()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            Dim resp As VariantType

            resp = (MsgBox("Seguro que se desea eliminar?", vbQuestion + vbYesNo, "Confirmación"))
            If (resp = vbYes) Then
                Dept.RegistroDepElim(idDept)
                llenarGrid()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub CambiarModo(idDept As Integer)
        mode = 1
        btnEliminar.Visible = True
        btnEditar.Visible = True
        GroupBox1.Text = "Administrar Departamento"
        Me.idDept = idDept
        Dept.Fill(tblDept)
        OrdenaDatos()
    End Sub

    Private Sub OrdenaDatos()
        Try
            txtID.Text = tblDept.Rows(idDept).Item(0)
            txtNombre.Text = tblDept.Rows(idDept).Item(1)
            txtEmail.Text = tblDept.Rows(idDept).Item(3)
            txtExt.Text = tblDept.Rows(idDept).Item(2)
            rtxtDesc.Text = tblDept.Rows(idDept).Item(4)
        Catch

        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim id As Integer = CInt(txtID.Text.Trim)
        Dim nombre As String = txtNombre.Text.Trim
        Dim email As String = txtEmail.Text.Trim
        Dim ext As String = txtExt.Text.Trim
        Dim desc As String = rtxtDesc.Text.Trim
        Dim estado As Integer
        Dept.RegistroDepAct(nombre, ext, email, desc, estado, idDept, id)

        llenarGrid()
    End Sub

    Private Sub FrmAddDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
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
    End Sub
End Class