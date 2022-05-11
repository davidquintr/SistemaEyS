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
        Me.layoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.labelParametros = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.labelTituloSel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.buttonEventos = New System.Windows.Forms.Button()
        Me.buttonAjustes = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'layoutPanel
        '
        Me.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.layoutPanel.Location = New System.Drawing.Point(344, 64)
        Me.layoutPanel.Name = "layoutPanel"
        Me.layoutPanel.Size = New System.Drawing.Size(420, 419)
        Me.layoutPanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.labelParametros)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(322, 43)
        Me.Panel2.TabIndex = 0
        '
        'labelParametros
        '
        Me.labelParametros.AutoSize = True
        Me.labelParametros.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelParametros.Location = New System.Drawing.Point(3, 9)
        Me.labelParametros.Name = "labelParametros"
        Me.labelParametros.Size = New System.Drawing.Size(194, 25)
        Me.labelParametros.TabIndex = 0
        Me.labelParametros.Text = "Parámetros Generales"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.labelTituloSel)
        Me.Panel3.Location = New System.Drawing.Point(347, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(417, 43)
        Me.Panel3.TabIndex = 1
        '
        'labelTituloSel
        '
        Me.labelTituloSel.AutoSize = True
        Me.labelTituloSel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTituloSel.Location = New System.Drawing.Point(3, 9)
        Me.labelTituloSel.Name = "labelTituloSel"
        Me.labelTituloSel.Size = New System.Drawing.Size(65, 25)
        Me.labelTituloSel.TabIndex = 1
        Me.labelTituloSel.Text = "Título."
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel2.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(340, 489)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(424, 53)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(341, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 47)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.buttonEventos)
        Me.FlowLayoutPanel3.Controls.Add(Me.buttonAjustes)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(12, 61)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(322, 481)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'buttonEventos
        '
        Me.buttonEventos.Location = New System.Drawing.Point(3, 3)
        Me.buttonEventos.Name = "buttonEventos"
        Me.buttonEventos.Size = New System.Drawing.Size(319, 46)
        Me.buttonEventos.TabIndex = 0
        Me.buttonEventos.Text = "Eventos"
        Me.buttonEventos.UseVisualStyleBackColor = True
        '
        'buttonAjustes
        '
        Me.buttonAjustes.Location = New System.Drawing.Point(3, 55)
        Me.buttonAjustes.Name = "buttonAjustes"
        Me.buttonAjustes.Size = New System.Drawing.Size(319, 46)
        Me.buttonAjustes.TabIndex = 1
        Me.buttonAjustes.Text = "Ajustes extras"
        Me.buttonAjustes.UseVisualStyleBackColor = True
        '
        'frmParametrosGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 548)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.layoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmParametrosGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros generales"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutPanel As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelParametros As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents labelTituloSel As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents buttonEventos As Button
    Friend WithEvents buttonAjustes As Button
End Class
