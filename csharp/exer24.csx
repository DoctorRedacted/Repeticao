public void cool(int input)
{
    int cont = 1;

    for(int cond = 1; cond <= input; cond++)
    {   
        for(int cond2 = 1; cond2 <= cond; cond2++)
        {
            Console.Write(cont++ + " ");
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