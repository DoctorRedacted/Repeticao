const readline = require('prompt-sync')();

function rept(input)
{

    for(let cond = 1; cond <= input; cond++)
    {  
        for(let cond2 = cond; cond2 <= input; cond2++)
        {
            process.stdout.write(" ");
        }
        for(let cond3 = 0; cond3 < cond; cond3++)
        {
            process.stdout.write(" "+ String(cond));
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