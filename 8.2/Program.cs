using System;

public enum AccountType
{
    Savings,
    Checking,
    Credit
}

public class BankAccount
{
    private static int _counter = 1000;

    private string _number;
    private decimal _balance;
    private AccountType _type;

    public string Number { get { return _number; } }
    public decimal Balance { get { return _balance; } }
    public AccountType Type { get { return _type; } }

    public BankAccount(AccountType type, decimal initialBalance)
    {
        _type = type;
        _balance = initialBalance;
        _number = GenerateNumber();
    }

    private static string GenerateNumber()
    {
        _counter++;
        return "ACC-" + _counter;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            return true;
        }
        return false;
    }

    public void Transfer(BankAccount source, decimal amount)
    {
        if (source.Withdraw(amount))
        {
            this.Deposit(amount);
        }
        else
        {
            Console.WriteLine("Перевод отклонен: недостаточно средств.");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount(AccountType.Savings, 5000);
        BankAccount acc2 = new BankAccount(AccountType.Checking, 1000);

        Console.WriteLine("Счет 1: " + acc1.Number + " | Баланс: " + acc1.Balance);
        Console.WriteLine("Счет 2: " + acc2.Number + " | Баланс: " + acc2.Balance);

        acc1.Transfer(acc2, 500);

        Console.WriteLine("После перевода 500 со счета 2 на счет 1:");
        Console.WriteLine("Счет 1: " + acc1.Number + " | Баланс: " + acc1.Balance);
        Console.WriteLine("Счет 2: " + acc2.Number + " | Баланс: " + acc2.Balance);

        Console.ReadKey();
    }
}