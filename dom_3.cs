////using System;

////public interface IFigure
////{
////    double GetArea();
////    double GetPerimeter();
////}

////public class Circle : IFigure
////{
////    public double Radius { get; set; }

////    public Circle(double radius)
////    {
////        Radius = radius;
////    }

////    public double GetArea()
////    {
////        return Math.PI * Radius * Radius;
////    }

////    public double GetPerimeter()
////    {
////        return 2 * Math.PI * Radius;
////    }
////}

////public class Square : IFigure
////{
////    public double Side { get; set; }

////    public Square(double side)
////    {
////        Side = side;
////    }

////    public double GetArea()
////    {
////        return Side * Side;
////    }

////    public double GetPerimeter()
////    {
////        return 4 * Side;
////    }
////}

////public class Triangle : IFigure
////{
////    public double SideA { get; set; }
////    public double SideB { get; set; }
////    public double SideC { get; set; }

////    public Triangle(double sideA, double sideB, double sideC)
////    {
////        SideA = sideA;
////        SideB = sideB;
////        SideC = sideC;
////    }

////    public double GetArea()
////    {
////        double p = GetPerimeter() / 2; 
////        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
////    }

////    public double GetPerimeter()
////    {
////        return SideA + SideB + SideC;
////    }
////}

////class Program
////{
////    static void Main()
////    {
////        IFigure[] figures = new IFigure[]
////        {
////            new Circle(5),
////            new Square(4),
////            new Triangle(3, 4, 5)
////        };

////        foreach (var figure in figures)
////        {
////            Console.WriteLine($"Фигура: {figure.GetType().Name}");
////            Console.WriteLine($"Площадь: {figure.GetArea():F2}");
////            Console.WriteLine($"Периметр: {figure.GetPerimeter():F2}");
////            Console.WriteLine();
////        }
////    }
////}


























//using System;

//public interface IVehicle
//{
//    void Start();
//    void Stop();
//    double GetSpeed();
//    void Accelerate(); 
//    void Brake();      
//}

//public class Car : IVehicle
//{
//    private double _speed;
//    private bool _isRunning;
//    private const double ACCELERATION_STEP = 20;
//    private const double BRAKE_STEP = 15;

//    public void Start()
//    {
//        _speed = 20;
//        _isRunning = true;
//        Console.WriteLine($"Автомобиль заведён. Скорость: {_speed} км/ч");
//    }

//    public void Stop()
//    {
//        _speed = 0;
//        _isRunning = false;
//        Console.WriteLine("Автомобиль остановлен");
//    }

//    public double GetSpeed()
//    {
//        return _isRunning ? _speed : 0;
//    }

//    public void Accelerate()
//    {
//        if (_isRunning)
//        {
//            _speed += ACCELERATION_STEP;
//            Console.WriteLine($"Автомобиль ускорился. Текущая скорость: {_speed} км/ч");
//        }
//        else
//        {
//            Console.WriteLine("Сначала заведите автомобиль (Старт)");
//        }
//    }

//    public void Brake()
//    {
//        if (_isRunning)
//        {
//            _speed = Math.Max(0, _speed - BRAKE_STEP);
//            Console.WriteLine($"Автомобиль замедлился. Текущая скорость: {_speed} км/ч");
//            if (_speed == 0)
//            {
//                _isRunning = false;
//                Console.WriteLine("Автомобиль полностью остановился");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Автомобиль уже остановлен");
//        }
//    }
//}

//public class Bicycle : IVehicle
//{
//    private double _speed;
//    private bool _isMoving;
//    private const double ACCELERATION_STEP = 5;
//    private const double BRAKE_STEP = 8;

//    public void Start()
//    {
//        _speed = 8;
//        _isMoving = true;
//        Console.WriteLine($"Велосипед поехал. Скорость: {_speed} км/ч");
//    }

//    public void Stop()
//    {
//        _speed = 0;
//        _isMoving = false;
//        Console.WriteLine("Велосипед остановлен");
//    }

