dim num, antes, depois
call processo

sub processo()
    num = cint(inputbox("Informe um número: ", "AVISO"))

    antes = num - 1
    depois = num + 1

    msgbox("O número digitado é: "  + vbNewLine &_
           "Antecessor: " & antes & ""  + vbNewLine &_
           "Sucessor: " & depois & ""), vbquestion + vbokonly, "RESULTADO"
end sub