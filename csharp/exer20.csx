public double cool(int input)
{
    double calc = 1;
    for(int i = 1; i <= input; i++)
    {
      calc *= i;
    }
   return calc;
}

public void Main()
{
  try
  {
    Console.Write("insert a number:");
    int conv = Convert.ToInt32(Console.ReadLine());
    double snd = cool(conv);
    Console.WriteLine(snd);
  }
  catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();