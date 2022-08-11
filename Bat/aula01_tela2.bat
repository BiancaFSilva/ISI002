@echo off

mode 60,30
title Aula 01 - Sistemas de Informacao
color 02

:inicio
cls

echo.
echo ====================================
echo [R] Retornar ao Menu
echo ====================================
echo.

set /p op= Digite R: 
if /i %op% == r (call aula01.bat) else (
    echo.
    echo --INVALIDO--
    echo.

    pause
    goto:inicio
)