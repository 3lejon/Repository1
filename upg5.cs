   Console.Write("Enter grade ");
   int grade = Convert.ToInt32(Console.ReadLine());
   switch (grade)
{
    case 0:
        Console.WriteLine("fail");

        break;
    case 1:
        Console.WriteLine("needs improvemnt");

        break;

    case 2:
        Console.WriteLine("ok");
        break;
    case 3:
        Console.WriteLine("satifactory");

        break;
    case 4:
        Console.WriteLine("good");

        break;
    case 5:
        Console.WriteLine("exselent");

        break;
   
    default:
        Console.WriteLine("invalid enter a value between 1 and 7 ");
        break;
}
 Console.ReadLine();