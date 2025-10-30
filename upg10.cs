static void Main(string[] args)
{ // del 1
    int num1 = 1;
    int num2 = 2;
    int num3 = 3;
    int num4 = 4;
    int num5 = 5;
    int num6 = 6;
    // del 2
    Console.WriteLine("1 + 2 = " + (num1 + num2)); // sum
    Console.WriteLine("3 * 4 = " + (num3 * num4)); // product 
    Console.WriteLine("5 % 6 = " + (num5 % num6)); // remainder

    // del 3

    Console.WriteLine("num6++ = " + (num6++)); // post fix  
    Console.WriteLine(" efter num6++: " + num6);


    Console.WriteLine("--num6 = " + (--num6)); // pre fix

    // del 4
    Console.WriteLine("num5 += 1 " + (num5 += 1));
    Console.WriteLine("num5 -= 1 " + (num5 -= 1));
    Console.WriteLine("num5 *= 1 " + (num5 *= 1));
    Console.WriteLine("num5 %= 1 " + (num5 % 1));
}