<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaAdmin
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportarUnProblemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.MonthCalendar1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(270, 605)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(9, 444)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(248, 147)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(9, 225)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(248, 33)
        Me.Panel3.TabIndex = 1
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(9, 270)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(9, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 206)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(942, 24)
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
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Location = New System.Drawing.Point(283, 535)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(647, 100)
        Me.Panel8.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Location = New System.Drawing.Point(283, 92)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(647, 437)
        Me.Panel7.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(283, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(647, 56)
        Me.Panel6.TabIndex = 6
        '
        'FrmVistaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 647)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(958, 686)
        Me.Name = "FrmVistaAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adminstracion"
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel8 As Panel
    Friend WithEvents AñadirEntidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel1 As Panel
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
End Class
