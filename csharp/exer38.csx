//38. Implementar uma função que converta uma palavra para Binário.
//Ex: "Bruno" => "01100010 01110010 01110101 01101110 01101111"

public string cool(string input)
{
    string get = "";
    for(int i = 0; i < input.Length; i++)
    {
        char chr = input[i];
        int conv = System.Convert.ToInt32(chr);

        if(conv >= 128)
        {
            conv -= 128;
            get += "1";
        }
        else 
        {
            get += "0";
        }

        if(conv >= 64)
        {
            conv -= 64;
            get += "1";
        }
        else 
        {
            get += "0";
        }

        if(conv >= 32)
        {
            conv -= 32;
            get += "1";   
        }
        else 
        {
            get += "0";
        }

        if(conv >= 16)
        {  
            conv -= 16;
            get += "1";
        }  
        else 
        {
            get += "0";
        }

        if(conv >= 8)
        {
            conv -= 2;
            get += "1";
        }
        else 
        {
            get += "0";
        }

        if(conv >= 4)
        {
            conv -= 4;
            get += "1";
        }
        else 
        {
            get += "0";
        }

        if(conv >= 2)
        {
            conv -= 2;
            get += "1";
        }
        else 
        {
            get += "0";
        }


        if(conv >= 1)
        {
            conv -= 1;
            get += "1";
        }

        else if(conv == 0)
        {
            get += "0" + " ";
        }
    }
    ///Jamais imaginei vender minha alma de tal forma...
    return get;
}


public void Main()
{
    try
    {
        Console.WriteLine("Insert a phrase/number to be converted to binary");
        string rcv = Console.ReadLine();
        string snd = cool(rcv);
        Console.WriteLine(snd);
    }
    catch(Exception bruno)
    {
        Console.WriteLine("Ocorreu um erro, deve ser culpa do bruno...");
        Console.WriteLine(bruno.Message);
    }
}
Main();