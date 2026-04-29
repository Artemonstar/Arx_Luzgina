namespace BookBankPointApp
{
    public struct Point
    {
        // Поля координат
        public int X;
        public int Y;

        // Метод для перемещения точки
        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        // Метод для вывода координат
        public string PrintCoordinates()
        {
            return $"Точка: ({X}, {Y})";
        }
    }
}