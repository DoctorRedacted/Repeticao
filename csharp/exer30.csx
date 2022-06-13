public int cool(string input, char input2)
{
    int output = 0;
    for(int i = 0; i < input.Length; i++)
    {
        char letter = input[i];
        int tst = letter == input2 ? output++ : output+=0;
    }
    return output; 
}

public void Main()
{
    try
    {
        Console.Write("insert a phrase:");
        string conv = Console.ReadLine();
        Console.Write("insert a character to seek for:");
        char conv2 = Convert.ToChar(Console.ReadLine());
        int send = cool(conv, conv2);
        Console.WriteLine(send);
    }

     catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();


