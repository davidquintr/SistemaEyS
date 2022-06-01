<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVistaEmp
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbBienvenida = New System.Windows.Forms.Label()
        Me.lbHoraEntrada = New System.Windows.Forms.Label()
        Me.lbTiempoTrab = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnIng = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.buttonEntrada = New System.Windows.Forms.Button()
        Me.labelHora = New System.Windows.Forms.Label()
        Me.Vw_EmpDataTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.Vw_EmpDataTableAdapter()
        Me.Vw_EmpDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New SistemaEyS.BDSistemaEySDataSet()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.Vw_EmpDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 276)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.SteelBlue
        Me.FlowLayoutPanel2.Controls.Add(Me.lbBienvenida)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbHoraEntrada)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbTiempoTrab)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(235, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(393, 85)
        Me.FlowLayoutPanel2.TabIndex = 9
        '
        'lbBienvenida
        '
        Me.lbBienvenida.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBienvenida.ForeColor = System.Drawing.Color.White
        Me.lbBienvenida.Location = New System.Drawing.Point(3, 10)
        Me.lbBienvenida.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lbBienvenida.Name = "lbBienvenida"
        Me.lbBienvenida.Size = New System.Drawing.Size(390, 20)
        Me.lbBienvenida.TabIndex = 0
        Me.lbBienvenida.Text = "Buenos días, Nombre"
        Me.lbBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbHoraEntrada
        '
        Me.lbHoraEntrada.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoraEntrada.ForeColor = System.Drawing.Color.White
        Me.lbHoraEntrada.Location = New System.Drawing.Point(3, 30)
        Me.lbHoraEntrada.Name = "lbHoraEntrada"
        Me.lbHoraEntrada.Size = New System.Drawing.Size(387, 20)
        Me.lbHoraEntrada.TabIndex = 1
        Me.lbHoraEntrada.Text = "Hora de entrada: HH:MM"
        Me.lbHoraEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTiempoTrab
        '
        Me.lbTiempoTrab.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiempoTrab.ForeColor = System.Drawing.Color.White
        Me.lbTiempoTrab.Location = New System.Drawing.Point(3, 50)
        Me.lbTiempoTrab.Name = "lbTiempoTrab"
        Me.lbTiempoTrab.Size = New System.Drawing.Size(387, 20)
        Me.lbTiempoTrab.TabIndex = 2
        Me.lbTiempoTrab.Text = "Tiempo trabajado: HH:MM"
        Me.lbTiempoTrab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Controls.Add(Me.btnIng)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(235, 238)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(393, 38)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'btnIng
        '
        Me.btnIng.BackColor = System.Drawing.Color.SteelBlue
        Me.btnIng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnIng.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btnIng.FlatAppearance.BorderSize = 0
        Me.btnIng.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIng.ForeColor = System.Drawing.Color.White
        Me.btnIng.Location = New System.Drawing.Point(240, 3)
        Me.btnIng.Name = "btnIng"
        Me.btnIng.Size = New System.Drawing.Size(150, 32)
        Me.btnIng.TabIndex = 6
        Me.btnIng.Text = "Finalizar"
        Me.btnIng.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.labelHora)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 276)
        Me.Panel2.TabIndex = 7
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.buttonEntrada)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(235, 85)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(393, 153)
        Me.FlowLayoutPanel3.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(100, 53)
        Me.Button1.Margin = New System.Windows.Forms.Padding(100, 3, 15, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Marcar Salida"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(100, 91)
        Me.Button2.Margin = New System.Windows.Forms.Padding(100, 3, 15, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Almuerzo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'buttonEntrada
        '
        Me.buttonEntrada.AutoSize = True
        Me.buttonEntrada.BackColor = System.Drawing.SystemColors.ControlLight
        Me.buttonEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonEntrada.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.buttonEntrada.FlatAppearance.BorderSize = 0
        Me.buttonEntrada.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonEntrada.ForeColor = System.Drawing.Color.DimGray
        Me.buttonEntrada.Location = New System.Drawing.Point(100, 15)
        Me.buttonEntrada.Margin = New System.Windows.Forms.Padding(100, 15, 15, 3)
        Me.buttonEntrada.Name = "buttonEntrada"
        Me.buttonEntrada.Size = New System.Drawing.Size(216, 32)
        Me.buttonEntrada.TabIndex = 9
        Me.buttonEntrada.Text = "Marcar Entrada"
        Me.buttonEntrada.UseVisualStyleBackColor = False
        '
        'labelHora
        '
        Me.labelHora.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.labelHora.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHora.ForeColor = System.Drawing.Color.Transparent
        Me.labelHora.Location = New System.Drawing.Point(0, 242)
        Me.labelHora.Name = "labelHora"
        Me.labelHora.Size = New System.Drawing.Size(235, 34)
        Me.labelHora.TabIndex = 4
        Me.labelHora.Text = "HH:MM:SS"
        Me.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmVistaEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 276)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVistaEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada y Salida"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.Vw_EmpDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lbBienvenida As Label
    Friend WithEvents lbHoraEntrada As Label
    Friend WithEvents lbTiempoTrab As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnIng As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents buttonEntrada As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents labelHora As Label
    Friend WithEvents Vw_EmpDataTableAdapter As BDSistemaEySDataSetTableAdapters.Vw_EmpDataTableAdapter
    Friend WithEvents Vw_EmpDataBindingSource As BindingSource
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
End Class
