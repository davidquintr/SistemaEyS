<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarEmp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rtxtDireccion = New System.Windows.Forms.RichTextBox()
        Me.lblFechaIng = New System.Windows.Forms.Label()
        Me.rtxtObservacion = New System.Windows.Forms.RichTextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblActividad = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEmailPer = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEmailCorp = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.btnAnt = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.lbCantEmp = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnAdministrar = New System.Windows.Forms.Button()
        Me.btnOpExtra = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(565, 517)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listar empleado"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94928!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.05072!))
        Me.TableLayoutPanel1.Controls.Add(Me.rtxtDireccion, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFechaIng, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.rtxtObservacion, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTelefono, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label27, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.lblActividad, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFechaNac, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmailPer, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmailCorp, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCargo, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDepartamento, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCedula, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSexo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lblApellidos, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNombres, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.lblID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 13)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 30)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 15
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(552, 481)
        Me.TableLayoutPanel1.TabIndex = 34
        '
        'rtxtDireccion
        '
        Me.rtxtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.rtxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtDireccion.Enabled = False
        Me.rtxtDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.rtxtDireccion.Location = New System.Drawing.Point(219, 445)
        Me.rtxtDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtxtDireccion.Name = "rtxtDireccion"
        Me.rtxtDireccion.Size = New System.Drawing.Size(328, 29)
        Me.rtxtDireccion.TabIndex = 29
        Me.rtxtDireccion.Text = ""
        '
        'lblFechaIng
        '
        Me.lblFechaIng.AutoSize = True
        Me.lblFechaIng.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFechaIng.Location = New System.Drawing.Point(219, 310)
        Me.lblFechaIng.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaIng.Name = "lblFechaIng"
        Me.lblFechaIng.Size = New System.Drawing.Size(125, 20)
        Me.lblFechaIng.TabIndex = 21
        Me.lblFechaIng.Text = "Texto de ejemplo"
        Me.lblFechaIng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtxtObservacion
        '
        Me.rtxtObservacion.BackColor = System.Drawing.SystemColors.Window
        Me.rtxtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtObservacion.Enabled = False
        Me.rtxtObservacion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.rtxtObservacion.Location = New System.Drawing.Point(219, 407)
        Me.rtxtObservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtxtObservacion.Name = "rtxtObservacion"
        Me.rtxtObservacion.Size = New System.Drawing.Size(328, 30)
        Me.rtxtObservacion.TabIndex = 27
        Me.rtxtObservacion.Text = ""
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTelefono.Location = New System.Drawing.Point(219, 372)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(125, 20)
        Me.lblTelefono.TabIndex = 25
        Me.lblTelefono.Text = "Texto de ejemplo"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label27.Location = New System.Drawing.Point(4, 310)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(124, 20)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "Fecha de ingreso:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblActividad.Location = New System.Drawing.Point(219, 341)
        Me.lblActividad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(125, 20)
        Me.lblActividad.TabIndex = 23
        Me.lblActividad.Text = "Texto de ejemplo"
        Me.lblActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(4, 441)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 20)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Dirección:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(4, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFechaNac.Location = New System.Drawing.Point(219, 279)
        Me.lblFechaNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(125, 20)
        Me.lblFechaNac.TabIndex = 19
        Me.lblFechaNac.Text = "Texto de ejemplo"
        Me.lblFechaNac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(4, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sexo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmailPer
        '
        Me.lblEmailPer.AutoSize = True
        Me.lblEmailPer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmailPer.Location = New System.Drawing.Point(219, 248)
        Me.lblEmailPer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailPer.Name = "lblEmailPer"
        Me.lblEmailPer.Size = New System.Drawing.Size(125, 20)
        Me.lblEmailPer.TabIndex = 17
        Me.lblEmailPer.Text = "Texto de ejemplo"
        Me.lblEmailPer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(4, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cédula:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmailCorp
        '
        Me.lblEmailCorp.AutoSize = True
        Me.lblEmailCorp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmailCorp.Location = New System.Drawing.Point(219, 217)
        Me.lblEmailCorp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailCorp.Name = "lblEmailCorp"
        Me.lblEmailCorp.Size = New System.Drawing.Size(125, 20)
        Me.lblEmailCorp.TabIndex = 15
        Me.lblEmailCorp.Text = "Texto de ejemplo"
        Me.lblEmailCorp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(4, 155)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Departamento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCargo.Location = New System.Drawing.Point(219, 186)
        Me.lblCargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(125, 20)
        Me.lblCargo.TabIndex = 13
        Me.lblCargo.Text = "Texto de ejemplo"
        Me.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(4, 186)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cargo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDepartamento.Location = New System.Drawing.Point(219, 155)
        Me.lblDepartamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(125, 20)
        Me.lblDepartamento.TabIndex = 11
        Me.lblDepartamento.Text = "Texto de ejemplo"
        Me.lblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(4, 217)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Email corporativo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCedula.Location = New System.Drawing.Point(219, 124)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(138, 20)
        Me.lblCedula.TabIndex = 9
        Me.lblCedula.Text = "XXX-XXXXXX-XXXX"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(4, 248)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Email personal:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSexo.Location = New System.Drawing.Point(219, 93)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(35, 20)
        Me.lblSexo.TabIndex = 7
        Me.lblSexo.Text = "M/F"
        Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(4, 279)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Fecha de nacimiento:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblApellidos.Location = New System.Drawing.Point(219, 62)
        Me.lblApellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(125, 20)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "Texto de ejemplo"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(4, 341)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Actividad:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNombres.Location = New System.Drawing.Point(219, 31)
        Me.lblNombres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(125, 20)
        Me.lblNombres.TabIndex = 3
        Me.lblNombres.Text = "Texto de ejemplo"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(4, 372)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Teléfono:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblID.Location = New System.Drawing.Point(219, 0)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(81, 20)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "XXXXXXXX"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(4, 403)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 20)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Observación:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbEmpleado
        '
        Me.cbEmpleado.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(16, 539)
        Me.cbEmpleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(253, 31)
        Me.cbEmpleado.TabIndex = 30
        '
        'btnAnt
        '
        Me.btnAnt.Location = New System.Drawing.Point(277, 539)
        Me.btnAnt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnt.Size = New System.Drawing.Size(35, 33)
        Me.btnAnt.TabIndex = 31
        Me.btnAnt.Text = "<"
        Me.btnAnt.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        Me.btnSig.Location = New System.Drawing.Point(541, 537)
        Me.btnSig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSig.Size = New System.Drawing.Size(35, 33)
        Me.btnSig.TabIndex = 33
        Me.btnSig.Text = ">"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'lbCantEmp
        '
        Me.lbCantEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCantEmp.Location = New System.Drawing.Point(319, 539)
        Me.lbCantEmp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCantEmp.Name = "lbCantEmp"
        Me.lbCantEmp.Size = New System.Drawing.Size(213, 30)
        Me.lbCantEmp.TabIndex = 32
        Me.lbCantEmp.Text = "999/999"
        Me.lbCantEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReporte)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdministrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpExtra)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(16, 580)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(565, 37)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(441, 4)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(120, 28)
        Me.btnCerrar.TabIndex = 37
        Me.btnCerrar.Text = " Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(313, 4)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(120, 28)
        Me.btnReporte.TabIndex = 36
        Me.btnReporte.Text = "Generar reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnAdministrar
        '
        Me.btnAdministrar.Location = New System.Drawing.Point(185, 4)
        Me.btnAdministrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdministrar.Name = "btnAdministrar"
        Me.btnAdministrar.Size = New System.Drawing.Size(120, 28)
        Me.btnAdministrar.TabIndex = 35
        Me.btnAdministrar.Text = "Administrar"
        Me.btnAdministrar.UseVisualStyleBackColor = True
        '
        'btnOpExtra
        '
        Me.btnOpExtra.Location = New System.Drawing.Point(57, 4)
        Me.btnOpExtra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOpExtra.Name = "btnOpExtra"
        Me.btnOpExtra.Size = New System.Drawing.Size(120, 28)
        Me.btnOpExtra.TabIndex = 34
        Me.btnOpExtra.Text = "Eventos"
        Me.btnOpExtra.UseVisualStyleBackColor = True
        '
        'frmListarEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 630)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lbCantEmp)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.cbEmpleado)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmListarEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblActividad As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblEmailPer As Label
    Friend WithEvents lblEmailCorp As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblID As Label
    Friend WithEvents rtxtDireccion As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents rtxtObservacion As RichTextBox
    Friend WithEvents lblFechaIng As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents btnAnt As Button
    Friend WithEvents btnSig As Button
    Friend WithEvents lbCantEmp As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnAdministrar As Button
    Friend WithEvents btnOpExtra As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
