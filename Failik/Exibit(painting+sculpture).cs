using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Failik
{
    abstract class Exhibit
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        protected Exhibit(string title, string artist, int year, string description)
        {
            Title = title;
            Artist = artist;
            Year = year;
            Description = description;
        }

        public abstract void DisplayInfo();
    }

    class Painting : Exhibit
    {
        public string Medium { get; set; }

        public Painting(string title, string artist, int year, string description, string medium)
            : base(title, artist, year, description)
        {
            Medium = medium;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Картина: {Title}, Художник: {Artist}, Год: {Year}, Описание: {Description}, Материал: {Medium}");
        }
    }

    class Sculpture : Exhibit
    {
        public string Material { get; set; }

        public Sculpture(string title, string artist, int year, string description, string material)
            : base(title, artist, year, description)
        {
            Material = material;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Скульптура: {Title}, Художник: {Artist}, Год: {Year}, Описание: {Description}, Материал: {Material}");
        }
    }
}
