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
End Class