
        static void Main(string[] args)
{

    Dictionary<string, string> subjects = new Dictionary<string, string>
            {
                {"Matts", "01" },
                {"Greta", "02" }
            };

    Console.WriteLine("Welcom to prakticum");
    while (true)
    {
        Console.WriteLine("\n Välj ett alternativ");
        Console.WriteLine("1 lägg till studerande");
        Console.WriteLine("2 ta bort studerande");
        Console.WriteLine("3 visa alla studerande och deras id numm");
        Console.WriteLine("4 Exit");

        Console.WriteLine("Ange ditt alternativ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Ange namnet på studerande ");
                string newSubject = Console.ReadLine();
                Console.WriteLine(" anhge id numm till studerande ");
                string newTeacher = Console.ReadLine();
                subjects.Add(newSubject, newTeacher);
                Console.WriteLine($"studerande ' {newSubject}' har lagits till");
                break;
            case 2:
                Console.Write("Ange namnet på studerande som ska taas bort ");
                string subjectToRemove = Console.ReadLine();
                if (subjects.ContainsKey(subjectToRemove))
                {
                    subjects.Remove(subjectToRemove);
                    Console.WriteLine($"studerande '{subjectToRemove}' har tagits bort");

                }
                else
                {
                    Console.WriteLine("studerande hittades inte i dictionary ");
                }
                break;
            case 3:
                Console.WriteLine("studerande och deras id");
                foreach (var subject in subjects)
                {
                    Console.WriteLine($"{subject.Key} - {subject.Value}");
                }
                break;
            case 4:
                Console.WriteLine("exitting???");
                return;
            default:
                Console.WriteLine("invalid input! Försök igen");
                break;
        }
    }
}