public void cool(int input)
{
    for(int cond = 1; cond <= input; cond++)
    {  
        for(int cond2 = cond; cond2 < input * 2; cond2++)
        {
            Console.Write(" ");
        }
        for(int cond3 = 1; cond3 < cond * 2; cond3++)
        {
            Console.Write(cond3);
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