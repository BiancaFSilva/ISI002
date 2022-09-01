' Sortear valores de 1 a 10 para n1 e n2, com 3 operadores sorteados + - *
dim n1, n2, sinal, resp, op, jogo, conta
dim acertos, erros
call sorteio

acertos = 0
erros = 0

sub sorteio()    
    randomize(second(time))
    n1 = int(rnd * 10) + 1
    n2 = int(rnd * 10) + 1
    sinal = int(rnd * 3) + 1

    if sinal = 1 then
        op = "+"
        conta = n1 + n2
    elseif sinal = 2 then
        op = "-"
        conta = n1 - n2
    else
        op = "*"
        conta = n1 * n2
    end if
    
    resp = cint(inputbox("Conta: " + vbNewLine &_
           "" & n1 & " " & op & " " & n2 & " = ?" + vbNewLine &_
           "" + vbNewLine &_
           "Qual o resutado?", "OPERACOES MATEMATICAS"))

    if resp = conta then
        msgbox("Parabens voce acertou! "), vbinformation + vbokonly, "VITORIA"
        acertos = acertos + 1        
    else
        msgbox("Erro! A resposta era " & conta & ""), vbcritical + vbokonly, "DERROTA"   
        erros = erros + 1     
    end if
    
    jogo = msgbox("Voce acertou " & acertos & " e errou " & erros & " operacoes!" + vbNewLine &_
                  "Deseja sortear outra operacao? ", vbquestion + vbyesno, "OPERACOES MATEMATICAS")
    if jogo = vbyes then
        call sorteio()
    else 
        wscript.quit
    end if
end sub