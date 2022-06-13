public int cool(string input)
{
    int novo = 0;
    for(int i = 0; i < input.Length; i++)
    {
        char letter = input[i];
        int tst = letter == 'a' ? novo++ : letter == 'e' ? novo++ : letter == 'i' ? novo++ : letter == 'o' ? novo++: letter == 'u' ? novo++ : novo;
    }
    return novo;
}

public void Main()
{
    try
    {
        Console.Write("insert a phrase:");
        string conv = Console.ReadLine();
        int send = cool(conv);
        Console.WriteLine(send);
    }

     catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();