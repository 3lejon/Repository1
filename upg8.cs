var name = "john";
Console.WriteLine($"Welcome, {name}! Let's check your age ");

Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

const int legalAge = 18;

if (age >= legalAge)
{
    Console.WriteLine("You are good to go.");
}
else
{
    Console.WriteLine("You need to be older.");

    int counter = 1;
    while (counter <= 5)
    {
        Console.WriteLine("Counter value: " + counter);
        counter++;
    }

    Console.WriteLine("Enter a number between 1 and 5:");
    int input = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
        case 1:
            Console.WriteLine("1");
            break;
        case 2:
            Console.WriteLine("2");
            break;
        case 3:
            Console.WriteLine("3");
            break;
        case 4:
            Console.WriteLine("4");
            break;
        case 5:
            Console.WriteLine("5");
            break;
        default:
            Console.WriteLine("Invalid input. Enter a value between 1 and 5.");
            break;
    }
}

Console.ReadLine();