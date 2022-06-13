//36. Implementar uma função que converta uma palavra para ASCII. Dica: Use a função Convert.ToInt32(..) para C#, e charCodeAt(...) para JS.
//Ex: "Bruno" => "66 114 117 110 111"

public string cool(string input)
{
    string get = "";

    for(int i = 0; i < input.Length; i++)
    {
        char chr = input[i];
        int conv = System.Convert.ToInt32(chr);
        get += conv + " ";
    }
    return get;
}

public void Main()
{
    try
    {
        Console.WriteLine("Insert a phrase/number to be converted to ASCII");
        string rcv = Console.ReadLine();
        string snd = cool(rcv);
        Console.WriteLine(snd);
    }
    catch(Exception bruno)
    {
        Console.WriteLine("Ocorreu um erro, deve ser culpa do bruno...");
        Console.WriteLine(bruno.Message);
    }
}
Main();