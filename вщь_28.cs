using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // ===== 1. ДЕЛЕГАТ (таймер) =====
        Console.WriteLine("=== Таймер ===");

        DoAfter(() =>
        {
            Console.WriteLine("Таймер сработал!");
        }, 3);

        // ===== 2. СОБЫТИЕ (будильник) =====
        Console.WriteLine("\n=== Будильник ===");

        Console.Write("Введите время (HH:mm:ss): ");
        string time = Console.ReadLine();

        AlarmClock clock = new AlarmClock(time);

        clock.AlarmRang += () =>
        {
            Console.WriteLine("⏰ Будильник сработал!");
        };

        clock.Start();
    }

    // ===== Делегат: выполнить через N секунд =====
    static void DoAfter(Action action, int seconds)
    {
        Thread.Sleep(seconds * 1000);
        action();
    }
}

// ===== КЛАСС БУДИЛЬНИКА =====
class AlarmClock
{
    public event Action AlarmRang;

    private string alarmTime;

    public AlarmClock(string time)
    {
        alarmTime = time;
    }

    public void Start()
    {
        while (true)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            Console.WriteLine("Текущее время: " + currentTime);

            if (currentTime == alarmTime)
            {
                AlarmRang?.Invoke();
                break;
            }

            Thread.Sleep(1000);
        }
    }
}