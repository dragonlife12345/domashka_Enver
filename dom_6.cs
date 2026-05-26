using System;

class Program
{
    static void Main()
    {
        // 1. Расстояние между точками
        DistanceBetweenPoints();

        // 2. Сумма цифр числа
        SumOfDigits();

        // 3. Генератор массива случайных чисел
        RandomArrayGenerator();
    }

    // 1. Функция вычисления расстояния
    static void DistanceBetweenPoints()
    {
        Console.WriteLine("=== Расстояние между точками ===");

        Console.Write("Введите x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Расстояние: {distance}");
    }

    // 2. Функция суммы цифр
    static void SumOfDigits()
    {
        Console.WriteLine("\n=== Сумма цифр числа ===");

        Console.Write("Введите число: ");
        int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine($"Сумма цифр: {sum}");
    }

    // 3. Функция генерации массива
    static void RandomArrayGenerator()
    {
        Console.WriteLine("\n=== Генератор массива случайных чисел ===");

        Console.Write("Введите количество элементов массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите минимальное число: ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите максимальное число: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];

        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(min, max + 1);
        }

        Console.WriteLine("Массив:");

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}