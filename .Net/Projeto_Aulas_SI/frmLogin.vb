Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDatabase()
    End Sub

    Private Sub chkVerSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerSenha.CheckedChanged
        Try
            If chkVerSenha.Checked Then
                txtSenha.PasswordChar = ""
            Else
                txtSenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsuario.Text = "admin" And txtSenha.Text = "admin" Then
                FormMenu.ShowDialog()
                FormMenu.GerenciarToolStripMenuItem.Visible = True
                Exit Sub
            End If

            sql = "SELECT * FROM tb_login WHERE (usuario = '" & txtUsuario.Text & "' or email = '" & txtUsuario.Text & "') and senha = '" & txtSenha.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                FormMenu.GerenciarToolStripMenuItem.Visible = False
                FormMenu.ShowDialog()
            Else
                MsgBox("Usuário e/ou senha inválidos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                txtUsuario.Clear()
                txtSenha.Clear()
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class