<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVistaAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim UsernameLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirEntidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarEntidadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ParámetrosGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePersonalizadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportarUnProblemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hora = New System.Windows.Forms.Timer(Me.components)
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDeEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDeSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwRegistrosDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New SistemaEyS.BDSistemaEySDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbEmp = New System.Windows.Forms.Label()
        Me.lbCargo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.labelHora = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Tbl_EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwVistaAdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_EmpleadoTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter()
        Me.TableAdapterManager = New SistemaEyS.BDSistemaEySDataSetTableAdapters.TableAdapterManager()
        Me.BDSistemaEySDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_VistaAdminTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.Vw_VistaAdminTableAdapter()
        Me.Vw_EmpDataTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.Vw_EmpDataTableAdapter()
        Me.Vw_EmpDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_UsuarioTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.Vw_UsuarioTableAdapter()
        Me.Vw_UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_RegistrosDiaTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.Vw_RegistrosDiaTableAdapter()
        UsernameLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwRegistrosDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Tbl_EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVistaAdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_EmpDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.BackColor = System.Drawing.Color.Transparent
        UsernameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.ForeColor = System.Drawing.Color.White
        UsernameLabel.Location = New System.Drawing.Point(0, 0)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(741, 50)
        UsernameLabel.TabIndex = 10
        UsernameLabel.Text = "Entradas del día"
        UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1039, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirEntidadToolStripMenuItem, Me.ListarEntidadaToolStripMenuItem, Me.ToolStripSeparator1, Me.ParámetrosGeneralesToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'AñadirEntidadToolStripMenuItem
        '
        Me.AñadirEntidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem, Me.CargoToolStripMenuItem, Me.EmpleadoToolStripMenuItem})
        Me.AñadirEntidadToolStripMenuItem.Name = "AñadirEntidadToolStripMenuItem"
        Me.AñadirEntidadToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AñadirEntidadToolStripMenuItem.Text = "Administrar"
        '
        'DepartamentoToolStripMenuItem
        '
        Me.DepartamentoToolStripMenuItem.Name = "DepartamentoToolStripMenuItem"
        Me.DepartamentoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DepartamentoToolStripMenuItem.Text = "Departamento"
        '
        'CargoToolStripMenuItem
        '
        Me.CargoToolStripMenuItem.Name = "CargoToolStripMenuItem"
        Me.CargoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CargoToolStripMenuItem.Text = "Cargo"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'ListarEntidadaToolStripMenuItem
        '
        Me.ListarEntidadaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem1, Me.CargoToolStripMenuItem1, Me.EmpleadoToolStripMenuItem1})
        Me.ListarEntidadaToolStripMenuItem.Name = "ListarEntidadaToolStripMenuItem"
        Me.ListarEntidadaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ListarEntidadaToolStripMenuItem.Text = "Listar"
        '
        'DepartamentoToolStripMenuItem1
        '
        Me.DepartamentoToolStripMenuItem1.Name = "DepartamentoToolStripMenuItem1"
        Me.DepartamentoToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.DepartamentoToolStripMenuItem1.Text = "Departamento"
        '
        'CargoToolStripMenuItem1
        '
        Me.CargoToolStripMenuItem1.Name = "CargoToolStripMenuItem1"
        Me.CargoToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.CargoToolStripMenuItem1.Text = "Cargo"
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.EmpleadoToolStripMenuItem1.Text = "Empleado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'ParámetrosGeneralesToolStripMenuItem
        '
        Me.ParámetrosGeneralesToolStripMenuItem.Name = "ParámetrosGeneralesToolStripMenuItem"
        Me.ParámetrosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ParámetrosGeneralesToolStripMenuItem.Text = "Parámetros generales"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportePersonalizadoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReportePersonalizadoToolStripMenuItem
        '
        Me.ReportePersonalizadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem2, Me.CargoToolStripMenuItem2, Me.DepartamentoToolStripMenuItem2})
        Me.ReportePersonalizadoToolStripMenuItem.Name = "ReportePersonalizadoToolStripMenuItem"
        Me.ReportePersonalizadoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ReportePersonalizadoToolStripMenuItem.Text = "Reporte personalizado"
        '
        'EmpleadoToolStripMenuItem2
        '
        Me.EmpleadoToolStripMenuItem2.Name = "EmpleadoToolStripMenuItem2"
        Me.EmpleadoToolStripMenuItem2.Size = New System.Drawing.Size(150, 22)
        Me.EmpleadoToolStripMenuItem2.Text = "Empleado"
        '
        'CargoToolStripMenuItem2
        '
        Me.CargoToolStripMenuItem2.Name = "CargoToolStripMenuItem2"
        Me.CargoToolStripMenuItem2.Size = New System.Drawing.Size(150, 22)
        Me.CargoToolStripMenuItem2.Text = "Cargo"
        '
        'DepartamentoToolStripMenuItem2
        '
        Me.DepartamentoToolStripMenuItem2.Name = "DepartamentoToolStripMenuItem2"
        Me.DepartamentoToolStripMenuItem2.Size = New System.Drawing.Size(150, 22)
        Me.DepartamentoToolStripMenuItem2.Text = "Departamento"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirToolStripMenuItem, Me.AdministrarToolStripMenuItem, Me.ToolStripSeparator2})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'AñadirToolStripMenuItem
        '
        Me.AñadirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolToolStripMenuItem, Me.UsuarioToolStripMenuItem1})
        Me.AñadirToolStripMenuItem.Name = "AñadirToolStripMenuItem"
        Me.AñadirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AñadirToolStripMenuItem.Text = "Añadir"
        '
        'RolToolStripMenuItem
        '
        Me.RolToolStripMenuItem.Name = "RolToolStripMenuItem"
        Me.RolToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RolToolStripMenuItem.Text = "Rol"
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.UsuarioToolStripMenuItem1.Text = "Usuario"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolToolStripMenuItem1, Me.UsuarioToolStripMenuItem2})
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdministrarToolStripMenuItem.Text = "Listar"
        '
        'RolToolStripMenuItem1
        '
        Me.RolToolStripMenuItem1.Name = "RolToolStripMenuItem1"
        Me.RolToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.RolToolStripMenuItem1.Text = "Rol"
        '
        'UsuarioToolStripMenuItem2
        '
        Me.UsuarioToolStripMenuItem2.Name = "UsuarioToolStripMenuItem2"
        Me.UsuarioToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.UsuarioToolStripMenuItem2.Text = "Usuario"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructivoToolStripMenuItem, Me.ReportarUnProblemaToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'InstructivoToolStripMenuItem
        '
        Me.InstructivoToolStripMenuItem.Name = "InstructivoToolStripMenuItem"
        Me.InstructivoToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.InstructivoToolStripMenuItem.Text = "Instructivo"
        '
        'ReportarUnProblemaToolStripMenuItem
        '
        Me.ReportarUnProblemaToolStripMenuItem.Name = "ReportarUnProblemaToolStripMenuItem"
        Me.ReportarUnProblemaToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ReportarUnProblemaToolStripMenuItem.Text = "Reportar un problema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'hora
        '
        Me.hora.Enabled = True
        '
        'Time
        '
        Me.Time.Enabled = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1039, 588)
        Me.Panel1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DepartamentoDataGridViewTextBoxColumn, Me.CargoDataGridViewTextBoxColumn, Me.HoraDeEntradaDataGridViewTextBoxColumn, Me.HoraDeSalidaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwRegistrosDiaBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(298, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(741, 438)
        Me.DataGridView1.TabIndex = 12
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        '
        'DepartamentoDataGridViewTextBoxColumn
        '
        Me.DepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.Name = "DepartamentoDataGridViewTextBoxColumn"
        '
        'CargoDataGridViewTextBoxColumn
        '
        Me.CargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo"
        Me.CargoDataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.CargoDataGridViewTextBoxColumn.Name = "CargoDataGridViewTextBoxColumn"
        '
        'HoraDeEntradaDataGridViewTextBoxColumn
        '
        Me.HoraDeEntradaDataGridViewTextBoxColumn.DataPropertyName = "Hora de Entrada"
        Me.HoraDeEntradaDataGridViewTextBoxColumn.HeaderText = "Hora de Entrada"
        Me.HoraDeEntradaDataGridViewTextBoxColumn.Name = "HoraDeEntradaDataGridViewTextBoxColumn"
        '
        'HoraDeSalidaDataGridViewTextBoxColumn
        '
        Me.HoraDeSalidaDataGridViewTextBoxColumn.DataPropertyName = "Hora de Salida"
        Me.HoraDeSalidaDataGridViewTextBoxColumn.HeaderText = "Hora de Salida"
        Me.HoraDeSalidaDataGridViewTextBoxColumn.Name = "HoraDeSalidaDataGridViewTextBoxColumn"
        '
        'VwRegistrosDiaBindingSource
        '
        Me.VwRegistrosDiaBindingSource.DataMember = "Vw_RegistrosDia"
        Me.VwRegistrosDiaBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.lbEmp)
        Me.Panel2.Controls.Add(Me.lbCargo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(298, 488)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 100)
        Me.Panel2.TabIndex = 10
        '
        'lbEmp
        '
        Me.lbEmp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbEmp.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmp.Location = New System.Drawing.Point(0, 44)
        Me.lbEmp.Name = "lbEmp"
        Me.lbEmp.Size = New System.Drawing.Size(641, 56)
        Me.lbEmp.TabIndex = 2
        Me.lbEmp.Text = "Empleado / Usuario"
        Me.lbEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCargo
        '
        Me.lbCargo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbCargo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCargo.Location = New System.Drawing.Point(0, 0)
        Me.lbCargo.Name = "lbCargo"
        Me.lbCargo.Size = New System.Drawing.Size(641, 44)
        Me.lbCargo.TabIndex = 1
        Me.lbCargo.Text = "Cargo / Rol"
        Me.lbCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Image = Global.SistemaEyS.My.Resources.Resources.userIcon
        Me.Label1.Location = New System.Drawing.Point(641, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 100)
        Me.Label1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(UsernameLabel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(298, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(741, 50)
        Me.Panel3.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.Controls.Add(Me.labelHora)
        Me.Panel4.Controls.Add(Me.RichTextBox1)
        Me.Panel4.Controls.Add(Me.MonthCalendar1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(298, 588)
        Me.Panel4.TabIndex = 3
        '
        'labelHora
        '
        Me.labelHora.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHora.ForeColor = System.Drawing.Color.Transparent
        Me.labelHora.Location = New System.Drawing.Point(9, 271)
        Me.labelHora.Name = "labelHora"
        Me.labelHora.Size = New System.Drawing.Size(283, 34)
        Me.labelHora.TabIndex = 3
        Me.labelHora.Text = "HH:MM:SS"
        Me.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 488)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(283, 90)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = "Eventos:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(9, 314)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Location = New System.Drawing.Point(9, 9)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(283, 252)
        Me.Panel5.TabIndex = 0
        '
        'Tbl_EmpleadoBindingSource
        '
        Me.Tbl_EmpleadoBindingSource.DataMember = "tbl_Empleado"
        Me.Tbl_EmpleadoBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'VwVistaAdminBindingSource
        '
        Me.VwVistaAdminBindingSource.DataMember = "Vw_VistaAdmin"
        Me.VwVistaAdminBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'Tbl_EmpleadoTableAdapter
        '
        Me.Tbl_EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_CargoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_ConfigTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_EmpleadoTableAdapter = Me.Tbl_EmpleadoTableAdapter
        Me.TableAdapterManager.tbl_EventoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HorarioTableAdapter = Nothing
        Me.TableAdapterManager.tbl_OpcionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_OpcRolTableAdapter = Nothing
        Me.TableAdapterManager.tbl_RegistroTableAdapter = Nothing
        Me.TableAdapterManager.tbl_RolTableAdapter = Nothing
        Me.TableAdapterManager.tbl_UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaEyS.BDSistemaEySDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BDSistemaEySDataSetBindingSource
        '
        Me.BDSistemaEySDataSetBindingSource.DataSource = Me.BDSistemaEySDataSet
        Me.BDSistemaEySDataSetBindingSource.Position = 0
        '
        'Vw_VistaAdminTableAdapter
        '
        Me.Vw_VistaAdminTableAdapter.ClearBeforeFill = True
        '
        'Vw_EmpDataTableAdapter
        '
        Me.Vw_EmpDataTableAdapter.ClearBeforeFill = True
        '
        'Vw_EmpDataBindingSource
        '
        Me.Vw_EmpDataBindingSource.DataSource = Me.BDSistemaEySDataSet
        Me.Vw_EmpDataBindingSource.Position = 0
        '
        'Vw_UsuarioTableAdapter
        '
        Me.Vw_UsuarioTableAdapter.ClearBeforeFill = True
        '
        'Vw_UsuarioBindingSource
        '
        Me.Vw_UsuarioBindingSource.DataSource = Me.BDSistemaEySDataSet
        Me.Vw_UsuarioBindingSource.Position = 0
        '
        'Vw_RegistrosDiaTableAdapter
        '
        Me.Vw_RegistrosDiaTableAdapter.ClearBeforeFill = True
        '
        'FrmVistaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1039, 612)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(956, 595)
        Me.Name = "FrmVistaAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adminstracion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwRegistrosDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.Tbl_EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVistaAdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_EmpDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirEntidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarEntidadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParámetrosGeneralesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportePersonalizadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportarUnProblemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents Tbl_EmpleadoBindingSource As BindingSource
    Friend WithEvents Tbl_EmpleadoTableAdapter As BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter
    Friend WithEvents TableAdapterManager As BDSistemaEySDataSetTableAdapters.TableAdapterManager
    Friend WithEvents hora As Timer
    Friend WithEvents Time As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AñadirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BDSistemaEySDataSetBindingSource As BindingSource
    Friend WithEvents VwVistaAdminBindingSource As BindingSource
    Friend WithEvents Vw_VistaAdminTableAdapter As BDSistemaEySDataSetTableAdapters.Vw_VistaAdminTableAdapter
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Timer2 As Timer
    Friend WithEvents EmpleadoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbEmp As Label
    Friend WithEvents lbCargo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents labelHora As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Vw_EmpDataTableAdapter As BDSistemaEySDataSetTableAdapters.Vw_EmpDataTableAdapter
    Friend WithEvents Vw_EmpDataBindingSource As BindingSource
    Friend WithEvents Vw_UsuarioTableAdapter As BDSistemaEySDataSetTableAdapters.Vw_UsuarioTableAdapter
    Friend WithEvents Vw_UsuarioBindingSource As BindingSource
    Friend WithEvents VwRegistrosDiaBindingSource As BindingSource
    Friend WithEvents Vw_RegistrosDiaTableAdapter As BDSistemaEySDataSetTableAdapters.Vw_RegistrosDiaTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraDeEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraDeSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
