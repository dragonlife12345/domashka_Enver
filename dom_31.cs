using System;
using System.Collections.Generic;

class Validator<T>
{
    // Список правил
    private List<Predicate<T>> rules = new List<Predicate<T>>();

    // Добавление правила
    public void AddRule(Predicate<T> rule)
    {
        rules.Add(rule);
    }

    // Проверка всех правил
    public bool Validate(T item)
    {
        foreach (Predicate<T> rule in rules)
        {
            if (!rule(item))
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Validator<int> numberValidator = new Validator<int>();

        // Правило: число должно быть больше 0
        numberValidator.AddRule(x => x > 0);

        // Правило: число должно быть четным
        numberValidator.AddRule(x => x % 2 == 0);

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool result = numberValidator.Validate(number);

        if (result)
        {
            Console.WriteLine("Число прошло проверку");
        }
        else
        {
            Console.WriteLine("Число НЕ прошло проверку");
        }
    }
}