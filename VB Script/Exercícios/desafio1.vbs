dim tipo_saida, audio, tipo 
dim n1, n2, n3, maior
call saida

sub saida()
    tipo_saida = msgbox("Deseja ativar o recurso de voz?", vbquestion + vbyesno, "AVISO")
    if tipo_saida = vbyes then  
        tipo = "audio"
    else
        tipo = "texto"        
    end if

    n1 = cint(inputbox("Informe o primeiro número: ", "AVISO"))
    n2 = cint(inputbox("Informe o segundo número: ", "AVISO"))
    n3 = cint(inputbox("Informe o terceiro número: ", "AVISO"))

    if n1 > n2 and n1 > n3 then
        maior = n1
    elseif n2 > n1 and n2 > n3 then
        maior = n2
    elseif n3 > n1 and n3 > n2 then
        maior = n3
    end if

    if tipo = "audio" then
        call voz
    elseif tipo = "texto" then
        call texto
    end if
end sub

sub voz()
    set audio = createObject("SAPI.SPVOICE")
    audio.rate = 2          
    audio.volume = 100  

    audio.speak("O maior número dentre os digitados (" & n1 & ", " & n2 &", "& n3 & ") é: " & maior & ". ")
end sub

sub texto()
    msgbox("O maior número dentre os digitados (" & n1 & ", " & n2 &", "& n3 & ") é: " & maior & ". "), vbquestion + vbokonly, "Maior número"
end sub