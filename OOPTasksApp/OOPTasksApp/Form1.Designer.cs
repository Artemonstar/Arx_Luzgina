namespace OOPTasksApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBook = new System.Windows.Forms.TabPage();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.tabCar = new System.Windows.Forms.TabPage();
            this.tabTriangle = new System.Windows.Forms.TabPage();
            this.tabPoint = new System.Windows.Forms.TabPage();

            // === Вкладка 1: Книга ===
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnCreateWarAndPeace = new System.Windows.Forms.Button();
            this.btnCreate1984 = new System.Windows.Forms.Button();
            this.btnCreateUnknownBook = new System.Windows.Forms.Button();
            this.btnClearBooks = new System.Windows.Forms.Button();
            this.lblBookResult = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lblBookInstruction = new System.Windows.Forms.Label();

            // === Вкладка 2: Студент ===
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.btnCreateStudentDefault = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnCreateStudentOneParam = new System.Windows.Forms.Button();
            this.lblStudentName2 = new System.Windows.Forms.Label();
            this.txtStudentName2 = new System.Windows.Forms.TextBox();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.btnCreateStudentTwoParams = new System.Windows.Forms.Button();
            this.btnClearStudents = new System.Windows.Forms.Button();
            this.lblStudentResult = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();

            // === Вкладка 3: Автомобиль ===
            this.grpCar = new System.Windows.Forms.GroupBox();
            this.btnCreateToyota = new System.Windows.Forms.Button();
            this.btnCreateBMW = new System.Windows.Forms.Button();
            this.btnCreateLada = new System.Windows.Forms.Button();
            this.btnClearCars = new System.Windows.Forms.Button();
            this.lblCarResult = new System.Windows.Forms.Label();
            this.lstCars = new System.Windows.Forms.ListBox();

            // === Вкладка 4: Треугольник ===
            this.grpTriangle = new System.Windows.Forms.GroupBox();
            this.btnCreateValidTriangle = new System.Windows.Forms.Button();
            this.btnCreateInvalidTriangle = new System.Windows.Forms.Button();
            this.lblSideA = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.lblSideB = new System.Windows.Forms.Label();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.lblSideC = new System.Windows.Forms.Label();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.btnCustomTriangle = new System.Windows.Forms.Button();
            this.btnClearTriangles = new System.Windows.Forms.Button();
            this.lblTriangleResult = new System.Windows.Forms.Label();
            this.lstTriangles = new System.Windows.Forms.ListBox();

            // === Вкладка 5: Точка ===
            this.grpPoint = new System.Windows.Forms.GroupBox();
            this.btnCreatePoint1 = new System.Windows.Forms.Button();
            this.btnCreatePoint2 = new System.Windows.Forms.Button();
            this.lblPointX = new System.Windows.Forms.Label();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.lblPointY = new System.Windows.Forms.Label();
            this.txtPointY = new System.Windows.Forms.TextBox();
            this.btnCustomPoint = new System.Windows.Forms.Button();
            this.btnClearPoints = new System.Windows.Forms.Button();
            this.lblPointResult = new System.Windows.Forms.Label();
            this.lstPoints = new System.Windows.Forms.ListBox();

            this.tabControl.SuspendLayout();
            this.tabBook.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.tabCar.SuspendLayout();
            this.tabTriangle.SuspendLayout();
            this.tabPoint.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.grpCar.SuspendLayout();
            this.grpTriangle.SuspendLayout();
            this.grpPoint.SuspendLayout();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.tabBook);
            this.tabControl.Controls.Add(this.tabStudent);
            this.tabControl.Controls.Add(this.tabCar);
            this.tabControl.Controls.Add(this.tabTriangle);
            this.tabControl.Controls.Add(this.tabPoint);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 580);
            this.tabControl.TabIndex = 0;

            // ========== Вкладка 1: Книга ==========
            this.tabBook.Text = "📚 Книга";
            this.tabBook.BackColor = System.Drawing.Color.White;

            this.grpBook.Text = "Задача 1: Класс \"Книга\"";
            this.grpBook.Location = new System.Drawing.Point(10, 10);
            this.grpBook.Size = new System.Drawing.Size(765, 530);
            this.grpBook.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblBookInstruction.Text = "Создайте книги, нажимая на кнопки:";
            this.lblBookInstruction.Location = new System.Drawing.Point(15, 25);
            this.lblBookInstruction.Size = new System.Drawing.Size(300, 25);

            this.btnCreateWarAndPeace.Text = "📖 Война и мир (1200 стр)";
            this.btnCreateWarAndPeace.Location = new System.Drawing.Point(15, 60);
            this.btnCreateWarAndPeace.Size = new System.Drawing.Size(200, 40);
            this.btnCreateWarAndPeace.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCreateWarAndPeace.ForeColor = System.Drawing.Color.White;
            this.btnCreateWarAndPeace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateWarAndPeace.Click += new System.EventHandler(this.btnCreateWarAndPeace_Click);

            this.btnCreate1984.Text = "📕 1984 (300 стр)";
            this.btnCreate1984.Location = new System.Drawing.Point(230, 60);
            this.btnCreate1984.Size = new System.Drawing.Size(200, 40);
            this.btnCreate1984.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCreate1984.ForeColor = System.Drawing.Color.White;
            this.btnCreate1984.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate1984.Click += new System.EventHandler(this.btnCreate1984_Click);

            this.btnCreateUnknownBook.Text = "📙 Книга без названия (500 стр)";
            this.btnCreateUnknownBook.Location = new System.Drawing.Point(445, 60);
            this.btnCreateUnknownBook.Size = new System.Drawing.Size(220, 40);
            this.btnCreateUnknownBook.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnCreateUnknownBook.ForeColor = System.Drawing.Color.White;
            this.btnCreateUnknownBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUnknownBook.Click += new System.EventHandler(this.btnCreateUnknownBook_Click);

            this.btnClearBooks.Text = "🗑 Очистить";
            this.btnClearBooks.Location = new System.Drawing.Point(680, 60);
            this.btnClearBooks.Size = new System.Drawing.Size(70, 40);
            this.btnClearBooks.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearBooks.ForeColor = System.Drawing.Color.White;
            this.btnClearBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBooks.Click += new System.EventHandler(this.btnClearBooks_Click);

            this.lblBookResult.Text = "Информация о книге появится здесь...";
            this.lblBookResult.Location = new System.Drawing.Point(15, 115);
            this.lblBookResult.Size = new System.Drawing.Size(735, 50);
            this.lblBookResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBookResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBookResult.BackColor = System.Drawing.Color.White;

            this.lstBooks.Location = new System.Drawing.Point(15, 180);
            this.lstBooks.Size = new System.Drawing.Size(735, 320);
            this.lstBooks.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstBooks.BackColor = System.Drawing.Color.LightYellow;

            this.grpBook.Controls.Add(this.lblBookInstruction);
            this.grpBook.Controls.Add(this.btnCreateWarAndPeace);
            this.grpBook.Controls.Add(this.btnCreate1984);
            this.grpBook.Controls.Add(this.btnCreateUnknownBook);
            this.grpBook.Controls.Add(this.btnClearBooks);
            this.grpBook.Controls.Add(this.lblBookResult);
            this.grpBook.Controls.Add(this.lstBooks);
            this.tabBook.Controls.Add(this.grpBook);

            // ========== Вкладка 2: Студент ==========
            this.tabStudent.Text = "👨‍🎓 Студент";
            this.tabStudent.BackColor = System.Drawing.Color.White;

            this.grpStudent.Text = "Задача 2: Конструкторы класса \"Студент\"";
            this.grpStudent.Location = new System.Drawing.Point(10, 10);
            this.grpStudent.Size = new System.Drawing.Size(765, 530);
            this.grpStudent.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.btnCreateStudentDefault.Text = "👤 Конструктор без параметров (Иван, 18)";
            this.btnCreateStudentDefault.Location = new System.Drawing.Point(15, 30);
            this.btnCreateStudentDefault.Size = new System.Drawing.Size(280, 40);
            this.btnCreateStudentDefault.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCreateStudentDefault.ForeColor = System.Drawing.Color.White;
            this.btnCreateStudentDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStudentDefault.Click += new System.EventHandler(this.btnCreateStudentDefault_Click);

            this.lblStudentName.Text = "Имя:";
            this.lblStudentName.Location = new System.Drawing.Point(15, 85);
            this.lblStudentName.Size = new System.Drawing.Size(50, 25);
            this.txtStudentName.Location = new System.Drawing.Point(70, 82);
            this.txtStudentName.Size = new System.Drawing.Size(150, 27);
            this.btnCreateStudentOneParam.Text = "👉 Конструктор с 1 параметром";
            this.btnCreateStudentOneParam.Location = new System.Drawing.Point(230, 80);
            this.btnCreateStudentOneParam.Size = new System.Drawing.Size(220, 30);
            this.btnCreateStudentOneParam.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCreateStudentOneParam.ForeColor = System.Drawing.Color.White;
            this.btnCreateStudentOneParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStudentOneParam.Click += new System.EventHandler(this.btnCreateStudentOneParam_Click);

            this.lblStudentName2.Text = "Имя:";
            this.lblStudentName2.Location = new System.Drawing.Point(15, 130);
            this.lblStudentName2.Size = new System.Drawing.Size(50, 25);
            this.txtStudentName2.Location = new System.Drawing.Point(70, 127);
            this.txtStudentName2.Size = new System.Drawing.Size(120, 27);
            this.lblStudentAge.Text = "Возраст:";
            this.lblStudentAge.Location = new System.Drawing.Point(200, 130);
            this.lblStudentAge.Size = new System.Drawing.Size(70, 25);
            this.txtStudentAge.Location = new System.Drawing.Point(275, 127);
            this.txtStudentAge.Size = new System.Drawing.Size(80, 27);
            this.btnCreateStudentTwoParams.Text = "👉 Конструктор с 2 параметрами";
            this.btnCreateStudentTwoParams.Location = new System.Drawing.Point(370, 125);
            this.btnCreateStudentTwoParams.Size = new System.Drawing.Size(220, 30);
            this.btnCreateStudentTwoParams.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnCreateStudentTwoParams.ForeColor = System.Drawing.Color.White;
            this.btnCreateStudentTwoParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStudentTwoParams.Click += new System.EventHandler(this.btnCreateStudentTwoParams_Click);

            this.btnClearStudents.Text = "🗑 Очистить";
            this.btnClearStudents.Location = new System.Drawing.Point(680, 30);
            this.btnClearStudents.Size = new System.Drawing.Size(70, 40);
            this.btnClearStudents.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearStudents.ForeColor = System.Drawing.Color.White;
            this.btnClearStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStudents.Click += new System.EventHandler(this.btnClearStudents_Click);

            this.lblStudentResult.Text = "Информация о студенте появится здесь...";
            this.lblStudentResult.Location = new System.Drawing.Point(15, 175);
            this.lblStudentResult.Size = new System.Drawing.Size(735, 50);
            this.lblStudentResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStudentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudentResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentResult.BackColor = System.Drawing.Color.White;

            this.lstStudents.Location = new System.Drawing.Point(15, 240);
            this.lstStudents.Size = new System.Drawing.Size(735, 260);
            this.lstStudents.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstStudents.BackColor = System.Drawing.Color.LightCyan;

            this.grpStudent.Controls.Add(this.btnCreateStudentDefault);
            this.grpStudent.Controls.Add(this.lblStudentName);
            this.grpStudent.Controls.Add(this.txtStudentName);
            this.grpStudent.Controls.Add(this.btnCreateStudentOneParam);
            this.grpStudent.Controls.Add(this.lblStudentName2);
            this.grpStudent.Controls.Add(this.txtStudentName2);
            this.grpStudent.Controls.Add(this.lblStudentAge);
            this.grpStudent.Controls.Add(this.txtStudentAge);
            this.grpStudent.Controls.Add(this.btnCreateStudentTwoParams);
            this.grpStudent.Controls.Add(this.btnClearStudents);
            this.grpStudent.Controls.Add(this.lblStudentResult);
            this.grpStudent.Controls.Add(this.lstStudents);
            this.tabStudent.Controls.Add(this.grpStudent);

            // ========== Вкладка 3: Автомобиль ==========
            this.tabCar.Text = "🚗 Автомобиль";
            this.tabCar.BackColor = System.Drawing.Color.White;

            this.grpCar.Text = "Задача 3: Инициализаторы объектов \"Автомобиль\"";
            this.grpCar.Location = new System.Drawing.Point(10, 10);
            this.grpCar.Size = new System.Drawing.Size(765, 530);
            this.grpCar.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.btnCreateToyota.Text = "🚙 Toyota Camry (2020)";
            this.btnCreateToyota.Location = new System.Drawing.Point(15, 30);
            this.btnCreateToyota.Size = new System.Drawing.Size(200, 50);
            this.btnCreateToyota.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCreateToyota.ForeColor = System.Drawing.Color.White;
            this.btnCreateToyota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateToyota.Click += new System.EventHandler(this.btnCreateToyota_Click);

            this.btnCreateBMW.Text = "🚙 BMW X5 (2022)";
            this.btnCreateBMW.Location = new System.Drawing.Point(230, 30);
            this.btnCreateBMW.Size = new System.Drawing.Size(200, 50);
            this.btnCreateBMW.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCreateBMW.ForeColor = System.Drawing.Color.White;
            this.btnCreateBMW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBMW.Click += new System.EventHandler(this.btnCreateBMW_Click);

            this.btnCreateLada.Text = "🚙 Lada Vesta (год по умолчанию)";
            this.btnCreateLada.Location = new System.Drawing.Point(445, 30);
            this.btnCreateLada.Size = new System.Drawing.Size(220, 50);
            this.btnCreateLada.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnCreateLada.ForeColor = System.Drawing.Color.White;
            this.btnCreateLada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateLada.Click += new System.EventHandler(this.btnCreateLada_Click);

            this.btnClearCars.Text = "🗑 Очистить";
            this.btnClearCars.Location = new System.Drawing.Point(680, 30);
            this.btnClearCars.Size = new System.Drawing.Size(70, 50);
            this.btnClearCars.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearCars.ForeColor = System.Drawing.Color.White;
            this.btnClearCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCars.Click += new System.EventHandler(this.btnClearCars_Click);

            this.lblCarResult.Text = "Информация об автомобиле появится здесь...";
            this.lblCarResult.Location = new System.Drawing.Point(15, 95);
            this.lblCarResult.Size = new System.Drawing.Size(735, 50);
            this.lblCarResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCarResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarResult.BackColor = System.Drawing.Color.White;

            this.lstCars.Location = new System.Drawing.Point(15, 160);
            this.lstCars.Size = new System.Drawing.Size(735, 340);
            this.lstCars.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstCars.BackColor = System.Drawing.Color.LightYellow;

            this.grpCar.Controls.Add(this.btnCreateToyota);
            this.grpCar.Controls.Add(this.btnCreateBMW);
            this.grpCar.Controls.Add(this.btnCreateLada);
            this.grpCar.Controls.Add(this.btnClearCars);
            this.grpCar.Controls.Add(this.lblCarResult);
            this.grpCar.Controls.Add(this.lstCars);
            this.tabCar.Controls.Add(this.grpCar);

            // ========== Вкладка 4: Треугольник ==========
            this.tabTriangle.Text = "🔺 Треугольник";
            this.tabTriangle.BackColor = System.Drawing.Color.White;

            this.grpTriangle.Text = "Задача 4: Класс \"Треугольник\" с проверкой (this)";
            this.grpTriangle.Location = new System.Drawing.Point(10, 10);
            this.grpTriangle.Size = new System.Drawing.Size(765, 530);
            this.grpTriangle.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.btnCreateValidTriangle.Text = "✅ Валидный: 3, 4, 5";
            this.btnCreateValidTriangle.Location = new System.Drawing.Point(15, 30);
            this.btnCreateValidTriangle.Size = new System.Drawing.Size(180, 40);
            this.btnCreateValidTriangle.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCreateValidTriangle.ForeColor = System.Drawing.Color.White;
            this.btnCreateValidTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateValidTriangle.Click += new System.EventHandler(this.btnCreateValidTriangle_Click);

            this.btnCreateInvalidTriangle.Text = "❌ Невалидный: 1, 2, 4";
            this.btnCreateInvalidTriangle.Location = new System.Drawing.Point(210, 30);
            this.btnCreateInvalidTriangle.Size = new System.Drawing.Size(180, 40);
            this.btnCreateInvalidTriangle.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCreateInvalidTriangle.ForeColor = System.Drawing.Color.White;
            this.btnCreateInvalidTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateInvalidTriangle.Click += new System.EventHandler(this.btnCreateInvalidTriangle_Click);

            this.lblSideA.Text = "a:";
            this.lblSideA.Location = new System.Drawing.Point(15, 85);
            this.lblSideA.Size = new System.Drawing.Size(30, 25);
            this.txtSideA.Location = new System.Drawing.Point(45, 82);
            this.txtSideA.Size = new System.Drawing.Size(60, 27);
            this.lblSideB.Text = "b:";
            this.lblSideB.Location = new System.Drawing.Point(115, 85);
            this.lblSideB.Size = new System.Drawing.Size(30, 25);
            this.txtSideB.Location = new System.Drawing.Point(145, 82);
            this.txtSideB.Size = new System.Drawing.Size(60, 27);
            this.lblSideC.Text = "c:";
            this.lblSideC.Location = new System.Drawing.Point(215, 85);
            this.lblSideC.Size = new System.Drawing.Size(30, 25);
            this.txtSideC.Location = new System.Drawing.Point(245, 82);
            this.txtSideC.Size = new System.Drawing.Size(60, 27);
            this.btnCustomTriangle.Text = "🔍 Проверить свои стороны";
            this.btnCustomTriangle.Location = new System.Drawing.Point(320, 80);
            this.btnCustomTriangle.Size = new System.Drawing.Size(200, 30);
            this.btnCustomTriangle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCustomTriangle.ForeColor = System.Drawing.Color.White;
            this.btnCustomTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomTriangle.Click += new System.EventHandler(this.btnCustomTriangle_Click);

            this.btnClearTriangles.Text = "🗑 Очистить";
            this.btnClearTriangles.Location = new System.Drawing.Point(680, 30);
            this.btnClearTriangles.Size = new System.Drawing.Size(70, 40);
            this.btnClearTriangles.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearTriangles.ForeColor = System.Drawing.Color.White;
            this.btnClearTriangles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTriangles.Click += new System.EventHandler(this.btnClearTriangles_Click);

            this.lblTriangleResult.Text = "Информация о треугольнике появится здесь...";
            this.lblTriangleResult.Location = new System.Drawing.Point(15, 130);
            this.lblTriangleResult.Size = new System.Drawing.Size(735, 50);
            this.lblTriangleResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTriangleResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTriangleResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTriangleResult.BackColor = System.Drawing.Color.White;

            this.lstTriangles.Location = new System.Drawing.Point(15, 195);
            this.lstTriangles.Size = new System.Drawing.Size(735, 305);
            this.lstTriangles.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstTriangles.BackColor = System.Drawing.Color.LightYellow;

            this.grpTriangle.Controls.Add(this.btnCreateValidTriangle);
            this.grpTriangle.Controls.Add(this.btnCreateInvalidTriangle);
            this.grpTriangle.Controls.Add(this.lblSideA);
            this.grpTriangle.Controls.Add(this.txtSideA);
            this.grpTriangle.Controls.Add(this.lblSideB);
            this.grpTriangle.Controls.Add(this.txtSideB);
            this.grpTriangle.Controls.Add(this.lblSideC);
            this.grpTriangle.Controls.Add(this.txtSideC);
            this.grpTriangle.Controls.Add(this.btnCustomTriangle);
            this.grpTriangle.Controls.Add(this.btnClearTriangles);
            this.grpTriangle.Controls.Add(this.lblTriangleResult);
            this.grpTriangle.Controls.Add(this.lstTriangles);
            this.tabTriangle.Controls.Add(this.grpTriangle);

            // ========== Вкладка 5: Точка (Деконструкция) ==========
            this.tabPoint.Text = "📍 Точка";
            this.tabPoint.BackColor = System.Drawing.Color.White;

            this.grpPoint.Text = "Задача 5: Деконструкция объекта \"Точка\"";
            this.grpPoint.Location = new System.Drawing.Point(10, 10);
            this.grpPoint.Size = new System.Drawing.Size(765, 530);
            this.grpPoint.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.btnCreatePoint1.Text = "📍 Точка (10, 20) - полная деконструкция";
            this.btnCreatePoint1.Location = new System.Drawing.Point(15, 30);
            this.btnCreatePoint1.Size = new System.Drawing.Size(280, 40);
            this.btnCreatePoint1.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCreatePoint1.ForeColor = System.Drawing.Color.White;
            this.btnCreatePoint1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePoint1.Click += new System.EventHandler(this.btnCreatePoint1_Click);

            this.btnCreatePoint2.Text = "📍 Точка (5, 7) - только Y (игнорируем X)";
            this.btnCreatePoint2.Location = new System.Drawing.Point(310, 30);
            this.btnCreatePoint2.Size = new System.Drawing.Size(280, 40);
            this.btnCreatePoint2.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCreatePoint2.ForeColor = System.Drawing.Color.White;
            this.btnCreatePoint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePoint2.Click += new System.EventHandler(this.btnCreatePoint2_Click);

            this.btnClearPoints.Text = "🗑 Очистить";
            this.btnClearPoints.Location = new System.Drawing.Point(680, 30);
            this.btnClearPoints.Size = new System.Drawing.Size(70, 40);
            this.btnClearPoints.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearPoints.ForeColor = System.Drawing.Color.White;
            this.btnClearPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPoints.Click += new System.EventHandler(this.btnClearPoints_Click);

            this.lblPointX.Text = "X:";
            this.lblPointX.Location = new System.Drawing.Point(15, 90);
            this.lblPointX.Size = new System.Drawing.Size(30, 25);
            this.txtPointX.Location = new System.Drawing.Point(45, 87);
            this.txtPointX.Size = new System.Drawing.Size(80, 27);
            this.lblPointY.Text = "Y:";
            this.lblPointY.Location = new System.Drawing.Point(135, 90);
            this.lblPointY.Size = new System.Drawing.Size(30, 25);
            this.txtPointY.Location = new System.Drawing.Point(165, 87);
            this.txtPointY.Size = new System.Drawing.Size(80, 27);
            this.btnCustomPoint.Text = "📍 Создать свою точку";
            this.btnCustomPoint.Location = new System.Drawing.Point(260, 85);
            this.btnCustomPoint.Size = new System.Drawing.Size(180, 30);
            this.btnCustomPoint.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnCustomPoint.ForeColor = System.Drawing.Color.White;
            this.btnCustomPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomPoint.Click += new System.EventHandler(this.btnCustomPoint_Click);

            this.lblPointResult.Text = "Информация о точке появится здесь...";
            this.lblPointResult.Location = new System.Drawing.Point(15, 130);
            this.lblPointResult.Size = new System.Drawing.Size(735, 60);
            this.lblPointResult.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPointResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPointResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPointResult.BackColor = System.Drawing.Color.White;

            this.lstPoints.Location = new System.Drawing.Point(15, 205);
            this.lstPoints.Size = new System.Drawing.Size(735, 295);
            this.lstPoints.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstPoints.BackColor = System.Drawing.Color.LightCyan;

            this.grpPoint.Controls.Add(this.btnCreatePoint1);
            this.grpPoint.Controls.Add(this.btnCreatePoint2);
            this.grpPoint.Controls.Add(this.btnClearPoints);
            this.grpPoint.Controls.Add(this.lblPointX);
            this.grpPoint.Controls.Add(this.txtPointX);
            this.grpPoint.Controls.Add(this.lblPointY);
            this.grpPoint.Controls.Add(this.txtPointY);
            this.grpPoint.Controls.Add(this.btnCustomPoint);
            this.grpPoint.Controls.Add(this.lblPointResult);
            this.grpPoint.Controls.Add(this.lstPoints);
            this.tabPoint.Controls.Add(this.grpPoint);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "ООП Задачи: Книга, Студент, Автомобиль, Треугольник, Точка";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabControl.ResumeLayout(false);
            this.tabBook.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabCar.ResumeLayout(false);
            this.tabTriangle.ResumeLayout(false);
            this.tabPoint.ResumeLayout(false);
            this.grpBook.ResumeLayout(false);
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpCar.ResumeLayout(false);
            this.grpTriangle.ResumeLayout(false);
            this.grpTriangle.PerformLayout();
            this.grpPoint.ResumeLayout(false);
            this.grpPoint.PerformLayout();
            this.ResumeLayout(false);
        }

        // Элементы управления - Вкладка 1
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBook;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabCar;
        private System.Windows.Forms.TabPage tabTriangle;
        private System.Windows.Forms.TabPage tabPoint;

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Button btnCreateWarAndPeace;
        private System.Windows.Forms.Button btnCreate1984;
        private System.Windows.Forms.Button btnCreateUnknownBook;
        private System.Windows.Forms.Button btnClearBooks;
        private System.Windows.Forms.Label lblBookResult;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Label lblBookInstruction;

        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.Button btnCreateStudentDefault;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnCreateStudentOneParam;
        private System.Windows.Forms.Label lblStudentName2;
        private System.Windows.Forms.TextBox txtStudentName2;
        private System.Windows.Forms.Label lblStudentAge;
        private System.Windows.Forms.TextBox txtStudentAge;
        private System.Windows.Forms.Button btnCreateStudentTwoParams;
        private System.Windows.Forms.Button btnClearStudents;
        private System.Windows.Forms.Label lblStudentResult;
        private System.Windows.Forms.ListBox lstStudents;

        private System.Windows.Forms.GroupBox grpCar;
        private System.Windows.Forms.Button btnCreateToyota;
        private System.Windows.Forms.Button btnCreateBMW;
        private System.Windows.Forms.Button btnCreateLada;
        private System.Windows.Forms.Button btnClearCars;
        private System.Windows.Forms.Label lblCarResult;
        private System.Windows.Forms.ListBox lstCars;

        private System.Windows.Forms.GroupBox grpTriangle;
        private System.Windows.Forms.Button btnCreateValidTriangle;
        private System.Windows.Forms.Button btnCreateInvalidTriangle;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Button btnCustomTriangle;
        private System.Windows.Forms.Button btnClearTriangles;
        private System.Windows.Forms.Label lblTriangleResult;
        private System.Windows.Forms.ListBox lstTriangles;

        private System.Windows.Forms.GroupBox grpPoint;
        private System.Windows.Forms.Button btnCreatePoint1;
        private System.Windows.Forms.Button btnCreatePoint2;
        private System.Windows.Forms.Button btnClearPoints;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.Label lblPointY;
        private System.Windows.Forms.TextBox txtPointY;
        private System.Windows.Forms.Button btnCustomPoint;
        private System.Windows.Forms.Label lblPointResult;
        private System.Windows.Forms.ListBox lstPoints;
    }
}