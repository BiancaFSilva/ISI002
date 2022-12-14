Public Class frmCadastraConta
    Private Sub frmCadastraConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnCadastraConta_Click(sender As Object, e As EventArgs) Handles btnCadastraConta.Click
        Try
            If txtUsuario.Text = "" Or txtEmail.Text = "" Or txtSenha.Text = "" Or txtRepeteSenha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf txtSenha.Text <> txtRepeteSenha.Text Then
                MsgBox("Senhas não conferem!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                sql = "SELECT * FROM tb_login WHERE usuario = '" & txtUsuario.Text & "' or email = '" & txtEmail.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    MsgBox("Conta de usuário já existente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "INSERT INTO tb_login (usuario, email, senha, status) VALUES ('" & txtUsuario.Text & "', " &
                          "'" & txtEmail.Text & "', '" & txtSenha.Text & "', 'Ativo')"
                    rs = db.Execute(sql)

                    MsgBox("Conta cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If

                txtUsuario.Clear()
                txtEmail.Clear()
                txtSenha.Clear()
                txtRepeteSenha.Clear()
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível cadastrar conta", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class