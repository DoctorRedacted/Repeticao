const readline = require('prompt-sync')();

function rept(input)
{
    for(let row = 0; row < input *2; row++)
    {
        let totcolsnrow = row > input ? input * 2 -row: row;
        let nspcs = input - totcolsnrow;

        for(let cols = 0; cols < nspcs*2; cols++)
        {
            process.stdout.write(" ");
        }
        for(let coltoo = 1; coltoo < totcolsnrow*2; coltoo++)
        {
            process.stdout.write("* ");
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