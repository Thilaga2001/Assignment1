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
            Console.WriteLine("3. Rabbit \n");
            Console.Write("User Input: ");

            string petTypeInput = Console.ReadLine();

            string petType;
            int hoursPassed = 0;

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

            Console.WriteLine($"You've chosen a {petType}. What would you like to name your pet?\n");
            Console.Write("Give the name for your pet: ");
            string petName = Console.ReadLine();

            Pet pet = new Pet(petType, petName);
            Console.WriteLine($"Welcome, {pet.Name}! Let's take good care of {pet.Type}.\n");

            bool running = true;
            while (running)
            {
               // Console.Clear();
              
                Console.WriteLine("Main Menu:");
                Console.WriteLine($"1. Feed {pet.Name}");
                Console.WriteLine($"2. Play with {pet.Name}");
                Console.WriteLine($"3. Let {pet.Name} Rest");
                Console.WriteLine($"4. Check {pet.Name}'s Status");
                Console.WriteLine("5. Exit\n");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        pet.Feed();
                        hoursPassed ++;
                        break;
                    case "2":
                        pet.Play();
                        hoursPassed++;
                        break;
                    case "3":
                        pet.Rest();
                        hoursPassed++;
                        break;                
                    case "4":
                    pet.DisplayStatus();
                    continue;
                case "5":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }
                Console.WriteLine($"Hours passed: {hoursPassed}\n");
                pet.PassTime(); 
               
                
            }

            Console.WriteLine("Thank you for playing with your pet. Goodbye!");
        }
    }
}
   