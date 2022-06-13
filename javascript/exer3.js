///01. Implementar uma função que escreva no terminal os números naturais de 1 até um número informado.
///Ex: (10) => 1 2 3 4 5 6 7 8 9 10

///02. Implementar uma função que escreva no terminal os números naturais pares de 0 até um número informado.
///Ex: (10) => 0 2 4 6 8 10

///03. Implementar uma função que escreva no terminal os números naturais ímpares de 1 até um número informado.
///Ex: (10) => 1 3 5 7 9

///04. Implementar uma função que escreva no terminal os números naturais, a partir de um número de início e fim.
///Ex: (3, 11) => 3 4 5 6 7 8 9 10 11


const readline = require('prompt-sync')(); 

function rept(input)
{
    for(let i = 1; i <= input; i++)
    {
        if(i % 2 != 0)
        {
            console.log(i);
        }
    }
}

function Main()
{
    try
    {
        console.log("Insert a number");
        let rcv = readline();
        let snd = rept(rcv);
        console.log(snd);
    }

    catch(brunerr)
    {
        console.log("An error ocurred, during the process");
        console.log(brunerr.message);
    }
}
Main();