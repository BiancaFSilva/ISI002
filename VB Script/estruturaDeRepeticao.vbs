' Estruturas de Repetição
dim n
call inicio

sub inicio()
    n = 1

    do while n <= 5
        n = n + 1
        msgbox("Contagem DO WHILE: " & n & ""), vbinformation + vbokonly, "CONTAGEM"
    loop

    for n=1 to 5 step 1
        msgbox("Contagem FOR: " & n & ""), vbinformation + vbokonly, "CONTAGEM"
    next
end sub