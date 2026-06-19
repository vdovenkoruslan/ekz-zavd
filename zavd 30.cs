using System;

public class Logger
{
    private static readonly Logger instance = new Logger();

    private Logger() { }

    public static Logger Instance
    {
        get { return instance; }
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG {DateTime.Now}]: {message}");
    }
}

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal initialBalance = 0)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Сума поповнення має бути більшою за нуль.");
        }

        balance += amount;
        Logger.Instance.Log($"Поповнення: {amount}. Рахунок: {accountNumber}. Новий баланс: {balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Сума зняття має бути більшою за нуль.");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Запитана сума перевищує баланс.");
        }

        balance -= amount;
        Logger.Instance.Log($"Зняття: {amount}. Рахунок: {accountNumber}. Новий баланс: {balance}");
    }
}
