### Símbolos e Expressões Lógicas

| Nome                      | Símbolo        |
|---------------------------|:--------------:|
| Igual                     | EQU            |
| Diferente                 | NEQ            |
| Menor                     | LSS            |
| Menor ou Igual            | LEQ            |
| Maior                     | GTR            |
| Maior ou Igual            | GEQ            |
| Negação                   | NOT            |
| Existe                    | EXIST          |

#### Estrutura de repetição
```batch
for /l %%var in (inicio, incremento, fim) do (comandos)
```

#### Contador simples
```batch
set /a cont= %cont% + 1
```

#### Número randômico
```batch
set /a num= (%Random% %% maiorNumero) + 1
```