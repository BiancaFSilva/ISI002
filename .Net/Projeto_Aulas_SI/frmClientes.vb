Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDatabase()
        Call carregaDados()
        Call carregaTipo()
    End Sub

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

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            sql = "SELECT * FROM tb_cadastro WHERE cpf = '" & txtCpf.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                sql = "UPDATE tb_cadastro SET data_nasci = '" & txtDataNascimento.Value & "', " &
                      "nome = '" & txtNome.Text & "', " &
                      "cep = '" & txtCep.Text & "', " &
                      "endereco = '" & txtEndereco.Text & "', " &
                      "bairro = '" & txtBairro.Text & "', " &
                      "cidade = '" & txtCidade.Text & "', " &
                      "uf = '" & txtUf.Text & "', " &
                      "fone = '" & txtFone.Text & "', " &
                      "email = '" & txtEmail.Text & "', " &
                      "foto = '" & dir & "' WHERE cpf = '" & txtCpf.Text & "'"
                rs = db.Execute(UCase(sql))

                MsgBox("Cadastro atualizado com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "INSERT INTO tb_cadastro VALUES ('" & txtCpf.Text & "', " &
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
                rs = db.Execute(UCase(sql))

                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If

            Call carregaDados()

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
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível cadastrar os dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Try
            sql = "SELECT * FROM tb_cadastro"
            rs = db.Execute(sql)
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível consultar as informações desejadas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txtCep_LostFocus(sender As Object, e As EventArgs) Handles txtCep.LostFocus
        Try
            sql = "SELECT * FROM tb_cep WHERE cep = '" & txtCep.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                txtEndereco.Text = rs.Fields(1).Value
                txtBairro.Text = rs.Fields(3).Value
                txtCidade.Text = rs.Fields(2).Value
                txtUf.Text = rs.Fields(4).Value
            Else
                MsgBox("CEP não localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a pesquisa", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        Try
            sql = "SELECT * FROM tb_cadastro WHERE " & cmbTipo.Text & " LIKE '" & txtBusca.Text & "% '"
            rs = db.Execute(sql)

            cont = 1
            With dgvDados
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()

                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a pesquisa", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        Try
            With dgvDados
                If .CurrentRow.Cells(3).Selected = True Then
                    aux = .CurrentRow.Cells(1).Value

                    sql = "SELECT * FROM tb_cadastro WHERE cpf '" & aux & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        tabGerenciaClientes.SelectTab(0)

                        txtCpf.Text = rs.Fields(0).Value
                        txtDataNascimento.Value = rs.Fields(1).Value
                        txtNome.Text = rs.Fields(2).Value
                        txtCep.Text = rs.Fields(3).Value
                        txtEndereco.Text = rs.Fields(4).Value
                        txtBairro.Text = rs.Fields(5).Value
                        txtCidade.Text = rs.Fields(6).Value
                        txtUf.Text = rs.Fields(7).Value
                        txtFone.Text = rs.Fields(8).Value
                        txtEmail.Text = rs.Fields(9).Value
                        imgUser.Load(rs.Fields(10).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux = .CurrentRow.Cells(1).Value

                    resp = MsgBox("Deseja realmente excluir os dados referentes ao CPF " & txtCpf.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "DELETE * FROM tb_cadastro WHERE cpf '" & aux & "'"
                        rs = db.Execute(sql)

                        Call carregaDados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class