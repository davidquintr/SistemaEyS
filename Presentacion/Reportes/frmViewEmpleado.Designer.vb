<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rptEmpleado = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rptEmpleado
        '
        Me.rptEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptEmpleado.LocalReport.ReportEmbeddedResource = "SistemaEyS.rptDepartamento.rdlc"
        Me.rptEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.rptEmpleado.Name = "rptEmpleado"
        Me.rptEmpleado.ServerReport.BearerToken = Nothing
        Me.rptEmpleado.Size = New System.Drawing.Size(800, 450)
        Me.rptEmpleado.TabIndex = 0
        '
        'frmViewEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rptEmpleado)
        Me.Name = "frmViewEmpleado"
        Me.Text = "frmViewEmpleado"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rptEmpleado As Microsoft.Reporting.WinForms.ReportViewer
End Class
