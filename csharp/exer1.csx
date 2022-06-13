///01. Implementar uma função que escreva no terminal os números naturais de 1 até um número informado.
///Ex: (10) => 1 2 3 4 5 6 7 8 9 10

///02. Implementar uma função que escreva no terminal os números naturais pares de 0 até um número informado.
///Ex: (10) => 0 2 4 6 8 10

///03. Implementar uma função que escreva no terminal os números naturais ímpares de 1 até um número informado.
///Ex: (10) => 1 3 5 7 9

///04. Implementar uma função que escreva no terminal os números naturais, a partir de um número de início e fim.
///Ex: (3, 11) => 3 4 5 6 7 8 9 10 11
public void cool(int input)
{
    for(int output = 1; output <= input; output++)
    {
        Console.WriteLine(output);
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