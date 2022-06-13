const readline = require('prompt-sync')();

function cool(input)
{
    let before = 0;
    let calc = 0;
    let present = 1; 

  for(let i = 0; i < input; i++)
  {
    calc = before + present;
    before = present;
    present = calc;
  }
   return before;
}

function Main()
{
    try
    {
        console.log("Insert a number, for fibonacci position");
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