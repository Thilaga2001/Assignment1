using System;

namespace VirtualPetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Pet Simulator!");

            // Pet creation
            Console.WriteLine("Please choose a type of pet:");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            string petTypeInput = Console.ReadLine();

            string petType;
            switch (petTypeInput)
            {
                case "1":
                    petType = "Cat";
                    break;
                case "2":
                    petType = "Dog";
                    break;
                case "3":
                    petType = "Rabbit";
                    break;
                default:
                    petType = "Unknown";
                    break;
            }

            Console.WriteLine($"You've chosen a {petType}. What would you like to name your pet?");
            string petName = Console.ReadLine();

            Pet pet = new Pet(petType, petName);
            Console.WriteLine($"Welcome, {pet.Name}! Let's take good care of {pet.Type}.");
        }
    }

    class Pet
    {
        public string Type { get; private set; }
        public string Name { get; private set; }

        public Pet(string type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
