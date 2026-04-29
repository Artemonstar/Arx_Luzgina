namespace OOPTasksApp
{
    public class Book
    {
        // Поля со значением по умолчанию
        public string title = "Неизвестно";
        public int pages;

        // Метод получения информации о книге
        public string GetInfo()
        {
            return $"Книга: {title}, страниц: {pages}";
        }
    }
}