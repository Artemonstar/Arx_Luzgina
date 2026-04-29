using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOPTasksApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ООП Задачи: Книга, Студент, Автомобиль, Треугольник, Точка";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
        }

        #region Задача 1: Книга

        private void btnCreateWarAndPeace_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.title = "Война и мир";
            book.pages = 1200;

            lstBooks.Items.Insert(0, book.GetInfo());
            lblBookResult.Text = book.GetInfo();
            lblBookResult.BackColor = Color.LightGreen;
            HighlightResult(lblBookResult);
        }

        private void btnCreate1984_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.title = "1984";
            book.pages = 300;

            lstBooks.Items.Insert(0, book.GetInfo());
            lblBookResult.Text = book.GetInfo();
            lblBookResult.BackColor = Color.LightGreen;
            HighlightResult(lblBookResult);
        }

        private void btnCreateUnknownBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.pages = 500;

            lstBooks.Items.Insert(0, book.GetInfo());
            lblBookResult.Text = book.GetInfo();
            lblBookResult.BackColor = Color.LightYellow;
            HighlightResult(lblBookResult);
        }

        private void btnClearBooks_Click(object sender, EventArgs e)
        {
            lstBooks.Items.Clear();
            lblBookResult.Text = "Информация о книге появится здесь...";
            lblBookResult.BackColor = Color.White;
        }

        #endregion

        #region Задача 2: Студент

        private void btnCreateStudentDefault_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            lstStudents.Items.Insert(0, student.PrintInfo());
            lblStudentResult.Text = student.PrintInfo();
            lblStudentResult.BackColor = Color.LightGreen;
            HighlightResult(lblStudentResult);
        }

        private void btnCreateStudentOneParam_Click(object sender, EventArgs e)
        {
            string name = txtStudentName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя студента!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = new Student(name);
            lstStudents.Items.Insert(0, student.PrintInfo());
            lblStudentResult.Text = student.PrintInfo();
            lblStudentResult.BackColor = Color.LightGreen;
            HighlightResult(lblStudentResult);
            txtStudentName.Clear();
        }

        private void btnCreateStudentTwoParams_Click(object sender, EventArgs e)
        {
            string name = txtStudentName2.Text.Trim();
            if (!int.TryParse(txtStudentAge.Text, out int age))
            {
                MessageBox.Show("Введите корректный возраст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя студента!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = new Student(name, age);
            lstStudents.Items.Insert(0, student.PrintInfo());
            lblStudentResult.Text = student.PrintInfo();
            lblStudentResult.BackColor = Color.LightGreen;
            HighlightResult(lblStudentResult);
            txtStudentName2.Clear();
            txtStudentAge.Clear();
        }

        private void btnClearStudents_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            lblStudentResult.Text = "Информация о студенте появится здесь...";
            lblStudentResult.BackColor = Color.White;
        }

        #endregion

        #region Задача 3: Автомобиль

        private void btnCreateToyota_Click(object sender, EventArgs e)
        {
            Car car = new Car { brand = "Toyota", model = "Camry", year = 2020 };
            string info = $"Машина: {car.brand} {car.model}, год: {car.year}";
            lstCars.Items.Insert(0, info);
            lblCarResult.Text = info;
            lblCarResult.BackColor = Color.LightGreen;
            HighlightResult(lblCarResult);
        }

        private void btnCreateBMW_Click(object sender, EventArgs e)
        {
            Car car = new Car { brand = "BMW", model = "X5", year = 2022 };
            string info = $"Машина: {car.brand} {car.model}, год: {car.year}";
            lstCars.Items.Insert(0, info);
            lblCarResult.Text = info;
            lblCarResult.BackColor = Color.LightGreen;
            HighlightResult(lblCarResult);
        }

        private void btnCreateLada_Click(object sender, EventArgs e)
        {
            Car car = new Car { brand = "Lada", model = "Vesta" };
            string info = $"Машина: {car.brand} {car.model}, год: {car.year}";
            lstCars.Items.Insert(0, info);
            lblCarResult.Text = info;
            lblCarResult.BackColor = Color.LightYellow;
            HighlightResult(lblCarResult);
        }

        private void btnClearCars_Click(object sender, EventArgs e)
        {
            lstCars.Items.Clear();
            lblCarResult.Text = "Информация об автомобиле появится здесь...";
            lblCarResult.BackColor = Color.White;
        }

        #endregion

        #region Задача 4: Треугольник

        private void btnCreateValidTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            string sides = triangle.PrintSides();
            bool isValid = triangle.IsValid();

            string result = $"{sides} → {(isValid ? "✓ ВАЛИДНЫЙ" : "✗ НЕВАЛИДНЫЙ")}";
            lstTriangles.Items.Insert(0, result);
            lblTriangleResult.Text = result;
            lblTriangleResult.BackColor = Color.LightGreen;
            HighlightResult(lblTriangleResult);
        }

        private void btnCreateInvalidTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(1, 2, 4);
            string sides = triangle.PrintSides();
            bool isValid = triangle.IsValid();

            string result = $"{sides} → {(isValid ? "✓ ВАЛИДНЫЙ" : "✗ НЕВАЛИДНЫЙ")}";
            lstTriangles.Items.Insert(0, result);
            lblTriangleResult.Text = result;
            lblTriangleResult.BackColor = Color.LightCoral;
            HighlightResult(lblTriangleResult);
        }

        private void btnCustomTriangle_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSideA.Text, out double a) ||
                !double.TryParse(txtSideB.Text, out double b) ||
                !double.TryParse(txtSideC.Text, out double c))
            {
                MessageBox.Show("Введите корректные значения сторон!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Triangle triangle = new Triangle(a, b, c);
            string sides = triangle.PrintSides();
            bool isValid = triangle.IsValid();

            string result = $"{sides} → {(isValid ? "✓ ВАЛИДНЫЙ" : "✗ НЕВАЛИДНЫЙ")}";
            lstTriangles.Items.Insert(0, result);
            lblTriangleResult.Text = result;
            lblTriangleResult.BackColor = isValid ? Color.LightGreen : Color.LightCoral;
            HighlightResult(lblTriangleResult);
        }

        private void btnClearTriangles_Click(object sender, EventArgs e)
        {
            lstTriangles.Items.Clear();
            lblTriangleResult.Text = "Информация о треугольнике появится здесь...";
            lblTriangleResult.BackColor = Color.White;
            txtSideA.Clear();
            txtSideB.Clear();
            txtSideC.Clear();
        }

        #endregion

        #region Задача 5: Точка (Деконструкция)

        private void btnCreatePoint1_Click(object sender, EventArgs e)
        {
            // Создание объекта Point с координатами (10, 20)
            Point point = new Point(10, 20);

            // Используя деконструктор, получаем координаты в отдельные переменные
            (int x, int y) = point;

            string result = $"Точка создана: {point.GetInfo()}\nДеконструкция: x = {x}, y = {y}";
            lstPoints.Items.Insert(0, result);
            lblPointResult.Text = result;
            lblPointResult.BackColor = Color.LightGreen;
            HighlightResult(lblPointResult);
        }

        private void btnCreatePoint2_Click(object sender, EventArgs e)
        {
            // Создание объекта Point с координатами (5, 7)
            Point point = new Point(5, 7);

            // Используя деконструктор, игнорируем X с помощью _
            (_, int y) = point;

            string result = $"Точка создана: {point.GetInfo()}\nДеконструкция (только Y): y = {y}";
            lstPoints.Items.Insert(0, result);
            lblPointResult.Text = result;
            lblPointResult.BackColor = Color.LightGreen;
            HighlightResult(lblPointResult);
        }

        private void btnCustomPoint_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPointX.Text, out int x) ||
                !int.TryParse(txtPointY.Text, out int y))
            {
                MessageBox.Show("Введите корректные координаты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Point point = new Point(x, y);
            (int dx, int dy) = point;

            string result = $"Точка создана: {point.GetInfo()}\nДеконструкция: x = {dx}, y = {dy}";
            lstPoints.Items.Insert(0, result);
            lblPointResult.Text = result;
            lblPointResult.BackColor = Color.LightGreen;
            HighlightResult(lblPointResult);
        }

        private void btnClearPoints_Click(object sender, EventArgs e)
        {
            lstPoints.Items.Clear();
            lblPointResult.Text = "Информация о точке появится здесь...";
            lblPointResult.BackColor = Color.White;
            txtPointX.Clear();
            txtPointY.Clear();
        }

        #endregion

        // Вспомогательный метод для анимации подсветки
        private void HighlightResult(Label label)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, ev) => { label.BackColor = Color.White; timer.Stop(); };
            timer.Start();
        }
    }
}