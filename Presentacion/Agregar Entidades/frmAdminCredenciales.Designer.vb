<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminCredenciales
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
        Me.gboxPrincipal = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtPassConfirm = New System.Windows.Forms.TextBox()
        Me.btnCon = New System.Windows.Forms.Button()
        Me.btnConCon = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.DgvCredenciales = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwUsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New SistemaEyS.BDSistemaEySDataSet()
        Me.VwUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_UsuarioTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.Vw_UsuarioTableAdapter()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.tblUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet1 = New SistemaEyS.BDSistemaEySDataSet()
        Me.Tbl_UsuarioTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.tbl_UsuarioTableAdapter()
        Me.gboxPrincipal.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DgvCredenciales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboxPrincipal
        '
        Me.gboxPrincipal.Controls.Add(Me.TableLayoutPanel1)
        Me.gboxPrincipal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxPrincipal.Location = New System.Drawing.Point(5, 46)
        Me.gboxPrincipal.Name = "gboxPrincipal"
        Me.gboxPrincipal.Size = New System.Drawing.Size(563, 150)
        Me.gboxPrincipal.TabIndex = 1
        Me.gboxPrincipal.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.94735!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30794!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.538087!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.19878!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.6572!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombre, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPass, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassConfirm, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCon, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnConCon, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbRol, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(545, 110)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(105, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(142, 23)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de usuario:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contraseña:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 30)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Confirmar contraseña:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(105, 39)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(142, 23)
        Me.txtPass.TabIndex = 5
        '
        'txtPassConfirm
        '
        Me.txtPassConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassConfirm.Location = New System.Drawing.Point(105, 75)
        Me.txtPassConfirm.Name = "txtPassConfirm"
        Me.txtPassConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassConfirm.Size = New System.Drawing.Size(142, 23)
        Me.txtPassConfirm.TabIndex = 6
        '
        'btnCon
        '
        Me.btnCon.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCon.Location = New System.Drawing.Point(269, 39)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(16, 21)
        Me.btnCon.TabIndex = 15
        Me.btnCon.Text = "*"
        Me.btnCon.UseVisualStyleBackColor = True
        '
        'btnConCon
        '
        Me.btnConCon.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConCon.Location = New System.Drawing.Point(269, 75)
        Me.btnConCon.Name = "btnConCon"
        Me.btnConCon.Size = New System.Drawing.Size(16, 21)
        Me.btnConCon.TabIndex = 14
        Me.btnConCon.Text = "*"
        Me.btnConCon.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(293, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Rol:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbRol
        '
        Me.cbRol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Items.AddRange(New Object() {"Sin empleado asignado"})
        Me.cbRol.Location = New System.Drawing.Point(368, 2)
        Me.cbRol.Margin = New System.Windows.Forms.Padding(2)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(158, 23)
        Me.cbRol.TabIndex = 7
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAgregar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnLimpiar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEliminar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 400)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(580, 33)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(504, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 23)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(425, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 23)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(346, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(73, 23)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(267, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(188, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'DgvCredenciales
        '
        Me.DgvCredenciales.AutoGenerateColumns = False
        Me.DgvCredenciales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvCredenciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCredenciales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.EmpleadoDataGridViewTextBoxColumn, Me.RolDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.IdRolDataGridViewTextBoxColumn})
        Me.DgvCredenciales.DataSource = Me.VwUsuarioBindingSource1
        Me.DgvCredenciales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvCredenciales.Location = New System.Drawing.Point(0, 202)
        Me.DgvCredenciales.Name = "DgvCredenciales"
        Me.DgvCredenciales.RowHeadersWidth = 51
        Me.DgvCredenciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCredenciales.Size = New System.Drawing.Size(580, 198)
        Me.DgvCredenciales.TabIndex = 13
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'EmpleadoDataGridViewTextBoxColumn
        '
        Me.EmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado"
        Me.EmpleadoDataGridViewTextBoxColumn.HeaderText = "Empleado"
        Me.EmpleadoDataGridViewTextBoxColumn.Name = "EmpleadoDataGridViewTextBoxColumn"
        Me.EmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RolDataGridViewTextBoxColumn
        '
        Me.RolDataGridViewTextBoxColumn.DataPropertyName = "Rol"
        Me.RolDataGridViewTextBoxColumn.HeaderText = "Rol"
        Me.RolDataGridViewTextBoxColumn.Name = "RolDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'IdRolDataGridViewTextBoxColumn
        '
        Me.IdRolDataGridViewTextBoxColumn.DataPropertyName = "idRol"
        Me.IdRolDataGridViewTextBoxColumn.HeaderText = "idRol"
        Me.IdRolDataGridViewTextBoxColumn.Name = "IdRolDataGridViewTextBoxColumn"
        '
        'VwUsuarioBindingSource1
        '
        Me.VwUsuarioBindingSource1.DataMember = "Vw_Usuario"
        Me.VwUsuarioBindingSource1.DataSource = Me.BDSistemaEySDataSet
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwUsuarioBindingSource
        '
        Me.VwUsuarioBindingSource.DataMember = "Vw_Usuario"
        Me.VwUsuarioBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'Vw_UsuarioTableAdapter
        '
        Me.Vw_UsuarioTableAdapter.ClearBeforeFill = True
        '
        'labelTitulo
        '
        Me.labelTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitulo.ForeColor = System.Drawing.Color.White
        Me.labelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(580, 43)
        Me.labelTitulo.TabIndex = 7
        Me.labelTitulo.Text = "Titulo"
        Me.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblUsuarioBindingSource
        '
        Me.tblUsuarioBindingSource.DataSource = Me.BDSistemaEySDataSet1
        Me.tblUsuarioBindingSource.Position = 0
        '
        'BDSistemaEySDataSet1
        '
        Me.BDSistemaEySDataSet1.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_UsuarioTableAdapter
        '
        Me.Tbl_UsuarioTableAdapter.ClearBeforeFill = True
        '
        'frmAdminCredenciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 433)
        Me.Controls.Add(Me.labelTitulo)
        Me.Controls.Add(Me.DgvCredenciales)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.gboxPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmAdminCredenciales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdminCredenciales"
        Me.gboxPrincipal.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DgvCredenciales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboxPrincipal As GroupBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbRol As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassConfirm As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents DgvCredenciales As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnConCon As Button
    Friend WithEvents btnCon As Button
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents VwUsuarioBindingSource As BindingSource
    Friend WithEvents Vw_UsuarioTableAdapter As BDSistemaEySDataSetTableAdapters.Vw_UsuarioTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VwUsuarioBindingSource1 As BindingSource
    Friend WithEvents labelTitulo As Label
    Friend WithEvents tblUsuarioBindingSource As BindingSource
    Friend WithEvents Tbl_UsuarioTableAdapter As BDSistemaEySDataSetTableAdapters.tbl_UsuarioTableAdapter
    Friend WithEvents BDSistemaEySDataSet1 As BDSistemaEySDataSet
End Class
