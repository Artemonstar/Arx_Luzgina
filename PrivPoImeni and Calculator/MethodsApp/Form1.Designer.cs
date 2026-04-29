namespace MethodsApp
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
            this.tabGreeting = new System.Windows.Forms.TabPage();
            this.tabAge = new System.Windows.Forms.TabPage();

            // === Вкладка 1: Приветствие ===
            this.grpGreeting = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnDemoThree = new System.Windows.Forms.Button();
            this.btnClearGreetings = new System.Windows.Forms.Button();
            this.lstGreetings = new System.Windows.Forms.ListBox();
            this.lblInstruction = new System.Windows.Forms.Label();

            // === Вкладка 2: Калькулятор возраста ===
            this.grpAge = new System.Windows.Forms.GroupBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.lblCurrentYear = new System.Windows.Forms.Label();
            this.txtCurrentYear = new System.Windows.Forms.TextBox();
            this.btnCalculateAge = new System.Windows.Forms.Button();
            this.lblAgeResult = new System.Windows.Forms.Label();
            this.btnDemoAge = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.lblFormula = new System.Windows.Forms.Label();

            this.tabControl.SuspendLayout();
            this.tabGreeting.SuspendLayout();
            this.tabAge.SuspendLayout();
            this.grpGreeting.SuspendLayout();
            this.grpAge.SuspendLayout();
            this.SuspendLayout();

            // === tabControl ===
            this.tabControl.Controls.Add(this.tabGreeting);
            this.tabControl.Controls.Add(this.tabAge);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(680, 460);
            this.tabControl.TabIndex = 0;

            // === Вкладка 1: Приветствие ===
            this.tabGreeting.Text = "👋 Приветствие";
            this.tabGreeting.BackColor = System.Drawing.Color.White;

            this.grpGreeting.Text = "Скажи \"Hello\"";
            this.grpGreeting.Location = new System.Drawing.Point(10, 10);
            this.grpGreeting.Size = new System.Drawing.Size(640, 410);
            this.grpGreeting.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblInstruction.Text = "Введите имя и нажмите кнопку для приветствия:";
            this.lblInstruction.Location = new System.Drawing.Point(15, 25);
            this.lblInstruction.Size = new System.Drawing.Size(350, 25);

            this.lblName.Text = "Ваше имя:";
            this.lblName.Location = new System.Drawing.Point(15, 60);
            this.lblName.Size = new System.Drawing.Size(80, 25);

            this.txtName.Location = new System.Drawing.Point(100, 58);
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);

            this.btnSayHello.Text = "👋 Поздороваться";
            this.btnSayHello.Location = new System.Drawing.Point(320, 55);
            this.btnSayHello.Size = new System.Drawing.Size(160, 35);
            this.btnSayHello.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSayHello.ForeColor = System.Drawing.Color.White;
            this.btnSayHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);

            this.btnDemoThree.Text = "📋 Демо (Tom, Bob, Alice)";
            this.btnDemoThree.Location = new System.Drawing.Point(320, 100);
            this.btnDemoThree.Size = new System.Drawing.Size(160, 35);
            this.btnDemoThree.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnDemoThree.ForeColor = System.Drawing.Color.White;
            this.btnDemoThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemoThree.Click += new System.EventHandler(this.btnDemoThree_Click);

            this.btnClearGreetings.Text = "🗑 Очистить";
            this.btnClearGreetings.Location = new System.Drawing.Point(320, 145);
            this.btnClearGreetings.Size = new System.Drawing.Size(160, 35);
            this.btnClearGreetings.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearGreetings.ForeColor = System.Drawing.Color.White;
            this.btnClearGreetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearGreetings.Click += new System.EventHandler(this.btnClearGreetings_Click);

            this.lstGreetings.Location = new System.Drawing.Point(15, 100);
            this.lstGreetings.Size = new System.Drawing.Size(285, 280);
            this.lstGreetings.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstGreetings.BackColor = System.Drawing.Color.LightYellow;

            this.grpGreeting.Controls.Add(this.lblInstruction);
            this.grpGreeting.Controls.Add(this.lblName);
            this.grpGreeting.Controls.Add(this.txtName);
            this.grpGreeting.Controls.Add(this.btnSayHello);
            this.grpGreeting.Controls.Add(this.btnDemoThree);
            this.grpGreeting.Controls.Add(this.btnClearGreetings);
            this.grpGreeting.Controls.Add(this.lstGreetings);

            this.tabGreeting.Controls.Add(this.grpGreeting);

            // === Вкладка 2: Калькулятор возраста ===
            this.tabAge.Text = "📅 Калькулятор возраста";
            this.tabAge.BackColor = System.Drawing.Color.White;

            this.grpAge.Text = "Вычисление возраста";
            this.grpAge.Location = new System.Drawing.Point(10, 10);
            this.grpAge.Size = new System.Drawing.Size(640, 410);
            this.grpAge.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblBirthYear.Text = "Год рождения:";
            this.lblBirthYear.Location = new System.Drawing.Point(15, 30);
            this.lblBirthYear.Size = new System.Drawing.Size(100, 25);

            this.txtBirthYear.Location = new System.Drawing.Point(120, 28);
            this.txtBirthYear.Size = new System.Drawing.Size(100, 27);
            this.txtBirthYear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBirthYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirthYear_KeyPress);

            this.lblCurrentYear.Text = "Текущий год:";
            this.lblCurrentYear.Location = new System.Drawing.Point(15, 70);
            this.lblCurrentYear.Size = new System.Drawing.Size(100, 25);

            this.txtCurrentYear.Location = new System.Drawing.Point(120, 68);
            this.txtCurrentYear.Size = new System.Drawing.Size(100, 27);
            this.txtCurrentYear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurrentYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentYear_KeyPress);

            this.btnCalculateAge.Text = "🔢 Рассчитать возраст";
            this.btnCalculateAge.Location = new System.Drawing.Point(250, 30);
            this.btnCalculateAge.Size = new System.Drawing.Size(180, 65);
            this.btnCalculateAge.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnCalculateAge.ForeColor = System.Drawing.Color.White;
            this.btnCalculateAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateAge.Click += new System.EventHandler(this.btnCalculateAge_Click);

            this.lblAgeResult.Text = "Возраст: ?";
            this.lblAgeResult.Location = new System.Drawing.Point(250, 110);
            this.lblAgeResult.Size = new System.Drawing.Size(180, 40);
            this.lblAgeResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAgeResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAgeResult.BackColor = System.Drawing.Color.White;

            this.lblFormula.Text = "Формула: возраст = текущий год - год рождения";
            this.lblFormula.Location = new System.Drawing.Point(15, 110);
            this.lblFormula.Size = new System.Drawing.Size(220, 40);
            this.lblFormula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFormula.ForeColor = System.Drawing.Color.Gray;

            this.btnDemoAge.Text = "📋 Демо (1990 и 2005)";
            this.btnDemoAge.Location = new System.Drawing.Point(460, 30);
            this.btnDemoAge.Size = new System.Drawing.Size(160, 35);
            this.btnDemoAge.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnDemoAge.ForeColor = System.Drawing.Color.White;
            this.btnDemoAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemoAge.Click += new System.EventHandler(this.btnDemoAge_Click);

            this.btnClearHistory.Text = "🗑 Очистить историю";
            this.btnClearHistory.Location = new System.Drawing.Point(460, 75);
            this.btnClearHistory.Size = new System.Drawing.Size(160, 35);
            this.btnClearHistory.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClearHistory.ForeColor = System.Drawing.Color.White;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);

            this.lstHistory.Location = new System.Drawing.Point(15, 160);
            this.lstHistory.Size = new System.Drawing.Size(605, 230);
            this.lstHistory.Font = new System.Drawing.Font("Consolas", 11F);
            this.lstHistory.BackColor = System.Drawing.Color.WhiteSmoke;

            this.grpAge.Controls.Add(this.lblBirthYear);
            this.grpAge.Controls.Add(this.txtBirthYear);
            this.grpAge.Controls.Add(this.lblCurrentYear);
            this.grpAge.Controls.Add(this.txtCurrentYear);
            this.grpAge.Controls.Add(this.btnCalculateAge);
            this.grpAge.Controls.Add(this.lblAgeResult);
            this.grpAge.Controls.Add(this.lblFormula);
            this.grpAge.Controls.Add(this.btnDemoAge);
            this.grpAge.Controls.Add(this.btnClearHistory);
            this.grpAge.Controls.Add(this.lstHistory);

            this.tabAge.Controls.Add(this.grpAge);

            // === Form1 ===
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Методы: Приветствие и Калькулятор возраста";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabControl.ResumeLayout(false);
            this.tabGreeting.ResumeLayout(false);
            this.tabAge.ResumeLayout(false);
            this.grpGreeting.ResumeLayout(false);
            this.grpGreeting.PerformLayout();
            this.grpAge.ResumeLayout(false);
            this.grpAge.PerformLayout();
            this.ResumeLayout(false);
        }

        // Элементы управления
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGreeting;
        private System.Windows.Forms.TabPage tabAge;

        // Вкладка 1
        private System.Windows.Forms.GroupBox grpGreeting;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnDemoThree;
        private System.Windows.Forms.Button btnClearGreetings;
        private System.Windows.Forms.ListBox lstGreetings;

        // Вкладка 2
        private System.Windows.Forms.GroupBox grpAge;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.Label lblCurrentYear;
        private System.Windows.Forms.TextBox txtCurrentYear;
        private System.Windows.Forms.Button btnCalculateAge;
        private System.Windows.Forms.Label lblAgeResult;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Button btnDemoAge;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.ListBox lstHistory;
    }
}