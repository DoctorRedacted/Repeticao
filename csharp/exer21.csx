//21. Implementar uma função que calcule a potenciação a partir de um número e do expoente. Obs: Essa versão da potenciação deve se preocupar apenas com números naturais, ou seja, inteiros positivos. Se a potência for zero, retorne 1. Se algum parâmetro for negativo, lançar um erro.
//Ex: Potência de 3 elevado a 3 => 27

public double pow(int num, int exp)
{   
    double calc = Math.Pow(num, exp);
    for(double cool = 0; cool <= calc; cool++)
    {
        cool += calc;
    }
    return calc;
}

public void Main()
{
  try
  {
    Console.Write("insert a number:");
    int conv = Convert.ToInt32(Console.ReadLine());
    Console.Write("insert another number:");
    int conv2 = Convert.ToInt32(Console.ReadLine());
    double send = pow(conv, conv2);
    Console.WriteLine(send);
  }
  catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();

