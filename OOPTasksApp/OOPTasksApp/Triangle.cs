namespace OOPTasksApp
{
    public class Triangle
    {
        // Поля
        public double a;
        public double b;
        public double c;

        // Конструктор с использованием this
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Метод проверки существования треугольника
        public bool IsValid()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        // Метод получения строки со сторонами
        public string PrintSides()
        {
            return $"Стороны: a = {a}, b = {b}, c = {c}";
        }
    }
}