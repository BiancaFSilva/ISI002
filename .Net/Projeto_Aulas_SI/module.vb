Module modulo
    ' Variáveis do banco de dados
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirDb = Application.StartupPath & "\db\cadastro.mdb"
    Public sql As String

    ' Outras Variáveis 
    Public dir As String

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
End Module