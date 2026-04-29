namespace BookBankPointApp
{
    public class Book
    {
        // Поля со значением по умолчанию
        public string title = "Неизвестно";
        public string author;
        public int year;

        // Метод вывода информации о книге
        public string DisplayInfo()
        {
            return $"Название: {title}, Автор: {author}, Год: {year}";
        }
    }
}