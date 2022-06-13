public void cool(int input)
{
    for(int row = 0; row < input *2; row++)
    {
        int totcolsnrow = row > input ? input * 2 -row: row;
        int nspcs = input - totcolsnrow;

        for(int cols = 0; cols < nspcs*2; cols++)
        {
            Console.Write(" ");
        }
        for(int coltoo = 1; coltoo < totcolsnrow*2; coltoo++)
        {
            Console.Write("* ");
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
        Console.WriteLine(conv);
    }
    
     catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();