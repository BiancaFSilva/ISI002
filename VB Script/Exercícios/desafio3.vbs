' Sequência de Fibonacci
dim num, serie, i
call inicio

sub inicio()
    num = cint(inputbox("Informe um número para terminar a sequência: ", "AVISO"))    
    serie = 0

    for i=1 to num step 1
        serie = serie + i  
        msgbox(serie)
    next
    
end sub