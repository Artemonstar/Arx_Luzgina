namespace BookAndVisitorApp
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
            this.tabVisitor = new System.Windows.Forms.TabPage();

            // === Вкладка 1: Книжная полка ===
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.btnDefaultBook = new System.Windows.Forms.Button();
            this.btnClearBooks = new System.Windows.Forms.Button();
            this.lblBookResult = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lblBookInstruction = new System.Windows.Forms.Label();

            // === Вкладка 2: Умный счетчик ===
            this.grpVisitor = new System.Windows.Forms.GroupBox();
            this.lblVisitorName = new System.Windows.Forms.Label();
            this.txtVisitorName = new System.Windows.Forms.TextBox();
            this.btnCreateVisitor = new System.Windows.Forms.Button();
            this.btnCreateThreeVisitors = new System.Windows.Forms.Button();
            this.btnShowTotal = new System.Windows.Forms.Button();
            this.btnResetVisitors = new System.Windows.Forms.Button();
            this.lstVisitors = new System.Windows.Forms.ListBox();
            this.lblTotalVisitors = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblVisitorInstruction = new System.Windows.Forms.Label();

            this.tabControl.SuspendLayout();
            this.tabBook.SuspendLayout();
            this.tabVisitor.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpVisitor.SuspendLayout();
            this.SuspendLayout();

            // === tabControl ===
            this.tabControl.Controls.Add(this.tabBook);
            this.tabControl.Controls.Add(this.tabVisitor);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(750, 520);
            this.tabControl.TabIndex = 0;

            // === Вкладка 1: Книжная полка ===
            this.tabBook.Text = "📚 Книжная полка";
            this.tabBook.BackColor = System.Drawing.Color.White;

            this.grpBook.Text = "Создание книги";
            this.grpBook.Location = new System.Drawing.Point(10, 10);
            this.grpBook.Size = new System.Drawing.Size(715, 465);
            this.grpBook.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblBookInstruction.Text = "📖 Заполните информацию о книге и нажмите \"Создать книгу\":";
            this.lblBookInstruction.Location = new System.Drawing.Point(15, 25);
            this.lblBookInstruction.Size = new System.Drawing.Size(400, 25);
            this.lblBookInstruction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblBookInstruction.ForeColor = System.Drawing.Color.Gray;

            // Название
            this.lblTitle.Text = "Название:";
            this.lblTitle.Location = new System.Drawing.Point(15, 65);
            this.lblTitle.Size = new System.Drawing.Size(80, 25);

            this.txtTitle.Location = new System.Drawing.Point(100, 62);
            this.txtTitle.Size = new System.Drawing.Size(250, 27);
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 11F);

            // Автор
            this.lblAuthor.Text = "Автор:";
            this.lblAuthor.Location = new System.Drawing.Point(15, 105);
            this.lblAuthor.Size = new System.Drawing.Size(80, 25);

            this.txtAuthor.Location = new System.Drawing.Point(100, 102);
            this.txtAuthor.Size = new System.Drawing.Size(250, 27);
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 11F);

            // Год
            this.lblYear.Text = "Год издания:";
            this.lblYear.Location = new System.Drawing.Point(15, 145);
            this.lblYear.Size = new System.Drawing.Size(100, 25);

            this.txtYear.Location = new System.Drawing.Point(115, 142);
            this.txtYear.Size = new System.Drawing.Size(100, 27);
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 11F);

            // Кнопки
            this.btnCreateBook.Text = "✨ Создать книгу";
            this.btnCreateBook.Location = new System.Drawing.Point(15, 185);
            this.btnCreateBook.Size = new System.Drawing.Size(150, 40);
            this.btnCreateBook.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCreateBook.ForeColor = System.Drawing.Color.White;
            this.btnCreateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);

            this.btnDefaultBook.Text = "📖 Книга по умолчанию";
            this.btnDefaultBook.Location = new System.Drawing.Point(175, 185);
            this.btnDefaultBook.Size = new System.Drawing.Size(170, 40);
            this.btnDefaultBook.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnDefaultBook.ForeColor = System.Drawing.Color.White;
            this.btnDefaultBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultBook.Click += new System.EventHandler(this.btnDefaultBook_Click);

            this.btnClearBooks.Text = "🗑 Очистить всё";
            this.btnClearBooks.Location = new System.Drawing.Point(355, 185);
            this.btnClearBooks.Size = new System.Drawing.Size(130, 40);
            this.btnClearBooks.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearBooks.ForeColor = System.Drawing.Color.White;
            this.btnClearBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBooks.Click += new System.EventHandler(this.btnClearBooks_Click);

            // Результат
            this.lblBookResult.Text = "📌 Информация о книге появится здесь...";
            this.lblBookResult.Location = new System.Drawing.Point(15, 240);
            this.lblBookResult.Size = new System.Drawing.Size(470, 60);
            this.lblBookResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBookResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBookResult.BackColor = System.Drawing.Color.White;

            // Список созданных книг
            this.lstBooks.Location = new System.Drawing.Point(15, 315);
            this.lstBooks.Size = new System.Drawing.Size(680, 130);
            this.lstBooks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstBooks.BackColor = System.Drawing.Color.LightYellow;

            this.grpBook.Controls.Add(this.lblBookInstruction);
            this.grpBook.Controls.Add(this.lblTitle);
            this.grpBook.Controls.Add(this.txtTitle);
            this.grpBook.Controls.Add(this.lblAuthor);
            this.grpBook.Controls.Add(this.txtAuthor);
            this.grpBook.Controls.Add(this.lblYear);
            this.grpBook.Controls.Add(this.txtYear);
            this.grpBook.Controls.Add(this.btnCreateBook);
            this.grpBook.Controls.Add(this.btnDefaultBook);
            this.grpBook.Controls.Add(this.btnClearBooks);
            this.grpBook.Controls.Add(this.lblBookResult);
            this.grpBook.Controls.Add(this.lstBooks);

            this.tabBook.Controls.Add(this.grpBook);

            // === Вкладка 2: Умный счетчик ===
            this.tabVisitor.Text = "👥 Умный счетчик";
            this.tabVisitor.BackColor = System.Drawing.Color.White;

            this.grpVisitor.Text = "Учет посетителей";
            this.grpVisitor.Location = new System.Drawing.Point(10, 10);
            this.grpVisitor.Size = new System.Drawing.Size(715, 465);
            this.grpVisitor.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblVisitorInstruction.Text = "👋 Введите имя посетителя для регистрации входа:";
            this.lblVisitorInstruction.Location = new System.Drawing.Point(15, 25);
            this.lblVisitorInstruction.Size = new System.Drawing.Size(350, 25);
            this.lblVisitorInstruction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblVisitorInstruction.ForeColor = System.Drawing.Color.Gray;

            // Имя посетителя
            this.lblVisitorName.Text = "Имя:";
            this.lblVisitorName.Location = new System.Drawing.Point(15, 65);
            this.lblVisitorName.Size = new System.Drawing.Size(50, 25);

            this.txtVisitorName.Location = new System.Drawing.Point(65, 62);
            this.txtVisitorName.Size = new System.Drawing.Size(200, 27);
            this.txtVisitorName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtVisitorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVisitorName_KeyPress);

            // Кнопки
            this.btnCreateVisitor.Text = "➕ Добавить посетителя";
            this.btnCreateVisitor.Location = new System.Drawing.Point(280, 55);
            this.btnCreateVisitor.Size = new System.Drawing.Size(180, 40);
            this.btnCreateVisitor.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCreateVisitor.ForeColor = System.Drawing.Color.White;
            this.btnCreateVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateVisitor.Click += new System.EventHandler(this.btnCreateVisitor_Click);

            this.btnCreateThreeVisitors.Text = "👥 Создать трёх (Анна, Борис, Виктор)";
            this.btnCreateThreeVisitors.Location = new System.Drawing.Point(15, 115);
            this.btnCreateThreeVisitors.Size = new System.Drawing.Size(250, 40);
            this.btnCreateThreeVisitors.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnCreateThreeVisitors.ForeColor = System.Drawing.Color.White;
            this.btnCreateThreeVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateThreeVisitors.Click += new System.EventHandler(this.btnCreateThreeVisitors_Click);

            this.btnShowTotal.Text = "📊 Показать общее количество";
            this.btnShowTotal.Location = new System.Drawing.Point(280, 115);
            this.btnShowTotal.Size = new System.Drawing.Size(200, 40);
            this.btnShowTotal.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnShowTotal.ForeColor = System.Drawing.Color.White;
            this.btnShowTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTotal.Click += new System.EventHandler(this.btnShowTotal_Click);

            this.btnResetVisitors.Text = "🔄 Сбросить счетчик";
            this.btnResetVisitors.Location = new System.Drawing.Point(500, 115);
            this.btnResetVisitors.Size = new System.Drawing.Size(180, 40);
            this.btnResetVisitors.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnResetVisitors.ForeColor = System.Drawing.Color.White;
            this.btnResetVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetVisitors.Click += new System.EventHandler(this.btnResetVisitors_Click);

            // Статистика
            this.lblStats.Text = "📊 Посетители не созданы";
            this.lblStats.Location = new System.Drawing.Point(15, 170);
            this.lblStats.Size = new System.Drawing.Size(350, 30);
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStats.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);

            this.lblTotalVisitors.Text = "Общее количество созданных посетителей: 0";
            this.lblTotalVisitors.Location = new System.Drawing.Point(15, 210);
            this.lblTotalVisitors.Size = new System.Drawing.Size(680, 35);
            this.lblTotalVisitors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalVisitors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalVisitors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalVisitors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalVisitors.Padding = new System.Windows.Forms.Padding(5);

            // Список посетителей
            this.lstVisitors.Location = new System.Drawing.Point(15, 260);
            this.lstVisitors.Size = new System.Drawing.Size(680, 180);
            this.lstVisitors.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstVisitors.BackColor = System.Drawing.Color.LightCyan;

            this.grpVisitor.Controls.Add(this.lblVisitorInstruction);
            this.grpVisitor.Controls.Add(this.lblVisitorName);
            this.grpVisitor.Controls.Add(this.txtVisitorName);
            this.grpVisitor.Controls.Add(this.btnCreateVisitor);
            this.grpVisitor.Controls.Add(this.btnCreateThreeVisitors);
            this.grpVisitor.Controls.Add(this.btnShowTotal);
            this.grpVisitor.Controls.Add(this.btnResetVisitors);
            this.grpVisitor.Controls.Add(this.lblStats);
            this.grpVisitor.Controls.Add(this.lblTotalVisitors);
            this.grpVisitor.Controls.Add(this.lstVisitors);

            this.tabVisitor.Controls.Add(this.grpVisitor);

            // === Form1 ===
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 520);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Книжная полка | Умный счетчик";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabControl.ResumeLayout(false);
            this.tabBook.ResumeLayout(false);
            this.tabVisitor.ResumeLayout(false);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpVisitor.ResumeLayout(false);
            this.grpVisitor.PerformLayout();
            this.ResumeLayout(false);
        }

        // Элементы управления - Вкладка 1
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBook;
        private System.Windows.Forms.TabPage tabVisitor;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Label lblBookInstruction;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Button btnDefaultBook;
        private System.Windows.Forms.Button btnClearBooks;
        private System.Windows.Forms.Label lblBookResult;
        private System.Windows.Forms.ListBox lstBooks;

        // Элементы управления - Вкладка 2
        private System.Windows.Forms.GroupBox grpVisitor;
        private System.Windows.Forms.Label lblVisitorInstruction;
        private System.Windows.Forms.Label lblVisitorName;
        private System.Windows.Forms.TextBox txtVisitorName;
        private System.Windows.Forms.Button btnCreateVisitor;
        private System.Windows.Forms.Button btnCreateThreeVisitors;
        private System.Windows.Forms.Button btnShowTotal;
        private System.Windows.Forms.Button btnResetVisitors;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblTotalVisitors;
        private System.Windows.Forms.ListBox lstVisitors;
    }
}