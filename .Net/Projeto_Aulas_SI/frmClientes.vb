Public Class frmClientes
    Private Sub imgUser_Click(sender As Object, e As EventArgs) Handles imgUser.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\img"
                .ShowDialog()

                dir = .FileName
                imgUser.Load(dir)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaBanco()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            sql = "SELECT * FROM tb_cadastro WHERE cpf = '" & txtCpf.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                MsgBox("CPF já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                sql = "INSERT INTO tb_cadastro VALUES ('" & txtCep.Text & "', " &
                      "'" & txtDataNascimento.Value & "', " &
                      "'" & txtNome.Text & "', " &
                      "'" & txtCep.Text & "', " &
                      "'" & txtEndereco.Text & "', " &
                      "'" & txtBairro.Text & "', " &
                      "'" & txtCidade.Text & "', " &
                      "'" & txtUf.Text & "', " &
                      "'" & txtFone.Text & "', " &
                      "'" & txtEmail.Text & "', " &
                      "'" & dir & "')"
                rs = db.Execute(sql)

                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

                ' Limpa os valores dos campos
                txtCpf.Clear()
                txtDataNascimento.Value = Now
                txtNome.Clear()
                txtCep.Clear()
                txtEndereco.Clear()
                txtBairro.Clear()
                txtCidade.Clear()
                txtUf.Clear()
                txtFone.Clear()
                txtEmail.Clear()
                imgUser.Load(Application.StartupPath & "\img\add_user.png")

                txtCpf.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class