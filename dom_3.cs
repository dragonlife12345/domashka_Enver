using System;

class Program
{
    static void Main()
    {
        // 1. Проверка есть ли в строке буква "a"
        Console.Write("Введите строку: ");
        string str1 = Console.ReadLine();

        if (str1.Contains("a"))
        {
            Console.WriteLine("Строка содержит букву 'a'");
        }
        else
        {
            Console.WriteLine("Строка НЕ содержит букву 'a'");
        }

        // 2. Проверка одинаковые ли 2 строки без учета регистра
        Console.Write("\nВведите первую строку: ");
        string s1 = Console.ReadLine();

        Console.Write("Введите вторую строку: ");
        string s2 = Console.ReadLine();

        if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Строки одинаковые");
        }
        else
        {
            Console.WriteLine("Строки разные");
        }

        // 3. Вывести строку по буквам с новой строки
        Console.Write("\nВведите строку: ");
        string str2 = Console.ReadLine();

        Console.WriteLine("Буквы строки:");
        foreach (char c in str2)
        {
            Console.WriteLine(c);
        }

        // 4. Вывести каждый четный символ строки
        Console.Write("\nВведите строку: ");
        string str3 = Console.ReadLine();

        Console.WriteLine("Четные символы:");
        for (int i = 1; i < str3.Length; i += 2)
        {
            Console.Write(str3[i] + " ");
        }
    }
}