# Sistemas de Informação
Consiste em um sistema aplicável a todo mecanismo projetado com a finalidade de coletar, processar, armazenar e transmitir informações, a fim de facilitar o acesso de usuários, solucionando problemas e atendendo suas necessidades.

### Conteúdos Abordados
- [Recursos de Sistemas da Informação](#recursos-de-sistemas-da-informação)
  - [Recursos Humanos ](#recursos-humanos) 
  - [Recursos de Hardware](#recursos-de-hardware)
  - [Recursos de Software](#recursos-de-software)
    - [Tipos de Software](#tipos-de-software)
  - [Recursos de Armazenamento](#recursos-de-armazenamento)
  - [Recursos de Rede](#recursos-de-rede)
- [Pirâmide do Conhecimento](#pirâmide-do-conhecimento)
  - [Database](#database)
  - [Data Warehouse](#data-warehouse)
  - [Data Mining](#data-mining)
  - [Data Mart](#data-mart)
- [Pirâmide Empresarial](#pirâmide-empresarial)
- [Classificações dos Sistemas de Informação](#classificação-dos-sistemas-de-informação)
  - [Processamento Sequencial em Lote](#processamento-sequencial-em-lote) 
  - [Soluções de E-business](#soluções-de-e-business) 
    - [Siglas](#siglas-de-negócios) 
  - [Sistemas Online](#sistemas-online) 
  - [Sistemas Client/Server](#sistemas-clientserver) 

### Programação
- [Batch](#batch)  
  - [Variáveis](#variáveis)
  - [Expressões Lógicas](#expressões-lógicas)
  - [Estrutura do Arquivo .bat](#estrutura-do-arquivo-bat)
  - [Códigos](#código)
    - [Contador](#)
    - [Estruturas de Repetição](#estruturas-de-repetição)
    - [Números randômicos](#)
  - [Cores da Tela do Programa](#)
- [VBScript](#vbscript)  
  - [Variáveis](#variáveis-1)
  - [Expressões Lógicas](#expressões-lógicas-1)
  - [Estrutura do Arquivo .vbs](#estrutura-do-arquivo-vbs)
  - [Códigos](#código-1)
    - [Estruturas de Repetição](#estruturas-de-repetição-1)
  
--- 
 
# Recursos de Sistemas da Informação
## Recursos Humanos 
No geral é formado pelas pessoas que compôem a equipe envolvida no projeto: programadores, analistas, gerentes de projeto e usuários
## Recursos de Hardware 
Consiste em toda a <b>parte física</b> utilizada: máquinas e equipamentos no geral
## Recursos de Software 
Consiste em toda a <b>parte lógica</b> utilizada e/ou desenvolvida para o projeto: linguagens de programação, sistemas operacionais, sites, aplicativos e ferramentas de busca
### Tipos de Software
- <b>Básico: </b> representado pelo mínimo necessário para o funcionamento de um software. <b>Sistemas Operacionais</b> (ex.: Linux, Windows, IOS, Android, etc)
- <b>Aplicativo: </b> composto por todas as <b>ferramentas e aplicações</b> em geral (ex.: sites, aplicativos, linguagens, bibliotecas, frameworks, etc)
## Recursos de Armazenamento
Composto por toda estrutura que armazena as informações de um software. Estruturas de <b>Bancos de Dados</b> e repositórios/bases de conhecimentos
## Recursos de Rede
Consiste na estrutura de comunicação e compartilhamento de dados em geral; <i>networking</i>. São exemplos a <b>internet, intranet</b> (restrita à empresa) e <b>extranet</b> (empresarial, aberta a clientes e fornecedores) <br>
Também pode ser subdividido em tipos específicos:
| Rede                             | Descrição                                                       | Exemplo                                  |
|----------------------------------|-----------------------------------------------------------------|------------------------------------------|
| LAN (Local Área Network)         | Interliga computadores dentro de um mesmo espaço físico         | Intranet empresarial                     |
| MAN (Metropolitan Area Networks) | Interligação entre cidades e/ou regiões próximas                | Interligação de filiais de uma empresa   | 
| WAN (Wide Area Network)          | Interligação entre países e/ou continentes                      | Sistema de uma multinacional             |
| PAN (Personal Area Network)      | Comunicação por um distância limitada                           | Bluetooth, roteador residencial, 4 e 5G  |  
| WLAN (Wireless LAN)              | Transmissão de dados para <b>conexão com a internet</b>         | Protocolos TCP/IP, HTTP, SMTP e FTP       |

[🔝 Voltar ao Menu](#conteúdos-abordados)

---

# Pirâmide do Conhecimento
A pirâmide do conhecimento é dividida em quatro níveis principais: Dados, Informações, Conhecimento e Sabedoria, nos quais os dois primeiros representam o banco de dados e os dois últimos 
- <b>Dados: </b> informação bruta, obtida inicialmente
- <b>Informações: </b> são os dados (relevantes) processados, prontos para utilização
- <b>Conhecimento: </b> conjunto de teorias, ideias e conceitos a serem aplicados
- <b>Sabedoria: </b> capacidade de aplicar corretamente um conhecimento

![Pirâmide do Conhecimento](https://user-images.githubusercontent.com/60801421/191577722-bc4221fc-4ddc-4f24-9255-497164068d81.png)

## Database
Consiste no <b>local de armazenamento dos dados</b> brutos usados para capturar um sistema ou situação específica; podendo ser estruturados, não-estruturados, relacionais, não-relacionais ou SGBDs. <br>
Todo dado que entra é processado e armazendo em uma tabela específica, organizada para ter seu gerenciamento facilitado.

## Data Warehouse
> “Data Warehouse é uma coleção de dados orientados por assuntos, integrados, variáveis com o tempo e não voláteis, para dar suporte ao processo de tomada de decisão.” (INMON, William H. 1990)

Consiste no principal sistema analítico de uma organização: o <b>Armazém de Dados</b>, uma massa de dados que podem ser <b>aproveitados para análises e criação de relatórios</b> <br>
Principais Características:
- Armazena grandes quantidades de dados históricos para que os dados antigos não sejam apagados quando novos dados são atualizados.
- Captura dados de múltiplos bancos de dados organizados por assunto
- Trabalha com ODS (Operational Data Store) para armazenar dados normalizados e limpos
- Aplicação OLAP (Online Analytical Processing)

## Data Mining
A Mineração de Dados consiste no uso de processos para <b>explorar grandes quantidades de dados à procura de padrões</b> como regras de associação ou sequências temporais, descobrir relacionamentos sistemáticos e detectar novos subconjuntos de dados em uma pesquisa específica <br>
Principais Características:
- Coleta, pré-processamento, análise e refinamento de dados do Data Warehouse
- Limitação da visibilidade dos dados não essenciais
- Foca em um assunto ou unidade de negócios
- Atua como um mini armazém de dados, contendo dados agregados
- Consultas mais rápidas e seguras
## Data Mart
Subconjunto de Data Warehouse, forma simples de armazenamento dos dados <b>utilizado para acessar informações concentradas em um único assunto ou departamento</b>. É dividido em dois tipos:
- <b>Data Mart independente: </b> formada sem um data warehouse, serve como um sistema autônomo e fácil de desenvolver para objetivos de curto prazo
- <b>Data Mart dependente: </b> construído usando um data warehouse já existente. É preciso salvar todos os dados em um único local central e, em seguida, extrair uma parte específica para análise. 

Principais Características do Data Mart:
- Gerenciamento de dados simples e escalável
- Fonte confiável, acesso e implementação mais rápidos

![Exemplificação](https://user-images.githubusercontent.com/60801421/191600251-6d85ff13-b5dd-42b7-b1f7-70bea3dedada.png)

Em suma Big Data refere-se à quantidade de dados produzidos diariamente, Data Mining é a “mineração” destes dados, Data Warehouse é um depósito de dados digitais e Data Mart é a segmentação de um data warehouse.

[🔝 Voltar ao Menu](#conteúdos-abordados)

---

# Pirâmide Empresarial
A pirâmide empresarial consiste na representação visual dos cargos de uma empresa dividida em três níveis principais: Operacional, Tático e Estratégico
- <b>Operacional: </b> analistas, programadores e usuários
- <b>Tático ou Gerencial: </b> gerente de projetos e/ou equipes
- <b>Estratégico: </b> CEO, diretores, presidentes

![Pirâmide Empresarial](https://user-images.githubusercontent.com/60801421/191602510-3e39ba2d-7538-4f16-b392-25fe7a713022.png)

[🔝 Voltar ao Menu](#conteúdos-abordados)

---

# Classificação dos Sistemas de Informação
Existem diversos sistemas de classificação, com conceitos e soluções previamente definidas.
## Processamento Sequencial em Lote 
Também conhecido como <b>Sistemas Batch</b>, o processamento sequencial em lote permite a transmissão de forma sequencial de um conjunto de dados pré-determinados
## Soluções de E-business 
Consiste em todo o processo de negociação e/ou transações financeiras, de bens e serviços que uma empresa faz pela internet
### Siglas de Negócios
Em 1997, a IBM passou a utilizar siglas para englobar áreas de negócios online, como o <b>e-business</b> e o <b>e-commerce</b>. Atualmente existem diversas siglas para definir modelos de negócio, dentre elas são destacadas:
| Sigla     | Relação                |
|:---------:|------------------------|
| B2B       | Business to Business   |
| B2C       | Business to Customer   |
| C2B       | Customer to Business   |
| C2C       | Customer to Business   |
| B2E       | Business to Employee   |
| B2G       | Business to Government |
## Sistemas Online
Como o próprio nome diz, as soluções de sistemas online se dão no meio virtual envolvendo todas as operações de um e-business ou e-commerce
## Sistemas Client/Server
O sistema cliente-servidor consiste em um modelo de aplicação distribuída, onde existem os fornecedores de recursos ou serviços (servidores) e os usuários destes recursos ou serviços (clientes)

[🔝 Voltar ao Menu](#conteúdos-abordados)

---

# Batch
Consiste em uma linguagem de processamento em lote que informa a os comandos a serem executados pelo intérprete da linha de comando, tais comando geralmente são armazenados em um arquivo de texto simples. <br>
Quase toda tarefa ou ação pode ser executada por uma simples sequência de comandos salvos em um arquivo .bat ou digitados no prompt de comando do Windows. 

## Variáveis 


## Expressões Lógicas
| Nome                      | Símbolo             |
|---------------------------|:-------------------:|
| Igual                     | EQU ou ==           |
| Diferente                 | NEQ                 |
| Menor                     | LSS                 |
| Menor ou Igual            | LEQ                 |
| Maior                     | GTR                 |
| Maior ou Igual            | GEQ                 |
| Negação                   | NOT                 |
| Existe                    | EXIST               |

## Estrutura do Arquivo .bat

```batch
@echo off
mode 60,30
title Estrutura Batch
color 0f

:inicio
  cls
  echo.
  echo MENU
  echo [1] Outra tela
  echo [2] Outra sub-rotina
  echo [3] Abrir aplicativo externo
  echo [x] Sair
  echo.
  set /p op= Informe a opcao desejada: 

  if %op% == 1 (call exemplo.bat)
  if %op% == 2 (goto:tela2)
  if %op% == 3 (goto:app)
  if /i %op% == x (exit)

:tela2
  cls
  echo.
  echo Estamos em uma outra tela!
  echo.

  pause
  goto:inicio
  
:app
  rem Inicia a calculadora
  start calc.exe
  goto:inicio
```

## Código
Exemplos de códigos simples
### Contador
```batch
set /a cont= %cont% + 1
```
### Estruturas de Repetição
```batch
for /l %%var in (inicio, incremento, fim) do (comandos)
```
### Números randômicos
```batch
set /a num= (%Random% %% maiorNumero) + 1
```

[🔝 Voltar ao Menu](#conteúdos-abordados)

---

# VBScript
Consiste em uma linguagem desenvolvido pela Microsoft criada a partir no Visual Basic, permite controle completo sobre muitos aspectos de ambiente computacional, de forma que o usuário pode gerar ferramentas para gerenciar computadores com manipulação de erros, sub-rotinas e outras construções de programação avançadas.
## Variáveis 
## Estrutura do Arquivo .vbs
## Código
### Estruturas de Repetição

[🔝 Voltar ao Menu](#conteúdos-abordados)
