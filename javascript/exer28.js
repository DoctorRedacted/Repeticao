function cool(input)
{
    let novo = 0;
    for(let i = 0; i < input.Length; i++)
    {
        let letter = input[i];
        let tst = letter == 'a' ? novo++ : letter == 'e' ? novo++ : letter == 'i' ? novo++ : letter == 'o' ? novo++: letter == 'u' ? novo++ : novo;
    }
    return novo;
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
