const readline = require('prompt-sync')();

function cool(input)
{
    let cnvinput = String(input);
    let check = false;
    let throwing = "";

    for(let i = cnvinput.length -1; i >= 0; i--)
    {
        let cnvt = cnvinput[i];
        if(i >= 0)
        { 
            throwing += cnvt;
        }
        else 
        {
            console.log("An error ocurred, my fellow sir/miss");
        }
    }

    return throwing == cnvinput ? check = true : check = false;
}


function Main()
{
    try
    {
        console.log("Insert a phrase");
        let rcv = Number(readline());
        let snd = cool(rcv);
        console.log(snd);
    }

    catch(brunerr)
    {
        console.log("An error ocurred, during the process");
        console.log(brunerr.message);
    }
}
Main();