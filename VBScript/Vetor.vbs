dim nome(6), n, i
call carregaNomes

sub carregaNomes()
    for i = 1 to 10 step 1
        nome(1) = "Andrew Minyard"
        nome(2) = "Aaron Minyard"
        nome(3) = "Amaro Carro"
        nome(4) = "Neil Josten"
        nome(5) = "Kevin Day"
        nome(6) = "Neide Teles"
        
        ' Dinamiza o sorteio a cada start do programa
        randomize(second(time))
        ' Sorteio 6 números, ignorando o 0
        n = int(rnd * 6) + 1
        msgbox(nome(n)), vbinformation + vbokonly, "AVISO"
    next

    msgbox("Fim do sorteio!"), vbinformation + vbokonly, "AVISO"
end sub