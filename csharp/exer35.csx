//35. Implementar uma função que verifique se um número é um palíndromo.
//Ex: 1198911 => true

public bool cool(int input)
{
    string cnvinput = Convert.ToString(input);
    bool check = false;
    string throwing = "";

    for(int i = cnvinput.Length-1; i >= 0; i--)
    {
        char cnvt = cnvinput[i];
        if(i >= 0)
        { 
            throwing += cnvt;
        }
        else 
        {
            Console.WriteLine("An error ocurred, my fellow sir/miss");
        }
    }

    return throwing == cnvinput ? check = true : check;
}

public void Main()
{
    try
    {
    Console.WriteLine("Insert some numbers to see if it's palindrome");
    int conv = Convert.ToInt32(Console.ReadLine());
    bool send = cool(conv);
    Console.WriteLine(send);
    }

    catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();