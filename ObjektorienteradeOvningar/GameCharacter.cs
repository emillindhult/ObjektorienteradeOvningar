namespace ObjektorienteradeOvningar;

class GameCharacter
{
    private readonly string name;
    private int health;
    private int attack;
    private bool isDead;

    public GameCharacter(string name, int health, int attack)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));
        this.name = name;

        if (health < 1 || health > 100)
            throw new ArgumentOutOfRangeException(nameof(health));
        this.health = health;

        if (attack < 1 || attack > 25)
            throw new ArgumentOutOfRangeException(nameof(attack));
        this.attack = attack;
    }

    public void Information()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"Attack: {attack}");
        Console.WriteLine($"Alive: {(!isDead ? "Yes" : "No")}");
    }

    public void Attack(GameCharacter enemy)
    {
        Console.WriteLine($"{name} attacked {enemy.name} and made {attack} damage.");
        enemy.TakeDamage(attack);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Console.WriteLine($"{name} died.");
            isDead = !isDead;
        }
    }

    public void ShowHealth()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: {health}");
    }
}