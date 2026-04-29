namespace BookBankPointApp
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
            this.tabBank = new System.Windows.Forms.TabPage();
            this.tabPoint = new System.Windows.Forms.TabPage();

            // === Вкладка 1: Книга ===
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookYear = new System.Windows.Forms.Label();
            this.txtBookYear = new System.Windows.Forms.TextBox();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.btnBookDefault = new System.Windows.Forms.Button();
            this.btnClearBooks = new System.Windows.Forms.Button();
            this.lblBookDisplayInfoLabel = new System.Windows.Forms.Label();
            this.lblBookDisplayInfo = new System.Windows.Forms.Label();
            this.lblBookFieldsLabel = new System.Windows.Forms.Label();
            this.lblBookFields = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lblBookInstruction = new System.Windows.Forms.Label();

            // === Вкладка 2: Счет в банке ===
            this.grpBank = new System.Windows.Forms.GroupBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDemoBank = new System.Windows.Forms.Button();
            this.btnResetBank = new System.Windows.Forms.Button();
            this.lblAccountInfoLabel = new System.Windows.Forms.Label();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.lstBankLog = new System.Windows.Forms.ListBox();
            this.lblBankInstruction = new System.Windows.Forms.Label();

            // === Вкладка 3: Точка ===
            this.grpPoint = new System.Windows.Forms.GroupBox();
            this.grpPointNew = new System.Windows.Forms.GroupBox();
            this.lblPointX1 = new System.Windows.Forms.Label();
            this.txtPointX1 = new System.Windows.Forms.TextBox();
            this.lblPointY1 = new System.Windows.Forms.Label();
            this.txtPointY1 = new System.Windows.Forms.TextBox();
            this.btnCreatePointNew = new System.Windows.Forms.Button();
            this.lblPointNew = new System.Windows.Forms.Label();

            this.grpPointWithoutNew = new System.Windows.Forms.GroupBox();
            this.lblPointX2 = new System.Windows.Forms.Label();
            this.txtPointX2 = new System.Windows.Forms.TextBox();
            this.lblPointY2 = new System.Windows.Forms.Label();
            this.txtPointY2 = new System.Windows.Forms.TextBox();
            this.btnCreatePointWithoutNew = new System.Windows.Forms.Button();
            this.lblPointWithoutNew = new System.Windows.Forms.Label();

            this.grpMove = new System.Windows.Forms.GroupBox();
            this.lblDeltaX = new System.Windows.Forms.Label();
            this.txtDeltaX = new System.Windows.Forms.TextBox();
            this.lblDeltaY = new System.Windows.Forms.Label();
            this.txtDeltaY = new System.Windows.Forms.TextBox();
            this.rbPointNew = new System.Windows.Forms.RadioButton();
            this.rbPointWithoutNew = new System.Windows.Forms.RadioButton();
            this.btnMovePoint = new System.Windows.Forms.Button();

            this.btnDemoPoint = new System.Windows.Forms.Button();
            this.btnClearPoints = new System.Windows.Forms.Button();
            this.lstPointLog = new System.Windows.Forms.ListBox();
            this.lblPointInstruction = new System.Windows.Forms.Label();

            this.tabControl.SuspendLayout();
            this.tabBook.SuspendLayout();
            this.tabBank.SuspendLayout();
            this.tabPoint.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpBank.SuspendLayout();
            this.grpPoint.SuspendLayout();
            this.grpPointNew.SuspendLayout();
            this.grpPointWithoutNew.SuspendLayout();
            this.grpMove.SuspendLayout();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.tabBook);
            this.tabControl.Controls.Add(this.tabBank);
            this.tabControl.Controls.Add(this.tabPoint);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(750, 580);
            this.tabControl.TabIndex = 0;

            // ========== Вкладка 1: Книга ==========
            this.tabBook.Text = "📚 Книга";
            this.tabBook.BackColor = System.Drawing.Color.White;

            this.grpBook.Text = "Задача 1: Класс \"Книга\"";
            this.grpBook.Location = new System.Drawing.Point(10, 10);
            this.grpBook.Size = new System.Drawing.Size(715, 530);
            this.grpBook.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblBookInstruction.Text = "📖 Заполните информацию о книге:";
            this.lblBookInstruction.Location = new System.Drawing.Point(15, 25);
            this.lblBookInstruction.Size = new System.Drawing.Size(300, 25);
            this.lblBookInstruction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblBookInstruction.ForeColor = System.Drawing.Color.Gray;

            this.lblBookTitle.Text = "Название:";
            this.lblBookTitle.Location = new System.Drawing.Point(15, 60);
            this.lblBookTitle.Size = new System.Drawing.Size(80, 25);
            this.txtBookTitle.Location = new System.Drawing.Point(100, 57);
            this.txtBookTitle.Size = new System.Drawing.Size(200, 27);

            this.lblBookAuthor.Text = "Автор:";
            this.lblBookAuthor.Location = new System.Drawing.Point(15, 95);
            this.lblBookAuthor.Size = new System.Drawing.Size(80, 25);
            this.txtBookAuthor.Location = new System.Drawing.Point(100, 92);
            this.txtBookAuthor.Size = new System.Drawing.Size(200, 27);

            this.lblBookYear.Text = "Год:";
            this.lblBookYear.Location = new System.Drawing.Point(15, 130);
            this.lblBookYear.Size = new System.Drawing.Size(80, 25);
            this.txtBookYear.Location = new System.Drawing.Point(100, 127);
            this.txtBookYear.Size = new System.Drawing.Size(100, 27);

            this.btnCreateBook.Text = "✨ Создать книгу";
            this.btnCreateBook.Location = new System.Drawing.Point(15, 165);
            this.btnCreateBook.Size = new System.Drawing.Size(130, 40);
            this.btnCreateBook.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCreateBook.ForeColor = System.Drawing.Color.White;
            this.btnCreateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);

            this.btnBookDefault.Text = "📖 Книга по умолчанию";
            this.btnBookDefault.Location = new System.Drawing.Point(155, 165);
            this.btnBookDefault.Size = new System.Drawing.Size(145, 40);
            this.btnBookDefault.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnBookDefault.ForeColor = System.Drawing.Color.White;
            this.btnBookDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookDefault.Click += new System.EventHandler(this.btnBookDefault_Click);

            this.btnClearBooks.Text = "🗑 Очистить";
            this.btnClearBooks.Location = new System.Drawing.Point(310, 165);
            this.btnClearBooks.Size = new System.Drawing.Size(100, 40);
            this.btnClearBooks.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearBooks.ForeColor = System.Drawing.Color.White;
            this.btnClearBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBooks.Click += new System.EventHandler(this.btnClearBooks_Click);

            this.lblBookDisplayInfoLabel.Text = "📌 Результат DisplayInfo():";
            this.lblBookDisplayInfoLabel.Location = new System.Drawing.Point(15, 215);
            this.lblBookDisplayInfoLabel.Size = new System.Drawing.Size(200, 25);

            this.lblBookDisplayInfo.Text = "Информация о книге (DisplayInfo) появится здесь...";
            this.lblBookDisplayInfo.Location = new System.Drawing.Point(15, 245);
            this.lblBookDisplayInfo.Size = new System.Drawing.Size(680, 40);
            this.lblBookDisplayInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBookDisplayInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBookDisplayInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBookDisplayInfo.BackColor = System.Drawing.Color.White;

            this.lblBookFieldsLabel.Text = "📌 Поля по отдельности:";
            this.lblBookFieldsLabel.Location = new System.Drawing.Point(15, 295);
            this.lblBookFieldsLabel.Size = new System.Drawing.Size(200, 25);

            this.lblBookFields.Text = "Название: \nАвтор: \nГод:";
            this.lblBookFields.Location = new System.Drawing.Point(15, 325);
            this.lblBookFields.Size = new System.Drawing.Size(680, 70);
            this.lblBookFields.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBookFields.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBookFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBookFields.BackColor = System.Drawing.Color.White;

            this.lstBooks.Location = new System.Drawing.Point(15, 405);
            this.lstBooks.Size = new System.Drawing.Size(680, 100);
            this.lstBooks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstBooks.BackColor = System.Drawing.Color.LightYellow;

            this.grpBook.Controls.Add(this.lblBookInstruction);
            this.grpBook.Controls.Add(this.lblBookTitle);
            this.grpBook.Controls.Add(this.txtBookTitle);
            this.grpBook.Controls.Add(this.lblBookAuthor);
            this.grpBook.Controls.Add(this.txtBookAuthor);
            this.grpBook.Controls.Add(this.lblBookYear);
            this.grpBook.Controls.Add(this.txtBookYear);
            this.grpBook.Controls.Add(this.btnCreateBook);
            this.grpBook.Controls.Add(this.btnBookDefault);
            this.grpBook.Controls.Add(this.btnClearBooks);
            this.grpBook.Controls.Add(this.lblBookDisplayInfoLabel);
            this.grpBook.Controls.Add(this.lblBookDisplayInfo);
            this.grpBook.Controls.Add(this.lblBookFieldsLabel);
            this.grpBook.Controls.Add(this.lblBookFields);
            this.grpBook.Controls.Add(this.lstBooks);

            this.tabBook.Controls.Add(this.grpBook);

            // ========== Вкладка 2: Счет в банке ==========
            this.tabBank.Text = "💰 Счет в банке";
            this.tabBank.BackColor = System.Drawing.Color.White;

            this.grpBank.Text = "Задача 2: Класс \"BankAccount\"";
            this.grpBank.Location = new System.Drawing.Point(10, 10);
            this.grpBank.Size = new System.Drawing.Size(715, 530);
            this.grpBank.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblBankInstruction.Text = "🏦 Создайте счет и выполняйте операции:";
            this.lblBankInstruction.Location = new System.Drawing.Point(15, 25);
            this.lblBankInstruction.Size = new System.Drawing.Size(350, 25);
            this.lblBankInstruction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblBankInstruction.ForeColor = System.Drawing.Color.Gray;

            this.lblAccountNumber.Text = "Номер счета:";
            this.lblAccountNumber.Location = new System.Drawing.Point(15, 60);
            this.lblAccountNumber.Size = new System.Drawing.Size(100, 25);
            this.txtAccountNumber.Location = new System.Drawing.Point(120, 57);
            this.txtAccountNumber.Size = new System.Drawing.Size(200, 27);
            this.btnCreateAccount.Text = "Создать счет";
            this.btnCreateAccount.Location = new System.Drawing.Point(335, 55);
            this.btnCreateAccount.Size = new System.Drawing.Size(120, 30);
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);

            this.lblAmount.Text = "Сумма:";
            this.lblAmount.Location = new System.Drawing.Point(15, 100);
            this.lblAmount.Size = new System.Drawing.Size(60, 25);
            this.txtAmount.Location = new System.Drawing.Point(80, 97);
            this.txtAmount.Size = new System.Drawing.Size(120, 27);
            this.btnDeposit.Text = "💰 Внести";
            this.btnDeposit.Location = new System.Drawing.Point(215, 95);
            this.btnDeposit.Size = new System.Drawing.Size(100, 30);
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            this.btnWithdraw.Text = "💸 Снять";
            this.btnWithdraw.Location = new System.Drawing.Point(325, 95);
            this.btnWithdraw.Size = new System.Drawing.Size(100, 30);
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);

            this.btnDemoBank.Text = "📋 Демо (по заданию)";
            this.btnDemoBank.Location = new System.Drawing.Point(580, 55);
            this.btnDemoBank.Size = new System.Drawing.Size(120, 40);
            this.btnDemoBank.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnDemoBank.ForeColor = System.Drawing.Color.White;
            this.btnDemoBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemoBank.Click += new System.EventHandler(this.btnDemoBank_Click);

            this.btnResetBank.Text = "🔄 Сброс";
            this.btnResetBank.Location = new System.Drawing.Point(580, 100);
            this.btnResetBank.Size = new System.Drawing.Size(120, 30);
            this.btnResetBank.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnResetBank.ForeColor = System.Drawing.Color.White;
            this.btnResetBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetBank.Click += new System.EventHandler(this.btnResetBank_Click);

            this.lblAccountInfoLabel.Text = "📌 Информация о счете:";
            this.lblAccountInfoLabel.Location = new System.Drawing.Point(15, 140);
            this.lblAccountInfoLabel.Size = new System.Drawing.Size(150, 25);

            this.lblAccountInfo.Text = "Информация о счете появится здесь...";
            this.lblAccountInfo.Location = new System.Drawing.Point(15, 170);
            this.lblAccountInfo.Size = new System.Drawing.Size(680, 40);
            this.lblAccountInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountInfo.BackColor = System.Drawing.Color.White;

            this.lstBankLog.Location = new System.Drawing.Point(15, 225);
            this.lstBankLog.Size = new System.Drawing.Size(680, 280);
            this.lstBankLog.Font = new System.Drawing.Font("Consolas", 11F);
            this.lstBankLog.BackColor = System.Drawing.Color.LightCyan;

            this.grpBank.Controls.Add(this.lblBankInstruction);
            this.grpBank.Controls.Add(this.lblAccountNumber);
            this.grpBank.Controls.Add(this.txtAccountNumber);
            this.grpBank.Controls.Add(this.btnCreateAccount);
            this.grpBank.Controls.Add(this.lblAmount);
            this.grpBank.Controls.Add(this.txtAmount);
            this.grpBank.Controls.Add(this.btnDeposit);
            this.grpBank.Controls.Add(this.btnWithdraw);
            this.grpBank.Controls.Add(this.btnDemoBank);
            this.grpBank.Controls.Add(this.btnResetBank);
            this.grpBank.Controls.Add(this.lblAccountInfoLabel);
            this.grpBank.Controls.Add(this.lblAccountInfo);
            this.grpBank.Controls.Add(this.lstBankLog);

            this.tabBank.Controls.Add(this.grpBank);

            // ========== Вкладка 3: Точка ==========
            this.tabPoint.Text = "📍 Точка";
            this.tabPoint.BackColor = System.Drawing.Color.White;

            this.grpPoint.Text = "Задача 3: Структура \"Point\"";
            this.grpPoint.Location = new System.Drawing.Point(10, 10);
            this.grpPoint.Size = new System.Drawing.Size(715, 530);
            this.grpPoint.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblPointInstruction.Text = "📍 Создание точек двумя способами: с new и без new";
            this.lblPointInstruction.Location = new System.Drawing.Point(10, 20);
            this.lblPointInstruction.Size = new System.Drawing.Size(400, 25);
            this.lblPointInstruction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblPointInstruction.ForeColor = System.Drawing.Color.Gray;

            // Группа для new
            this.grpPointNew.Text = "Создание через new Point()";
            this.grpPointNew.Location = new System.Drawing.Point(10, 50);
            this.grpPointNew.Size = new System.Drawing.Size(340, 200);
            this.grpPointNew.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.lblPointX1.Text = "X:";
            this.lblPointX1.Location = new System.Drawing.Point(15, 30);
            this.lblPointX1.Size = new System.Drawing.Size(30, 25);
            this.txtPointX1.Location = new System.Drawing.Point(50, 27);
            this.txtPointX1.Size = new System.Drawing.Size(80, 27);

            this.lblPointY1.Text = "Y:";
            this.lblPointY1.Location = new System.Drawing.Point(140, 30);
            this.lblPointY1.Size = new System.Drawing.Size(30, 25);
            this.txtPointY1.Location = new System.Drawing.Point(175, 27);
            this.txtPointY1.Size = new System.Drawing.Size(80, 27);

            this.btnCreatePointNew.Text = "Создать точку";
            this.btnCreatePointNew.Location = new System.Drawing.Point(50, 65);
            this.btnCreatePointNew.Size = new System.Drawing.Size(150, 30);
            this.btnCreatePointNew.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCreatePointNew.ForeColor = System.Drawing.Color.White;
            this.btnCreatePointNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePointNew.Click += new System.EventHandler(this.btnCreatePointNew_Click);

            this.lblPointNew.Text = "Точка с new не создана";
            this.lblPointNew.Location = new System.Drawing.Point(15, 110);
            this.lblPointNew.Size = new System.Drawing.Size(310, 60);
            this.lblPointNew.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPointNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPointNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPointNew.BackColor = System.Drawing.Color.White;

            this.grpPointNew.Controls.Add(this.lblPointX1);
            this.grpPointNew.Controls.Add(this.txtPointX1);
            this.grpPointNew.Controls.Add(this.lblPointY1);
            this.grpPointNew.Controls.Add(this.txtPointY1);
            this.grpPointNew.Controls.Add(this.btnCreatePointNew);
            this.grpPointNew.Controls.Add(this.lblPointNew);

            // Группа для без new
            this.grpPointWithoutNew.Text = "Создание без new (Point p2;)";
            this.grpPointWithoutNew.Location = new System.Drawing.Point(365, 50);
            this.grpPointWithoutNew.Size = new System.Drawing.Size(340, 200);
            this.grpPointWithoutNew.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.lblPointX2.Text = "X:";
            this.lblPointX2.Location = new System.Drawing.Point(15, 30);
            this.lblPointX2.Size = new System.Drawing.Size(30, 25);
            this.txtPointX2.Location = new System.Drawing.Point(50, 27);
            this.txtPointX2.Size = new System.Drawing.Size(80, 27);

            this.lblPointY2.Text = "Y:";
            this.lblPointY2.Location = new System.Drawing.Point(140, 30);
            this.lblPointY2.Size = new System.Drawing.Size(30, 25);
            this.txtPointY2.Location = new System.Drawing.Point(175, 27);
            this.txtPointY2.Size = new System.Drawing.Size(80, 27);

            this.btnCreatePointWithoutNew.Text = "Создать точку";
            this.btnCreatePointWithoutNew.Location = new System.Drawing.Point(50, 65);
            this.btnCreatePointWithoutNew.Size = new System.Drawing.Size(150, 30);
            this.btnCreatePointWithoutNew.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCreatePointWithoutNew.ForeColor = System.Drawing.Color.White;
            this.btnCreatePointWithoutNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePointWithoutNew.Click += new System.EventHandler(this.btnCreatePointWithoutNew_Click);

            this.lblPointWithoutNew.Text = "Точка без new не создана";
            this.lblPointWithoutNew.Location = new System.Drawing.Point(15, 110);
            this.lblPointWithoutNew.Size = new System.Drawing.Size(310, 60);
            this.lblPointWithoutNew.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPointWithoutNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPointWithoutNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPointWithoutNew.BackColor = System.Drawing.Color.White;

            this.grpPointWithoutNew.Controls.Add(this.lblPointX2);
            this.grpPointWithoutNew.Controls.Add(this.txtPointX2);
            this.grpPointWithoutNew.Controls.Add(this.lblPointY2);
            this.grpPointWithoutNew.Controls.Add(this.txtPointY2);
            this.grpPointWithoutNew.Controls.Add(this.btnCreatePointWithoutNew);
            this.grpPointWithoutNew.Controls.Add(this.lblPointWithoutNew);

            // Группа для перемещения
            this.grpMove.Text = "Перемещение точки (метод Move)";
            this.grpMove.Location = new System.Drawing.Point(10, 260);
            this.grpMove.Size = new System.Drawing.Size(695, 120);
            this.grpMove.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.lblDeltaX.Text = "ΔX:";
            this.lblDeltaX.Location = new System.Drawing.Point(15, 25);
            this.lblDeltaX.Size = new System.Drawing.Size(40, 25);
            this.txtDeltaX.Location = new System.Drawing.Point(55, 22);
            this.txtDeltaX.Size = new System.Drawing.Size(80, 27);
            this.txtDeltaX.Text = "0";

            this.lblDeltaY.Text = "ΔY:";
            this.lblDeltaY.Location = new System.Drawing.Point(150, 25);
            this.lblDeltaY.Size = new System.Drawing.Size(40, 25);
            this.txtDeltaY.Location = new System.Drawing.Point(190, 22);
            this.txtDeltaY.Size = new System.Drawing.Size(80, 27);
            this.txtDeltaY.Text = "0";

            this.rbPointNew.Text = "Перемещать точку с new";
            this.rbPointNew.Location = new System.Drawing.Point(300, 20);
            this.rbPointNew.Size = new System.Drawing.Size(180, 25);

            this.rbPointWithoutNew.Text = "Перемещать точку без new";
            this.rbPointWithoutNew.Location = new System.Drawing.Point(500, 20);
            this.rbPointWithoutNew.Size = new System.Drawing.Size(180, 25);

            this.btnMovePoint.Text = "▶ Переместить";
            this.btnMovePoint.Location = new System.Drawing.Point(190, 60);
            this.btnMovePoint.Size = new System.Drawing.Size(120, 35);
            this.btnMovePoint.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnMovePoint.ForeColor = System.Drawing.Color.White;
            this.btnMovePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovePoint.Click += new System.EventHandler(this.btnMovePoint_Click);

            this.grpMove.Controls.Add(this.lblDeltaX);
            this.grpMove.Controls.Add(this.txtDeltaX);
            this.grpMove.Controls.Add(this.lblDeltaY);
            this.grpMove.Controls.Add(this.txtDeltaY);
            this.grpMove.Controls.Add(this.rbPointNew);
            this.grpMove.Controls.Add(this.rbPointWithoutNew);
            this.grpMove.Controls.Add(this.btnMovePoint);

            this.btnDemoPoint.Text = "📋 Демо (по заданию)";
            this.btnDemoPoint.Location = new System.Drawing.Point(580, 395);
            this.btnDemoPoint.Size = new System.Drawing.Size(125, 40);
            this.btnDemoPoint.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnDemoPoint.ForeColor = System.Drawing.Color.White;
            this.btnDemoPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemoPoint.Click += new System.EventHandler(this.btnDemoPoint_Click);

            this.btnClearPoints.Text = "🗑 Очистить всё";
            this.btnClearPoints.Location = new System.Drawing.Point(580, 440);
            this.btnClearPoints.Size = new System.Drawing.Size(125, 40);
            this.btnClearPoints.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearPoints.ForeColor = System.Drawing.Color.White;
            this.btnClearPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPoints.Click += new System.EventHandler(this.btnClearPoints_Click);

            this.lstPointLog.Location = new System.Drawing.Point(10, 390);
            this.lstPointLog.Size = new System.Drawing.Size(560, 120);
            this.lstPointLog.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstPointLog.BackColor = System.Drawing.Color.LightYellow;

            this.grpPoint.Controls.Add(this.lblPointInstruction);
            this.grpPoint.Controls.Add(this.grpPointNew);
            this.grpPoint.Controls.Add(this.grpPointWithoutNew);
            this.grpPoint.Controls.Add(this.grpMove);
            this.grpPoint.Controls.Add(this.btnDemoPoint);
            this.grpPoint.Controls.Add(this.btnClearPoints);
            this.grpPoint.Controls.Add(this.lstPointLog);

            this.tabPoint.Controls.Add(this.grpPoint);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Задачи: Книга | Счет в банке | Точка";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabControl.ResumeLayout(false);
            this.tabBook.ResumeLayout(false);
            this.tabBank.ResumeLayout(false);
            this.tabPoint.ResumeLayout(false);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpBank.ResumeLayout(false);
            this.grpBank.PerformLayout();
            this.grpPoint.ResumeLayout(false);
            this.grpPointNew.ResumeLayout(false);
            this.grpPointNew.PerformLayout();
            this.grpPointWithoutNew.ResumeLayout(false);
            this.grpPointWithoutNew.PerformLayout();
            this.grpMove.ResumeLayout(false);
            this.grpMove.PerformLayout();
            this.ResumeLayout(false);
        }

        // Элементы управления - Вкладка 1
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBook;
        private System.Windows.Forms.TabPage tabBank;
        private System.Windows.Forms.TabPage tabPoint;

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Label lblBookInstruction;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookYear;
        private System.Windows.Forms.TextBox txtBookYear;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Button btnBookDefault;
        private System.Windows.Forms.Button btnClearBooks;
        private System.Windows.Forms.Label lblBookDisplayInfoLabel;
        private System.Windows.Forms.Label lblBookDisplayInfo;
        private System.Windows.Forms.Label lblBookFieldsLabel;
        private System.Windows.Forms.Label lblBookFields;
        private System.Windows.Forms.ListBox lstBooks;

        private System.Windows.Forms.GroupBox grpBank;
        private System.Windows.Forms.Label lblBankInstruction;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDemoBank;
        private System.Windows.Forms.Button btnResetBank;
        private System.Windows.Forms.Label lblAccountInfoLabel;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.ListBox lstBankLog;

        private System.Windows.Forms.GroupBox grpPoint;
        private System.Windows.Forms.Label lblPointInstruction;
        private System.Windows.Forms.GroupBox grpPointNew;
        private System.Windows.Forms.Label lblPointX1;
        private System.Windows.Forms.TextBox txtPointX1;
        private System.Windows.Forms.Label lblPointY1;
        private System.Windows.Forms.TextBox txtPointY1;
        private System.Windows.Forms.Button btnCreatePointNew;
        private System.Windows.Forms.Label lblPointNew;
        private System.Windows.Forms.GroupBox grpPointWithoutNew;
        private System.Windows.Forms.Label lblPointX2;
        private System.Windows.Forms.TextBox txtPointX2;
        private System.Windows.Forms.Label lblPointY2;
        private System.Windows.Forms.TextBox txtPointY2;
        private System.Windows.Forms.Button btnCreatePointWithoutNew;
        private System.Windows.Forms.Label lblPointWithoutNew;
        private System.Windows.Forms.GroupBox grpMove;
        private System.Windows.Forms.Label lblDeltaX;
        private System.Windows.Forms.TextBox txtDeltaX;
        private System.Windows.Forms.Label lblDeltaY;
        private System.Windows.Forms.TextBox txtDeltaY;
        private System.Windows.Forms.RadioButton rbPointNew;
        private System.Windows.Forms.RadioButton rbPointWithoutNew;
        private System.Windows.Forms.Button btnMovePoint;
        private System.Windows.Forms.Button btnDemoPoint;
        private System.Windows.Forms.Button btnClearPoints;
        private System.Windows.Forms.ListBox lstPointLog;
    }
}