//    public double GetSpeed()
//    {
//        return _isMoving ? _speed : 0;
//    }

//    public void Accelerate()
//    {
//        if (_isMoving)
//        {
//            _speed += ACCELERATION_STEP;
//            Console.WriteLine($"Велосипед ускорился. Текущая скорость: {_speed} км/ч");
//        }
//        else
//        {
//            Console.WriteLine("Сначала начните движение (Старт)");
//        }
//    }

//    public void Brake()
//    {
//        if (_isMoving)
//        {
//            _speed = Math.Max(0, _speed - BRAKE_STEP);
//            Console.WriteLine($"Велосипед замедлился. Текущая скорость: {_speed} км/ч");
//            if (_speed == 0)
//            {
//                _isMoving = false;
//                Console.WriteLine("Велосипед полностью остановился");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Велосипед уже остановлен");
//        }
//    }
//}

//public class Boat : IVehicle
//{
//    private double _speed;
//    private bool _isSailing;
//    private const double ACCELERATION_STEP = 10;
//    private const double BRAKE_STEP = 7;

//    public void Start()
//    {
//        _speed = 5;
//        _isSailing = true;
//        Console.WriteLine($"Лодка отчалила. Скорость: {_speed} узлов");
//    }

//    public void Stop()
//    {
//        _speed = 0;
//        _isSailing = false;
//        Console.WriteLine("Лодка остановлена");
//    }

//    public double GetSpeed()
//    {
//        return _isSailing ? _speed : 0;
//    }

//    public void Accelerate()
//    {
//        if (_isSailing)
//        {
//            _speed += ACCELERATION_STEP;
//            Console.WriteLine($"Лодка ускорилась. Текущая скорость: {_speed} узлов");
//        }
//        else
//        {
//            Console.WriteLine("Сначала запустите лодку (Старт)");
//        }
//    }

//    public void Brake()
//    {
//        if (_isSailing)
//        {
//            _speed = Math.Max(0, _speed - BRAKE_STEP);
//            Console.WriteLine($"Лодка замедлилась. Текущая скорость: {_speed} узлов");
//            if (_speed == 0)
//            {
//                _isSailing = false;
//                Console.WriteLine("Лодка полностью остановилась");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Лодка уже остановлена");
//        }
//    }
//}

//public class Airplane : IVehicle
//{
//    private double _speed;
//    private bool _isFlying;
//    private const double ACCELERATION_STEP = 100;
//    private const double BRAKE_STEP = 80;

//    public void Start()
//    {
//        _speed = 250;
//        _isFlying = true;
//        Console.WriteLine($"Самолёт взлетел. Скорость: {_speed} км/ч");
//    }

//    public void Stop()
//    {
//        _speed = 0;
//        _isFlying = false;
//        Console.WriteLine("Самолёт совершил посадку");
//    }

//    public double GetSpeed()
//    {
//        return _isFlying ? _speed : 0;
//    }

//    public void Accelerate()
//    {
//        if (_isFlying)
//        {
//            _speed += ACCELERATION_STEP;
//            Console.WriteLine($"Самолёт ускорился. Текущая скорость: {_speed} км/ч");
//        }
//        else
//        {
//            Console.WriteLine("Сначала взлетите (Старт)");
//        }
//    }

//    public void Brake()
//    {
//        if (_isFlying)
//        {
//            _speed = Math.Max(0, _speed - BRAKE_STEP);
//            Console.WriteLine($"Самолёт замедлился. Текущая скорость: {_speed} км/ч");
//            if (_speed == 0)
//            {
//                _isFlying = false;
//                Console.WriteLine("Самолёт полностью остановился");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Самолёт уже на земле");
//        }
//    }
//}

//public class Train : IVehicle
//{
//    private double _speed;
//    private bool _isMoving;
//    private const double ACCELERATION_STEP = 30;
//    private const double BRAKE_STEP = 25;

//    public void Start()
//    {
//        _speed = 40;
//        _isMoving = true;
//        Console.WriteLine($"Поезд отправился. Скорость: {_speed} км/ч");
//    }

