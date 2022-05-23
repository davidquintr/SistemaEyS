Public Class FrmAddDepartamento

    Dim Dept As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim tblDept As New BDSistemaEySDataSet.tbl_DepartamentoDataTable
    Dim mode As Int16 = 0
    Dim idDept As Integer

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
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim resp As VariantType
            Dim id As Integer
            Dim nombre As String = txtNombre.Text
            Dim ext As String = txtExt.Text
            Dim email As String = txtEmail.Text
            Dim desc As String = rtxtDesc.Text
            Dim estado As Integer

            resp = (MsgBox("Seguro que se desea eliminar?", vbQuestion + vbYesNo, "Confirmación"))
            If (resp = vbYesNo) Then
                Dept.RegistroDepElim(id, nombre, ext, email, desc, estado)

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

        If (String.IsNullOrEmpty(txtID.Text)) Then
            MsgBox("Ningun campo puede quedar vacio", MsgBoxStyle.Critical, "Advertencia")
            txtID.Focus()
            Exit Sub
        End If

        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("Ningun campo puede quedar vacio", MsgBoxStyle.Critical, "Advertencia")
            txtNombre.Focus()
            Exit Sub
        End If

        If (String.IsNullOrEmpty(txtEmail.Text)) Then
            MsgBox("Ningun campo puede quedar vacio", MsgBoxStyle.Critical, "Advertencia")
            txtEmail.Focus()
            Exit Sub
        End If

        If (String.IsNullOrEmpty(txtExt.Text)) Then
            MsgBox("Ningun campo puede quedar vacio", MsgBoxStyle.Critical, "Advertencia")
            txtExt.Focus()
            Exit Sub
        End If

        If (String.IsNullOrEmpty(rtxtDesc.Text)) Then
            MsgBox("Ningun campo puede quedar vacio", MsgBoxStyle.Critical, "Advertencia")
            rtxtDesc.Focus()
            Exit Sub
        End If

        Dim id As Integer = txtID.Text.Trim
        Dim nombre As String = txtNombre.Text.Trim
        Dim email As String = txtEmail.Text.Trim
        Dim ext As String = txtExt.Text.Trim
        Dim desc As String = rtxtDesc.Text.Trim
        Dim estado As Integer

        Dept.RegistroDepAct(nombre, ext, email, desc, estado, idDept, id)

        OrdenaDatos()
    End Sub
End Class