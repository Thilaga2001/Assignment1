using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
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

        public void PassTime()
        {
            Hunger = Math.Min(10, Hunger + 1);
            Happiness = Math.Max(0, Happiness - 1);

            if (Hunger >= 8)
            {
                Health = Math.Max(0, Health - 2);
                Console.WriteLine($"{Name} is very hungry! Health is decreasing.");
            }

            if (Happiness <= 2)
            {
                Health = Math.Max(0, Health - 1);
                Console.WriteLine($"{Name} is very unhappy! Health is decreasing.");
            }
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
