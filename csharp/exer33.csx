//33. Implementar uma função que verifique se um texto é um palíndromo.
//Ex: "luz azul" => true

public string cool(string input)
{
    string cnvinput = input;
    string hehe = "";

      for(int i = cnvinput.Length - 1; i >= 0; i--)
      {
          char letter = cnvinput[i];
          if (i >= 0)
            hehe += letter;

          else
            Console.WriteLine("erro");
      }
    return hehe == cnvinput ? "###################\n##É um palíndromo##\n###################" : "########################\n##Não é um palíndromo##\n####################";
}

public void Main()
{
    try
    {
        Console.Write("Insert a phrase: ");
        string cnv = Console.ReadLine();
        string send = cool(cnv);
        Console.WriteLine(send);
    }

    catch(Exception error)
    {
        Console.WriteLine("An error ocurred, brunex");
        Console.WriteLine(error.Message);
    }
}
Main();