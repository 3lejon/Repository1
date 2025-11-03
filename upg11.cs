 static void Main(string[] args)
{
    Console.WriteLine("please enter the message: C# is fun i am going to code C# tomorrow ");
    
    var message = Console.ReadLine();
    Console.WriteLine("normal");
    if (message != " C# is fun i am going to code C# tomorrow  ")
    {
        Console.WriteLine(message);
        char[] messagearray = message.ToCharArray();
        Array.Reverse(messagearray);

        Console.WriteLine("Reversed ");
        Console.WriteLine(messagearray);

        Random rnd = new Random();

        Console.WriteLine("normal");
        foreach (char c in message)
        {

            Console.WriteLine(c);
            Thread.Sleep(rnd.Next(150));
        }



        Console.WriteLine("reversed");
        string reversedMessage = new string(message.Reverse().ToArray());
        foreach (char c in reversedMessage)
        {
            Console.WriteLine(c);
            Thread.Sleep(rnd.Next(150));
        }






    }
    else
    {
        Console.WriteLine("please enter the text above");
    }
}           