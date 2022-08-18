@echo off

mode 60,30
title Atividade 01 - Gerenciamento do Sistema
color 0f

:inicio
cls

echo.
echo ====================================
echo       GERENCIAMENTO DO SISTEMA
echo ====================================
echo [1] Desligar a Maquina
echo [2] Reiniciar a Máquina
echo [x] Retornar ao Menu
echo ====================================
echo.

set /p op= Informe a opcao desejada: 

if %op% == 1 (goto:desliga)
if %op% == 2 (goto:reinicia)
if /i %op% == x (call menu.bat)

:desliga
shutdown

:reinicia
shutdown -r
