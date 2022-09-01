' Solicitar nome (por na barra de titulo), sortear uma palavra(15) e usar a saída de voz, 4 níveis
' Disponibilizar duas opções: ouvir a palavra novamente (1x rodada) e pular palavra (1x nivel) 
' Mudanla de nivel a cada 5 acertos, Vence 15 acertos consecutivos
' Vetor: nivel 1 (1 a 10) pontos +1k , nivel 2 (11 a 20) pontos +10k, nivel 3 (21 a 30) pontos +100k, nivel 4 (31 a 40) pontos 1m
dim palavra(40), i, n
dim nome, opcaoJogo, soletra, nivel, pontos
dim audio
call palavras

nivel = 1
pontos = 0
acertos = 0

sub palavras()
    ' Nivel 1
    palavra(1) = "a"
    palavra(2) = "s"
    palavra(3) = "d"
    palavra(4) = "f"
    palavra(5) = "g"
    palavra(6) = "h"
    palavra(7) = "j"
    palavra(8) = "k"
    palavra(9) = "l"
    palavra(10) = "ç"
    ' Nivel 2
    palavra(11) = "q"
    palavra(12) = "w"
    palavra(13) = "e"
    palavra(14) = "r"
    palavra(15) = "t"
    palavra(16) = "y"
    palavra(17) = "u"
    palavra(18) = "i"
    palavra(19) = "o"
    palavra(20) = "p"
    ' Nivel 3
    palavra(21) = "z"
    palavra(22) = "x"
    palavra(23) = "c"
    palavra(24) = "v"
    palavra(25) = "b"
    palavra(26) = "n"
    palavra(27) = "m"
    palavra(28) = "qw"
    palavra(29) = "er"
    palavra(30) = "ty"
    ' Nivel 4
    palavra(31) = "ui"
    palavra(32) = "op"
    palavra(33) = "as"
    palavra(34) = "df"
    palavra(35) = "gh"
    palavra(36) = "jk"
    palavra(37) = "lç"
    palavra(38) = "zx"
    palavra(39) = "cv"
    palavra(40) = "bn"

    nome = inputbox("Informe seu nome: ", "Soletrando")  
    call sorteio
end sub

sub sorteio()
    set audio = createObject("SAPI.SPVOICE")
    audio.rate = 2          
    audio.volume = 100 

    randomize(second(time))
    if acertos >= 0 and acertos <= 5 then
        for i = 1 to 10 step 1 
            n = int(rnd * 10) + 1
        next
    elseif acertos > 5 and acertos <= 10 then
        for i = 11 to 20 step 1 
            n = int(rnd * 10) + 1
        next
    elseif acertos > 11 and acertos <= 15 then
        for i = 21 to 30 step 1 
            n = int(rnd * 10) + 1
        next
    elseif acertos = 16 then
        for i = 31 to 40 step 1 
            n = int(rnd * 10) + 1
        next
    end if

    audio.speak(palavra(n))
   
    opcaoJogo = cint(inputbox("Bem-vindo(a) ao S-o-l-e-t-r-a-n-d-o" + vbnewline & _
                         "" + vbnewline & _                         
                         "[1] Ouvir a palavra novamente" + vbnewline & _
                         "[2] Pular esta palavra", "Ola " & nome & "!"))

    if opcaoJogo = 1 then
        audio.speak(palavra(n))
        call jogo
    elseif opcaoJogo = 2 then
        call sorteio
    end if
end sub

sub jogo()   
    soletra = inputbox("")
end sub