using System;
using System.Drawing;
using System.Windows.Forms;

namespace MethodsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Задачи: Приветствие и Калькулятор возраста";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(700, 500);
        }

       // Задача 1: Приветствие по имени

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя!", "Предупреждение",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вызов метода SayHelloTo с переданным именем
            string result = SayHelloTo(name);

            lstGreetings.Items.Insert(0, result);

            // Очистка поля ввода
            txtName.Clear();
            txtName.Focus();

            // Подсветка кнопки
            btnSayHello.BackColor = Color.LightGreen;
            Timer timer = new Timer();
            timer.Interval = 300;
            timer.Tick += (s, ev) => { btnSayHello.BackColor = Color.FromArgb(52, 152, 219); timer.Stop(); };
            timer.Start();
        }

        /// <summary>
        /// Метод приветствия пользователя по имени
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <returns>Строка приветствия</returns>
        private string SayHelloTo(string name)
        {
            // Обычная форма записи метода
            return $"Hello, {name}!";
        }

        // Пример метода со стрелочной записью (лямбда-выражение)
        // private string SayHelloTo(string name) => $"Hello, {name}!";

        private void btnDemoThree_Click(object sender, EventArgs e)
        {
            // Демонстрация работы метода с тремя разными именами
            lstGreetings.Items.Clear();

            string[] names = { "Tom", "Bob", "Alice" };

            foreach (string name in names)
            {
                lstGreetings.Items.Add(SayHelloTo(name));
            }

            MessageBox.Show("Демонстрация завершена! Показаны приветствия для Tom, Bob и Alice.",
                          "Демонстрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearGreetings_Click(object sender, EventArgs e)
        {
            lstGreetings.Items.Clear();
        }

    

        #region Задача 2: Калькулятор возраста

        private void btnCalculateAge_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBirthYear.Text, out int birthYear))
            {
                MessageBox.Show("Введите корректный год рождения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCurrentYear.Text, out int currentYear))
            {
                MessageBox.Show("Введите корректный текущий год!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (birthYear > currentYear)
            {
                MessageBox.Show("Год рождения не может быть больше текущего года!",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вызов метода CalculateAge
            int age = CalculateAge(birthYear, currentYear);

            lblAgeResult.Text = $"Возраст: {age} лет";
            lblAgeResult.BackColor = Color.LightGreen;

            // Добавляем в историю
            lstHistory.Items.Insert(0, $"{birthYear} → {currentYear}: {age} лет");

            Timer timer = new Timer();
            timer.Interval = 800;
            timer.Tick += (s, ev) => { lblAgeResult.BackColor = Color.White; timer.Stop(); };
            timer.Start();
        }

        /// <summary>
        /// Метод вычисления возраста (обычная форма записи)
        /// </summary>
        /// <param name="birthYear">Год рождения</param>
        /// <param name="currentYear">Текущий год</param>
        /// <returns>Возраст</returns>
        private int CalculateAge(int birthYear, int currentYear)
        {
            return currentYear - birthYear;
        }

        // Альтернативная запись метода со стрелочной формой (=>)
        // private int CalculateAge(int birthYear, int currentYear) => currentYear - birthYear;

        private void btnDemoAge_Click(object sender, EventArgs e)
        {
            // Демонстрация с двумя примерами из задания
            lstHistory.Items.Clear();

            int year1990 = CalculateAge(1990, 2024);
            int year2005 = CalculateAge(2005, 2024);

            lstHistory.Items.Add("=== ДЕМОНСТРАЦИЯ ===");
            lstHistory.Items.Add($"1990 год → {year1990} лет");
            lstHistory.Items.Add($"2005 год → {year2005} лет");
            lstHistory.Items.Add("");
            lstHistory.Items.Add("По заданию:");
            lstHistory.Items.Add($"Человек 1990 г.р. в 2024 году: {year1990} лет");
            lstHistory.Items.Add($"Человек 2005 г.р. в 2024 году: {year2005} лет");

            // Также показываем в основном поле
            txtBirthYear.Text = "1990";
            txtCurrentYear.Text = "2024";
            btnCalculateAge.PerformClick();

            MessageBox.Show("Демонстрация завершена!\n\n" +
                          "Человек 1990 года рождения в 2024 году: " + year1990 + " лет\n" +
                          "Человек 2005 года рождения в 2024 году: " + year2005 + " лет",
                          "Демонстрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }

        private void txtBirthYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем только цифры и Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCurrentYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}