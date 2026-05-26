using System;

// Родительский класс
class Exchange
{
    // Метод вывода курса
    public void ShowRate(string fromCurrency, string toCurrency, double rate)
    {
        Console.WriteLine($"Курс {fromCurrency} -> {toCurrency} = {rate}");
    }
}

// Дочерние классы валют
class USD : Exchange
{
    public void Info()
    {
        ShowRate("USD", "RUB", 90.5);
        ShowRate("USD", "EUR", 0.92);
    }
}

class RUB : Exchange
{
    public void Info()
    {
        ShowRate("RUB", "USD", 0.011);
        ShowRate("RUB", "EUR", 0.010);
    }
}

class EUR : Exchange
{
    public void Info()
    {
        ShowRate("EUR", "USD", 1.08);
        ShowRate("EUR", "RUB", 98.3);
    }
}

class UAN : Exchange
{
    public void Info()
    {
        ShowRate("UAN", "USD", 0.14);
        ShowRate("UAN", "RUB", 12.5);
    }
}

class Peso : Exchange
{
    public void Info()
    {
        ShowRate("Peso", "USD", 0.056);
        ShowRate("Peso", "EUR", 0.052);
    }
}

class Program
{
    static void Main()
    {
        USD usd = new USD();
        RUB rub = new RUB();
        EUR eur = new EUR();
        UAN uan = new UAN();
        Peso peso = new Peso();

        Console.WriteLine("=== USD ===");
        usd.Info();

        Console.WriteLine("\n=== RUB ===");
        rub.Info();

        Console.WriteLine("\n=== EUR ===");
        eur.Info();

        Console.WriteLine("\n=== UAN ===");
        uan.Info();

        Console.WriteLine("\n=== Peso ===");
        peso.Info();
    }
}