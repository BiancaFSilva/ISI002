@echo off
title Atividade - Adivinhacao
mode 60,30
color 0f

:inicio
cls
echo ============================================================
echo                     Jogo da Adivinhacao
echo ------------------------------------------------------------
echo Sorteamos um numero de 1 a 100, sera que voce adivinha esse numero em 5 tentativas?
echo ============================================================
echo.
set /p op= Deseja testar sua sorte? (S/N): 
if /i %op% EQU s (goto:jogo)
if /i %op% EQU n (exit)

:jogo
set /a num= (%random% %%100) + 1
set /a vida= 5

cls
echo ============================================================
echo                     Jogo da Adivinhacao
echo ------------------------------------------------------------
echo.
echo Numero sorteado: %num%
for /l %%n in (5,-1,0) do (    
    echo Tentativa(s) restante(s): %vida%
    set /p sorte= Seu palpite: 
    echo.
    echo ============================================================
    echo.

    if %sorte% EQU %num% (goto:vitoria)
    if %sorte% LEQ %num% (
        set /a vida= %vida% - 1
        set /p sorte= Tente um numero MAIOR: 
    )
    if %sorte% GEQ %num% (
        set /a vida= %vida% - 1
        set /p sorte= Tente um numero MENOR: 
    )
    if %vida% EQU 0 (goto:derrota)
)

:vitoria
echo.
echo VOCE VENCEU!
echo.
set /p resp= Deseja jogar novamente? (S/N): 
if /i %resp% == s (goto:inicio) else if /i %resp == n (exit)

:derrota
echo.
echo VOCE PERDEU! 
echo O numero sorteado era %num%
echo.
set /p resp= Deseja jogar novamente? (S/N): 
if /i %resp% == s (goto:inicio) else if /i %resp == n (exit)