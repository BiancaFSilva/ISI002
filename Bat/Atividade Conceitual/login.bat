@echo off

mode 60,30
title Atividade 01 - Login
color 0f

:inicio
cls

echo.
echo ====================================
echo                LOGIN
echo ====================================
echo.

set /p email= Email:
set /p senha= Senha:

if %email% == ads@fatec (
    if %senha% == 123a (call menu.bat)
) else (goto:inicio)