        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int total = SumOfNumbers(numbers);

            Console.WriteLine("Array length: " + numbers.Length);
            Console.WriteLine("Sum of array: " + total);

            // Extra condition checks
        if (numbers.Length == 0)
        {
                Console.WriteLine("Cannot add up empty array");
        }
        else if (total < 0)
        {
            Console.WriteLine("negative total");
        }
        else
        {
                Console.WriteLine($"The total is {total}");
        }
        }

        static int SumOfNumbers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }  




