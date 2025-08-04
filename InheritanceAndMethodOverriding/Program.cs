using System;

namespace InheritanceAndOverriding
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an animal to hear its sound:");
            Console.WriteLine("1. Generic Animal");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Cat");
            Console.Write("Enter your choice (1, 2, or 3): ");

            string choice = Console.ReadLine();
            Animal selectedAnimal;

            switch (choice)
            {
                case "1":
                    selectedAnimal = new Animal();
                    break;
                case "2":
                    selectedAnimal = new Dog();
                    break;
                case "3":
                    selectedAnimal = new Cat();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to generic Animal.");
                    selectedAnimal = new Animal();
                    break;
            }

            Console.WriteLine("\nSound:");
            selectedAnimal.MakeSound();

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
