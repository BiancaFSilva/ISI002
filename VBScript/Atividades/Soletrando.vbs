' Solicitar nome (por na barra de titulo), sortear uma palavra(15) e usar a saída de voz, 4 níveis
' Disponibilizar duas opções: ouvir a palavra novamente (1x rodada) e pular palavra (1x nivel) 
' Mudança de nivel a cada 5 acertos, Vence 15 acertos consecutivos
' Vetor: nivel 1 (1 a 10) pontos +1k , nivel 2 (11 a 20) pontos +10k, nivel 3 (21 a 30) pontos +100k, nivel 4 (31 a 40) pontos 1m
dim palavra(40), i, n
dim nome, soletra, nivel, acertos, pontos, resp
dim pularPalavra, repetirPalavra
dim audio

call novoJogo

sub novoJogo()
    nivel = 1
    pontos = 0
    acertos = 0

    pularPalavra = 1
    repetirPalavra = 1

    call carregaAudio
end sub

sub carregaAudio()
    set audio = createObject("SAPI.SPVOICE")
    audio.rate = 2          
    audio.volume = 100 

    call palavras
end sub

sub palavras()
    ' Nivel 1 - Fácil
    palavra(1) = "pirulito"
    palavra(2) = "jabuti"
    palavra(3) = "coleira"
    palavra(4) = "dezenove"
    palavra(5) = "jejum"
    palavra(6) = "tucano"
    palavra(7) = "faxina"
    palavra(8) = "morte"
    palavra(9) = "elite"
    palavra(10) = "xarope"
    ' Nivel 2 - Médio
    palavra(11) = "guerra"
    palavra(12) = "fósforo"
    palavra(13) = "emocionado"
    palavra(14) = "companhia"
    palavra(15) = "cérebro"
    palavra(16) = "ansioso"
    palavra(17) = "suspense"
    palavra(18) = "gastrite"
    palavra(19) = "irrequieto"
    palavra(20) = "capcioso"
    ' Nivel 3 - Difícil
    palavra(21) = "recôndito"
    palavra(22) = "putrefato"
    palavra(23) = "exceção"
    palavra(24) = "balbúrdia"
    palavra(25) = "arquétipo"
    palavra(26) = "cóccix"
    palavra(27) = "assertividade"
    palavra(28) = "fleumático"
    palavra(29) = "antropocentrismo"
    palavra(30) = "assoreamento"
    ' Nivel 4 - Expert
    palavra(31) = "verossimilhança"
    palavra(32) = "imunodeficiência"
    palavra(33) = "réveillon"
    palavra(34) = "fosforescência"
    palavra(35) = "zooplâncton"
    palavra(36) = "inconstitucionalissimamente"
    palavra(37) = "impeachment"
    palavra(38) = "otorrinolaringologista"
    palavra(39) = "quinquilharia"
    palavra(40) = "hebdomadário"

    call jogador
end sub

sub jogador()
    nome = inputbox("Bem-vindo(a) ao jogo Soletrando" + vbnewline & _
                    "" + vbnewline & _
                    "Informe seu nome: ", "Soletrando")    
    if nome = "" then
        msgbox("Nenhum nome digitado"), vbexclamation + vbokonly, "ATENCAO"
        call jogador
    end if

    call regras
end sub

sub regras()   
    msgbox("Esquema de Pontuacao:" + vbnewline & _
           "" + vbnewline & _
           "1. Facil:          1.000 pontos" + vbnewline & _
           "2. Medio:       10.000 pontos" + vbnewline & _
           "3. Dificil:        100.000 pontos" + vbnewline & _
           "4. Expert:       1.000.000 pontos" + vbnewline & _
           "" + vbnewline & _
           "A PALAVRA SERA REVELADA"), vbinformation + vbokonly, nome & " Soletra!"
    call sorteio
end sub

sub sorteio()   
    randomize(second(time))

    if acertos >= 0 and acertos <= 5 then
        for i = 1 to 10 step 1 
            n = int(rnd * 10) 
        next
    elseif acertos >= 6 and acertos <= 10 then
        for i = 11 to 20 step 1 
            n = int(rnd * 10) + 11
        next
    elseif acertos >= 11 and acertos <= 14 then
        for i = 21 to 30 step 1 
            n = int(rnd * 10) + 21
        next
    elseif acertos = 15 then
        for i = 31 to 40 step 1 
            n = int(rnd * 10) + 31
        next
    end if

    call revelaPalavra
end sub

sub revelaPalavra()    
    audio.speak(palavra(n))

    call jogo
end sub

sub jogo()
    soletra = inputbox("Digite corretamente a palavra que ouviu" + vbnewline & _  
                       "" + vbnewline & _  
                       "Opcoes: " + vbnewline & _                      
                       "[1] Ouvir a palavra novamente" + vbnewline & _
                       "[2] Pular esta palavra" + vbnewline & _
                       "[x] Sair" + vbnewline & _
                       "", nome & " Soletra!")

    if soletra = "1" and repetirPalavra = 1 then 
        repetirPalavra = repetirPalavra - 1

        audio.speak(palavra(n))   
        call jogo        
    elseif soletra = "1" and repetirPalavra = 0 then
        msgbox("Voce ja utilizou esta opcao" + vbnewline & _
               "O recurso de ouvir uma palavra novamente so pode ser acionado uma vez"), vbexclamation + vbokonly, "ATENCAO"
        call jogo
    elseif soletra = "2" and pularPalavra = 1 then  
        pularPalavra = pularPalavra - 1

        call sorteio           
    elseif soletra = "2" and pularPalavra = 0 then
        msgbox("Voce ja utilizou esta opcao" + vbnewline & _
               "O recurso de pular uma palavra so pode ser acionado uma vez"), vbexclamation + vbokonly, "ATENCAO" 
        call jogo      
    elseif soletra = "x" then
        wscript.quit
    elseif soletra = "" then
        msgbox("Nenhuma palavra digitada"), vbexclamation + vbokonly, "ATENCAO"
        call jogo
    end if

    if soletra = palavra(n) then
        acertos = acertos + 1

        if acertos >= 1 and acertos <= 5 then
            nivel = 1
            pontos = pontos + 1000
        elseif acertos >= 6 and acertos <= 10 then
            nivel = 2
            pontos = pontos + 10000
        elseif acertos >= 11 and acertos <= 14 then
            nivel = 3
            pontos = pontos + 100000
        elseif acertos = 15 then
            nivel = 4
            pontos = pontos + 1000000

            call vitoria
        end if        

        call placar
    elseif soletra <> palavra(n) then
        call placar
    end if
end sub

sub placar()
    msgbox("Seu jogo: " + vbnewline & _
           "" + vbnewline & _
           "Nivel: " & nivel & "" + vbnewline & _
           "Acertos: " & acertos & "" + vbnewline & _
           "Pontuacao: " & pontos), vbinformation + vbokonly, nome & " Soletra!"

    if soletra = palavra(n) then
        call sorteio
    elseif soletra <> palavra(n) then
        msgbox("Que pena, voce digitou a palavra " & palavra(n) & " errado! " + vbnewline & _
                        "" + vbnewline & _
                        "Deseja jogar novamente?"), vbinformation + vbyesno, nome & " Soletra!"
        if resp = vbyes then
            call novoJogo
        else
            wscript.quit
        end if
    end if
end sub

sub vitoria()
    msgbox("Vitória" + vbnewline & _
           "Voce conquistou o titulo MESTRE DA SOLETRAÇÃO"), vbinformation + vbokonly, nome & " Soletra!"
    call placar
end sub