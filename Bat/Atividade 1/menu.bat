@echo off

mode 60,30
title Atividade 01 - Menu Principal
color 0f

:inicio
cls

echo.
echo ====================================
echo            MENU PRINCIPAL
echo ====================================
echo [P] Pacote Office
echo [A] Aplicacoes Windows
echo [S] Servicos de Redes
echo [G] Gerenciamento do Sistema
echo [E] Encerrar Sessao
echo [F] Finalizar Programa
echo ====================================
echo.

set /p op= Informe a opcao desejada: 

if /i %op% == p (call pacoteOffice.bat)
if /i %op% == a (call appWindows.bat)
if /i %op% == s (call redes.bat)
if /i %op% == g (call gerenciamento.bat)
if /i %op% == e (goto:termina) 

if /i %op% == f (exit) 

:termina
set /p encerra= Realmente deseja encerrar a sessao? (S/N): 
if /i %encerra% == s (call login.bat) else (
    if /i %encerra% == n (goto:inicio) else (
        echo.
        echo ENTRADA INVALIDA
        echo.
    )
)