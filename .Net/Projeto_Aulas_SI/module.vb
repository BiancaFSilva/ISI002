Module modulo
    ' Variáveis do banco de dados
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirDb = Application.StartupPath & "\db\cadastro.mdb"
    Public sql As String

    ' Outras Variáveis 
    Public dir, resp, aux As String
    Public cont As Integer

    Sub conectaDatabase()
        Try
            ' Inicializa a conexão com o banco de dados e informa o banco a ser aberto
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirDb)

            MsgBox("Conexão realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a conexão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregaDados()
        Try
            sql = "SELECT * FROM tb_cadastro ORDER BY nome ASC"
            rs = db.Execute(sql)

            cont = 1
            With frmClientes.dgvDados
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()

                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregaTipo()
        Try
            With frmClientes.cmbTipo.Items
                .Add("Nome")
                .Add("CPF")
            End With

            frmClientes.cmbTipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module