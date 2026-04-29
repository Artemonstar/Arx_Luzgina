using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookBankPointApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Задачи: Книга | Счет в банке | Точка";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(750, 600);
        }

        #region Задача 1: Книга

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            string title = txtBookTitle.Text.Trim();
            string author = txtBookAuthor.Text.Trim();
            string yearText = txtBookYear.Text.Trim();

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

            // Создание объекта Book
            Book myBook = new Book();
            myBook.title = title;
            myBook.author = author;
            myBook.year = year;

            // Вывод через метод DisplayInfo()
            string info = myBook.DisplayInfo();
            lblBookDisplayInfo.Text = info;

            // Вывод каждого поля по отдельности
            string fields = $"Название: {myBook.title}\nАвтор: {myBook.author}\nГод: {myBook.year}";
            lblBookFields.Text = fields;

            // Добавление в список
            lstBooks.Items.Insert(0, $"Книга создана: {info}");

            // Подсветка
            lblBookDisplayInfo.BackColor = Color.LightGreen;
            HighlightResult(lblBookDisplayInfo);
            HighlightResult(lblBookFields);

            // Очистка полей
            txtBookTitle.Clear();
            txtBookAuthor.Clear();
            txtBookYear.Clear();
        }

        private void btnBookDefault_Click(object sender, EventArgs e)
        {
            // Создание книги со значениями по умолчанию
            Book defaultBook = new Book();
            defaultBook.author = "Неизвестен";
            defaultBook.year = 0;

            lblBookDisplayInfo.Text = defaultBook.DisplayInfo();
            lblBookFields.Text = $"Название: {defaultBook.title}\nАвтор: {defaultBook.author}\nГод: {defaultBook.year}";
            lstBooks.Items.Insert(0, $"Книга по умолчанию: {defaultBook.DisplayInfo()}");

            lblBookDisplayInfo.BackColor = Color.LightYellow;
            lblBookFields.BackColor = Color.LightYellow;
            HighlightResult(lblBookDisplayInfo);
            HighlightResult(lblBookFields);
        }

        private void btnClearBooks_Click(object sender, EventArgs e)
        {
            lstBooks.Items.Clear();
            lblBookDisplayInfo.Text = "Информация о книге (DisplayInfo) появится здесь...";
            lblBookFields.Text = "Поля по отдельности:\nНазвание: \nАвтор: \nГод:";
            lblBookDisplayInfo.BackColor = Color.White;
            lblBookFields.BackColor = Color.White;
            txtBookTitle.Clear();
            txtBookAuthor.Clear();
            txtBookYear.Clear();
        }

        #endregion

        #region Задача 2: Счет в банке

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountNum = txtAccountNumber.Text.Trim();

            if (string.IsNullOrEmpty(accountNum))
            {
                MessageBox.Show("Введите номер счета!", "Предупреждение",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание нового счета
            currentAccount = new BankAccount();
            currentAccount.accountNumber = accountNum;

            lblAccountInfo.Text = currentAccount.GetAccountInfo();
            lstBankLog.Items.Clear();
            lstBankLog.Items.Add($"=== Счет создан: {currentAccount.GetAccountInfo()} ===");

            txtAccountNumber.Enabled = false;
            btnCreateAccount.Enabled = false;
            btnDeposit.Enabled = true;
            btnWithdraw.Enabled = true;

            lblAccountInfo.BackColor = Color.LightGreen;
            HighlightResult(lblAccountInfo);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (currentAccount == null) return;

            if (!double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Введите корректную сумму!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = currentAccount.Deposit(amount);
            lstBankLog.Items.Insert(0, result);
            lblAccountInfo.Text = currentAccount.GetAccountInfo();
            lblAccountInfo.BackColor = Color.LightGreen;
            HighlightResult(lblAccountInfo);

            txtAmount.Clear();
            txtAmount.Focus();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (currentAccount == null) return;

            if (!double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Введите корректную сумму!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = currentAccount.Withdraw(amount);
            lstBankLog.Items.Insert(0, result);
            lblAccountInfo.Text = currentAccount.GetAccountInfo();

            if (result.Contains("Недостаточно"))
            {
                lblAccountInfo.BackColor = Color.LightCoral;
            }
            else
            {
                lblAccountInfo.BackColor = Color.LightGreen;
            }
            HighlightResult(lblAccountInfo);

            txtAmount.Clear();
            txtAmount.Focus();
        }

        private void btnDemoBank_Click(object sender, EventArgs e)
        {
            // Демонстрация согласно заданию
            txtAccountNumber.Text = "40817810099990001234";
            btnCreateAccount.PerformClick();

            // Deposit(500)
            txtAmount.Text = "500";
            btnDeposit.PerformClick();

            // Withdraw(200)
            txtAmount.Text = "200";
            btnWithdraw.PerformClick();

            // Withdraw(400) - проверка недостатка средств
            txtAmount.Text = "400";
            btnWithdraw.PerformClick();

            btnDemoBank.Enabled = false;
        }

        private void btnResetBank_Click(object sender, EventArgs e)
        {
            currentAccount = null;
            txtAccountNumber.Enabled = true;
            btnCreateAccount.Enabled = true;
            btnDeposit.Enabled = false;
            btnWithdraw.Enabled = false;
            btnDemoBank.Enabled = true;

            txtAccountNumber.Clear();
            txtAmount.Clear();
            lblAccountInfo.Text = "Информация о счете появится здесь...";
            lstBankLog.Items.Clear();
            lblAccountInfo.BackColor = Color.White;
        }

        #endregion

        #region Задача 3: Структура Точка

        private void btnCreatePointNew_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPointX1.Text, out int x) || !int.TryParse(txtPointY1.Text, out int y))
            {
                MessageBox.Show("Введите корректные координаты!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание через new
            Point p1 = new Point();
            p1.X = x;
            p1.Y = y;

            currentPointNew = p1;
            lblPointNew.Text = currentPointNew.PrintCoordinates();
            lblPointNew.BackColor = Color.LightGreen;
            HighlightResult(lblPointNew);
        }

        private void btnCreatePointWithoutNew_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPointX2.Text, out int x) || !int.TryParse(txtPointY2.Text, out int y))
            {
                MessageBox.Show("Введите корректные координаты!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание без new (просто объявление переменной)
            Point p2;
            p2.X = x;
            p2.Y = y;

            currentPointWithoutNew = p2;
            lblPointWithoutNew.Text = currentPointWithoutNew.PrintCoordinates();
            lblPointWithoutNew.BackColor = Color.LightGreen;
            HighlightResult(lblPointWithoutNew);
        }

        private void btnMovePoint_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDeltaX.Text, out int deltaX) || !int.TryParse(txtDeltaY.Text, out int deltaY))
            {
                MessageBox.Show("Введите корректные значения дельты!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Выбираем какую точку перемещать
            if (rbPointNew.Checked)
            {
                currentPointNew.Move(deltaX, deltaY);
                lblPointNew.Text = currentPointNew.PrintCoordinates();
                lblPointNew.BackColor = Color.LightYellow;
                lstPointLog.Items.Insert(0, $"Точка1 перемещена на ({deltaX}, {deltaY}): {currentPointNew.PrintCoordinates()}");
            }
            else if (rbPointWithoutNew.Checked)
            {
                currentPointWithoutNew.Move(deltaX, deltaY);
                lblPointWithoutNew.Text = currentPointWithoutNew.PrintCoordinates();
                lblPointWithoutNew.BackColor = Color.LightYellow;
                lstPointLog.Items.Insert(0, $"Точка2 перемещена на ({deltaX}, {deltaY}): {currentPointWithoutNew.PrintCoordinates()}");
            }
            else
            {
                MessageBox.Show("Выберите точку для перемещения!", "Предупреждение",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            HighlightResult(lblPointNew);
            HighlightResult(lblPointWithoutNew);
        }

        private void btnDemoPoint_Click(object sender, EventArgs e)
        {
            // Демонстрация согласно заданию
            txtPointX1.Text = "10";
            txtPointY1.Text = "20";
            btnCreatePointNew.PerformClick();

            txtPointX2.Text = "5";
            txtPointY2.Text = "7";
            btnCreatePointWithoutNew.PerformClick();

            rbPointNew.Checked = true;
            txtDeltaX.Text = "5";
            txtDeltaY.Text = "-3";
            btnMovePoint.PerformClick();

            btnDemoPoint.Enabled = false;
        }

        private void btnClearPoints_Click(object sender, EventArgs e)
        {
            currentPointNew = new Point();
            currentPointWithoutNew = new Point();

            txtPointX1.Clear();
            txtPointY1.Clear();
            txtPointX2.Clear();
            txtPointY2.Clear();
            txtDeltaX.Clear();
            txtDeltaY.Clear();

            lblPointNew.Text = "Точка с new не создана";
            lblPointWithoutNew.Text = "Точка без new не создана";
            lblPointNew.BackColor = Color.White;
            lblPointWithoutNew.BackColor = Color.White;

            lstPointLog.Items.Clear();

            rbPointNew.Checked = false;
            rbPointWithoutNew.Checked = false;

            btnDemoPoint.Enabled = true;
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

        // Переменные для хранения состояния
        private BankAccount currentAccount;
        private Point currentPointNew;
        private Point currentPointWithoutNew;
    }
}