using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Failik
{
    class Exhibition
    {
        private List<Exhibit> exhibits;

        public Exhibition()
        {
            exhibits = new List<Exhibit>();
        }

        public void AddExhibit(Exhibit exhibit)
        {
            exhibits.Add(exhibit);
        }

        public void RemoveExhibit(int index)
        {
            if (index >= 0 && index < exhibits.Count)
            {
                exhibits.RemoveAt(index);
                Console.WriteLine("Экспонат удален.");
            }
            else
            {
                Console.WriteLine("Некорректный индекс.");
            }
        }

        public void SortExhibitsByYear()
        {
            exhibits.Sort((x, y) => x.Year.CompareTo(y.Year));
            Console.WriteLine("Экспонаты отсортированы по году создания.");
        }

        public void ShowExhibits()
        {
            Console.WriteLine("Экспонаты выставки:");
            for (int i = 0; i < exhibits.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                exhibits[i].DisplayInfo();
            }
        }
    }
}
