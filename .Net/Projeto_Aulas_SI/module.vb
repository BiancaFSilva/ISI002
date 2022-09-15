Module modulo
    ' Variáveis de conexão com o banco de dados
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    ' Public dirDb = Application.StartupPath & "\db\cadastro.accdb"
    Public dirDb = Application.StartupPath & "\db\cadastro.mdb"

    ' Variáveis
    Public dir, sql As String

    Sub conectaBanco()
        Try
            ' Inicializa a conexão com o banco de dados
            db = CreateObject("ADODB.Connection")
            ' Informa o banco a ser aberto
            ' db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dirDb)
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirDb)

            MsgBox("Conexão realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a conexão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module