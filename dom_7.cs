using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Сортировка массива строк по последней букве
        SortByLastLetter();

        // 2. Сумма всех чисел в string массиве
        SumNumbersFromStringArray();

        // 3. Проверка степени двойки
        CheckPowerOfTwo();
    }

    // 1. Сортировка по последней букве
    static void SortByLastLetter()
    {
        Console.WriteLine("=== Сортировка по последней букве ===");

        string[] words = { "кот", "яблоко", "дом", "арбуз", "лист", "нос" };

        var sorted = words.OrderBy(word => word[word.Length - 1]);

        Console.WriteLine("Отсортированный массив:");

        foreach (string word in sorted)
        {
            Console.WriteLine(word);
        }
    }

    // 2. Сумма чисел из string массива
    static void SumNumbersFromStringArray()
    {
        Console.WriteLine("\n=== Сумма чисел из массива ===");

        string[] data = { "10", "кот", "25", "дом", "5", "abc", "15" };

        int sum = 0;

        foreach (string item in data)
        {
            if (int.TryParse(item, out int number))
            {
                sum += number;
            }
        }

        Console.WriteLine($"Сумма чисел: {sum}");
    }

    // 3. Проверка степени двойки
    static void CheckPowerOfTwo()
    {
        Console.WriteLine("\n=== Проверка степени двойки ===");

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPowerOfTwo(number))
        {
            Console.WriteLine("Число является степенью двойки");
        }
        else
        {
            Console.WriteLine("Число НЕ является степенью двойки");
        }
    }

    // Функция проверки степени двойки
    static bool IsPowerOfTwo(int n)
    {
        if (n <= 0)
            return false;

        while (n % 2 == 0)
        {
            n /= 2;
        }

        return n == 1;
    }
}