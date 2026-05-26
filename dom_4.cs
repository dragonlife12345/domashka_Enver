using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Массив из 50 слов
        string[] words =
        {
            "кот", "ток", "дом", "мода", "амод", "лист", "стол", "слот",
            "нос", "сон", "гора", "рога", "мир", "рим", "котик", "кино",
            "окно", "банан", "арбуз", "машина", "река", "каре", "куст",
            "стук", "книга", "игрок", "корги", "лампа", "палма", "свет",
            "ветс", "ручка", "чурка", "стена", "наветс", "поле", "елоп",
            "сыр", "рысь", "школа", "ложка", "город", "дорог", "трава",
            "автар", "крот", "торк", "зима", "мази"
        };

        // 1. Проверка есть ли слово в массиве
        Console.Write("Введите слово для поиска: ");
        string searchWord = Console.ReadLine();

        if (words.Contains(searchWord))
        {
            Console.WriteLine("Слово найдено в массиве.");
        }
        else
        {
            Console.WriteLine("Слово не найдено.");
        }

        // 2. Поиск анаграмм
        Console.Write("\nВведите слово для поиска анаграмм: ");
        string input = Console.ReadLine();

        string sortedInput = String.Concat(input.OrderBy(c => c));

        Console.WriteLine("Анаграммы:");

        foreach (string word in words)
        {
            string sortedWord = String.Concat(word.OrderBy(c => c));

            if (sortedWord == sortedInput && word != input)
            {
                Console.WriteLine(word);
            }
        }

        // 3. Сортировка по последней букве
        Console.WriteLine("\nСортировка по последней букве:");

        var sortedWords = words.OrderBy(w => w[w.Length - 1]);

        foreach (string word in sortedWords)
        {
            Console.WriteLine(word);
        }
    }
}