//    public void Stop()
//    {
//        _speed = 0;
//        _isMoving = false;
//        Console.WriteLine("Поезд остановлен");
//    }

//    public double GetSpeed()
//    {
//        return _isMoving ? _speed : 0;
//    }

//    public void Accelerate()
//    {
//        if (_isMoving)
//        {
//            _speed += ACCELERATION_STEP;
//            Console.WriteLine($"Поезд ускорился. Текущая скорость: {_speed} км/ч");
//        }
//        else
//        {
//            Console.WriteLine("Сначала отправьте поезд (Старт)");
//        }
//    }

//    public void Brake()
//    {
//        if (_isMoving)
//        {
//            _speed = Math.Max(0, _speed - BRAKE_STEP);
//            Console.WriteLine($"Поезд замедлился. Текущая скорость: {_speed} км/ч");
//            if (_speed == 0)
//            {
//                _isMoving = false;
//                Console.WriteLine("Поезд полностью остановился");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Поезд уже остановлен");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        IVehicle currentVehicle = null;
//        bool exit = false;

//        while (!exit)
//        {
//            Console.Clear();
//            Console.WriteLine("=== СИСТЕМА УПРАВЛЕНИЯ ТРАНСПОРТОМ ===");
//            Console.WriteLine("1. Автомобиль");
//            Console.WriteLine("2. Велосипед");
//            Console.WriteLine("3. Лодка");
//            Console.WriteLine("4. Самолёт");
//            Console.WriteLine("5. Поезд");
//            Console.WriteLine("6. Выход");
//            Console.Write("Выберите транспорт: ");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    currentVehicle = new Car();
//                    Console.WriteLine("\nВыбран АВТОМОБИЛЬ");
//                    break;
//                case "2":
//                    currentVehicle = new Bicycle();
//                    Console.WriteLine("\nВыбран ВЕЛОСИПЕД");
//                    break;
//                case "3":
//                    currentVehicle = new Boat();
//                    Console.WriteLine("\nВыбрана ЛОДКА");
//                    break;
//                case "4":
//                    currentVehicle = new Airplane();
//                    Console.WriteLine("\nВыбран САМОЛЁТ");
//                    break;
//                case "5":
//                    currentVehicle = new Train();
//                    Console.WriteLine("\nВыбран ПОЕЗД");
//                    break;
//                case "6":
//                    exit = true;
//                    continue;
//                default:
//                    Console.WriteLine("Неверный выбор!");
//                    Console.ReadKey();
//                    continue;
//            }

//            bool backToMenu = false;
//            while (!backToMenu && currentVehicle != null)
//            {
//                Console.WriteLine("\n--- ДЕЙСТВИЯ ---");
//                Console.WriteLine("1. Старт");
//                Console.WriteLine("2. Ускориться");
//                Console.WriteLine("3. Замедлиться");
//                Console.WriteLine("4. Стоп");
//                Console.WriteLine("5. Показать текущую скорость");
//                Console.WriteLine("6. Выбрать другой транспорт");
//                Console.Write("Ваш выбор: ");

//                string action = Console.ReadLine();

//                switch (action)
//                {
//                    case "1":
//                        currentVehicle.Start();
//                        break;
//                    case "2":
//                        currentVehicle.Accelerate();
//                        break;
//                    case "3":
//                        currentVehicle.Brake();
//                        break;
//                    case "4":
//                        currentVehicle.Stop();
//                        break;
//                    case "5":
//                        double currentSpeed = currentVehicle.GetSpeed();
//                        Console.WriteLine($"Текущая скорость: {currentSpeed}");
//                        break;
//                    case "6":
//                        backToMenu = true;
//                        break;
//                    default:
//                        Console.WriteLine("Неверный выбор!");
//                        break;
//                }

//                if (!backToMenu && action != "6")
//                {
//                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                    Console.ReadKey();
//                }
//            }
//        }

//        Console.WriteLine("Программа завершена. До свидания!");
//    }
//}