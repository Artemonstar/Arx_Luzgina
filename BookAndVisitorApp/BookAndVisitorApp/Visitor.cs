using System;

namespace BookAndVisitorApp
{
    public class Visitor
    {
        // Поле для имени посетителя
        public string name;

        // Статическое поле - общее для всех объектов
        private static int totalVisitors = 0;

        /// <summary>
        /// Конструктор класса Visitor
        /// При создании объекта увеличивает счетчик
        /// </summary>
        /// <param name="visitorName">Имя посетителя</param>
        public Visitor(string visitorName)
        {
            name = visitorName;
            totalVisitors++;
        }

        /// <summary>
        /// Метод вывода информации о конкретном посетителе
        /// </summary>
        public string PrintInfo()
        {
            return $"Посетитель: {name}";
        }

        /// <summary>
        /// Статический метод для получения общего количества посетителей
        /// </summary>
        public static string ShowTotalVisitors()
        {
            return $"Общее количество созданных посетителей: {totalVisitors}";
        }

        /// <summary>
        /// Статический метод для получения числа посетителей (числом)
        /// </summary>
        public static int GetTotalVisitors()
        {
            return totalVisitors;
        }

        /// <summary>
        /// Метод для сброса счетчика (для демонстрации)
        /// </summary>
        public static void ResetCounter()
        {
            totalVisitors = 0;
        }
    }
}