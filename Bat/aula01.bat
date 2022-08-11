@echo off

mode 60,30
title Aula 01 - Sistemas de Informacao
color 0f

:inicio
cls

echo.
echo ====================================
echo                MENU
echo ====================================
echo [1] Executar Word
echo [2] Executar Excel
echo [3] Ativar Teclado Virtual
echo [4] Calculadora
echo [5] Navegar na Web
echo [6] Testar Conexao de Rede
echo [7] Chamar Outra Tela
echo [x] Finalizar Programa
echo ====================================
echo.

set /p op= Informe a opcao desejada:

if %op% == 1 (goto:texto)
if %op% == 2 (goto:planilha)
if %op% == 3 (goto:teclado)
if %op% == 4 (goto:calculadora)
if %op% == 5 (goto:web)
if %op% == 6 (goto:rede)
if %op% == 7 (call aula01_tela2.bat)
if /i %op% == x (exit) else (
    echo.
    echo --INVALIDO--
    echo.

    pause
    goto:inicio
)

:texto
start winword.exe
goto:inicio

:planilha
start excel.exe
goto:inicio

:teclado
start osk.exe
goto:inicio

:calculadora
start calc.exe
goto:inicio

:web
echo. 
set /p site= Informe o link do site desejado: 
start chrome.exe %site%
goto:inicio

:rede
echo. 
set /p conexao= Informe o IP ou endereco do site: 
ping %conexao% -t
goto:inicio