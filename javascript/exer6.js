const readline = require('prompt-sync')(); 

function rept(input)
{
    for(let i = input; i >= 0; i--)
    {
        if(i % 2 == 0)
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