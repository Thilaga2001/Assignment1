class Pet
{
    public string Type { get; private set; }
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public int Health { get; private set; }
   

    public Pet(string type, string name)
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
        Console.WriteLine($"You fed {Name}. Hunger decreases, and health improves slightly.\nHunger:{Hunger}\nHealth:{Health}\nHappiness:{Happiness}\n");
    }

    public void Play()
    {
        Happiness = Math.Min(10, Happiness + 2);
        Hunger = Math.Min(10, Hunger + 1);
        Console.WriteLine($"You played with {Name}. Happiness increases, but hunger increases slightly.\nHunger:{Hunger}\nHealth:{Health}\nHappiness:{Happiness}\n");
    }

    public void Rest()
    {
        Health = Math.Min(10, Health + 2);
        Happiness = Math.Max(0, Happiness - 1);
        Console.WriteLine($"{Name} is resting. Health increased, happiness decreased slightly.\nHunger:{Health}\nHealth:{Health}\nHappiness:{Happiness}\n");
    }

    public void PassTime()
    {
        
        Hunger = Math.Min(10, Hunger + 1);
        Happiness = Math.Max(0, Happiness - 1);

        if (Hunger >= 8)
        {
            Health = Math.Max(0, Health - 2);
            Console.WriteLine($"{Name} looks very hungry. You should feed them soon!\n");
        }

        if (Happiness <= 2)
        {
            Health = Math.Max(0, Health - 1);
            Console.WriteLine($"{Name} looks very sad. They need some cheering up!\n");
        }
        if (Health <= 3)
        {
            Console.WriteLine($"{Name} looks very weak. Take good care of them!\n");
        }



    }

    public void DisplayStatus()
    {
        Console.WriteLine($"{Name}'s Status:");
        Console.WriteLine($"- Hunger: {Hunger}");
        Console.WriteLine($"- Happiness: {Happiness}");
        Console.WriteLine($"- Health: {Health}\n");
         
    }
}