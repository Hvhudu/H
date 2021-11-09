using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Пользователь вводит число секунд. Переведите секунды в часы, минуты, секунды.
            Console.WriteLine("Введите кол-во секунд: ");
            double sekonds = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            Console.WriteLine(@"Выберите вариант конвертации:
                                    1-часы
                                    2-минуты
                                    3-секунды");
            var choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    result = sekonds / 3600;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{result}");
                    Console.ResetColor();
                    break;
                case 2:
                    result = sekonds / 60;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{result}");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{sekonds}");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! Выбран несуществующий пункт!");
                    Console.ResetColor();
                    break;
            }
        }
    }
}