namespace OOPTasksApp
{
    public class Student
    {
        // Поля
        public string name;
        public int age;

        // Конструктор без параметров
        public Student() : this("Иван", 18)
        {
        }

        // Конструктор с одним параметром
        public Student(string name) : this(name, 18)
        {
        }

        // Конструктор с двумя параметрами
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Метод получения информации о студенте
        public string PrintInfo()
        {
            return $"Имя: {name}, Возраст: {age}";
        }
    }
}