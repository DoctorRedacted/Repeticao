//37. Implementar uma função que verifique se uma senha é forte. Para ser forte, ela precisa ter pelo menos 2 caracteres especiais, 2 números e 8 digitos.
//Ex: "bruno@123#" => true

const readline = require('prompt-sync')();

function cool(input)
{
    let cntnum = 0;
    let ctnnum = 0;
    let fnvalue = false;

    for(let i = 0; i < input.Length; i++)
    {
        let see = input[i];
        let chng = input.Length >= 8 ? fnvalue = true : fnvalue = false;
        let seer = Char.IsNumber(see) ? cntnum++ : cntnum;   
        let envy = see == '!' ? ctnnum++ : see == '@' ? ctnnum++ : see == '#' ? ctnnum++ : ctnnum == '$' ? ctnnum++ : ctnnum == '$' ? ctnnum++ : ctnnum;
    }
     if(cntnum >= 2 && ctnnum >= 2)
     {
         fnvalue = true;
     }
     else
     {
         fnvalue = false;
     }
    return fnvalue;
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