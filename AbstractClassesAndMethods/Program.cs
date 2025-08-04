using System;

namespace AbstractClassAndMethods
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Shape circle = new Circle(radius);

            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Shape rectangle = new Rectangle(width, height);

            Console.WriteLine($"\nCircle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
