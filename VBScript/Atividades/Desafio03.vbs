' Sequência de Fibonacci
dim num, fib, i, a, b
call inicio

sub inicio()
    num = cint(inputbox("Informe um número para terminar a sequência: ", "AVISO"))    
    fib = 0
    a = 0
    b = 1

    for i=1 to num step 1
        if i = 1 then 
            msgbox(b)
        else 
            fib = a + b
            a = b
            b = fib
            
            msgbox(fib)
        end if
    next
end sub