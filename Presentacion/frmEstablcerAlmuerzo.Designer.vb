﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstablcerAlmuerzo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.npM2R = New System.Windows.Forms.NumericUpDown()
        Me.npH2R = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.npM1R = New System.Windows.Forms.NumericUpDown()
        Me.npH1R = New System.Windows.Forms.NumericUpDown()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New SistemaEyS.BDSistemaEySDataSet()
        Me.Tbl_ConfigTableAdapter1 = New SistemaEyS.BDSistemaEySDataSetTableAdapters.tbl_ConfigTableAdapter()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.npM2R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npH2R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npM1R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npH1R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGuardar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 87)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(415, 31)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(339, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 23)
        Me.btnCerrar.TabIndex = 25
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(260, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 23)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 87)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Establecer horarios: Almuerzo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.68504!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.81102!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.281345!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.31498!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.09174!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14985!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.622517!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.51656!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.npM2R, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.npH2R, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.npM1R, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.npH1R, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(21, 39)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(381, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Horario:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(182, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 29)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "-"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'npM2R
        '
        Me.npM2R.Location = New System.Drawing.Point(295, 3)
        Me.npM2R.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.npM2R.Name = "npM2R"
        Me.npM2R.Size = New System.Drawing.Size(43, 25)
        Me.npM2R.TabIndex = 7
        '
        'npH2R
        '
        Me.npH2R.Location = New System.Drawing.Point(220, 3)
        Me.npH2R.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.npH2R.Name = "npH2R"
        Me.npH2R.Size = New System.Drawing.Size(37, 25)
        Me.npH2R.TabIndex = 5
        Me.npH2R.Value = New Decimal(New Integer() {17, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(270, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = ":"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(123, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'npM1R
        '
        Me.npM1R.Location = New System.Drawing.Point(139, 3)
        Me.npM1R.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.npM1R.Name = "npM1R"
        Me.npM1R.Size = New System.Drawing.Size(37, 25)
        Me.npM1R.TabIndex = 3
        '
        'npH1R
        '
        Me.npH1R.Location = New System.Drawing.Point(78, 3)
        Me.npH1R.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.npH1R.Name = "npH1R"
        Me.npH1R.Size = New System.Drawing.Size(37, 25)
        Me.npH1R.TabIndex = 1
        Me.npH1R.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.BDSistemaEySDataSet
        Me.BindingSource1.Position = 0
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_ConfigTableAdapter1
        '
        Me.Tbl_ConfigTableAdapter1.ClearBeforeFill = True
        '
        'frmEstablcerAlmuerzo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 118)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmEstablcerAlmuerzo"
        Me.Text = "frmEstablcerAlmuerzo"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.npM2R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npH2R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npM1R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npH1R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents npH1R As NumericUpDown
    Friend WithEvents npM1R As NumericUpDown
    Friend WithEvents npM2R As NumericUpDown
    Friend WithEvents npH2R As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Tbl_ConfigTableAdapter1 As BDSistemaEySDataSetTableAdapters.tbl_ConfigTableAdapter
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents Label2 As Label
End Class
