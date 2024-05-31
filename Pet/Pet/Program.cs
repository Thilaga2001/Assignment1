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

            Petaction pet = new Petaction(petType, petName);
            Console.WriteLine($"Welcome, {pet.Name}! Let's take good care of {pet.Type}.");

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine($"1. Feed {pet.Name}");
                Console.WriteLine($"2. Play with {pet.Name}");
                Console.WriteLine($"3. Let {pet.Name} Rest");
                Console.WriteLine($"4. Check {pet.Name}'s Status");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        pet.Feed();
                        break;
                    case "2":
                        pet.Play();
                        break;
                    case "3":
                        pet.Rest();
                        break;
                    case "4":
                        pet.DisplayStatus();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }

            Console.WriteLine("Thank you for playing with your pet. Goodbye!");
        }
    }

    class Petaction
    {
        public string Type { get; private set; }
        public string Name { get; private set; }
        public int Hunger { get; private set; }
        public int Happiness { get; private set; }
        public int Health { get; private set; }

        public Petaction(string type, string name)
        {
            Type = type;
            Name = name;
            Hunger = 5;
            Happiness = 5;
            Health = 8;
        }

        public void Feed()
        {
            Hunger = Math.Max(0, Hunger - 1);
            Health = Math.Min(10, Health + 1);
            Console.WriteLine($"You fed {Name}. His hunger decreases, and health improves slightly.");
        }

        public void Play()
        {
            Happiness = Math.Min(10, Happiness + 2);
            Hunger = Math.Min(10, Hunger + 1);
            Console.WriteLine($"You played with {Name}. His happiness increases, but he's a bit hungrier.");
        }

        public void Rest()
        {
            Health = Math.Min(10, Health + 2);
            Happiness = Math.Max(0, Happiness - 1);
            Console.WriteLine($"{Name} is resting. Health increased, Happiness decreased.");
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"{Name}'s Status:");
            Console.WriteLine($"- Hunger: {Hunger}");
            Console.WriteLine($"- Happiness: {Happiness}");
            Console.WriteLine($"- Health: {Health}");
        }
    }
}
