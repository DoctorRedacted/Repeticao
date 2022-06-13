const readline = require('prompt-sync')();

function rept(input)
{
    let cont = 1;

    for(let cond = 1; cond <= input; cond++)
    {  
        for(let cond2 = 1; cond2 <= cond; cond2++)
        {
            process.stdout.write(String(cont++ +" "));
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