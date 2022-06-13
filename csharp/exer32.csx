//32. Implementar uma função que inverta os caracteres de um texto recebido.
//Ex: "Bruno" => "onurB"


public string cool(int input)
{
    string cnvinput = Convert.ToString(input); 
    string hehe = "";

      for(int i = cnvinput.Length - 1; i >= 0; i--)
      {
          char letter = cnvinput[i];
          if (i >= 0)
              hehe += letter;
          else
            Console.WriteLine("erro");
      }
    return hehe;
}

public void Main()
{
    try
    {
        Console.Write("Insert some numbers: ");
        int cnv = Convert.ToInt32(Console.ReadLine());
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