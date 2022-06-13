function cool(input)
{
    let a = 0;
    let e = 0;
    let i = 0;
    let o = 0;
    let u = 0;
    let see = false;

    for(let cont = 0; cont < input.Length; cont++)
    {
        let letter = input[cont];
        let tst = letter == 'a' ? a++ : letter == 'e' ? e++ : letter == 'i' ? i++ : letter == 'o' ? o++ : letter == 'u' ? u++ : 0;
    }

    see = a > 0 && e > 0 && i > 0 && o > 0 && u > 0 ? true:false;
    return see;
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
