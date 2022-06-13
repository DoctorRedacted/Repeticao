public int cool(string input, char input2)
{
    int novo = 0;

    for(int i = 0; i < input.Length; i++)
    {
        char see = input[i];
        int tst = see == input2 ? novo++ : novo;
    }
    return novo;
}

public void Main()
{
    try
    {
        Console.Write("Insert some numbers: ");
        string cnv = Console.ReadLine();
        Console.Write("Inserta number to see how may times it appears: ");
        char cnvagain = Convert.ToChar(Console.ReadLine());
        int send = cool(cnv, cnvagain);
        Console.WriteLine(send);
    }

    catch(Exception error)
    {
        Console.WriteLine("An error ocurred, brunex");
        Console.WriteLine(error.Message);
    }
}
Main();