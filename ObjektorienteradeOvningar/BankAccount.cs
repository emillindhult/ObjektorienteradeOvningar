//var cat = new Pet("Roger", "Cat", 80);
//var dog = new Pet("Greger", "Dog", 60);

//cat.Play();
//dog.Play();

//cat.Eat();
//dog.Eat();

//cat.ShowEnergy();
//dog.ShowEnergy();




class BankAccount
{
    private readonly string accountHolder;
    private readonly string accountNumber;
    private double balance;

    public BankAccount(string accountHolder, string accountNumber, double balance)
    {
        this.accountHolder = accountHolder;
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void ShowAccountInformation()
    {
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Balance: {balance}");
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"You've deposited {amount}$");
    }

    public void Withdraw(double amount)
    {
        if (balance - amount < 0)
        {
            Console.WriteLine("You don't have enough money.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"You've withdrawn {amount}$");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Current Balance: {balance}");
    }
}