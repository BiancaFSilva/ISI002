' Declaração de variável, não é necessário declarar tipo
dim n1, n2, n3, media, situacao
dim resp, audio
call chama_voz ' Chamada de função

sub chama_voz()
    set audio = createObject("SAPI.SPVOICE")
    audio.rate = 2          ' Velocidade de fala
    audio.volume = 100      ' Volume
    
    call entrada_notas 
end sub

sub entrada_notas()  
    ' Conversão da variável de String alfanumérico (padrão)
    ' Cint > inteiro        Cdbl > double       Ccur > monetário
    n1 = cdbl(inputbox("Informe a primeira nota: ", "AVISO"))
    n2 = cdbl(inputbox("Informe a segunda nota: ", "AVISO"))
    n3 = cdbl(inputbox("Informe a terceira nota: ", "AVISO"))

    ' Configura média aritmética
    media = round((n1 + n2 + n3)/3, 1) ' Ajusta a quantidade de casas decimais

    ' Condição
    if media < 4 then
        situacao = "Reprovado"
    elseif media >= 4 and media < 6 then
        situacao = "Recuperação"
    else 
        situacao = "Aprovado"
    end if

    audio.speak("Média do aluno" & media & ". " + vbnewline &_ 
                "Situação" & situacao & ". ")

    ' Saída de dados: mensagem, tipo de ícone, tipo de botão, título
    msgbox("Média do aluno: " & media & ". " + vbNewLine &_
           "Situação: " & situacao & ". "), vbquestion + vbokonly, "RENDIMENTO"

    call novo_calculo
end sub

sub novo_calculo()
    resp = msgbox("Deseja realizar um novo cálculo?", vbquestion + vbyesno, "ATENÇÃO")
    if resp = vbyes then
        call entrada_notas()  
    else 
        wscript.quit
    end if
end sub