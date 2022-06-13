public int cool(int input)
{
    int calc = 0;
    for(int i = 1; i <= input; i++)
    {
        if(i % 2 == 0)
        {
            calc += i;
        }
    }
   return calc;
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