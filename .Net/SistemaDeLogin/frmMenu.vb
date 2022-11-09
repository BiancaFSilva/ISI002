Public Class frmMenu
    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PainelAdministrativoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PainelAdministrativoToolStripMenuItem.Click
        frmDashboard.ShowDialog()
    End Sub

    Private Sub btnBuscaCep_Click(sender As Object, e As EventArgs) Handles btnBuscaCep.Click
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
                txtEndereco.Clear()
                txtBairro.Clear()
                txtCidade.Clear()
                txtUf.Clear()
                txtCep.Clear()
                txtCep.Focus()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a pesquisa. Tente novamente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txtCep.Clear()
            txtCep.Focus()
        End Try
    End Sub
End Class