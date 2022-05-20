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
        Me.AdministraciónDeCredencialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestauraciónDeEntidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportarUnProblemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BDSistemaEySDataSet = New SistemaEyS.BDSistemaEySDataSet()
        Me.Tbl_EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_EmpleadoTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter()
        Me.TableAdapterManager = New SistemaEyS.BDSistemaEySDataSetTableAdapters.TableAdapterManager()
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
        Me.MenuStrip1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirEntidadToolStripMenuItem, Me.ListarEntidadaToolStripMenuItem, Me.ParámetrosGeneralesToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'AñadirEntidadToolStripMenuItem
        '
        Me.AñadirEntidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem, Me.CargoToolStripMenuItem, Me.EmpleadoToolStripMenuItem})
        Me.AñadirEntidadToolStripMenuItem.Name = "AñadirEntidadToolStripMenuItem"
        Me.AñadirEntidadToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AñadirEntidadToolStripMenuItem.Text = "Añadir entidad"
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
        Me.ListarEntidadaToolStripMenuItem.Text = "Listar entidad"
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
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VistaPersonalizadaToolStripMenuItem, Me.ReportePersonalizadoToolStripMenuItem, Me.ReporteGeneralToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VistaPersonalizadaToolStripMenuItem
        '
        Me.VistaPersonalizadaToolStripMenuItem.Name = "VistaPersonalizadaToolStripMenuItem"
        Me.VistaPersonalizadaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.VistaPersonalizadaToolStripMenuItem.Text = "Vista personalizada"
        '
        'ReportePersonalizadoToolStripMenuItem
        '
        Me.ReportePersonalizadoToolStripMenuItem.Name = "ReportePersonalizadoToolStripMenuItem"
        Me.ReportePersonalizadoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ReportePersonalizadoToolStripMenuItem.Text = "Reporte personalizado"
        '
        'ReporteGeneralToolStripMenuItem
        '
        Me.ReporteGeneralToolStripMenuItem.Name = "ReporteGeneralToolStripMenuItem"
        Me.ReporteGeneralToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ReporteGeneralToolStripMenuItem.Text = "Reporte general"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónDeCredencialesToolStripMenuItem, Me.RestauraciónDeEntidadesToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'AdministraciónDeCredencialesToolStripMenuItem
        '
        Me.AdministraciónDeCredencialesToolStripMenuItem.Name = "AdministraciónDeCredencialesToolStripMenuItem"
        Me.AdministraciónDeCredencialesToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AdministraciónDeCredencialesToolStripMenuItem.Text = "Administración de credenciales"
        '
        'RestauraciónDeEntidadesToolStripMenuItem
        '
        Me.RestauraciónDeEntidadesToolStripMenuItem.Name = "RestauraciónDeEntidadesToolStripMenuItem"
        Me.RestauraciónDeEntidadesToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.RestauraciónDeEntidadesToolStripMenuItem.Text = "Restauración de entidades"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
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
        'Panel7
        '
        Me.Panel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.DataGridView1)
        Me.Panel7.Location = New System.Drawing.Point(283, 92)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(645, 432)
        Me.Panel7.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(283, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(645, 56)
        Me.Panel6.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 600)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 517)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 77)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eventos del mes"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(6, 307)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HH:MM:SS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 253)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(283, 530)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(645, 100)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.PrimerNombreDataGridViewTextBoxColumn, Me.SegundoNombreDataGridViewTextBoxColumn, Me.PrimerApellidoDataGridViewTextBoxColumn, Me.SegundoApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailPersonalDataGridViewTextBoxColumn, Me.EmailCorporativoDataGridViewTextBoxColumn, Me.SexoDataGridViewCheckBoxColumn, Me.EstadoActividadDataGridViewCheckBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.FechaIngresoDataGridViewTextBoxColumn, Me.FechaAgregadoDataGridViewTextBoxColumn, Me.IdCargoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Tbl_EmpleadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(634, 401)
        Me.DataGridView1.TabIndex = 0
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_EmpleadoBindingSource
        '
        Me.Tbl_EmpleadoBindingSource.DataMember = "tbl_Empleado"
        Me.Tbl_EmpleadoBindingSource.DataSource = Me.BDSistemaEySDataSet
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
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        '
        'PrimerNombreDataGridViewTextBoxColumn
        '
        Me.PrimerNombreDataGridViewTextBoxColumn.DataPropertyName = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.HeaderText = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.Name = "PrimerNombreDataGridViewTextBoxColumn"
        '
        'SegundoNombreDataGridViewTextBoxColumn
        '
        Me.SegundoNombreDataGridViewTextBoxColumn.DataPropertyName = "segundoNombre"
        Me.SegundoNombreDataGridViewTextBoxColumn.HeaderText = "segundoNombre"
        Me.SegundoNombreDataGridViewTextBoxColumn.Name = "SegundoNombreDataGridViewTextBoxColumn"
        '
        'PrimerApellidoDataGridViewTextBoxColumn
        '
        Me.PrimerApellidoDataGridViewTextBoxColumn.DataPropertyName = "primerApellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.HeaderText = "primerApellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.Name = "PrimerApellidoDataGridViewTextBoxColumn"
        '
        'SegundoApellidoDataGridViewTextBoxColumn
        '
        Me.SegundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "segundoApellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.HeaderText = "segundoApellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.Name = "SegundoApellidoDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'EmailPersonalDataGridViewTextBoxColumn
        '
        Me.EmailPersonalDataGridViewTextBoxColumn.DataPropertyName = "emailPersonal"
        Me.EmailPersonalDataGridViewTextBoxColumn.HeaderText = "emailPersonal"
        Me.EmailPersonalDataGridViewTextBoxColumn.Name = "EmailPersonalDataGridViewTextBoxColumn"
        '
        'EmailCorporativoDataGridViewTextBoxColumn
        '
        Me.EmailCorporativoDataGridViewTextBoxColumn.DataPropertyName = "emailCorporativo"
        Me.EmailCorporativoDataGridViewTextBoxColumn.HeaderText = "emailCorporativo"
        Me.EmailCorporativoDataGridViewTextBoxColumn.Name = "EmailCorporativoDataGridViewTextBoxColumn"
        '
        'SexoDataGridViewCheckBoxColumn
        '
        Me.SexoDataGridViewCheckBoxColumn.DataPropertyName = "sexo"
        Me.SexoDataGridViewCheckBoxColumn.HeaderText = "sexo"
        Me.SexoDataGridViewCheckBoxColumn.Name = "SexoDataGridViewCheckBoxColumn"
        '
        'EstadoActividadDataGridViewCheckBoxColumn
        '
        Me.EstadoActividadDataGridViewCheckBoxColumn.DataPropertyName = "estadoActividad"
        Me.EstadoActividadDataGridViewCheckBoxColumn.HeaderText = "estadoActividad"
        Me.EstadoActividadDataGridViewCheckBoxColumn.Name = "EstadoActividadDataGridViewCheckBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "fechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "fechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        '
        'FechaIngresoDataGridViewTextBoxColumn
        '
        Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "fechaIngreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "fechaIngreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
        '
        'FechaAgregadoDataGridViewTextBoxColumn
        '
        Me.FechaAgregadoDataGridViewTextBoxColumn.DataPropertyName = "fechaAgregado"
        Me.FechaAgregadoDataGridViewTextBoxColumn.HeaderText = "fechaAgregado"
        Me.FechaAgregadoDataGridViewTextBoxColumn.Name = "FechaAgregadoDataGridViewTextBoxColumn"
        '
        'IdCargoDataGridViewTextBoxColumn
        '
        Me.IdCargoDataGridViewTextBoxColumn.DataPropertyName = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.HeaderText = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.Name = "IdCargoDataGridViewTextBoxColumn"
        '
        'FrmVistaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 609)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(957, 597)
        Me.Name = "FrmVistaAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adminstracion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministraciónDeCredencialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestauraciónDeEntidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
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
End Class
