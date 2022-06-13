const readline = require('prompt-sync')();

function cool(input)
{
    let check = false;
    let trueone = "";

    for(let i = input.length-1; i >= 0; i--)
    {
        let letter = input[i];
        if(i >= 0)
        { 
            trueone += letter;
        } 
    }
     return trueone == input ? check = true:check ;
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