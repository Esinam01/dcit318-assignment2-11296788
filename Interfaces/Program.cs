using System;

namespace InterfaceDemo
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movement Demo!");
            Console.WriteLine("Type 'car' or 'bicycle' to see it move. Type 'exit' to quit.\n");

            while (true)
            {
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;
                }

                IMovable movable;

                switch (input)
                {
                    case "car":
                        movable = new Car();
                        break;
                    case "bicycle":
                        movable = new Bicycle();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter 'car', 'bicycle', or 'exit'.\n");
                        continue;
                }

                movable.Move();
                Console.WriteLine();
            }

            Console.WriteLine("Thanks for using the program. Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
