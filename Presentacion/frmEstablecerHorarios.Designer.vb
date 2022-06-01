<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstablecerHorarios
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
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkReg = New System.Windows.Forms.CheckBox()
        Me.checkSab = New System.Windows.Forms.CheckBox()
        Me.checkDom = New System.Windows.Forms.CheckBox()
        Me.npH1R = New System.Windows.Forms.NumericUpDown()
        Me.npH1S = New System.Windows.Forms.NumericUpDown()
        Me.npH1D = New System.Windows.Forms.NumericUpDown()
        Me.npM1R = New System.Windows.Forms.NumericUpDown()
        Me.npM1S = New System.Windows.Forms.NumericUpDown()
        Me.npM1D = New System.Windows.Forms.NumericUpDown()
        Me.npM2R = New System.Windows.Forms.NumericUpDown()
        Me.npM2S = New System.Windows.Forms.NumericUpDown()
        Me.npM2D = New System.Windows.Forms.NumericUpDown()
        Me.npH2R = New System.Windows.Forms.NumericUpDown()
        Me.npH2S = New System.Windows.Forms.NumericUpDown()
        Me.npH2D = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tbl_HorarioTableAdapter = New SistemaEyS.BDSistemaEySDataSetTableAdapters.tbl_HorarioTableAdapter()
        Me.Tbl_HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New SistemaEyS.BDSistemaEySDataSet()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.npH1R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npH1S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npH1D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npM1R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npM1S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npM1D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npM2R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npM2S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npM2D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npH2R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npH2S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npH2D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGuardar)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 154)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(445, 31)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(369, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 23)
        Me.btnCerrar.TabIndex = 25
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(290, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 23)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Establecer horarios: Cargo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.checkReg, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.checkSab, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.checkDom, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.npH1R, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.npH1S, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.npH1D, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.npM1R, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.npM1S, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.npM1D, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.npM2R, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.npM2S, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.npM2D, 7, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.npH2R, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.npH2S, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.npH2D, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 6, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 26)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(433, 93)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(258, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 30)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "-"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(258, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 30)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "-"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(258, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 30)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "-"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(178, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'checkReg
        '
        Me.checkReg.AutoSize = True
        Me.checkReg.Location = New System.Drawing.Point(3, 3)
        Me.checkReg.Name = "checkReg"
        Me.checkReg.Size = New System.Drawing.Size(76, 23)
        Me.checkReg.TabIndex = 0
        Me.checkReg.Text = "Regular"
        Me.checkReg.UseVisualStyleBackColor = True
        '
        'checkSab
        '
        Me.checkSab.AutoSize = True
        Me.checkSab.Location = New System.Drawing.Point(3, 34)
        Me.checkSab.Name = "checkSab"
        Me.checkSab.Size = New System.Drawing.Size(74, 23)
        Me.checkSab.TabIndex = 8
        Me.checkSab.Text = "Sábado"
        Me.checkSab.UseVisualStyleBackColor = True
        '
        'checkDom
        '
        Me.checkDom.AutoSize = True
        Me.checkDom.Location = New System.Drawing.Point(3, 65)
        Me.checkDom.Name = "checkDom"
        Me.checkDom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.checkDom.Size = New System.Drawing.Size(86, 23)
        Me.checkDom.TabIndex = 16
        Me.checkDom.Text = "Domingo"
        Me.checkDom.UseVisualStyleBackColor = True
        '
        'npH1R
        '
        Me.npH1R.Enabled = False
        Me.npH1R.Location = New System.Drawing.Point(118, 3)
        Me.npH1R.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.npH1R.Name = "npH1R"
        Me.npH1R.Size = New System.Drawing.Size(53, 25)
        Me.npH1R.TabIndex = 1
        Me.npH1R.Value = New Decimal(New Integer() {23, 0, 0, 0})
        '
        'npH1S
        '
        Me.npH1S.Enabled = False
        Me.npH1S.Location = New System.Drawing.Point(118, 34)
        Me.npH1S.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.npH1S.Name = "npH1S"
        Me.npH1S.Size = New System.Drawing.Size(53, 25)
        Me.npH1S.TabIndex = 9
        Me.npH1S.Value = New Decimal(New Integer() {23, 0, 0, 0})
        '
        'npH1D
        '
        Me.npH1D.Enabled = False
        Me.npH1D.Location = New System.Drawing.Point(118, 65)
        Me.npH1D.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.npH1D.Name = "npH1D"
        Me.npH1D.Size = New System.Drawing.Size(53, 25)
        Me.npH1D.TabIndex = 17
        Me.npH1D.Value = New Decimal(New Integer() {23, 0, 0, 0})
        '
        'npM1R
        '
        Me.npM1R.Enabled = False
        Me.npM1R.Location = New System.Drawing.Point(198, 3)
        Me.npM1R.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.npM1R.Name = "npM1R"
        Me.npM1R.Size = New System.Drawing.Size(53, 25)
        Me.npM1R.TabIndex = 3
        Me.npM1R.Value = New Decimal(New Integer() {59, 0, 0, 0})
        '
        'npM1S
        '
        Me.npM1S.Enabled = False
        Me.npM1S.Location = New System.Drawing.Point(198, 34)
        Me.npM1S.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.npM1S.Name = "npM1S"
        Me.npM1S.Size = New System.Drawing.Size(53, 25)
        Me.npM1S.TabIndex = 11
        Me.npM1S.Value = New Decimal(New Integer() {59, 0, 0, 0})
        '
        'npM1D
        '
        Me.npM1D.Enabled = False
        Me.npM1D.Location = New System.Drawing.Point(198, 65)
        Me.npM1D.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.npM1D.Name = "npM1D"
        Me.npM1D.Size = New System.Drawing.Size(53, 25)
        Me.npM1D.TabIndex = 19
        Me.npM1D.Value = New Decimal(New Integer() {59, 0, 0, 0})
        '
        'npM2R
        '
        Me.npM2R.Enabled = False
        Me.npM2R.Location = New System.Drawing.Point(368, 3)
        Me.npM2R.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.npM2R.Name = "npM2R"
        Me.npM2R.Size = New System.Drawing.Size(53, 25)
        Me.npM2R.TabIndex = 7
        Me.npM2R.Value = New Decimal(New Integer() {59, 0, 0, 0})
        '
        'npM2S
        '
        Me.npM2S.Enabled = False
        Me.npM2S.Location = New System.Drawing.Point(368, 34)
        Me.npM2S.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.npM2S.Name = "npM2S"
        Me.npM2S.Size = New System.Drawing.Size(53, 25)
        Me.npM2S.TabIndex = 15
        Me.npM2S.Value = New Decimal(New Integer() {59, 0, 0, 0})
        '
        'npM2D
        '
        Me.npM2D.Enabled = False
        Me.npM2D.Location = New System.Drawing.Point(368, 65)
        Me.npM2D.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.npM2D.Name = "npM2D"
        Me.npM2D.Size = New System.Drawing.Size(53, 25)
        Me.npM2D.TabIndex = 23
        Me.npM2D.Value = New Decimal(New Integer() {59, 0, 0, 0})
        '
        'npH2R
        '
        Me.npH2R.Enabled = False
        Me.npH2R.Location = New System.Drawing.Point(288, 3)
        Me.npH2R.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.npH2R.Name = "npH2R"
        Me.npH2R.Size = New System.Drawing.Size(53, 25)
        Me.npH2R.TabIndex = 5
        Me.npH2R.Value = New Decimal(New Integer() {23, 0, 0, 0})
        '
        'npH2S
        '
        Me.npH2S.Enabled = False
        Me.npH2S.Location = New System.Drawing.Point(288, 34)
        Me.npH2S.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.npH2S.Name = "npH2S"
        Me.npH2S.Size = New System.Drawing.Size(53, 25)
        Me.npH2S.TabIndex = 13
        Me.npH2S.Value = New Decimal(New Integer() {23, 0, 0, 0})
        '
        'npH2D
        '
        Me.npH2D.Enabled = False
        Me.npH2D.Location = New System.Drawing.Point(288, 65)
        Me.npH2D.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.npH2D.Name = "npH2D"
        Me.npH2D.Size = New System.Drawing.Size(53, 25)
        Me.npH2D.TabIndex = 21
        Me.npH2D.Value = New Decimal(New Integer() {23, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(178, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 30)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = ":"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(178, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 30)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = ":"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(348, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = ":"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(348, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 30)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(348, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 30)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_HorarioTableAdapter
        '
        Me.Tbl_HorarioTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HorarioBindingSource
        '
        Me.Tbl_HorarioBindingSource.DataSource = Me.BDSistemaEySDataSet
        Me.Tbl_HorarioBindingSource.Position = 0
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmEstablecerHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 197)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEstablecerHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Establecer horarios"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.npH1R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npH1S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npH1D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npM1R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npM1S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npM1D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npM2R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npM2S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npM2D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npH2R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npH2S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npH2D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents checkReg As CheckBox
    Friend WithEvents checkSab As CheckBox
    Friend WithEvents checkDom As CheckBox
    Friend WithEvents npH1R As NumericUpDown
    Friend WithEvents npH1S As NumericUpDown
    Friend WithEvents npH1D As NumericUpDown
    Friend WithEvents npM1R As NumericUpDown
    Friend WithEvents npM1S As NumericUpDown
    Friend WithEvents npM1D As NumericUpDown
    Friend WithEvents npM2R As NumericUpDown
    Friend WithEvents npM2S As NumericUpDown
    Friend WithEvents npM2D As NumericUpDown
    Friend WithEvents npH2R As NumericUpDown
    Friend WithEvents npH2S As NumericUpDown
    Friend WithEvents npH2D As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Tbl_HorarioTableAdapter As BDSistemaEySDataSetTableAdapters.tbl_HorarioTableAdapter
    Friend WithEvents Tbl_HorarioBindingSource As BindingSource
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
End Class
