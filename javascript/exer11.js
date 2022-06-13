const readline = require('prompt-sync')();

function rept(input, input2)
{
    for(let i = 0; i <= input2; i++)
    {
        let calc = input * i;
        console.log(input + " x " + i + " = " + calc);
    }
}

function Main()
{
    try
    {
        console.log("Insert a number");
        let rcv = Number(readline());
        console.log("Insert a number");
        let rcvagain = Number(readline()); 
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