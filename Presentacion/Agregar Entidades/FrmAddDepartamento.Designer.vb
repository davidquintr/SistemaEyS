<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddDepartamento
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
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rtxtDesc = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.DgvDepartamentos = New System.Windows.Forms.DataGridView()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DgvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEditar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnLimpiar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEliminar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 340)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(591, 33)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(515, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 25)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(436, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 25)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Nuevo"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(357, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(73, 25)
        Me.btnEditar.TabIndex = 12
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(278, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(73, 25)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(199, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 25)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.27493!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.72507!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExt, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rtxtDesc, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombre, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmail, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 18)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(563, 71)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(306, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ext:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExt
        '
        Me.txtExt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExt.Location = New System.Drawing.Point(385, 3)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(171, 23)
        Me.txtExt.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(306, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Descripción:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtxtDesc
        '
        Me.rtxtDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtDesc.Location = New System.Drawing.Point(385, 38)
        Me.rtxtDesc.Name = "rtxtDesc"
        Me.rtxtDesc.Size = New System.Drawing.Size(171, 23)
        Me.rtxtDesc.TabIndex = 9
        Me.rtxtDesc.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(122, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(126, 23)
        Me.txtNombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(122, 38)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(126, 23)
        Me.txtEmail.TabIndex = 5
        '
        'DgvDepartamentos
        '
        Me.DgvDepartamentos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDepartamentos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvDepartamentos.Location = New System.Drawing.Point(0, 153)
        Me.DgvDepartamentos.Name = "DgvDepartamentos"
        Me.DgvDepartamentos.RowHeadersWidth = 51
        Me.DgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDepartamentos.Size = New System.Drawing.Size(591, 187)
        Me.DgvDepartamentos.TabIndex = 15
        '
        'labelTitulo
        '
        Me.labelTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitulo.ForeColor = System.Drawing.Color.White
        Me.labelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(591, 43)
        Me.labelTitulo.TabIndex = 6
        Me.labelTitulo.Text = "Titulo"
        Me.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmAddDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 373)
        Me.Controls.Add(Me.labelTitulo)
        Me.Controls.Add(Me.DgvDepartamentos)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmAddDepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar departamento"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DgvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtExt As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents rtxtDesc As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnEditar As Button
    Friend WithEvents DgvDepartamentos As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents labelTitulo As Label
End Class
