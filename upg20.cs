 internal class Program
 {
     class Circle
     {
         public double Radius;

         public Circle(double radius)
         {
             Radius = radius;
         }


         public double GetArea()
         { 
             return Math.PI *  Math.Pow(Radius, 2);
         }
     }
     static void Main(string[] args)
     {
         Console.WriteLine("enter radius of circle");
         double radius = Convert.ToDouble(Console.ReadLine());

         Circle circle = new Circle(radius);

         double area = circle.GetArea();
         Console.WriteLine($"The area of the circle is {area:F2}");
     }
 }