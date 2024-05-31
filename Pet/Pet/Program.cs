using Pet;
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
            Console.WriteLine("3. Rabbit\n");
            // Console.WriteLine();
            Console.Write("User Input: ");

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
            //  Console.WriteLine();
            Console.WriteLine($"\nYou've chosen a {petType}. What would you like to name your pet?");
            Console.Write("User Input: ");
            string petName = Console.ReadLine();

             
            Petaction pet = new Petaction(petType, petName);
            Console.WriteLine($"Welcome, {pet.Name}! Let's take good care of {pet.Type}.\n");
            // Console.WriteLine();

            bool running = true;
            while (running)
            {
                //Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine($"1. Feed {pet.Name}");
                Console.WriteLine($"2. Play with {pet.Name}");
                Console.WriteLine($"3. Let {pet.Name} Rest");
                Console.WriteLine($"4. Check {pet.Name}'s Status");
                Console.WriteLine("5. Exit\n");
                //   Console.WriteLine();
                Console.Write("User Input: ");

                string choice = Console.ReadLine();
                //  Console.WriteLine();

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

                pet.PassTime();
                    Console.WriteLine("Press Enter to continue...\n");
                //  Console.ReadLine();
            }
            //   Console.WriteLine();
            Console.WriteLine($"Thank you for playing with {pet.Name}. Goodbye!");
        }
    }
}
    