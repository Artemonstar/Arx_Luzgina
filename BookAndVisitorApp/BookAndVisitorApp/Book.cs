using System;

namespace BookAndVisitorApp
{
    public class Book
    {
        // Поля класса Book
        public string title = "Неизвестно";
        public string author = "Неизвестен";
        public int year;

        /// <summary>
        /// Метод вывода информации о книге
        /// </summary>
        public string GetInfo()
        {
            return $"«{title}», {author} ({year})";
        }
    }
}