 static void Main(string[] args)
 {
     Console.WriteLine("Enter a numbr that gets divided by 2:");
     string input = Console.ReadLine();
     int divisor = 2;

     if (int.TryParse(input, out int number))
     {
         int remainder = number % divisor;

         if (remainder == 0)
         {
             Console.WriteLine("Heltal, remainder: " + remainder);
         }
         else
         {
             Console.WriteLine("Uddatal, remainder: " + remainder);
         }
     }
     else
     {
         Console.WriteLine("Please enter a valid numbr.");
     }

 }