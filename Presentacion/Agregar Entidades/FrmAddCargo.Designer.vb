<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddCargo
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnHorario = New System.Windows.Forms.Button()
        Me.dgvCargos = New System.Windows.Forms.DataGridView()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbDep = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rtxtDesc = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.dgvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(507, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 25)
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAgregar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnLimpiar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHorario)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 313)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(583, 33)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(428, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 25)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(349, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(73, 25)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(270, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 25)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guadar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(191, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 25)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnHorario
        '
        Me.btnHorario.Location = New System.Drawing.Point(112, 3)
        Me.btnHorario.Name = "btnHorario"
        Me.btnHorario.Size = New System.Drawing.Size(73, 25)
        Me.btnHorario.TabIndex = 10
        Me.btnHorario.Text = "Horario"
        Me.btnHorario.UseVisualStyleBackColor = True
        '
        'dgvCargos
        '
        Me.dgvCargos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCargos.Location = New System.Drawing.Point(0, 163)
        Me.dgvCargos.Name = "dgvCargos"
        Me.dgvCargos.RowHeadersWidth = 51
        Me.dgvCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCargos.Size = New System.Drawing.Size(583, 150)
        Me.dgvCargos.TabIndex = 16
        '
        'labelTitulo
        '
        Me.labelTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitulo.ForeColor = System.Drawing.Color.White
        Me.labelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(583, 43)
        Me.labelTitulo.TabIndex = 4
        Me.labelTitulo.Text = "Titulo"
        Me.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.labelTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 43)
        Me.Panel1.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.96558!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.46471!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.96558!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.60413!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txbNombre, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbDep, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rtxtDesc, 3, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(553, 78)
        Me.TableLayoutPanel1.TabIndex = 3
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
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(113, 3)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(127, 23)
        Me.txbNombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Departamento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDep
        '
        Me.cbDep.FormattingEnabled = True
        Me.cbDep.Location = New System.Drawing.Point(113, 42)
        Me.cbDep.Name = "cbDep"
        Me.cbDep.Size = New System.Drawing.Size(126, 23)
        Me.cbDep.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(281, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Descripción:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtxtDesc
        '
        Me.rtxtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtDesc.Location = New System.Drawing.Point(391, 3)
        Me.rtxtDesc.Name = "rtxtDesc"
        Me.rtxtDesc.Size = New System.Drawing.Size(159, 33)
        Me.rtxtDesc.TabIndex = 5
        Me.rtxtDesc.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'FrmAddCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 346)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvCargos)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmAddCargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar cargo"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnHorario As Button
    Friend WithEvents dgvCargos As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents labelTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDep As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents rtxtDesc As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
