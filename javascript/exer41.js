//41. Implementar uma função que implemente a criptografia ZENIT POLAR.
//Ex: "bruno" => "btule"

//O Z substitui o P e vice e versa.
//O E substitui o O e vice e versa.
//O N substitui o L e vice e versa.
//O I substitui o A e vice e versa.
//O T substitui o R e vice e versa.

const readline = require('prompt-sync')();

function cool(input)
{
    let armz = "";

    for(let i = 0; i < input.Length; i++)
    {
        let see = input[i];
        let zenpol = see == 'p' ? armz += "z" : see == 'z' ? armz += "p" : see == 'e' ? armz += "o" : see == 'o' ? armz += "e" : see == 'n' ? armz += "l" : see == 'l' ? armz += "n" : see == 'i' ? armz += "a" : see == 'a' ? armz += "i" : see == 't' ? armz += "r" : see == 'r' ? armz += "t" : armz += see; 
    }
    return armz;
}


function Main()
{
    try
    {
        console.log("Insert a phrase for ZENIT POLAR");
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