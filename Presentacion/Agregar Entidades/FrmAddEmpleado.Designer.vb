<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnDarDeBaja = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbCar = New System.Windows.Forms.ComboBox()
        Me.txtEmailC = New System.Windows.Forms.TextBox()
        Me.cbDep = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.rtxtObservacion = New System.Windows.Forms.RichTextBox()
        Me.txtEmailP = New System.Windows.Forms.TextBox()
        Me.rtxtDireccion = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbAll = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpNac = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panelSexo = New System.Windows.Forms.FlowLayoutPanel()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.gbAll.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panelSexo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnLimpiar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEditar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDarDeBaja)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(16, 586)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(839, 41)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(738, 4)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(97, 31)
        Me.btnCerrar.TabIndex = 27
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(598, 4)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 31)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Agregar empleado"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(458, 4)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(132, 31)
        Me.btnLimpiar.TabIndex = 29
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(318, 4)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(132, 31)
        Me.btnEditar.TabIndex = 28
        Me.btnEditar.Text = "Guardar cambios"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnDarDeBaja
        '
        Me.btnDarDeBaja.Location = New System.Drawing.Point(178, 4)
        Me.btnDarDeBaja.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDarDeBaja.Name = "btnDarDeBaja"
        Me.btnDarDeBaja.Size = New System.Drawing.Size(132, 31)
        Me.btnDarDeBaja.TabIndex = 25
        Me.btnDarDeBaja.Text = "Eliminar"
        Me.btnDarDeBaja.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 132)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Observación:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Teléfono:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 99)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Sexo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbCar
        '
        Me.cbCar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCar.FormattingEnabled = True
        Me.cbCar.Location = New System.Drawing.Point(177, 136)
        Me.cbCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCar.Name = "cbCar"
        Me.cbCar.Size = New System.Drawing.Size(199, 28)
        Me.cbCar.TabIndex = 18
        '
        'txtEmailC
        '
        Me.txtEmailC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailC.Location = New System.Drawing.Point(177, 169)
        Me.txtEmailC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmailC.Name = "txtEmailC"
        Me.txtEmailC.Size = New System.Drawing.Size(199, 27)
        Me.txtEmailC.TabIndex = 20
        '
        'cbDep
        '
        Me.cbDep.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDep.FormattingEnabled = True
        Me.cbDep.ItemHeight = 20
        Me.cbDep.Location = New System.Drawing.Point(177, 103)
        Me.cbDep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbDep.Name = "cbDep"
        Me.cbDep.Size = New System.Drawing.Size(199, 28)
        Me.cbDep.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 33)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Fecha de Nacimiento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(177, 70)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(199, 27)
        Me.txtApellidos.TabIndex = 10
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(170, 4)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(249, 27)
        Me.txtTelefono.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(177, 37)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(199, 27)
        Me.txtNombre.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 165)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Dirección:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(177, 4)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(199, 27)
        Me.txtCedula.TabIndex = 1
        '
        'rbMasculino
        '
        Me.rbMasculino.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMasculino.Location = New System.Drawing.Point(4, 43)
        Me.rbMasculino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(119, 31)
        Me.rbMasculino.TabIndex = 7
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'rbFemenino
        '
        Me.rbFemenino.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFemenino.Location = New System.Drawing.Point(4, 4)
        Me.rbFemenino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(119, 31)
        Me.rbFemenino.TabIndex = 8
        Me.rbFemenino.Text = "Femenino"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(170, 70)
        Me.dtpFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(249, 27)
        Me.dtpFechaIngreso.TabIndex = 12
        '
        'rtxtObservacion
        '
        Me.rtxtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtObservacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtObservacion.Location = New System.Drawing.Point(170, 136)
        Me.rtxtObservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtxtObservacion.Name = "rtxtObservacion"
        Me.rtxtObservacion.Size = New System.Drawing.Size(249, 25)
        Me.rtxtObservacion.TabIndex = 16
        Me.rtxtObservacion.Text = ""
        '
        'txtEmailP
        '
        Me.txtEmailP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailP.Location = New System.Drawing.Point(177, 202)
        Me.txtEmailP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmailP.Name = "txtEmailP"
        Me.txtEmailP.Size = New System.Drawing.Size(199, 27)
        Me.txtEmailP.TabIndex = 24
        '
        'rtxtDireccion
        '
        Me.rtxtDireccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtDireccion.Location = New System.Drawing.Point(170, 169)
        Me.rtxtDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtxtDireccion.Name = "rtxtDireccion"
        Me.rtxtDireccion.Size = New System.Drawing.Size(249, 25)
        Me.rtxtDireccion.TabIndex = 22
        Me.rtxtDireccion.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Departamento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 132)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cargo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Email corporativo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Apellidos:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 198)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Email personal:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbAll
        '
        Me.gbAll.Controls.Add(Me.TableLayoutPanel2)
        Me.gbAll.Controls.Add(Me.TableLayoutPanel1)
        Me.gbAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAll.Location = New System.Drawing.Point(16, 15)
        Me.gbAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbAll.Name = "gbAll"
        Me.gbAll.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbAll.Size = New System.Drawing.Size(839, 281)
        Me.gbAll.TabIndex = 0
        Me.gbAll.TabStop = False
        Me.gbAll.Text = "ACCION - Empleado"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.36842!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.63158!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpNac, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTelefono, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rtxtDireccion, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.rtxtObservacion, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.panelSexo, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpFechaIngreso, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cbUsuario, 1, 6)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(409, 33)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(423, 235)
        Me.TableLayoutPanel2.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 198)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 20)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Usuario:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpNac
        '
        Me.dtpNac.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNac.Location = New System.Drawing.Point(170, 37)
        Me.dtpNac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNac.Name = "dtpNac"
        Me.dtpNac.Size = New System.Drawing.Size(249, 27)
        Me.dtpNac.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 66)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 20)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Fecha de ingreso:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelSexo
        '
        Me.panelSexo.Controls.Add(Me.rbFemenino)
        Me.panelSexo.Controls.Add(Me.rbMasculino)
        Me.panelSexo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelSexo.Location = New System.Drawing.Point(169, 101)
        Me.panelSexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelSexo.Name = "panelSexo"
        Me.panelSexo.Size = New System.Drawing.Size(251, 27)
        Me.panelSexo.TabIndex = 13
        '
        'cbUsuario
        '
        Me.cbUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(170, 202)
        Me.cbUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(249, 28)
        Me.cbUsuario.TabIndex = 29
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.73464!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.26536!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmailP, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCedula, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtApellidos, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmailC, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cbDep, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cbCar, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 33)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(396, 235)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Location = New System.Drawing.Point(23, 303)
        Me.DgvEmpleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.RowHeadersWidth = 51
        Me.DgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleado.Size = New System.Drawing.Size(832, 276)
        Me.DgvEmpleado.TabIndex = 5
        '
        'FrmAddEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 641)
        Me.Controls.Add(Me.DgvEmpleado)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.gbAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmAddEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar empleado"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.gbAll.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.panelSexo.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbCar As ComboBox
    Friend WithEvents txtEmailC As TextBox
    Friend WithEvents cbDep As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents rtxtObservacion As RichTextBox
    Friend WithEvents txtEmailP As TextBox
    Friend WithEvents rtxtDireccion As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gbAll As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dtpNac As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents panelSexo As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnEditar As Button
    Friend WithEvents DgvEmpleado As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents btnLimpiar As Button
    Private WithEvents btnDarDeBaja As Button
End Class
