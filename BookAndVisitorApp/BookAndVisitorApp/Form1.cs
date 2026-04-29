using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookAndVisitorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Книжная полка | Умный счетчик";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(750, 550);
        }

        #region Задача 1: Книжная полка

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string yearText = txtYear.Text.Trim();

            // Валидация ввода
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(yearText))
            {
                MessageBox.Show("Заполните все поля для книги!", "Предупреждение",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(yearText, out int year))
            {
                MessageBox.Show("Введите корректный год издания!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание и настройка книги
            Book myBook = new Book();
            myBook.title = title;
            myBook.author = author;
            myBook.year = year;

            // Вывод информации
            lblBookResult.Text = myBook.GetInfo();
            lblBookResult.BackColor = Color.LightGreen;

            // Добавление в список
            lstBooks.Items.Insert(0, $"Книга создана: {myBook.GetInfo()}");

            // Очистка полей
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();

            // Анимация
            Timer timer = new Timer();
            timer.Interval = 800;
            timer.Tick += (s, ev) => { lblBookResult.BackColor = Color.White; timer.Stop(); };
            timer.Start();
        }

        private void btnDefaultBook_Click(object sender, EventArgs e)
        {
            // Создание книги с параметрами по умолчанию
            Book unknownBook = new Book();

            lblBookResult.Text = unknownBook.GetInfo();
            lblBookResult.BackColor = Color.LightYellow;

            lstBooks.Items.Insert(0, $"Книга по умолчанию: {unknownBook.GetInfo()}");
        }

        private void btnClearBooks_Click(object sender, EventArgs e)
        {
            lstBooks.Items.Clear();
            lblBookResult.Text = "Информация о книге появится здесь...";
            lblBookResult.BackColor = Color.White;

            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
        }

        #endregion

        #region Задача 2: Умный счетчик

        // Список для хранения созданных посетителей
        private void btnCreateVisitor_Click(object sender, EventArgs e)
        {
            string name = txtVisitorName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя посетителя!", "Предупреждение",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание нового посетителя (счетчик увеличится автоматически)
            Visitor visitor = new Visitor(name);

            // Вывод информации о посетителе
            lstVisitors.Items.Insert(0, visitor.PrintInfo());

            // Обновление счетчика на форме
            UpdateVisitorCounter();

            // Очистка поля ввода
            txtVisitorName.Clear();
            txtVisitorName.Focus();

            // Подсветка кнопки
            btnCreateVisitor.BackColor = Color.LightGreen;
            Timer timer = new Timer();
            timer.Interval = 300;
            timer.Tick += (s, ev) => { btnCreateVisitor.BackColor = Color.FromArgb(52, 152, 219); timer.Stop(); };
            timer.Start();
        }

        private void btnCreateThreeVisitors_Click(object sender, EventArgs e)
        {
            // Создание трех посетителей согласно заданию
            string[] names = { "Анна", "Борис", "Виктор" };

            foreach (string name in names)
            {
                Visitor visitor = new Visitor(name);
                lstVisitors.Items.Insert(0, visitor.PrintInfo());
            }

            UpdateVisitorCounter();

            MessageBox.Show("Созданы три посетителя: Анна, Борис, Виктор",
                          "Демонстрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowTotal_Click(object sender, EventArgs e)
        {
            // Вызов статического метода ShowTotalVisitors()
            string totalMessage = Visitor.ShowTotalVisitors();

            MessageBox.Show(totalMessage, "Общая статистика",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Также обновляем текстовое поле
            lblTotalVisitors.Text = totalMessage;
            lblTotalVisitors.BackColor = Color.LightGreen;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, ev) => { lblTotalVisitors.BackColor = Color.WhiteSmoke; timer.Stop(); };
            timer.Start();
        }

        private void btnResetVisitors_Click(object sender, EventArgs e)
        {
            // Сброс счетчика и очистка списка
            Visitor.ResetCounter();
            lstVisitors.Items.Clear();
            UpdateVisitorCounter();

            lblTotalVisitors.Text = "Общее количество созданных посетителей: 0";
            lblTotalVisitors.BackColor = Color.LightYellow;

            MessageBox.Show("Счетчик посетителей сброшен!", "Сброс",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateVisitorCounter()
        {
            // Обновление отображения счетчика
            int total = Visitor.GetTotalVisitors();
            lblTotalVisitors.Text = $"Общее количество созданных посетителей: {total}";

            // Обновляем также в группе статистики
            if (total > 0)
            {
                lblStats.Text = $"📊 Создано посетителей: {total}";
            }
            else
            {
                lblStats.Text = "📊 Посетители не созданы";
            }
        }

        private void txtVisitorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCreateVisitor.PerformClick();
            }
        }

        #endregion
    }
}