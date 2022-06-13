public void cool(int input)
{
    for(int output = 0; output <= input; output++)
    {
        if(output % 2 == 0)
        Console.WriteLine(output);
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