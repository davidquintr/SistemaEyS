Imports Microsoft.Reporting.WinForms
Module ConfiguracionesRepotes


    Sub VerReporte(ByVal tbl As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDs, tbl)
            With frmViewEmpleado
                .rptEmp.LocalReport.DataSources.Clear()
                .rptEmp.LocalReport.DataSources.Add(rpt)
                .rptEmp.LocalReport.ReportPath = nombreRpt
                .rptEmp.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al mostrar reporte")
        End Try

    End Sub

End Module
