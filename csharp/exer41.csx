//41. Implementar uma função que implemente a criptografia ZENIT POLAR.
//Ex: "bruno" => "btule"

//O Z substitui o P e vice e versa.
//O E substitui o O e vice e versa.
//O N substitui o L e vice e versa.
//O I substitui o A e vice e versa.
//O T substitui o R e vice e versa.


public string cool(string input)
{
    string armz = "";

    for(int i = 0; i < input.Length; i++)
    {
        char see = input[i];
        string zenpol = see == 'p' ? armz += "z" : see == 'z' ? armz += "p" : see == 'e' ? armz += "o" : see == 'o' ? armz += "e" : see == 'n' ? armz += "l" : see == 'l' ? armz += "n" : see == 'i' ? armz += "a" : see == 'a' ? armz += "i" : see == 't' ? armz += "r" : see == 'r' ? armz += "t" : armz += see; 
    }
    return armz;
}

public void Main()
{
    Console.WriteLine("Insert a phrase to be converted to zenit polar");
    string rcv = Console.ReadLine();
    string send = cool(rcv);
    Console.WriteLine(send);
}
Main();