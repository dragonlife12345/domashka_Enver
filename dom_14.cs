using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string password;

        while (true)
        {
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();

            // Проверка длины
            bool lengthCheck = password.Length == 5;

            // Подсчет цифр
            int digitCount = password.Count(char.IsDigit);

            // Подсчет спецсимволов
            int specialCount = password.Count(ch => !char.IsLetterOrDigit(ch));

            // Проверки
            bool digitCheck = digitCount >= 3;
            bool specialCheck = specialCount >= 1;

            if (lengthCheck && digitCheck && specialCheck)
            {
                Console.WriteLine("Пароль подходит!");
                break;
            }
            else
            {
                Console.WriteLine("Пароль не подходит.");
                Console.WriteLine("Условия:");
                Console.WriteLine("- Длина 5 символов");
                Console.WriteLine("- Минимум 3 цифры");
                Console.WriteLine("- Минимум 1 спецсимвол");
                Console.WriteLine("Попробуйте снова.\n");
            }
        }
    }
}