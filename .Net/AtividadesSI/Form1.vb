Public Class Form1
    Private Sub btnBatMenu_Click(sender As Object, e As EventArgs) Handles btnBatMenu.Click
        Try
            Process.Start(Application.StartupPath & "\app\bat\menu\login.bat")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnBatAdivinha_Click(sender As Object, e As EventArgs) Handles btnBatAdivinha.Click
        Try
            Process.Start(Application.StartupPath & "\app\bat\Adivinhacao.bat")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnBatJoKenPo_Click(sender As Object, e As EventArgs) Handles btnBatJoKenPo.Click
        Try
            Process.Start(Application.StartupPath & "\app\bat\JoKenPo.bat")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnVbsDesafio01_Click(sender As Object, e As EventArgs) Handles btnVbsDesafio01.Click
        Try
            Process.Start(Application.StartupPath & "\app\vbs\Desafio01.vbs")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnVbsDesafio02_Click(sender As Object, e As EventArgs) Handles btnVbsDesafio02.Click
        Try
            Process.Start(Application.StartupPath & "\app\vbs\Desafio02.vbs")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnVbsDesafio03_Click(sender As Object, e As EventArgs) Handles btnVbsDesafio03.Click
        Try
            Process.Start(Application.StartupPath & "\app\vbs\Desafio03.vbs")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnVbsOperadores_Click(sender As Object, e As EventArgs) Handles btnVbsOperadores.Click
        Try
            Process.Start(Application.StartupPath & "\app\vbs\OperadoresMatematicos.vbs")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnVbsSoletrando_Click(sender As Object, e As EventArgs) Handles btnVbsSoletrando.Click
        Try
            Process.Start(Application.StartupPath & "\app\vbs\Soletrando.vbs")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class
