Public Class frmMenu
    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PainelAdministrativoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PainelAdministrativoToolStripMenuItem.Click
        frmDashboard.ShowDialog()
    End Sub
End Class