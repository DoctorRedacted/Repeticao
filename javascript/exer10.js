const readline = require('prompt-sync')();

function cool(input)
{
    for(let output = input*2; output <= input*2; output++)
    {
        process.stdout.write("O dobro é " + output);
    }
}

function Main() {
    process.stdout.write("Insert a number: ");
    let rcv = Number(readline());
    let snd = cool(rcv);
    console.log(snd);
}
Main();