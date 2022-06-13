public void cool(int input)
{
    for(int cond = 0; cond <= input; cond++)
    {  
        for(int cond2 = 0; cond2 < input; cond2++)
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

