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

    Private Sub lblEsqueceuSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblEsqueceuSenha.LinkClicked
        frmRecuperaSenha.ShowDialog()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsuario.Text = "admin" And txtSenha.Text = "admin" Then
                frmMenu.ShowDialog()
                frmMenu.PainelAdministrativoToolStripMenuItem.Visible = True
                Close()
            End If

            sql = "SELECT * FROM tb_usuarios WHERE (usuario = '" & txtUsuario.Text & "' or email = '" & txtUsuario.Text & "') and senha = '" & txtSenha.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                frmMenu.PainelAdministrativoToolStripMenuItem.Visible = False
                frmMenu.ShowDialog()
                Close()
            Else
                MsgBox("Usuário e/ou senha inválidos! Tente novamente ou cadastre-se" = vbNewLine &
                       "Deseja criar uma conta?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                If resp = vbYes Then
                    frmCadastro.ShowDialog()
                    Close()
                End If

                txtUsuario.Clear()
                txtSenha.Clear()
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class
