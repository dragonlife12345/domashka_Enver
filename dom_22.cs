using System;
using System.Linq;

class HistogramArray
{
    private double[] data;
    private int intervals;
    private double min;
    private double max;
    private double intervalSize;

    // Конструктор
    public HistogramArray(double[] array, int intervalCount)
    {
        data = array.OrderBy(x => x).ToArray();
        intervals = intervalCount;

        min = data.Min();
        max = data.Max();

        intervalSize = (max - min) / intervals;
    }

    // get int -> возвращает индекс интервала
    public int GetInterval(double value)
    {
        if (value < min || value > max)
            return -1;

        int index = (int)((value - min) / intervalSize);

        // Для максимального значения
        if (index == intervals)
            index--;

        return index;
    }

    // get double -> возвращает значение по процентилю
    public double GetPercentile(double percentile)
    {
        if (percentile < 0 || percentile > 100)
            throw new Exception("Процентиль должен быть от 0 до 100");

        int index = (int)Math.Ceiling((percentile / 100.0) * data.Length) - 1;

        if (index < 0)
            index = 0;

        return data[index];
    }
}

class Program
{
    static void Main()
    {
        double[] numbers = { 10, 20, 15, 40, 35, 50, 60, 80, 90, 100 };

        HistogramArray histogram = new HistogramArray(numbers, 5);

        // Проверка интервала
        Console.Write("Введите число: ");
        double value = Convert.ToDouble(Console.ReadLine());

        int interval = histogram.GetInterval(value);

        if (interval == -1)
            Console.WriteLine("Число вне диапазона");
        else
            Console.WriteLine($"Число находится в интервале: {interval}");

        // Проверка процентиля
        Console.Write("\nВведите процентиль: ");
        double p = Convert.ToDouble(Console.ReadLine());

        double result = histogram.GetPercentile(p);

        Console.WriteLine($"Значение процентиля {p}% = {result}");
    }
}