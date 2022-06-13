const readline = require('prompt-sync')();

function cool(input)
{
    let strin = "";
    for(let i = 0; i < input.length; i++)
    {
        let letter = input[i];
        let conv = letter.charCodeAt(letter);
        strin += conv + " "; 
    }
    return strin;
}

function Main()
{
    try
    {
        console.log("Insert a phrase");
        let rcv = readline();
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