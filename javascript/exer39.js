const readline = require('prompt-sync')();

function cool(input)
{
    let num = false;
    for(let ver = 0; ver < 1; ver++)
    {
        console.log("It is true or false that {0} is a prime number? ", input);
    }
    return input % 2 != 0 ? num = true : input % input == 1 ? num = true : num;
}

function Main()
{
    try
    {
        console.log("Insert a number");
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