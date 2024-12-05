using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Failik
{
    internal class Failik
    {
        static void Main(string[] args)
        {
            Exhibition exhibition = new Exhibition();
            Painting painting1 = new Painting("Звездная ночь", "Винсент Ван Гог", 1889, "Известная картина с ночным небом", "Масло");
            Painting painting2 = new Painting("Мона Лиза", "Леонардо да Винчи", 1503, "Знаменитый портрет женщины", "Масло");
            Painting painting3 = new Painting("Крик", "Эдвард Мунк", 1893, "Картина, символизирующая экзистенциальный страх", "Масло");
            Painting painting4 = new Painting("Девушка с жемчужной серёжкой", "Йоханнес Вермеер", 1665, "Известная картина с загадочной девушкой", "Масло");
            Painting painting5 = new Painting("Сотворение Адама", "Микеланджело", 1512, "Часть потолка Сикстинской капеллы", "Фреска");

            Sculpture sculpture1 = new Sculpture("Давид", "Микеланджело", 1504, "Известная скульптура", "Мрамор");
            Sculpture sculpture2 = new Sculpture("Мыслитель", "Огюст Роден", 1902, "Скульптура, символизирующая философию", "Бронза");
            Sculpture sculpture3 = new Sculpture("Венера Милосская", "Неизвестный", -1, "Классическая греческая скульптура", "Мрамор");
            Sculpture sculpture4 = new Sculpture("Пьета", "Микеланджело", 1499, "Скульптура, изображающая Марию с телом Иисуса", "Мрамор");

            ShowMenu(exhibition);
        }
        static void ShowMenu(Exhibition exhibition)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Показать экспонаты");
                Console.WriteLine("2. Добавить экспонат");
                Console.WriteLine("3. Удалить экспонат");
                Console.WriteLine("4. Сортировать экспонаты по году создания");
                Console.WriteLine("5. Выход");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        exhibition.ShowExhibits();
                        break;
                    case "2":
                        AddExhibit(exhibition);
                        break;
                    case "3":
                        RemoveExhibit(exhibition);
                        break;
                    case "4":
                        exhibition.SortExhibitsByYear();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static void AddExhibit(Exhibition exhibition)
        {
            Console.WriteLine("Введите тип экспоната (картина/скульптура):");
            string type = Console.ReadLine().ToLower();
            Console.WriteLine("Введите название:");
            string title = Console.ReadLine();
            Console.WriteLine("Введите художника:");
            string artist = Console.ReadLine();
            Console.WriteLine("Введите год создания:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите описание:");
            string description = Console.ReadLine();

            if (type == "картина")
            {
                Console.WriteLine("Введите материал:");
                string medium = Console.ReadLine();
                exhibition.AddExhibit(new Painting(title, artist, year, description, medium));
            }
            else if (type == "скульптура")
            {
                Console.WriteLine("Введите материал:");
                string material = Console.ReadLine();
                exhibition.AddExhibit(new Sculpture(title, artist, year, description, material));
            }
            else
            {
                Console.WriteLine("Некорректный тип экспоната.");
            }
        }

        static void RemoveExhibit(Exhibition exhibition)
        {
            exhibition.ShowExhibits();
            Console.WriteLine("Введите номер экспоната для удаления:");
            int index = int.Parse(Console.ReadLine()) - 1;
            exhibition.RemoveExhibit(index);
        }
    }
}

