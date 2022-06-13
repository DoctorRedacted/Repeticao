public bool cool(string input)
{
    int a = 0;
    int e = 0;
    int i = 0;
    int o = 0;
    int u = 0;
    bool see = false;

    for(int cont = 0; cont < input.Length; cont++)
    {
        char letter = input[cont];
        int tst = letter == 'a' ? a++ : letter == 'e' ? e++ : letter == 'i' ? i++ : letter == 'o' ? o++ : letter == 'u' ? u++ : 0;
    }

    see = a > 0 && e > 0 && i > 0 && o > 0 && u > 0 ? true:false;
    return see;
}

public void Main()
{
    try
    {
        Console.Write("insert a phrase: ");
        string conv = Console.ReadLine();
        bool x = cool(conv);
        Console.WriteLine(x);
    }

     catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();