using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6
{
    class BuildInfo
    {
        private static Guid Identificator;
        private int height;
        private int floor;
        private int countflat;
        private int entrance;

        public static void Execute()
        {
            Console.WriteLine("Домашнее задание 7.1");
            var build = new BuildInfo();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите команды: заполнить, вывести, вычислить высоту этажа, вычислить количество квартир в подъезде, вычислить количество квартир на этаже, выход");
                string act = Console.ReadLine().ToLower();

                switch (act)
                {
                    case "выход":
                        flag = false;
                        break;
                    case "заполнить":
                        build.GetInfo();
                        break;
                    case "вывести":
                        build.Print();
                        break;
                    case "вычислить высоту этажа":
                        build.SolutionHeight();
                        break;
                    case "вычислить количество квартир в подъезде":
                        build.SolutionCountFLat();
                        break;
                    case "вычислить количество квартир на этаже":
                        Console.WriteLine("Введите количество квартир на этаже");
                        int cf;
                        while (!int.TryParse(Console.ReadLine(), out cf) || cf < 0)
                        {
                            Console.WriteLine("Ошибка ввода! Введите целое число");
                        }
                        build.SolutionCountFLatFloor(cf);
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда. Пожалуйста, попробуйте снова.");
                        break;
                }
            }
        }

        private void GetInfo()
        {
            Console.WriteLine("Высота здания");
            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Console.WriteLine("Количество этажей");
            while (!int.TryParse(Console.ReadLine(), out floor))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Console.WriteLine("Количество подъездов");
            while (!int.TryParse(Console.ReadLine(), out countflat))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Console.WriteLine("Количество квартир");
            while (!int.TryParse(Console.ReadLine(), out entrance))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Identificator = Guid.NewGuid();
        }

        private void Print()
        {
            Console.WriteLine("Информация о здании:");
            Console.WriteLine($"Id: {Identificator}");
            Console.WriteLine($"Высота: {height}");
            Console.WriteLine($"Этажи: {floor}");
            Console.WriteLine($"Количество квартир: {countflat}");
            Console.WriteLine($"Количество подъездов: {entrance}");
        }

        private void SolutionHeight()
        {
            int heightfloor = (int)(height / floor);
            Console.WriteLine($"Высота этажа: {heightfloor}");
        }

        private void SolutionCountFLat()
        {
            int CountFLat = (int)(entrance / countflat);
            Console.WriteLine($"Количество квартир в подъезде: {CountFLat}");
        }

        private void SolutionCountFLatFloor(int cf)
        {
            int CountFLatFloor = (int)(cf / floor);
            Console.WriteLine($"Количество квартир на этаже: {CountFLatFloor}");
        }
    }
}
