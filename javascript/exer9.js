const readline = require('prompt-sync')(); 

function rept(input, input2)
{
    let x = input;
    while (input <= input2)
    {
        console.log(input);
        input+=x;
    }
}
function Main()
{
    try
    {
        console.log("Insert a number");
        let rcv = Number(readline());
        console.log("Insert another number");
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