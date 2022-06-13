function cool(input, input2)
{
    let novo = 0;

    for(let i = 0; i < input.Length; i++)
    {
        let see = input[i];
        let = see == input2 ? novo++ : novo;
    }
    return novo;
}

function Main()
{
    try
    {
        console.log("Insert a sequence of numbers");
        let rcv = Number(readline());
        console.log("Insert a number to seek for");
        let rcvr = Number(readline());
        let snd = cool(rcv, rcvr);
        console.log(snd);
    }

    catch(brunerr)
    {
        console.log("An error ocurred, during the process");
        console.log(brunerr.message);
    }
}
Main();