@echo off

mode 60,30
title Atividade 01 - Servicos de Rede
color 0f

:inicio
cls

echo.
echo ====================================
echo           SERVICOS DE REDE
echo ====================================
echo [1] Navegar na Web
echo [2] Obter o Endereco IP da Maquina
echo [3] Testar Conexao de Rede
echo [x] Retornar ao Menu
echo ====================================
echo.

set /p op= Informe a opcao desejada: 

if %op% == 1 (goto:web)
if %op% == 2 (goto:ip)
if %op% == 3 (goto:conexao)
if /i %op% == x (call menu.bat)

:web
echo. 
set /p site= Informe o link do site desejado: 
start firefox.exe %site%
goto:inicio

:ip
goto:inicio

:conexao
echo. 
set /p conexao= Informe o IP ou endereco do site: 
ping %conexao% -t
goto:inicio