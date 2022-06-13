//37. Implementar uma função que verifique se uma senha é forte. Para ser forte, ela precisa ter pelo menos 2 caracteres especiais, 2 números e 8 digitos.
//Ex: "bruno@123#" => true

public bool cool(string input)
{
    int cntnum = 0;
    int ctnnum = 0;
    bool fnvalue = false;

    for(int i = 0; i < input.Length; i++)
    {
        char see = input[i];
        bool chng = input.Length >= 8 ? fnvalue = true : fnvalue = false;
        int seer = Char.IsNumber(see) ? cntnum++ : cntnum;   
        int envy = see == '!' ? ctnnum++ : see == '@' ? ctnnum++ : see == '#' ? ctnnum++ : ctnnum == '$' ? ctnnum++ : ctnnum == '$' ? ctnnum++ : ctnnum;
    }
     if(cntnum >= 2 && ctnnum >= 2)
     {
         fnvalue = true;
     }
     else
     {
         fnvalue = false;
     }
    return fnvalue;
}

public void Main()
{
    Console.WriteLine("Insert a password that contains at least 2 especial characters, 2 numbers and 8 digits");
    string rcv = Console.ReadLine();
    bool send = cool(rcv);
    Console.WriteLine(send);
}
Main();