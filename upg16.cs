 static void Main(string[] args)
{
    int[] numbers = { 45, 12, 78, 34, 89, 23 };


    Console.WriteLine("Original:"); //original aray
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }


    Console.WriteLine("Ascending:"); 
    Array.Sort(numbers);
    foreach (int num in numbers)
    {
        Console.WriteLine(num);
    }


    Console.WriteLine("Descending:"); // reverse
    Array.Reverse(numbers);
    foreach (int item in numbers)
    {
        Console.WriteLine(item);
    }


    List<int> listnumbers = new List<int> { 45, 12, 78, 34, 89, 23 };
    listnumbers.Remove(78); // Remove value 78
    Console.WriteLine("List after remove 78:");
    foreach (var item in listnumbers)
    {
        Console.WriteLine(item);
    }
//find number
    Console.WriteLine("Enter a numbr to search:");
    int searchn = Convert.ToInt32(Console.ReadLine());
    int position = Array.IndexOf(numbers, searchn);

    if (position > -1)
    {
        Console.WriteLine($"Numbr {searchn} found at position {position + 0}");
    }
    else
    {
        Console.WriteLine($"Numbr {searchn} not found");
    }
}