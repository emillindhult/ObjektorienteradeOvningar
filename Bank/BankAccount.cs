namespace Bank;

internal class BankAccount
{
    private List<string> transactions = [];
    private decimal balance = 0;
    public decimal Balance
    {
        get { return balance; }
    }

    public decimal Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be greater than 0.");

        balance += amount;
        transactions.Add($"Deposit: {amount}$");

        return balance;
    }

    public decimal Withdraw(decimal amount)
    {
        if (balance - amount < 0)
        {
            Console.WriteLine("Not enough money in your account.");
            return 0;
        }

        balance -= amount;
        transactions.Add($"Withdrawal: {amount}$");

        return balance;
    }

    public decimal Transfer(BankAccount account, decimal amount)
    {
        if (balance - amount < 0)
        {
            Console.WriteLine("Not enough money in your account.");
            return 0;
        }

        balance -= amount;
        account.Deposit(amount);

        return balance;
    }

    public void ShowTransactions()
    {
        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}
