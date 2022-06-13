//34. Implementar uma função que inverta os digitos de um número recebido.
//Ex: 12345 => 54321
public bool cool(string input)
{
    bool check = false;
    string trueone = "";

    for(int i = input.Length-1; i >= 0; i--)
    {
        char letter = input[i];
        if(i >= 0)
        { 
            trueone += letter;
        } 
    }
     return trueone == input ? check = true:check ;
}

public void Main()
{
    try
    {
        Console.WriteLine("Insert some numbers, so it can be inverted");
        string receive = Console.ReadLine();
        bool send = cool(receive);
        Console.WriteLine(send);
    }

    catch(Exception error)
    {
        Console.WriteLine("An error ocurred, brunex");
        Console.WriteLine(error.Message);
    }
}
Main();

