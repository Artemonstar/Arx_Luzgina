namespace OOPTasksApp
{
    public class Point
    {
        // Поля
        public int X = 0;
        public int Y = 0;

        // Конструктор
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Метод деконструкции
        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }

        // Метод получения информации
        public string GetInfo()
        {
            return $"Point: ({X}, {Y})";
        }
    }
}