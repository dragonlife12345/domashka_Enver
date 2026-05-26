using System;

// Родительский класс
class BankAccount
{
    public string Owner { get; set; }
    public double Balance { get; set; }

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }

    // Метод пополнения
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"{amount} зачислено на счет {Owner}");
    }

    // Метод снятия
    public bool Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{amount} снято со счета {Owner}");
            return true;
        }
        else
        {
            Console.WriteLine("Недостаточно средств");
            return false;
        }
    }

    // Информация о счете
    public void ShowInfo()
    {
        Console.WriteLine($"Владелец: {Owner}, Баланс: {Balance}");
    }
}

// Дочерний класс
class UserAccount : BankAccount
{
    public UserAccount(string owner, double balance)
        : base(owner, balance)
    {
    }

    // Метод перевода денег
    public void Transfer(UserAccount target, double amount)
    {
        Console.WriteLine($"\nПеревод {amount} от {Owner} к {target.Owner}");

        if (Withdraw(amount))
        {
            target.Deposit(amount);
            Console.WriteLine("Перевод выполнен успешно");
        }
        else
        {
            Console.WriteLine("Перевод не выполнен");
        }
    }
}

class Program
{
    static void Main()
    {
        // Создание счетов
        UserAccount user1 = new UserAccount("Иван", 1000);
        UserAccount user2 = new UserAccount("Анна", 500);

        // Информация до перевода
        Console.WriteLine("До перевода:");
        user1.ShowInfo();
        user2.ShowInfo();

        // Перевод
        user1.Transfer(user2, 300);

        // Информация после перевода
        Console.WriteLine("\nПосле перевода:");
        user1.ShowInfo();
        user2.ShowInfo();
    }
}