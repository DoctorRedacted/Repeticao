//40. Implementar uma função que verifique qual é o número da sequência de fibonacci, a partir de uma posição informada.
//Sequência Fibonacci: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
//Ex: 10 => 55

/// 0 - 1 - 1 - 3 - 5 - 8 - 13

public int cool(int input)
{
    int before = 0;
    int calc = 0;
    int present = 1; 

  for(int i = 0; i < input; i++)
  {
    calc = before + present;
    before = present;
    present = calc;
  }
   return before;
}

public void Main()
{
  try
  {
    Console.Write("insert a number:");
    int conv = Convert.ToInt32(Console.ReadLine());
    int snd = cool(conv);
    Console.WriteLine(snd);
  }
  catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();