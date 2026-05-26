using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Пути к файлам
        string[] files = {
            "file1.txt",
            "file2.txt",
            "file3.txt"
        };

        Console.Write("Введите слово для поиска: ");
        string word = Console.ReadLine();

        bool found = SearchWordInFiles(files, word);

        Console.WriteLine(found);
    }

    static bool SearchWordInFiles(string[] files, string word)
    {
        foreach (string file in files)
        {
            if (File.Exists(file))
            {
                string content = File.ReadAllText(file);

                if (content.Contains(word))
                {
                    return true;
                }
            }
        }

        return false;
    }
}