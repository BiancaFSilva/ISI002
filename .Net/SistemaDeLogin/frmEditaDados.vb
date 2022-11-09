Public Class frmEditaDados
    Private Sub frmEditaDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDatabase()
        Call carregaDadosUsuario()
        Call carregaStatus()
    End Sub

    Private Sub btnCadastraConta_Click(sender As Object, e As EventArgs) Handles btnAtualizaConta.Click
        Try
            sql = "SELECT * FROM tb_usuarios WHERE usuario '" & aux & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                sql = "UPDATE tb_usuarios SET usuario = '" & txtUsuario.Text & "', email = '" & txtEmail.Text & "', " &
                      "status = '" & cmbStatus.SelectedItem & "' WHERE cpf = '" & txtId.Text & "'"
                rs = db.Execute(UCase(sql))

                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Close()
        End Try
    End Sub
End Class