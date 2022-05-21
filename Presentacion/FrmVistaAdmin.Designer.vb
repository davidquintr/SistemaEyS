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
        Me.ParámetrosGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistaPersonalizadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePersonalizadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportarUnProblemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailPersonalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailCorporativoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EstadoActividadDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAgregadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New SistemaEyS.BDSistemaEySDataSet()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tbl_EmpleadoTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter()
        Me.TableAdapterManager = New SistemaEyS.BDSistemaEySDataSetTableAdapters.TableAdapterManager()
        Me.hora = New System.Windows.Forms.Timer(Me.components)
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RestaurarEntidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1255, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirEntidadToolStripMenuItem, Me.ListarEntidadaToolStripMenuItem, Me.ParámetrosGeneralesToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'AñadirEntidadToolStripMenuItem
        '
        Me.AñadirEntidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem, Me.CargoToolStripMenuItem, Me.EmpleadoToolStripMenuItem})
        Me.AñadirEntidadToolStripMenuItem.Name = "AñadirEntidadToolStripMenuItem"
        Me.AñadirEntidadToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.AñadirEntidadToolStripMenuItem.Text = "Añadir entidad"
        '
        'DepartamentoToolStripMenuItem
        '
        Me.DepartamentoToolStripMenuItem.Name = "DepartamentoToolStripMenuItem"
        Me.DepartamentoToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.DepartamentoToolStripMenuItem.Text = "Departamento"
        '
        'CargoToolStripMenuItem
        '
        Me.CargoToolStripMenuItem.Name = "CargoToolStripMenuItem"
        Me.CargoToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.CargoToolStripMenuItem.Text = "Cargo"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'ListarEntidadaToolStripMenuItem
        '
        Me.ListarEntidadaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem1, Me.CargoToolStripMenuItem1, Me.EmpleadoToolStripMenuItem1})
        Me.ListarEntidadaToolStripMenuItem.Name = "ListarEntidadaToolStripMenuItem"
        Me.ListarEntidadaToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ListarEntidadaToolStripMenuItem.Text = "Listar entidad"
        '
        'DepartamentoToolStripMenuItem1
        '
        Me.DepartamentoToolStripMenuItem1.Name = "DepartamentoToolStripMenuItem1"
        Me.DepartamentoToolStripMenuItem1.Size = New System.Drawing.Size(189, 26)
        Me.DepartamentoToolStripMenuItem1.Text = "Departamento"
        '
        'CargoToolStripMenuItem1
        '
        Me.CargoToolStripMenuItem1.Name = "CargoToolStripMenuItem1"
        Me.CargoToolStripMenuItem1.Size = New System.Drawing.Size(189, 26)
        Me.CargoToolStripMenuItem1.Text = "Cargo"
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(189, 26)
        Me.EmpleadoToolStripMenuItem1.Text = "Empleado"
        '
        'ParámetrosGeneralesToolStripMenuItem
        '
        Me.ParámetrosGeneralesToolStripMenuItem.Name = "ParámetrosGeneralesToolStripMenuItem"
        Me.ParámetrosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ParámetrosGeneralesToolStripMenuItem.Text = "Parámetros generales"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VistaPersonalizadaToolStripMenuItem, Me.ReportePersonalizadoToolStripMenuItem, Me.ReporteGeneralToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VistaPersonalizadaToolStripMenuItem
        '
        Me.VistaPersonalizadaToolStripMenuItem.Name = "VistaPersonalizadaToolStripMenuItem"
        Me.VistaPersonalizadaToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.VistaPersonalizadaToolStripMenuItem.Text = "Vista personalizada"
        '
        'ReportePersonalizadoToolStripMenuItem
        '
        Me.ReportePersonalizadoToolStripMenuItem.Name = "ReportePersonalizadoToolStripMenuItem"
        Me.ReportePersonalizadoToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.ReportePersonalizadoToolStripMenuItem.Text = "Reporte personalizado"
        '
        'ReporteGeneralToolStripMenuItem
        '
        Me.ReporteGeneralToolStripMenuItem.Name = "ReporteGeneralToolStripMenuItem"
        Me.ReporteGeneralToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.ReporteGeneralToolStripMenuItem.Text = "Reporte general"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirToolStripMenuItem, Me.AdministrarToolStripMenuItem, Me.RestaurarEntidadesToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructivoToolStripMenuItem, Me.ReportarUnProblemaToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'InstructivoToolStripMenuItem
        '
        Me.InstructivoToolStripMenuItem.Name = "InstructivoToolStripMenuItem"
        Me.InstructivoToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.InstructivoToolStripMenuItem.Text = "Instructivo"
        '
        'ReportarUnProblemaToolStripMenuItem
        '
        Me.ReportarUnProblemaToolStripMenuItem.Name = "ReportarUnProblemaToolStripMenuItem"
        Me.ReportarUnProblemaToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.ReportarUnProblemaToolStripMenuItem.Text = "Reportar un problema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.DataGridView1)
        Me.Panel7.Location = New System.Drawing.Point(377, 113)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(859, 531)
        Me.Panel7.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.PrimerNombreDataGridViewTextBoxColumn, Me.SegundoNombreDataGridViewTextBoxColumn, Me.PrimerApellidoDataGridViewTextBoxColumn, Me.SegundoApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailPersonalDataGridViewTextBoxColumn, Me.EmailCorporativoDataGridViewTextBoxColumn, Me.SexoDataGridViewCheckBoxColumn, Me.EstadoActividadDataGridViewCheckBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.FechaIngresoDataGridViewTextBoxColumn, Me.FechaAgregadoDataGridViewTextBoxColumn, Me.IdCargoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Tbl_EmpleadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(5, 5)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(845, 494)
        Me.DataGridView1.TabIndex = 0
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpleadoDataGridViewTextBoxColumn.Width = 125
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.Width = 125
        '
        'PrimerNombreDataGridViewTextBoxColumn
        '
        Me.PrimerNombreDataGridViewTextBoxColumn.DataPropertyName = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.HeaderText = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrimerNombreDataGridViewTextBoxColumn.Name = "PrimerNombreDataGridViewTextBoxColumn"
        Me.PrimerNombreDataGridViewTextBoxColumn.Width = 125
        '
        'SegundoNombreDataGridViewTextBoxColumn
        '
        Me.SegundoNombreDataGridViewTextBoxColumn.DataPropertyName = "segundoNombre"
        Me.SegundoNombreDataGridViewTextBoxColumn.HeaderText = "segundoNombre"
        Me.SegundoNombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SegundoNombreDataGridViewTextBoxColumn.Name = "SegundoNombreDataGridViewTextBoxColumn"
        Me.SegundoNombreDataGridViewTextBoxColumn.Width = 125
        '
        'PrimerApellidoDataGridViewTextBoxColumn
        '
        Me.PrimerApellidoDataGridViewTextBoxColumn.DataPropertyName = "primerApellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.HeaderText = "primerApellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrimerApellidoDataGridViewTextBoxColumn.Name = "PrimerApellidoDataGridViewTextBoxColumn"
        Me.PrimerApellidoDataGridViewTextBoxColumn.Width = 125
        '
        'SegundoApellidoDataGridViewTextBoxColumn
        '
        Me.SegundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "segundoApellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.HeaderText = "segundoApellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SegundoApellidoDataGridViewTextBoxColumn.Name = "SegundoApellidoDataGridViewTextBoxColumn"
        Me.SegundoApellidoDataGridViewTextBoxColumn.Width = 125
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.Width = 125
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.Width = 125
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.Width = 125
        '
        'EmailPersonalDataGridViewTextBoxColumn
        '
        Me.EmailPersonalDataGridViewTextBoxColumn.DataPropertyName = "emailPersonal"
        Me.EmailPersonalDataGridViewTextBoxColumn.HeaderText = "emailPersonal"
        Me.EmailPersonalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailPersonalDataGridViewTextBoxColumn.Name = "EmailPersonalDataGridViewTextBoxColumn"
        Me.EmailPersonalDataGridViewTextBoxColumn.Width = 125
        '
        'EmailCorporativoDataGridViewTextBoxColumn
        '
        Me.EmailCorporativoDataGridViewTextBoxColumn.DataPropertyName = "emailCorporativo"
        Me.EmailCorporativoDataGridViewTextBoxColumn.HeaderText = "emailCorporativo"
        Me.EmailCorporativoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailCorporativoDataGridViewTextBoxColumn.Name = "EmailCorporativoDataGridViewTextBoxColumn"
        Me.EmailCorporativoDataGridViewTextBoxColumn.Width = 125
        '
        'SexoDataGridViewCheckBoxColumn
        '
        Me.SexoDataGridViewCheckBoxColumn.DataPropertyName = "sexo"
        Me.SexoDataGridViewCheckBoxColumn.HeaderText = "sexo"
        Me.SexoDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.SexoDataGridViewCheckBoxColumn.Name = "SexoDataGridViewCheckBoxColumn"
        Me.SexoDataGridViewCheckBoxColumn.Width = 125
        '
        'EstadoActividadDataGridViewCheckBoxColumn
        '
        Me.EstadoActividadDataGridViewCheckBoxColumn.DataPropertyName = "estadoActividad"
        Me.EstadoActividadDataGridViewCheckBoxColumn.HeaderText = "estadoActividad"
        Me.EstadoActividadDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.EstadoActividadDataGridViewCheckBoxColumn.Name = "EstadoActividadDataGridViewCheckBoxColumn"
        Me.EstadoActividadDataGridViewCheckBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
        '
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "fechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "fechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        Me.FechaNacDataGridViewTextBoxColumn.Width = 125
        '
        'FechaIngresoDataGridViewTextBoxColumn
        '
        Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "fechaIngreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "fechaIngreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
        Me.FechaIngresoDataGridViewTextBoxColumn.Width = 125
        '
        'FechaAgregadoDataGridViewTextBoxColumn
        '
        Me.FechaAgregadoDataGridViewTextBoxColumn.DataPropertyName = "fechaAgregado"
        Me.FechaAgregadoDataGridViewTextBoxColumn.HeaderText = "fechaAgregado"
        Me.FechaAgregadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaAgregadoDataGridViewTextBoxColumn.Name = "FechaAgregadoDataGridViewTextBoxColumn"
        Me.FechaAgregadoDataGridViewTextBoxColumn.Width = 125
        '
        'IdCargoDataGridViewTextBoxColumn
        '
        Me.IdCargoDataGridViewTextBoxColumn.DataPropertyName = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.HeaderText = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCargoDataGridViewTextBoxColumn.Name = "IdCargoDataGridViewTextBoxColumn"
        Me.IdCargoDataGridViewTextBoxColumn.Width = 125
        '
        'Tbl_EmpleadoBindingSource
        '
        Me.Tbl_EmpleadoBindingSource.DataMember = "tbl_Empleado"
        Me.Tbl_EmpleadoBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(377, 37)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(859, 68)
        Me.Panel6.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.lblHora)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(353, 738)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 636)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(337, 95)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eventos del mes"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(8, 378)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 2
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(8, 338)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(337, 28)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "HH:MM:SS"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(8, 23)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 311)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(377, 652)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(860, 123)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
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
        Me.TableAdapterManager.tbl_OpcCarTableAdapter = Nothing
        Me.TableAdapterManager.tbl_OpcionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_RegistroTableAdapter = Nothing
        Me.TableAdapterManager.tbl_UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaEyS.BDSistemaEySDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'RestaurarEntidadesToolStripMenuItem
        '
        Me.RestaurarEntidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem2, Me.CargoToolStripMenuItem2, Me.EmpleadoToolStripMenuItem2, Me.UsuarioToolStripMenuItem})
        Me.RestaurarEntidadesToolStripMenuItem.Name = "RestaurarEntidadesToolStripMenuItem"
        Me.RestaurarEntidadesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RestaurarEntidadesToolStripMenuItem.Text = "Restaurar entidades"
        '
        'DepartamentoToolStripMenuItem2
        '
        Me.DepartamentoToolStripMenuItem2.Name = "DepartamentoToolStripMenuItem2"
        Me.DepartamentoToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.DepartamentoToolStripMenuItem2.Text = "Departamento"
        '
        'CargoToolStripMenuItem2
        '
        Me.CargoToolStripMenuItem2.Name = "CargoToolStripMenuItem2"
        Me.CargoToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.CargoToolStripMenuItem2.Text = "Cargo"
        '
        'EmpleadoToolStripMenuItem2
        '
        Me.EmpleadoToolStripMenuItem2.Name = "EmpleadoToolStripMenuItem2"
        Me.EmpleadoToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.EmpleadoToolStripMenuItem2.Text = "Empleado"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'AñadirToolStripMenuItem
        '
        Me.AñadirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolToolStripMenuItem, Me.UsuarioToolStripMenuItem1})
        Me.AñadirToolStripMenuItem.Name = "AñadirToolStripMenuItem"
        Me.AñadirToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AñadirToolStripMenuItem.Text = "Añadir"
        '
        'RolToolStripMenuItem
        '
        Me.RolToolStripMenuItem.Name = "RolToolStripMenuItem"
        Me.RolToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RolToolStripMenuItem.Text = "Rol"
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.UsuarioToolStripMenuItem1.Text = "Usuario"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolToolStripMenuItem1, Me.UsuarioToolStripMenuItem2})
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        '
        'RolToolStripMenuItem1
        '
        Me.RolToolStripMenuItem1.Name = "RolToolStripMenuItem1"
        Me.RolToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.RolToolStripMenuItem1.Text = "Rol"
        '
        'UsuarioToolStripMenuItem2
        '
        Me.UsuarioToolStripMenuItem2.Name = "UsuarioToolStripMenuItem2"
        Me.UsuarioToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.UsuarioToolStripMenuItem2.Text = "Usuario"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'FrmVistaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 750)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1270, 724)
        Me.Name = "FrmVistaAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adminstracion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirEntidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ListarEntidadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParámetrosGeneralesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VistaPersonalizadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportePersonalizadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportarUnProblemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents lblHora As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents Tbl_EmpleadoBindingSource As BindingSource
    Friend WithEvents Tbl_EmpleadoTableAdapter As BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter
    Friend WithEvents TableAdapterManager As BDSistemaEySDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailPersonalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailCorporativoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EstadoActividadDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAgregadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents hora As Timer
    Friend WithEvents Time As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RestaurarEntidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
End Class
