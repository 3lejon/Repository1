 static void Main(string[] args)
{

    Console.Write("enter width: "); //brädden
    double Width = Convert.ToDouble(Console.ReadLine());


    Console.Write("Enter the length: "); // längden
    double Heigth = Convert.ToDouble(Console.ReadLine());


    double area = CalculateArea(Width, Heigth);


    Console.WriteLine($"The area of the triangle is: {area}"); //Räknar arean 








    //utrycket
    static double CalculateArea(double Width, double Heigth)
    {
        return (Width * Heigth) / 2;

    }
}