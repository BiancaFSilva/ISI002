Public Class frmRecuperaSenha
    Private Sub frmRecuperaSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDatabase()
    End Sub

    Private Sub chkVerSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerSenha.CheckedChanged
        Try
            If chkVerSenha.Checked Then
                txtSenha.PasswordChar = ""
                txtRepeteSenha.PasswordChar = ""
            Else
                txtSenha.PasswordChar = "•"
                txtRepeteSenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnRedefineSenha_Click(sender As Object, e As EventArgs) Handles btnRedefineSenha.Click
        Try
            If txtSenha.Text = "" Or txtRepeteSenha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf txtSenha.Text <> txtRepeteSenha.Text Then
                MsgBox("Senhas não conferem!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            sql = "SELECT * FROM tb_usuarios WHERE usuario = '" & txtUsuario.Text & "' or email = '" & txtUsuario.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                sql = "UPDATE tb_usuarios SET senha = '" & txtSenha.Text & "' WHERE usuario = '" & txtUsuario.Text & "' OR email = '" & txtUsuario.Text & "'"
                rs = db.Execute(UCase(sql))

                MsgBox("Sua senha foi atualizada com sucesso!" + vbNewLine &
                       "Realize o login para recuperar o acesso a sua conta", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                frmLogin.ShowDialog()
                Close()
            Else
                MsgBox("Usuário e/ou email inválidos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                txtUsuario.Clear()
                txtSenha.Clear()
                txtRepeteSenha.Clear()
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class