Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDatabase()
        Call carregaDadosUsuario()
    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        Try
            With dgvUsuarios
                If .CurrentRow.Cells(4).Selected = True Then
                    aux = .CurrentRow.Cells(1).Value

                    sql = "SELECT * FROM tb_usuarios WHERE usuario '" & aux & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        ' Valores a serem editados
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux = .CurrentRow.Cells(1).Value

                    resp = MsgBox("Deseja realmente excluir os dados desse usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "DELETE * FROM tb_usuarios WHERE usuario '" & aux & "'"
                        rs = db.Execute(sql)

                        MsgBox("Conta excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Call carregaDadosUsuario()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnCadastra_Click(sender As Object, e As EventArgs) Handles btnCadastra.Click
        frmCadastro.ShowDialog()
    End Sub
End Class