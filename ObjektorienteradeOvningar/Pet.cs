class Pet
{
    private string name { get; set; } = string.Empty;
    private string type { get; set; } = string.Empty;
    private int energy { get; set; }

    public Pet(string name, string type, int energy)
    {
        this.name = name;
        this.type = type;
        if (energy < 0 || energy > 100)
            throw new ArgumentOutOfRangeException(nameof(energy));
        this.energy = energy;
    }

    public void PresentPet()
    {
        Console.WriteLine($"Hello my name is {name} and i am a {type}.");
    }

    public void Eat()
    {
        energy += 5;
        Console.WriteLine($"Your energy raised by 5.");
    }

    public void Play()
    {
        energy -= 10;
        Console.WriteLine($"Your energy depleted by 10.");
    }

    public void ShowEnergy()
    {
        Console.WriteLine($"Your current energy: {energy}");
    }
}