dim cor, farol, resp
call escolha

sub escolha()
    farol = cint(inputbox("[1] Verde" + vbNewLine &_
                          "[2] Amarelo" + vbNewLine &_
                          "[3] Vermelho" + vbNewLine &_
                          "[0 ou 10] Encerrar Script", "Cores do Semáforo"))
    select case farol
        case 1:
            cor = "Verde - Siga em frente!"
        case 2:
            cor = "Amarelo - Atenção!"
        case 3:
            cor = "Vermelho - Pare!"
        ' Casa um OU outro
        case 0, 10:
            resp = msgbox("Deseja encerrar?", vnquestion + vbyesno, "AVISO")
            
            if resp = vbyes then
                wscript.quit
            else
                call escolha
            end if
        case else
            cor = "Inválido!"
    end select
   
    msgbox("" & cor & ""), vbinformation + vbokonly, "Cores do Semáforo"
    call escolha
end sub