function cool(input)
{
    let cnvinput = input;
    let hehe = "";

      for(let i = cnvinput.length - 1; i >= 0; i--)
      {
          let letter = cnvinput[i];
          if (i >= 0)
            hehe += letter;

          else
            Console.WriteLine("erro");
      }
    return hehe == cnvinput ? "###################\n##É um palíndromo##\n###################" : "########################\n##Não é um palíndromo##\n####################";
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