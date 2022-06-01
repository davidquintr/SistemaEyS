<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosGen
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.labelParametros = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.buttonAjustes = New System.Windows.Forms.Button()
        Me.btnEmpresa = New System.Windows.Forms.Button()
        Me.layoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnExtras = New System.Windows.Forms.Button()
        Me.btnNombreEmpresa = New System.Windows.Forms.Button()
        Me.btnHorarioAlmuerzo = New System.Windows.Forms.Button()
        Me.btnTGracia = New System.Windows.Forms.Button()
        Me.btnDominio = New System.Windows.Forms.Button()
        Me.btnIng = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.layoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.labelParametros)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(641, 43)
        Me.Panel2.TabIndex = 0
        '
        'labelParametros
        '
        Me.labelParametros.BackColor = System.Drawing.Color.SteelBlue
        Me.labelParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelParametros.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelParametros.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelParametros.Location = New System.Drawing.Point(0, 0)
        Me.labelParametros.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.labelParametros.Name = "labelParametros"
        Me.labelParametros.Size = New System.Drawing.Size(641, 43)
        Me.labelParametros.TabIndex = 0
        Me.labelParametros.Text = "Parámetros Generales"
        Me.labelParametros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel2.Controls.Add(Me.btnIng)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 509)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(641, 39)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.SteelBlue
        Me.FlowLayoutPanel3.Controls.Add(Me.buttonAjustes)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnEmpresa)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 43)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(311, 466)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'buttonAjustes
        '
        Me.buttonAjustes.Location = New System.Drawing.Point(3, 3)
        Me.buttonAjustes.Name = "buttonAjustes"
        Me.buttonAjustes.Size = New System.Drawing.Size(298, 46)
        Me.buttonAjustes.TabIndex = 1
        Me.buttonAjustes.Text = "Ajustes extras"
        Me.buttonAjustes.UseVisualStyleBackColor = True
        '
        'btnEmpresa
        '
        Me.btnEmpresa.Location = New System.Drawing.Point(3, 55)
        Me.btnEmpresa.Name = "btnEmpresa"
        Me.btnEmpresa.Size = New System.Drawing.Size(298, 46)
        Me.btnEmpresa.TabIndex = 2
        Me.btnEmpresa.Text = "Empresa"
        Me.btnEmpresa.UseVisualStyleBackColor = True
        Me.btnEmpresa.Visible = False
        '
        'layoutPanel
        '
        Me.layoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.layoutPanel.Controls.Add(Me.btnExtras)
        Me.layoutPanel.Controls.Add(Me.btnNombreEmpresa)
        Me.layoutPanel.Controls.Add(Me.btnHorarioAlmuerzo)
        Me.layoutPanel.Controls.Add(Me.btnTGracia)
        Me.layoutPanel.Controls.Add(Me.btnDominio)
        Me.layoutPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.layoutPanel.Location = New System.Drawing.Point(307, 43)
        Me.layoutPanel.Name = "layoutPanel"
        Me.layoutPanel.Size = New System.Drawing.Size(334, 466)
        Me.layoutPanel.TabIndex = 8
        '
        'btnExtras
        '
        Me.btnExtras.Location = New System.Drawing.Point(10, 3)
        Me.btnExtras.Name = "btnExtras"
        Me.btnExtras.Size = New System.Drawing.Size(321, 46)
        Me.btnExtras.TabIndex = 2
        Me.btnExtras.Text = "Ajustes extras"
        Me.btnExtras.UseVisualStyleBackColor = True
        '
        'btnNombreEmpresa
        '
        Me.btnNombreEmpresa.Location = New System.Drawing.Point(10, 55)
        Me.btnNombreEmpresa.Name = "btnNombreEmpresa"
        Me.btnNombreEmpresa.Size = New System.Drawing.Size(321, 46)
        Me.btnNombreEmpresa.TabIndex = 3
        Me.btnNombreEmpresa.Text = "Nombre de la Empresa"
        Me.btnNombreEmpresa.UseVisualStyleBackColor = True
        Me.btnNombreEmpresa.Visible = False
        '
        'btnHorarioAlmuerzo
        '
        Me.btnHorarioAlmuerzo.Location = New System.Drawing.Point(10, 107)
        Me.btnHorarioAlmuerzo.Name = "btnHorarioAlmuerzo"
        Me.btnHorarioAlmuerzo.Size = New System.Drawing.Size(321, 46)
        Me.btnHorarioAlmuerzo.TabIndex = 4
        Me.btnHorarioAlmuerzo.Text = "Horario de almuerzo"
        Me.btnHorarioAlmuerzo.UseVisualStyleBackColor = True
        Me.btnHorarioAlmuerzo.Visible = False
        '
        'btnTGracia
        '
        Me.btnTGracia.Location = New System.Drawing.Point(10, 159)
        Me.btnTGracia.Name = "btnTGracia"
        Me.btnTGracia.Size = New System.Drawing.Size(321, 46)
        Me.btnTGracia.TabIndex = 5
        Me.btnTGracia.Text = "Tiempo de gracia"
        Me.btnTGracia.UseVisualStyleBackColor = True
        Me.btnTGracia.Visible = False
        '
        'btnDominio
        '
        Me.btnDominio.Location = New System.Drawing.Point(10, 211)
        Me.btnDominio.Name = "btnDominio"
        Me.btnDominio.Size = New System.Drawing.Size(321, 46)
        Me.btnDominio.TabIndex = 6
        Me.btnDominio.Text = "Dominio de la empresa(@)"
        Me.btnDominio.UseVisualStyleBackColor = True
        Me.btnDominio.Visible = False
        '
        'btnIng
        '
        Me.btnIng.BackColor = System.Drawing.Color.SteelBlue
        Me.btnIng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnIng.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btnIng.FlatAppearance.BorderSize = 0
        Me.btnIng.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIng.ForeColor = System.Drawing.Color.White
        Me.btnIng.Location = New System.Drawing.Point(488, 3)
        Me.btnIng.Name = "btnIng"
        Me.btnIng.Size = New System.Drawing.Size(150, 32)
        Me.btnIng.TabIndex = 7
        Me.btnIng.Text = "Finalizar"
        Me.btnIng.UseVisualStyleBackColor = False
        '
        'frmParametrosGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 548)
        Me.Controls.Add(Me.layoutPanel)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmParametrosGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros generales"
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.layoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelParametros As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents buttonAjustes As Button
    Friend WithEvents btnEmpresa As Button
    Friend WithEvents layoutPanel As FlowLayoutPanel
    Friend WithEvents btnExtras As Button
    Friend WithEvents btnNombreEmpresa As Button
    Friend WithEvents btnHorarioAlmuerzo As Button
    Friend WithEvents btnTGracia As Button
    Friend WithEvents btnDominio As Button
    Friend WithEvents btnIng As Button
End Class
