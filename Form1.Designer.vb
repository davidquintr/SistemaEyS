<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.lbInicioSesion = New System.Windows.Forms.Label()
        Me.btnIng = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BDSistemaEySDataSet = New SistemaEyS.BDSistemaEySDataSet()
        Me.Tbl_UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_UsuarioTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.tbl_UsuarioTableAdapter()
        Me.TableAdapterManager = New SistemaEyS.BDSistemaEySDataSetTableAdapters.TableAdapterManager()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(4, 0)
        UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(164, 23)
        UsernameLabel.TabIndex = 8
        UsernameLabel.Text = "Nombre de Usuario:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(4, 41)
        PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(101, 23)
        PasswordLabel.TabIndex = 9
        PasswordLabel.Text = "Contraseña:"
        AddHandler PasswordLabel.Click, AddressOf Me.PasswordLabel_Click
        '
        'lbInicioSesion
        '
        Me.lbInicioSesion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInicioSesion.ForeColor = System.Drawing.Color.Black
        Me.lbInicioSesion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbInicioSesion.Location = New System.Drawing.Point(16, 11)
        Me.lbInicioSesion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbInicioSesion.Name = "lbInicioSesion"
        Me.lbInicioSesion.Size = New System.Drawing.Size(556, 25)
        Me.lbInicioSesion.TabIndex = 0
        Me.lbInicioSesion.Text = "Inicio de sesión"
        Me.lbInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIng
        '
        Me.btnIng.Location = New System.Drawing.Point(174, 4)
        Me.btnIng.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnIng.Name = "btnIng"
        Me.btnIng.Size = New System.Drawing.Size(147, 31)
        Me.btnIng.TabIndex = 5
        Me.btnIng.Text = "Iniciar sesión"
        Me.btnIng.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnIng)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(16, 150)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(480, 40)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_UsuarioBindingSource
        '
        Me.Tbl_UsuarioBindingSource.DataMember = "tbl_Usuario"
        Me.Tbl_UsuarioBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'Tbl_UsuarioTableAdapter
        '
        Me.Tbl_UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_CargoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_ConfigTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_EventoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HorarioTableAdapter = Nothing
        Me.TableAdapterManager.tbl_OpcionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_OpcRolTableAdapter = Nothing
        Me.TableAdapterManager.tbl_RegistroTableAdapter = Nothing
        Me.TableAdapterManager.tbl_RolTableAdapter = Nothing
        Me.TableAdapterManager.tbl_UsuarioTableAdapter = Me.Tbl_UsuarioTableAdapter
        Me.TableAdapterManager.UpdateOrder = SistemaEyS.BDSistemaEySDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_UsuarioBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(184, 4)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(203, 22)
        Me.UsernameTextBox.TabIndex = 9
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_UsuarioBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(184, 45)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordTextBox.Size = New System.Drawing.Size(203, 22)
        Me.PasswordTextBox.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.35443!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.64557!))
        Me.TableLayoutPanel1.Controls.Add(Me.PasswordTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(PasswordLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(UsernameLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UsernameTextBox, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(77, 49)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(417, 82)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(512, 203)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lbInicioSesion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesion"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbInicioSesion As Label
    Friend WithEvents btnIng As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents Tbl_UsuarioBindingSource As BindingSource
    Friend WithEvents Tbl_UsuarioTableAdapter As BDSistemaEySDataSetTableAdapters.tbl_UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As BDSistemaEySDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
