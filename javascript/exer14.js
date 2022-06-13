const readline = require('prompt-sync')();

function rept(input, secinput)
{
    for(let i = 0; i < input; i++)
    {
        for(let ii = 0; ii < secinput; ii++)
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
        console.log("Insert another number");
        let rcvr = Number(readline());
        let snd = rept(rcv, rcvr);
        console.log(snd);
    }

    catch(brunerr)
    {
        console.log("An error ocurred, during the process");
        console.log(brunerr.message);
    }
}
Main();