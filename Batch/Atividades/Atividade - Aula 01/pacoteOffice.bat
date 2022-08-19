@echo off

mode 60,30
title Atividade 01 - Pacote Office
color 0f

:inicio
cls

echo.
echo ====================================
echo             PACOTE OFFICE
echo ====================================
echo [1] Word
echo [2] Excel
echo [3] PowerPoint
echo [4] Access
echo [x] Retornar ao Menu
echo ====================================
echo.

set /p op= Informe a opcao desejada:

if %op% == 1 (goto:texto)
if %op% == 2 (goto:planilha)
if %op% == 3 (goto:slide)
if %op% == 4 (goto:dados)

if /i %op% == x (call menu.bat)

:texto
start winword.exe
goto:inicio

:planilha
start excel.exe
goto:inicio

:slide
start powerpnt.exe
goto:inicio

:dados
start msaccess.exe
goto:inicio