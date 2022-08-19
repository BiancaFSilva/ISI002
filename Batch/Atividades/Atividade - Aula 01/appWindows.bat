@echo off

mode 60,30
title Atividade 01 - Aplicativos do Windows
color 0f

:inicio
cls

echo.
echo ====================================
echo        APLICATIVOS DO WINDOWS
echo ====================================
echo [1] Bloco de Notas
echo [2] Teclado Virtual
echo [3] Painel de Controle
echo [4] Calculadora
echo [5] Paint
echo [6] Windows Explorer
echo [x] Retornar ao Menu
echo ====================================
echo.

set /p op= Informe a opcao desejada: 

if %op% == 1 (goto:texto)
if %op% == 2 (goto:teclado)
if %op% == 3 (goto:painel)
if %op% == 4 (goto:calculadora)
if %op% == 5 (goto:paint)
if %op% == 6 (goto:explorer)
if /i %op% == x (call menu.bat)

:texto
start notepad.exe
goto:inicio

:teclado
start osk.exe
goto:inicio

:painel
start control.exe
goto:inicio

:calculadora
start calc.exe
goto:inicio

:paint
start mspaint.exe
goto:inicio

:explorer
start explorer.exe 
goto:inicio