 static void Main(string[] args)
 {
     int num = 7;
     int length = 5;
     int[] numbers = new int[length];

     Console.WriteLine(num * length);

     for (int i = 0; i < length; i++)
     {
         numbers[i] = i * num;
     }
     Console.WriteLine($"multiplication table for {num}");
 }