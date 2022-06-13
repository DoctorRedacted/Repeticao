public void cool(int input, int input2)
{
    int x = input;
    while (input <= input2)
    {
        Console.WriteLine(input);
        input+=x;
    }
}

public void Main()
{
    try
    {
        Console.Write("insert a number:");
        int conv = Convert.ToInt32(Console.ReadLine());
        Console.Write("insert a second number:");
        int conv2 = Convert.ToInt32(Console.ReadLine());
        cool(conv, conv2);
    }
    
    catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();
