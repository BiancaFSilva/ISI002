Public Class FormMenu
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            ' O comando Start("...") chama um componente externo
            Process.Start("calc.exe")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Try
            ' O comando ShowDialog() chama um componente interno, do próprio projeto
            frmClientes.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class