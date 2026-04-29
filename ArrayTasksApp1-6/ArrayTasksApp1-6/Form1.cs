using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArrayTasksApp1_6
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Лабораторные работы: Массивы";
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeTask1();
            InitializeTask2();
            InitializeTask3();
            InitializeTask4();
            InitializeTask5();
            InitializeTask6();
        }

        #region Задача 1: Сумма элементов массива

        private TextBox[] task1TextBoxes;
        private Label lblTask1Result;
        private Button btnTask1Calculate;

        private void InitializeTask1()
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Задача 1: Сумма элементов массива";
            groupBox.Location = new Point(10, 10);
            groupBox.Size = new Size(760, 280);
            groupBox.Font = new Font("Segoe UI", 10F);
            groupBox.BackColor = Color.White;

            Label lblInstruction = new Label();
            lblInstruction.Text = "Введите 10 целых чисел:";
            lblInstruction.Location = new Point(15, 25);
            lblInstruction.Size = new Size(200, 25);

            task1TextBoxes = new TextBox[10];
            int startX = 15;
            int startY = 60;

            for (int i = 0; i < 10; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"Эл.{i + 1}:";
                lbl.Location = new Point(startX, startY + (i * 25));
                lbl.Size = new Size(40, 23);

                TextBox txt = new TextBox();
                txt.Location = new Point(startX + 45, startY + (i * 25));
                txt.Size = new Size(80, 27);
                txt.Name = $"txtTask1_{i}";

                task1TextBoxes[i] = txt;
                groupBox.Controls.Add(lbl);
                groupBox.Controls.Add(txt);
            }

            btnTask1Calculate = new Button();
            btnTask1Calculate.Text = "Вычислить сумму";
            btnTask1Calculate.Location = new Point(300, 60);
            btnTask1Calculate.Size = new Size(150, 40);
            btnTask1Calculate.BackColor = Color.FromArgb(52, 152, 219);
            btnTask1Calculate.ForeColor = Color.White;
            btnTask1Calculate.FlatStyle = FlatStyle.Flat;
            btnTask1Calculate.Click += BtnTask1Calculate_Click;

            lblTask1Result = new Label();
            lblTask1Result.Location = new Point(300, 120);
            lblTask1Result.Size = new Size(400, 100);
            lblTask1Result.Font = new Font("Segoe UI", 12F);
            lblTask1Result.BorderStyle = BorderStyle.FixedSingle;
            lblTask1Result.BackColor = Color.LightYellow;

            groupBox.Controls.Add(btnTask1Calculate);
            groupBox.Controls.Add(lblTask1Result);

            TabPage tabPage = new TabPage();
            tabPage.Text = "1. Сумма массива";
            tabPage.Controls.Add(groupBox);
            tabControl.TabPages.Add(tabPage);
        }

        private void BtnTask1Calculate_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[10];
            bool valid = true;

            for (int i = 0; i < 10; i++)
            {
                if (!int.TryParse(task1TextBoxes[i].Text, out numbers[i]))
                {
                    MessageBox.Show($"Введите корректное целое число для элемента {i + 1}!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;
                    break;
                }
            }

            if (valid)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }

                lblTask1Result.Text = $"Введённые числа: {string.Join(", ", numbers)}\n\n" +
                                     $"Сумма всех элементов: {sum}";
                lblTask1Result.BackColor = Color.LightGreen;
                Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (s, ev) => { lblTask1Result.BackColor = Color.LightYellow; timer.Stop(); };
                timer.Start();
            }
        }

        #endregion

        #region Задача 2: Поиск максимума и минимума

        private NumericUpDown nudTask2Size;
        private Button btnTask2Generate;
        private TextBox txtTask2Array;
        private Label lblTask2Result;
        private Button btnTask2Find;
        private int[] currentTask2Array;

        private void InitializeTask2()
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Задача 2: Поиск максимума и минимума";
            groupBox.Location = new Point(10, 10);
            groupBox.Size = new Size(760, 280);
            groupBox.Font = new Font("Segoe UI", 10F);

            Label lblSize = new Label();
            lblSize.Text = "Размер массива N:";
            lblSize.Location = new Point(15, 30);
            lblSize.Size = new Size(150, 25);

            nudTask2Size = new NumericUpDown();
            nudTask2Size.Location = new Point(170, 28);
            nudTask2Size.Size = new Size(80, 27);
            nudTask2Size.Minimum = 1;
            nudTask2Size.Maximum = 20;
            nudTask2Size.Value = 10;

            btnTask2Generate = new Button();
            btnTask2Generate.Text = "Сгенерировать массив";
            btnTask2Generate.Location = new Point(270, 25);
            btnTask2Generate.Size = new Size(150, 30);
            btnTask2Generate.Click += BtnTask2Generate_Click;

            Label lblArray = new Label();
            lblArray.Text = "Массив:";
            lblArray.Location = new Point(15, 70);
            lblArray.Size = new Size(60, 25);

            txtTask2Array = new TextBox();
            txtTask2Array.Location = new Point(80, 68);
            txtTask2Array.Size = new Size(650, 27);
            txtTask2Array.ReadOnly = true;
            txtTask2Array.BackColor = Color.WhiteSmoke;

            btnTask2Find = new Button();
            btnTask2Find.Text = "Найти максимум и минимум";
            btnTask2Find.Location = new Point(80, 110);
            btnTask2Find.Size = new Size(200, 35);
            btnTask2Find.BackColor = Color.FromArgb(46, 204, 113);
            btnTask2Find.ForeColor = Color.White;
            btnTask2Find.FlatStyle = FlatStyle.Flat;
            btnTask2Find.Click += BtnTask2Find_Click;

            lblTask2Result = new Label();
            lblTask2Result.Location = new Point(80, 160);
            lblTask2Result.Size = new Size(650, 90);
            lblTask2Result.Font = new Font("Segoe UI", 11F);
            lblTask2Result.BorderStyle = BorderStyle.FixedSingle;
            lblTask2Result.BackColor = Color.White;

            groupBox.Controls.Add(lblSize);
            groupBox.Controls.Add(nudTask2Size);
            groupBox.Controls.Add(btnTask2Generate);
            groupBox.Controls.Add(lblArray);
            groupBox.Controls.Add(txtTask2Array);
            groupBox.Controls.Add(btnTask2Find);
            groupBox.Controls.Add(lblTask2Result);

            TabPage tabPage = new TabPage();
            tabPage.Text = "2. Max и Min";
            tabPage.Controls.Add(groupBox);
            tabControl.TabPages.Add(tabPage);
        }

        private void BtnTask2Generate_Click(object sender, EventArgs e)
        {
            int size = (int)nudTask2Size.Value;
            currentTask2Array = new int[size];

            for (int i = 0; i < size; i++)
            {
                currentTask2Array[i] = random.Next(1, 101);
            }

            txtTask2Array.Text = string.Join(", ", currentTask2Array);
            lblTask2Result.Text = "Нажмите кнопку \"Найти максимум и минимум\"";
            lblTask2Result.BackColor = Color.White;
        }

        private void BtnTask2Find_Click(object sender, EventArgs e)
        {
            if (currentTask2Array == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив!", "Предупреждение",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int max = currentTask2Array[0];
            int min = currentTask2Array[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < currentTask2Array.Length; i++)
            {
                if (currentTask2Array[i] > max)
                {
                    max = currentTask2Array[i];
                    maxIndex = i;
                }
                if (currentTask2Array[i] < min)
                {
                    min = currentTask2Array[i];
                    minIndex = i;
                }
            }

            lblTask2Result.Text = $"Максимальный элемент: {max} (индекс {maxIndex})\n" +
                                 $"Минимальный элемент: {min} (индекс {minIndex})\n\n" +
                                 $"Размер массива: {currentTask2Array.Length} элементов";
            lblTask2Result.BackColor = Color.LightGreen;
        }

        #endregion

        #region Задача 3: Подсчет четных и нечетных

        private Button btnTask3Generate;
        private TextBox txtTask3Array;
        private Label lblTask3Result;
        private Button btnTask3Count;
        private int[] currentTask3Array;

        private void InitializeTask3()
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Задача 3: Подсчет четных и нечетных";
            groupBox.Location = new Point(10, 10);
            groupBox.Size = new Size(760, 280);
            groupBox.Font = new Font("Segoe UI", 10F);

            btnTask3Generate = new Button();
            btnTask3Generate.Text = "Сгенерировать массив (15 элементов)";
            btnTask3Generate.Location = new Point(20, 30);
            btnTask3Generate.Size = new Size(250, 35);
            btnTask3Generate.Click += BtnTask3Generate_Click;

            Label lblArray = new Label();
            lblArray.Text = "Сгенерированный массив:";
            lblArray.Location = new Point(20, 80);
            lblArray.Size = new Size(160, 25);

            txtTask3Array = new TextBox();
            txtTask3Array.Location = new Point(180, 78);
            txtTask3Array.Size = new Size(550, 27);
            txtTask3Array.ReadOnly = true;
            txtTask3Array.BackColor = Color.WhiteSmoke;

            btnTask3Count = new Button();
            btnTask3Count.Text = "Подсчитать четные и нечетные";
            btnTask3Count.Location = new Point(20, 120);
            btnTask3Count.Size = new Size(250, 35);
            btnTask3Count.BackColor = Color.FromArgb(155, 89, 182);
            btnTask3Count.ForeColor = Color.White;
            btnTask3Count.FlatStyle = FlatStyle.Flat;
            btnTask3Count.Click += BtnTask3Count_Click;

            lblTask3Result = new Label();
            lblTask3Result.Location = new Point(20, 170);
            lblTask3Result.Size = new Size(710, 80);
            lblTask3Result.Font = new Font("Segoe UI", 12F);
            lblTask3Result.BorderStyle = BorderStyle.FixedSingle;
            lblTask3Result.BackColor = Color.White;

            groupBox.Controls.Add(btnTask3Generate);
            groupBox.Controls.Add(lblArray);
            groupBox.Controls.Add(txtTask3Array);
            groupBox.Controls.Add(btnTask3Count);
            groupBox.Controls.Add(lblTask3Result);

            TabPage tabPage = new TabPage();
            tabPage.Text = "3. Четные и нечетные";
            tabPage.Controls.Add(groupBox);
            tabControl.TabPages.Add(tabPage);
        }

        private void BtnTask3Generate_Click(object sender, EventArgs e)
        {
            currentTask3Array = new int[15];

            for (int i = 0; i < 15; i++)
            {
                currentTask3Array[i] = random.Next(10, 51);
            }

            txtTask3Array.Text = string.Join(", ", currentTask3Array);
            lblTask3Result.Text = "Нажмите кнопку \"Подсчитать четные и нечетные\"";
            lblTask3Result.BackColor = Color.White;
        }

        private void BtnTask3Count_Click(object sender, EventArgs e)
        {
            if (currentTask3Array == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив!", "Предупреждение",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in currentTask3Array)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            lblTask3Result.Text = $"Массив из {currentTask3Array.Length} элементов (диапазон: 10-50)\n\n" +
                                 $"✓ Четных чисел: {evenCount}\n" +
                                 $"✗ Нечетных чисел: {oddCount}\n\n" +
                                 $"Процентное соотношение: {(double)evenCount / currentTask3Array.Length * 100:F1}% / " +
                                 $"{(double)oddCount / currentTask3Array.Length * 100:F1}%";
            lblTask3Result.BackColor = Color.LightGreen;
        }

        #endregion

        #region Задача 4: Реверс массива

        private TextBox[] task4TextBoxes;
        private Button btnTask4Reverse;
        private Label lblTask4Original;
        private Label lblTask4Reversed;

        private void InitializeTask4()
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Задача 4: Реверс массива";
            groupBox.Location = new Point(10, 10);
            groupBox.Size = new Size(760, 300);
            groupBox.Font = new Font("Segoe UI", 10F);

            Label lblInstruction = new Label();
            lblInstruction.Text = "Введите 5 чисел:";
            lblInstruction.Location = new Point(15, 25);
            lblInstruction.Size = new Size(150, 25);

            task4TextBoxes = new TextBox[5];
            for (int i = 0; i < 5; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"Число {i + 1}:";
                lbl.Location = new Point(15, 60 + (i * 35));
                lbl.Size = new Size(70, 23);

                TextBox txt = new TextBox();
                txt.Location = new Point(90, 58 + (i * 35));
                txt.Size = new Size(100, 27);
                txt.Name = $"txtTask4_{i}";

                task4TextBoxes[i] = txt;
                groupBox.Controls.Add(lbl);
                groupBox.Controls.Add(txt);
            }

            btnTask4Reverse = new Button();
            btnTask4Reverse.Text = "Выполнить реверс";
            btnTask4Reverse.Location = new Point(220, 60);
            btnTask4Reverse.Size = new Size(180, 40);
            btnTask4Reverse.BackColor = Color.FromArgb(241, 196, 15);
            btnTask4Reverse.ForeColor = Color.White;
            btnTask4Reverse.FlatStyle = FlatStyle.Flat;
            btnTask4Reverse.Click += BtnTask4Reverse_Click;

            lblTask4Original = new Label();
            lblTask4Original.Location = new Point(220, 120);
            lblTask4Original.Size = new Size(500, 40);
            lblTask4Original.Font = new Font("Segoe UI", 10F);
            lblTask4Original.BorderStyle = BorderStyle.FixedSingle;
            lblTask4Original.BackColor = Color.White;

            lblTask4Reversed = new Label();
            lblTask4Reversed.Location = new Point(220, 180);
            lblTask4Reversed.Size = new Size(500, 40);
            lblTask4Reversed.Font = new Font("Segoe UI", 10F);
            lblTask4Reversed.BorderStyle = BorderStyle.FixedSingle;
            lblTask4Reversed.BackColor = Color.White;

            groupBox.Controls.Add(btnTask4Reverse);
            groupBox.Controls.Add(lblTask4Original);
            groupBox.Controls.Add(lblTask4Reversed);

            TabPage tabPage = new TabPage();
            tabPage.Text = "4. Реверс массива";
            tabPage.Controls.Add(groupBox);
            tabControl.TabPages.Add(tabPage);
        }

        private void BtnTask4Reverse_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            bool valid = true;

            for (int i = 0; i < 5; i++)
            {
                if (!int.TryParse(task4TextBoxes[i].Text, out numbers[i]))
                {
                    MessageBox.Show($"Введите корректное целое число для позиции {i + 1}!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;
                    break;
                }
            }

            if (valid)
            {
                lblTask4Original.Text = $"Исходный массив: [{string.Join(", ", numbers)}]";

                // Реверс без создания нового массива
                for (int i = 0; i < numbers.Length / 2; i++)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[numbers.Length - 1 - i];
                    numbers[numbers.Length - 1 - i] = temp;
                }

                lblTask4Reversed.Text = $"Реверсированный массив: [{string.Join(", ", numbers)}]";
                lblTask4Original.BackColor = Color.LightYellow;
                lblTask4Reversed.BackColor = Color.LightGreen;
            }
        }

        #endregion

        #region Задача 5: Сдвиг элементов

        private TextBox[] task5TextBoxes;
        private Button btnTask5Shift;
        private Label lblTask5Original;
        private Label lblTask5Shifted;

        private void InitializeTask5()
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Задача 5: Циклический сдвиг вправо";
            groupBox.Location = new Point(10, 10);
            groupBox.Size = new Size(760, 300);
            groupBox.Font = new Font("Segoe UI", 10F);

            Label lblInstruction = new Label();
            lblInstruction.Text = "Введите 5 чисел для сдвига:";
            lblInstruction.Location = new Point(15, 25);
            lblInstruction.Size = new Size(200, 25);

            task5TextBoxes = new TextBox[5];
            for (int i = 0; i < 5; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"Эл.{i + 1}:";
                lbl.Location = new Point(15, 60 + (i * 35));
                lbl.Size = new Size(50, 23);

                TextBox txt = new TextBox();
                txt.Location = new Point(70, 58 + (i * 35));
                txt.Size = new Size(100, 27);
                txt.Name = $"txtTask5_{i}";

                task5TextBoxes[i] = txt;
                groupBox.Controls.Add(lbl);
                groupBox.Controls.Add(txt);
            }

            btnTask5Shift = new Button();
            btnTask5Shift.Text = "Выполнить сдвиг вправо";
            btnTask5Shift.Location = new Point(200, 60);
            btnTask5Shift.Size = new Size(200, 40);
            btnTask5Shift.BackColor = Color.FromArgb(230, 126, 34);
            btnTask5Shift.ForeColor = Color.White;
            btnTask5Shift.FlatStyle = FlatStyle.Flat;
            btnTask5Shift.Click += BtnTask5Shift_Click;

            lblTask5Original = new Label();
            lblTask5Original.Location = new Point(200, 120);
            lblTask5Original.Size = new Size(520, 40);
            lblTask5Original.Font = new Font("Segoe UI", 10F);
            lblTask5Original.BorderStyle = BorderStyle.FixedSingle;
            lblTask5Original.BackColor = Color.White;

            lblTask5Shifted = new Label();
            lblTask5Shifted.Location = new Point(200, 180);
            lblTask5Shifted.Size = new Size(520, 40);
            lblTask5Shifted.Font = new Font("Segoe UI", 10F);
            lblTask5Shifted.BorderStyle = BorderStyle.FixedSingle;
            lblTask5Shifted.BackColor = Color.White;

            groupBox.Controls.Add(btnTask5Shift);
            groupBox.Controls.Add(lblTask5Original);
            groupBox.Controls.Add(lblTask5Shifted);

            TabPage tabPage = new TabPage();
            tabPage.Text = "5. Сдвиг элементов";
            tabPage.Controls.Add(groupBox);
            tabControl.TabPages.Add(tabPage);
        }

        private void BtnTask5Shift_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            bool valid = true;

            for (int i = 0; i < 5; i++)
            {
                if (!int.TryParse(task5TextBoxes[i].Text, out numbers[i]))
                {
                    MessageBox.Show($"Введите корректное целое число для элемента {i + 1}!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;
                    break;
                }
            }

            if (valid)
            {
                lblTask5Original.Text = $"Исходный массив: [{string.Join(", ", numbers)}]";

                // Циклический сдвиг вправо
                int lastElement = numbers[numbers.Length - 1];
                for (int i = numbers.Length - 1; i > 0; i--)
                {
                    numbers[i] = numbers[i - 1];
                }
                numbers[0] = lastElement;

                lblTask5Shifted.Text = $"После сдвига вправо: [{string.Join(", ", numbers)}]";
                lblTask5Original.BackColor = Color.LightYellow;
                lblTask5Shifted.BackColor = Color.LightGreen;
            }
        }

        #endregion

        #region Задача 6: Подсчет дубликатов

        private TextBox[] task6TextBoxes;
        private Button btnTask6Count;
        private RichTextBox rtbTask6Result;

        private void InitializeTask6()
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Задача 6: Подсчет дубликатов";
            groupBox.Location = new Point(10, 10);
            groupBox.Size = new Size(760, 330);
            groupBox.Font = new Font("Segoe UI", 10F);

            Label lblInstruction = new Label();
            lblInstruction.Text = "Введите 10 чисел:";
            lblInstruction.Location = new Point(15, 25);
            lblInstruction.Size = new Size(150, 25);

            task6TextBoxes = new TextBox[10];
            for (int i = 0; i < 10; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"{i + 1}:";
                lbl.Location = new Point(15 + (i * 70), 60);
                lbl.Size = new Size(25, 23);

                TextBox txt = new TextBox();
                txt.Location = new Point(15 + (i * 70), 85);
                txt.Size = new Size(60, 27);
                txt.Name = $"txtTask6_{i}";

                task6TextBoxes[i] = txt;
                groupBox.Controls.Add(lbl);
                groupBox.Controls.Add(txt);
            }

            btnTask6Count = new Button();
            btnTask6Count.Text = "Подсчитать вхождения";
            btnTask6Count.Location = new Point(300, 60);
            btnTask6Count.Size = new Size(200, 45);
            btnTask6Count.BackColor = Color.FromArgb(231, 76, 60);
            btnTask6Count.ForeColor = Color.White;
            btnTask6Count.FlatStyle = FlatStyle.Flat;
            btnTask6Count.Click += BtnTask6Count_Click;

            rtbTask6Result = new RichTextBox();
            rtbTask6Result.Location = new Point(15, 130);
            rtbTask6Result.Size = new Size(720, 180);
            rtbTask6Result.Font = new Font("Consolas", 11F);
            rtbTask6Result.BackColor = Color.WhiteSmoke;

            groupBox.Controls.Add(btnTask6Count);
            groupBox.Controls.Add(rtbTask6Result);

            TabPage tabPage = new TabPage();
            tabPage.Text = "6. Подсчет дубликатов";
            tabPage.Controls.Add(groupBox);
            tabControl.TabPages.Add(tabPage);
        }

        private void BtnTask6Count_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[10];
            bool valid = true;

            for (int i = 0; i < 10; i++)
            {
                if (!int.TryParse(task6TextBoxes[i].Text, out numbers[i]))
                {
                    MessageBox.Show($"Введите корректное целое число для позиции {i + 1}!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;
                    break;
                }
            }

            if (valid)
            {
                rtbTask6Result.Clear();
                rtbTask6Result.AppendText("=== РЕЗУЛЬТАТ ПОДСЧЕТА ===\n");
                rtbTask6Result.AppendText($"Массив: [{string.Join(", ", numbers)}]\n\n");
                rtbTask6Result.AppendText("Частота вхождения чисел:\n");
                rtbTask6Result.AppendText("────────────────────────────────────────\n");

                // Подсчет с помощью вложенных циклов
                bool[] counted = new bool[10];

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (!counted[i])
                    {
                        int count = 1;
                        for (int j = i + 1; j < numbers.Length; j++)
                        {
                            if (numbers[i] == numbers[j])
                            {
                                count++;
                                counted[j] = true;
                            }
                        }
                        rtbTask6Result.AppendText($"Число {numbers[i],4} встречается {count,2} раз(а)\n");
                    }
                }

                rtbTask6Result.AppendText("────────────────────────────────────────\n");
                rtbTask6Result.AppendText($"Всего элементов: {numbers.Length}\n");

                // Подсчет уникальных
                int uniqueCount = 0;
                bool[] uniqueChecked = new bool[10];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (!uniqueChecked[i])
                    {
                        uniqueCount++;
                        for (int j = i + 1; j < numbers.Length; j++)
                        {
                            if (numbers[i] == numbers[j])
                            {
                                uniqueChecked[j] = true;
                            }
                        }
                        uniqueChecked[i] = true;
                    }
                }
                rtbTask6Result.AppendText($"Уникальных чисел: {uniqueCount}");
            }
        }

        #endregion

        // Главный элемент управления
        private TabControl tabControl;
    }
}