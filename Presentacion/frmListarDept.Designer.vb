<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarDept
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbEXT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnAdministrar = New System.Windows.Forms.Button()
        Me.lblCantDep = New System.Windows.Forms.Label()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnAnt = New System.Windows.Forms.Button()
        Me.cbDept = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbEXT)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rtxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lbEmail)
        Me.GroupBox1.Controls.Add(Me.lbNombre)
        Me.GroupBox1.Controls.Add(Me.lbID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listar departamentos"
        '
        'lbEXT
        '
        Me.lbEXT.AutoSize = True
        Me.lbEXT.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEXT.Location = New System.Drawing.Point(212, 120)
        Me.lbEXT.Name = "lbEXT"
        Me.lbEXT.Size = New System.Drawing.Size(49, 19)
        Me.lbEXT.TabIndex = 7
        Me.lbEXT.Text = "XXXXX"
        Me.lbEXT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ext:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtxtDescripcion
        '
        Me.rtxtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.rtxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtDescripcion.Enabled = False
        Me.rtxtDescripcion.Location = New System.Drawing.Point(216, 150)
        Me.rtxtDescripcion.Name = "rtxtDescripcion"
        Me.rtxtDescripcion.Size = New System.Drawing.Size(269, 38)
        Me.rtxtDescripcion.TabIndex = 9
        Me.rtxtDescripcion.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 19)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Descripción:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.Location = New System.Drawing.Point(212, 90)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(144, 19)
        Me.lbEmail.TabIndex = 5
        Me.lbEmail.Text = "texto@ejemplo.com.ni"
        Me.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(212, 60)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(112, 19)
        Me.lbNombre.TabIndex = 3
        Me.lbNombre.Text = "Texto de ejemplo"
        Me.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(212, 30)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(73, 19)
        Me.lbID.TabIndex = 1
        Me.lbID.Text = "XXXXXXXX"
        Me.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdministrar)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 257)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(518, 53)
        Me.FlowLayoutPanel1.TabIndex = 14
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(442, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 47)
        Me.btnCerrar.TabIndex = 16
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnAdministrar
        '
        Me.btnAdministrar.Location = New System.Drawing.Point(363, 3)
        Me.btnAdministrar.Name = "btnAdministrar"
        Me.btnAdministrar.Size = New System.Drawing.Size(73, 47)
        Me.btnAdministrar.TabIndex = 15
        Me.btnAdministrar.Text = "Administrar"
        Me.btnAdministrar.UseVisualStyleBackColor = True
        '
        'lblCantDep
        '
        Me.lblCantDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantDep.Location = New System.Drawing.Point(344, 220)
        Me.lblCantDep.Name = "lblCantDep"
        Me.lblCantDep.Size = New System.Drawing.Size(146, 32)
        Me.lblCantDep.TabIndex = 12
        Me.lblCantDep.Text = "999/999"
        Me.lblCantDep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSig
        '
        Me.btnSig.Location = New System.Drawing.Point(496, 220)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSig.Size = New System.Drawing.Size(31, 31)
        Me.btnSig.TabIndex = 13
        Me.btnSig.Text = ">"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'btnAnt
        '
        Me.btnAnt.Location = New System.Drawing.Point(307, 220)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnt.Size = New System.Drawing.Size(31, 31)
        Me.btnAnt.TabIndex = 11
        Me.btnAnt.Text = "<"
        Me.btnAnt.UseVisualStyleBackColor = True
        '
        'cbDept
        '
        Me.cbDept.Font = New System.Drawing.Font("Segoe UI", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDept.FormattingEnabled = True
        Me.cbDept.Location = New System.Drawing.Point(12, 220)
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(289, 28)
        Me.cbDept.TabIndex = 10
        '
        'frmListarDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 322)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lblCantDep)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.cbDept)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmListarDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar departamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtxtDescripcion As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnAdministrar As Button
    Friend WithEvents lblCantDep As Label
    Friend WithEvents btnSig As Button
    Friend WithEvents btnAnt As Button
    Friend WithEvents cbDept As ComboBox
    Friend WithEvents lbEXT As Label
    Friend WithEvents Label5 As Label
End Class
