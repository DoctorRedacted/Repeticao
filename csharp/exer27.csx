public string cool(string input)
{
    string hehe = "";
    int contador = 0;
    for(int i = 0; i < input.Length; i++)
    {
        char letter = input[i];
        if (i == input.Length) 
        {
            contador++;
            hehe += contador;
        }
        else 
        {
            hehe += letter + " - ";
        }
    }
    return hehe;
}

public void Main()
{
    try
    {
        Console.Write("insert a phrase:");
        string conv = Console.ReadLine();
        cool(conv);
    }

     catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();