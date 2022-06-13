const readline = require('prompt-sync')();

function rept(input)
{
    for(let i = 0; i < input; i++)
    {
        for(let ii = 0; ii <= input; ii++)
        {
            process.stdout.write(" *");
        }
        console.log();
    }
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