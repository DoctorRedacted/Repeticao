const readline = require('prompt-sync')();

function rept(input)
{
    let cont = 0;

    for(let i = 1; i <= input; i++)
    {
        cont += i;
    }
    return cont;
}

function Main()
{
    try
    {
        console.log("Insert a number");
        let rcv = Number(readline());
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