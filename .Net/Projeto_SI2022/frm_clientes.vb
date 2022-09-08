Public Class frm_clientes

    Private Sub img_foto_Click(sender As Object, e As EventArgs)
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "C:\Users\Aluno\Desktop\ADSMA2 - Sistemas da Informacao\.Net\PRJ_SI_2022\bin\Debug\img"
                .ShowDialog()

                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class