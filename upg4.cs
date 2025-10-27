 Console.WriteLine("Enter your age:");
 string ageInput = Console.ReadLine();
 int age = Convert.ToInt32(ageInput);

 if (age < 0 || age > 150)
 {
     Console.WriteLine("!Invalid age");
 }
 else if (age > 18 && age <= 25)
 {
     Console.WriteLine("You are between 18 & 25 years old");
 }
 else if (age >= 26)
 {
     Console.WriteLine("can vote");
 }
 else
 {
     Console.WriteLine("cannot vote");
 }

          
