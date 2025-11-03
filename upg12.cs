
        static void Main(string[] args)
{
    Console.Write("Enter your password: ");
    string password = Console.ReadLine();

    if (string.IsNullOrEmpty(password))
    {
        Console.WriteLine("Password cannot be empty");
    }
    else if (password == "prakticum")
    {
        Console.Write("Enter 2nd password: ");
        string password2 = Console.ReadLine();

        if (string.IsNullOrEmpty(password2))
        {
            Console.WriteLine("Second password cannot be empty");
        }
        else if (password2 == "trelejon")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Invalid second password");
        }
    }
    else
    {
        Console.WriteLine("Invalid first password");
    }
}