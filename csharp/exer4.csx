public void cool(int input, int input2)
{

    for(int output = input; output <= input2; output++)
    {
        Console.WriteLine(output);
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