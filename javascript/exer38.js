const readline = require('prompt-sync')();

function cool(input)
{
    let get = "";
    for(let i = 0; i < input.length; i++)
    {
        let chr = input[i];
        let conv = chr.charCodeAt(chr);

        if(conv >= 128)
        {
            conv -= 128;
            get += "1";
        }
        else 
        {
            get += "0";
        }

        if(conv >= 64)
        {
            conv -= 64;
            get += "1";
        }
        else 
        {
            get += "0";
        }

        if(conv >= 32)
        {
            conv -= 32;
            get += "1";   
        }
        else 
        {
            get += "0";
        }

        if(conv >= 16)
        {  
            conv -= 16;
            get += "1";
        }  
        else 
        {
            get += "0";
        }

        if(conv >= 8)
        {
            conv -= 2;
            get += "1";
        }
        else 
        {
            get += "0";
        }

        if(conv >= 4)
        {
            conv -= 4;
            get += "1";
        }
        else 
        {
            get += "0";
        }

        if(conv >= 2)
        {
            conv -= 2;
            get += "1";
        }
        else 
        {
            get += "0";
        }


        if(conv >= 1)
        {
            conv -= 1;
            get += "1";
        }

        else if(conv == 0)
        {
            get += "0" + " ";
        }
    }
    ///Jamais imaginei vender minha alma de tal forma...
    return get;
}


function Main()
{
    try
    {
        console.log("Insert a phrase/numbers");
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