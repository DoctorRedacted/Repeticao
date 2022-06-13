public void cool(int input, int input2)
{
    for(int cond = 0; cond < input; cond++)
    {  
        for(int cond2 = 0; cond2 < input2; cond2++)
        {
        Console.Write(" *");
        }
        Console.WriteLine();
    }
}
public void Main()
{
    try
    {
        Console.Write("insert a row: ");
        int conv = Convert.ToInt32(Console.ReadLine());
        Console.Write("insert column: ");
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

