public void cool(int input, int secinput)
{
    for(int output = 1; output <= secinput; output++)
    {
        int calc = input * output;
        Console.WriteLine("{0} x {1} = {2}", input, output, calc);
    }
}
public void Main()
{
    try
    {
        Console.Write("insert a number:");
        int conv = Convert.ToInt32(Console.ReadLine());
        Console.Write("insert a number:");
        int conv2 = Convert.ToInt32(Console.ReadLine());
        cool(conv, conv2);

    }

    catch(Exception error)
    {
        Console.WriteLine("An error ocurred");
        Console.WriteLine(error.Message);
    }
}
Main();


//1
//1x1=1
//1x