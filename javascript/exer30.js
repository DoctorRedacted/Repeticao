const readline = require('prompt-sync')();

function rept(input, input2)
{
    let output = 0;
    for(let i = 0; i < input.Length; i++)
    {
        let letter = input[i];
        let tst = letter == input2 ? output++ : output+=0;
    }
    return output; 
}

function Main()
{
    try
    {
        console.log("Insert a phrase");
        let rcv = readline();
        console.log("Insert a letter to seek for");
        let rcvr = readline();
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
