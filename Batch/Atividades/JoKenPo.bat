@echo off
title Atividade - Jo Ken Po
mode 60,30
color 0f

:inicio
    cls

    set /a ganha= 0
    set /a perde= 0
    set /a empata= 0

    echo ============================================================
    echo                          JO KEN PO
    echo ------------------------------------------------------------
    echo.
    echo [1] Novo Jogo
    echo [2] Regras
    echo [x] Sair
    echo.
    echo ============================================================
    echo.

    set /p nome= Informe seu nome: 
    set /p op= Digite a opcao desejada: 

    if %op% EQU 1 ( goto:jogo )
    if %op% EQU 2 ( goto:regras )
    if /i %op% EQU x ( exit ) else (
        echo Opcao invalida...

        pause > nul
        goto:inicio
    )

:regras
    cls
    echo ============================================================
    echo                            REGRAS
    echo ------------------------------------------------------------
    echo.
    echo PEDRA: ganha de tesoura e lagarto, perde para Spock e papel,empata com pedra
    echo.
    echo PAPEL: ganha de pedra e Spock, perde para tesoura e lagarto,empata com papel
    echo.
    echo TESOURA: ganha de papel e lagarto, perde para pedra e Spock,empata com tesoura
    echo.
    echo LAGARTO: ganha de papel e Spock, perde para pedra e tesoura,empata com lagarto
    echo.
    echo SPOCK: ganha de pedra e tesoura, perde para lagarto e papel,empata com Spock
    echo.
    echo ============================================================
    echo.

    pause > nul
    goto:inicio

:jogo
    cls
    rem Sorteia a jogada da máquina
    set /a sort= (%random% %%5) + 1

    echo ============================================================
    echo                          JO KEN PO
    echo ------------------------------------------------------------
    echo.
    echo Bem-vindo(a) %nome%, essas sao suas opcoes:
    echo.
    echo          [1] Pedra      [2] Papel      [3] Tesoura
    echo          [4] Lagarto    [5] Spock      [x] Sair
    echo.
    set /p op= Digite a opcao desejada: 
    echo.
    echo ============================================================
    echo.
    if /i %op% EQU x ( exit ) 

    rem Mostra a jogada 
    if %op% EQU 1 ( echo %nome% escolheu PEDRA )
    if %op% EQU 2 ( echo %nome% escolheu PAPEL )
    if %op% EQU 3 ( echo %nome% escolheu TESOURA )
    if %op% EQU 4 ( echo %nome% escolheu LAGARTO )
    if %op% EQU 5 ( echo %nome% escolheu SPOCK )    

    rem Mostra a jogada da máquina
    if %sort% EQU 1 ( echo Computador escolheu PEDRA )
    if %sort% EQU 2 ( echo Computador escolheu PAPEL )
    if %sort% EQU 3 ( echo Computador escolheu TESOURA )
    if %sort% EQU 4 ( echo Computador escolheu LAGARTO )
    if %sort% EQU 5 ( echo Computador escolheu SPOCK )

    rem Compara as jogas e define se houve vitório, derrota ou empate
    if %op% EQU %sort% ( set /a empata= %empata% + 1 )

    if %op% EQU 1 (
        if %sort% EQU 3 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 4 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 2 ( set /a perde= %perde% + 1 )
        if %sort% EQU 5 ( set /a perde= %perde% + 1 )
    )   
    if %op% EQU 2 (
        if %sort% EQU 1 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 5 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 3 ( set /a perde= %perde% + 1 )
        if %sort% EQU 4 ( set /a perde= %perde% + 1 )
    ) 
    if %op% EQU 3 (
        if %sort% EQU 2 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 4 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 1 ( set /a perde= %perde% + 1 )
        if %sort% EQU 5 ( set /a perde= %perde% + 1 )
    ) 
    if %op% EQU 4 (
        if %sort% EQU 2 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 5 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 1 ( set /a perde= %perde% + 1 )
        if %sort% EQU 3 ( set /a perde= %perde% + 1 )
    ) 
    if %op% EQU 5 (
        if %sort% EQU 1 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 3 ( set /a ganha= %ganha% + 1 )
        if %sort% EQU 2 ( set /a perde= %perde% + 1 )
        if %sort% EQU 4 ( set /a perde= %perde% + 1 )
    ) 

    echo.
    echo ------------------------------------------------------------
    echo.
    echo   Vitoria(s): %ganha%         Empate(s): %empata%         Derrota(s): %perde%
    echo.
    echo ============================================================
    echo.

    set /p op= Deseja jogar novamente? (S/N): 
    if /i %op% EQU s ( goto:jogo )
    if /i %op% EQU n ( exit )