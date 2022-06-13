const readline = require('prompt-sync')();

function rept(input)
{
    let rspt = "";

    for(let cond = 0; cond < input.length; cond++)
    {  
        let letter = input[cond];
        rspt += letter + "-";
    }
    return rspt;
}

function Main()
{
    try
    {
        console.log("Insert a phrase");
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