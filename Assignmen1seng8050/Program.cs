using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");

        Console.Write("Choose a pet type (Cat, Dog, Horse): ");
        string petType;
    }
    class virtualpet
{
    // Pet attributes
    private string petType;
    private string petName;
    private int hunger;
    private int happiness;
    private int health;

    public virtualpet(string type, string name)
    {
        petType = type;
        petName = name;
        hunger = 10;
        happiness = 10;
        health = 10;
    }

    // Method to display pet's status
    public void DisplayStatus()
    {
        Console.WriteLine($"Pet Type: {petType}, Name: {petName}");
        Console.WriteLine($"Hunger: {hunger}/10, Happiness: {happiness}/10, Health: {health}/10");
        Console.WriteLine();
    }

    // Method to feed the pet
    public void Feed()
    {
        Console.WriteLine($"{petName} is being fed...");
        hunger = Math.Max(0, hunger - 2);
        health = Math.Min(10, health + 1);
        DisplayStatus();
    }

    // Method to play with the pet
    public void Play()
    {
        Console.WriteLine($"{petName} is playing...");
        happiness = Math.Min(10, happiness + 2);
        hunger = Math.Min(10, hunger + 1);
        DisplayStatus();
    }

    // Method to let the pet rest
    public void Rest()
    {
        Console.WriteLine($"{petName} is resting...");
        health = Math.Min(10, health + 2);
        happiness = Math.Max(0, happiness - 1);
        DisplayStatus();
    }

    // Method to simulate the passage of time
    public void PassTime()
    {
        Console.WriteLine($"Time is passing for {petName}...");
        hunger = Math.Min(10, hunger + 1);
        happiness = Math.Max(0, happiness - 1);
        health = Math.Max(0, health - 1);
        DisplayStatus();
    }

    // Method to check if the pet is in a critical state
    public bool IsCritical()
    {
        return hunger <= 2 || happiness <= 2 || health <= 2;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");

        Console.Write("Enter the type of pet (e.g., cat, dog, rabbit): ");
        string petType = Console.ReadLine();

        Console.Write("Enter the name of your pet: ");
        string petName = Console.ReadLine();

        VirtualPet pet = new VirtualPet(petType, petName);

        Console.WriteLine($"Welcome, {petName} the {petType}!");

        while (true)
        {
            Console.WriteLine("\nActions:");
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Let the pet rest");
            Console.WriteLine("4. Display pet's status");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an action (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    pet.Feed();
                    break;
                case 2:
                    pet.Play();
                    break;
                case 3:
                    pet.Rest();
                    break;
                case 4:
                    pet.DisplayStatus();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid action.");
                    break;
            }

            pet.PassTime();

            if (pet.IsCritical())
            {
                Console.WriteLine("Warning: Your pet is in a critical state. Take action!");
            }
        }
    }
}
