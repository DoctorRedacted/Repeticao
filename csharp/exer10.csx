public void cool(int input)
{
    for(int output = input*2; output <= input*2; output++)
    {
        Console.WriteLine("O dobro de {0} é: {1}", input, output);
    }
}

public void Main()
{
    try
    {
        Console.Write("insert a number:");
        int conv = Convert.ToInt32(Console.ReadLine());
        cool(conv);
    }
    
    catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();
