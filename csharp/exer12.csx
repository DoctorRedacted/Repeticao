public void cool(int input)
{

    for(int output = 1; output <= input; output++)
    {  
        Console.Write(" *");
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
