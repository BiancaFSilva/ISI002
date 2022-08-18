@echo off

mode 60,30
title Aula 02 - Gerenciamento de Arquivos
color 0f

:inicio
cls

echo.
echo ====================================
echo      GERENCIAMENTO DE ARQUIVOS
echo ====================================
echo [1] Gerar Arquivos 
echo [2] Organizar Arquivos
echo [3] Ocultar Arquivos e Pastas
echo [4] Exibir Arquivos e Pastas
echo [5] Excluir Arquivos e Pastas
echo [x] Finalizar Programa
echo ====================================
echo.

set /p op= Digite a opcao desejada: 

if %op% == 1 (goto:gerar)
if %op% == 2 (goto:organizar)
if %op% == 3 (goto:ocultar)
if %op% == 4 (goto:exibir)
if %op% == 5 (goto:excluir)
if /i %op% == x (exit) else (
	echo.
	echo ====================================
	echo            OPCAO INVALIDA
	echo ====================================
	echo.
	
	pause
	goto:inicio)
	
:gerar
echo.
set /p arquivo= Digite o nome do arquivo a ser gerado: 
set /p qtde= Digite a quantidade de arquivos a serem gerados: 
set /p ext= Digite a extensao do arquivo: 

rem Usado para loops
for /l %%n in (1,1,%qtde%) do (echo fatecSCS > %arquivo%%%n.%ext%)

echo.
echo ====================================
echo     ARQUIVOS CRIADOS COM SUCESSO
echo ====================================
echo.
goto:inicio

:organizar
echo.
set /p pasta= Digite o nome da pasta a ser criada: 
set /p endereco= Digite o diretorio da nova pasta: 
set /p ext= Digite a extensao do arquivo a ser organizado: 

md %pasta% 
move *.%ext% %endereco%\%pasta%

echo.
echo ====================================
echo     ARQUIVOS MOVIDOS COM SUCESSO
echo ====================================
echo.
goto:inicio

:ocultar
echo.
set /p pasta= Digite a pasta ou arquivo a ser ocultada: 
rem h = hidden e r = read
attrib %pasta% +h +r 

echo.
echo ====================================
echo    ARQUIVOS OCULTADOS COM SUCESSO
echo ====================================
echo.
goto:inicio

:exibir
echo.
set /p pasta= Digite a pasta ou arquivo a ser exibida: 
rem o sinal - serve para desfazer a ocultacao
attrib %pasta% -h -r 

echo.
echo ====================================
echo    ARQUIVOS EXIBIDOS COM SUCESSO
echo ====================================
echo.
goto:inicio

:excluir
echo. 
set /p pasta= Digite a pasta a ser excluida: 
set /p confirma= Deseja realmente excluir o diretorio? (S/N): 

if /i %confirma% == s (
	c: 
	rem chama o diretorio
	cd C:\Users\Aluno\Desktop\SI-ADSMA2
	rem /f exclui arquivos da pasta
	rem /s exclui sem confirmacao do sim
	rem /q excluir sem enviar para a lixeira
	del /f /s /q %pasta%
	rem exclui a pasta vazia
	rd %pasta%
	
	echo.
	echo ====================================
	echo    ARQUIVOS EXCLUIDOS COM SUCESSO
	echo ====================================
	echo.) else if /i %confirma% == n (
	echo.
	echo ====================================
	echo          ARQUIVOS MANTIDOS
	echo ====================================
	echo.
	goto:inicio) else (
	echo.
	echo ====================================
	echo            OPCAO INVALIDA
	echo ====================================
	echo.
	
	pause
	goto:inicio)