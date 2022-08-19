@echo off

mode 60,30
title Aula 02 - Numeros Randomicos e Contadores
color 0f

:inicio
cls
rem /a passa um atributo diretamente para a variavel
set /a cont= 0

:sorteio
cls
set /a num= (%random% %%100) + 1
set /a cont= %cont% + 1

echo.
echo ====================================
echo Numero sorteado: %num%
echo Quantidade de sorteio(s): %cont%
echo ====================================
echo.

set /p resp= Deseja sortear um novo numero? (S/N): 
if /i %resp% == s (goto:sorteio) else if /i %resp == n (exit)