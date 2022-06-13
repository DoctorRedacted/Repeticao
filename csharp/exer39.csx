//39. Implementar uma função que verifique, sim ou não, se um número é primo.
//Ex: 17 => true

public bool cool(int input)
{
    bool num = false;
    for(int ver = 0; ver < 1; ver++)
    {
        Console.Write("It is true or false that {0} is a prime number? ", input);
    }
    return input % 2 != 0 ? num = true : input % input == 1 ? num = true : num;
}

public void Main()
{
    try
    {
        Console.Write("Insert a number, to see if it is a prime one: ");
        Console.Beep();
        int conv = Convert.ToInt32(Console.ReadLine());
        bool send = cool(conv);
        Console.WriteLine(send);
    }
    
    catch(Exception error)
    {
        Console.WriteLine("An error ocurred, brunex");
        Console.WriteLine(error.Message);
    }
}
Main();
