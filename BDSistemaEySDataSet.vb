Partial Class BDSistemaEySDataSet
    Partial Public Class tbl_HorarioDataTable
        Private Sub tbl_HorarioDataTable_tbl_HorarioRowChanging(sender As Object, e As tbl_HorarioRowChangeEvent) Handles Me.tbl_HorarioRowChanging

        End Sub

    End Class

    Partial Public Class tbl_UsuarioDataTable
        Private Sub tbl_UsuarioDataTable_tbl_UsuarioRowChanging(sender As Object, e As tbl_UsuarioRowChangeEvent) Handles Me.tbl_UsuarioRowChanging

        End Sub

    End Class

    Partial Public Class tbl_EventoDataTable
        Private Sub tbl_EventoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.tipoEventoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class tbl_RolDataTable
        Private Sub tbl_RolDataTable_tbl_RolRowChanging(sender As Object, e As tbl_RolRowChangeEvent) Handles Me.tbl_RolRowChanging

        End Sub

    End Class

    Partial Public Class tbl_OpcionDataTable
        Private Sub tbl_OpcionDataTable_tbl_OpcionRowChanging(sender As Object, e As tbl_OpcionRowChangeEvent) Handles Me.tbl_OpcionRowChanging

        End Sub

    End Class
End Class

Namespace BDSistemaEySDataSetTableAdapters
    Partial Public Class tbl_UsuarioTableAdapter
    End Class

    Partial Public Class tbl_RegistroTableAdapter
    End Class

    Partial Public Class Vw_UsuarioTableAdapter
    End Class

    Partial Public Class Vw_ListEmpTableAdapter
    End Class
End Namespace

Namespace BDSistemaEySDataSetTableAdapters
    Partial Public Class tbl_UsuarioTableAdapter
    End Class
End Namespace
