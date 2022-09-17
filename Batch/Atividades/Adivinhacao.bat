@echo off
title Atividade - Adivinhacao
mode 60,30
color 0f

:inicio
    cls
    echo ============================================================
    echo                     Jogo da Adivinhacao
    echo ------------------------------------------------------------
    echo.
    echo Sorteamos um numero de 1 a 100, sera que voce adivinha esse numero em 5 tentativas?
    echo.
    echo ============================================================
    echo.
    set /p op= Deseja testar sua sorte? (S/N): 
    if /i %op% EQU s ( goto:sorteio )
    if /i %op% EQU n ( exit )

:sorteio
    set /a num= (%random% %%100) + 1    
    set /a vida= 5
    goto:jogo

:jogo
    cls
    echo ============================================================
    echo                     Jogo da Adivinhacao
    echo ------------------------------------------------------------
    echo.
    echo Digite um numero entre 1 e 100
    echo Tentativa(s) restante(s): %vida%
    echo Numero sorteado: %num%
    echo.
    echo ============================================================
    echo.        
    set /p sorte= Seu palpite: 

    rem Validação da entrada de dados
    if %sorte% GTR 100 (
        echo. 
        echo Digite um numero valido! 
    )
    if %sorte% LSS 1 ( 
        echo.
        echo Digite um numero valido! 
    )

    goto:verifica

:verifica
    set /a erro = %vida% - 1

    rem Compara o número sorteado com o número digitado
    if %sorte% EQU %num% ( 
        echo.
        echo VOCE VENCEU!        

        goto:novoJogo
    )
    if %sorte% LEQ %num% ( 
        echo.         
        set /p %sorte%= Tente um numero MAIOR: 
    ) 
    if %sorte% GEQ %num% ( 
        echo.  
        set /p %sorte%= Tente um numero MENOR: 
    )                       
    if %vida% EQU 0 (
        echo.
        echo VOCE PERDEU! 
        echo O numero sorteado era %num%

        goto:novoJogo
    )

    echo Tentativa(s) restante(s): %erro%
    goto:verifica

:novoJogo
    echo.
    set /p resp= Deseja jogar novamente? (S/N): 

    if /i %resp% == s ( goto:inicio ) 
    if /i %resp% == n ( exit )