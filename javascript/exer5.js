const readline = require('prompt-sync')(); 

function rept(input, input2)
{
    for(let i = input; i >= input2; i--)
    {
        console.log(i);
    }
}

function Main()
{
    try
    {
        console.log("Insert a number");
        let rcv = readline();
        let rcvagain = readline(); 
        let snd = rept(rcv, rcvagain);
        console.log(snd);
    }

    catch(brunerr)
    {
        console.log("An error ocurred, during the process");
        console.log(brunerr.message);
    }
}
Main();