namespace FinalDraft
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.InitialEquation = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.ThemeName = new System.Windows.Forms.ListBox();
            this.MethodName = new System.Windows.Forms.ListBox();
            this.DimensionalMethods = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fault = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Limitation = new System.Windows.Forms.TextBox();
            this.StartingPoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Сalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ChekFunction = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныеФункцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.function33 = new System.Windows.Forms.ToolStripMenuItem();
            this.function34 = new System.Windows.Forms.ToolStripMenuItem();
            this.function35 = new System.Windows.Forms.ToolStripMenuItem();
            this.function36 = new System.Windows.Forms.ToolStripMenuItem();
            this.function37 = new System.Windows.Forms.ToolStripMenuItem();
            this.function38 = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходная функция:";
            // 
            // InitialEquation
            // 
            this.InitialEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitialEquation.Location = new System.Drawing.Point(14, 76);
            this.InitialEquation.Name = "InitialEquation";
            this.InitialEquation.Size = new System.Drawing.Size(454, 30);
            this.InitialEquation.TabIndex = 1;
            this.InitialEquation.TextChanged += new System.EventHandler(this.InitialEquation_TextChanged);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(1138, 593);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(130, 40);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ThemeName
            // 
            this.ThemeName.FormattingEnabled = true;
            this.ThemeName.ItemHeight = 22;
            this.ThemeName.Location = new System.Drawing.Point(407, 310);
            this.ThemeName.Name = "ThemeName";
            this.ThemeName.Size = new System.Drawing.Size(360, 70);
            this.ThemeName.TabIndex = 3;
            this.ThemeName.SelectedIndexChanged += new System.EventHandler(this.ThemeName_SelectedIndexChanged);
            // 
            // MethodName
            // 
            this.MethodName.FormattingEnabled = true;
            this.MethodName.ItemHeight = 22;
            this.MethodName.Location = new System.Drawing.Point(407, 398);
            this.MethodName.Name = "MethodName";
            this.MethodName.Size = new System.Drawing.Size(360, 136);
            this.MethodName.TabIndex = 4;
            // 
            // DimensionalMethods
            // 
            this.DimensionalMethods.FormattingEnabled = true;
            this.DimensionalMethods.ItemHeight = 22;
            this.DimensionalMethods.Location = new System.Drawing.Point(12, 310);
            this.DimensionalMethods.Name = "DimensionalMethods";
            this.DimensionalMethods.Size = new System.Drawing.Size(360, 224);
            this.DimensionalMethods.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите метод одномерного поиска:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(402, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите метод многомерного поиска:";
            // 
            // Fault
            // 
            this.Fault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fault.Location = new System.Drawing.Point(355, 159);
            this.Fault.Name = "Fault";
            this.Fault.Size = new System.Drawing.Size(111, 30);
            this.Fault.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Точность локализации минимума:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ограничение количества итераций:";
            // 
            // Limitation
            // 
            this.Limitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Limitation.Location = new System.Drawing.Point(355, 207);
            this.Limitation.Name = "Limitation";
            this.Limitation.Size = new System.Drawing.Size(111, 30);
            this.Limitation.TabIndex = 11;
            // 
            // StartingPoint
            // 
            this.StartingPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartingPoint.Location = new System.Drawing.Point(474, 76);
            this.StartingPoint.Name = "StartingPoint";
            this.StartingPoint.Size = new System.Drawing.Size(122, 30);
            this.StartingPoint.TabIndex = 12;
            this.toolTip1.SetToolTip(this.StartingPoint, "Если значение не введено, точки равны 0");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(469, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Начальные точки:";
            // 
            // Сalculate
            // 
            this.Сalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сalculate.Location = new System.Drawing.Point(14, 593);
            this.Сalculate.Name = "Сalculate";
            this.Сalculate.Size = new System.Drawing.Size(130, 40);
            this.Сalculate.TabIndex = 14;
            this.Сalculate.Text = "Вычислить";
            this.Сalculate.UseVisualStyleBackColor = true;
            this.Сalculate.Click += new System.EventHandler(this.Сalculate_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1136, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChekFunction
            // 
            this.ChekFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChekFunction.Location = new System.Drawing.Point(166, 593);
            this.ChekFunction.Name = "ChekFunction";
            this.ChekFunction.Size = new System.Drawing.Size(130, 40);
            this.ChekFunction.TabIndex = 16;
            this.ChekFunction.Text = "Проверка";
            this.ChekFunction.UseVisualStyleBackColor = true;
            this.ChekFunction.Click += new System.EventHandler(this.ChekFunction_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(680, 76);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(586, 116);
            this.Result.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(74, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(675, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Результат:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 36);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартныеФункцииToolStripMenuItem,
            this.дополнительныеНастройкиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // стандартныеФункцииToolStripMenuItem
            // 
            this.стандартныеФункцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.function33,
            this.function34,
            this.function35,
            this.function36,
            this.function37,
            this.function38});
            this.стандартныеФункцииToolStripMenuItem.Name = "стандартныеФункцииToolStripMenuItem";
            this.стандартныеФункцииToolStripMenuItem.Size = new System.Drawing.Size(359, 32);
            this.стандартныеФункцииToolStripMenuItem.Text = "Стандартные функции";
            // 
            // function33
            // 
            this.function33.Name = "function33";
            this.function33.Size = new System.Drawing.Size(1128, 32);
            this.function33.Text = "(1,5 - x1*(1 - x2))^2 + (2,25 - x1*(1 - x2^2))^2 + (2,625 - x1*(1 - x2^3))^2";
            this.function33.ToolTipText = "Минимум функции: [3 ; 0,5]";
            this.function33.Click += new System.EventHandler(this.function33_Click);
            // 
            // function34
            // 
            this.function34.Name = "function34";
            this.function34.Size = new System.Drawing.Size(1128, 32);
            this.function34.Text = "(x1 + 10*x2)^2 + 5*(x3 - x4)^2 + (x2 - 2*x3)^4 + 10*(x1 - x4)^4";
            this.function34.ToolTipText = "Миниум функции: [0 ; 0 ; 0; 0 ]\r\nМатрица Гесса в точке x* синулярна";
            this.function34.Click += new System.EventHandler(this.function34_Click);
            // 
            // function35
            // 
            this.function35.Name = "function35";
            this.function35.Size = new System.Drawing.Size(1128, 32);
            this.function35.Text = "100*(x2 - x1^2)^2 + (1 - x1)^2 + 90*(x4 - x3^2)^2 + (1 - x3)^3 + 10,1*((x2 - 1)^2" +
    " + (x4 - 1)^2) + 19,8*(x2 - 1)*(x4 - 1)";
            this.function35.ToolTipText = "Минимум функции [1 ; 1 ; 1 ; 1]";
            this.function35.Click += new System.EventHandler(this.function35_Click);
            // 
            // function36
            // 
            this.function36.Name = "function36";
            this.function36.Size = new System.Drawing.Size(1128, 32);
            this.function36.Text = "(2*x1^2 + 3*x2^2)*exp(x1^2 - x2^2)";
            this.function36.ToolTipText = "Минимум функции: [0 ; 0]\r\nФункция не унимодальна";
            this.function36.Click += new System.EventHandler(this.function36_Click);
            // 
            // function37
            // 
            this.function37.Name = "function37";
            this.function37.Size = new System.Drawing.Size(1128, 32);
            this.function37.Text = "0,1*(12 + x1^2 + (1 + x2^2)/(x1^2) + (x1^2*x2^2 + 100)/(x1^4*x2^4))";
            this.function37.ToolTipText = "Минимум функции: [1,743 ; 2,036]\r\n";
            this.function37.Click += new System.EventHandler(this.function37_Click);
            // 
            // function38
            // 
            this.function38.Name = "function38";
            this.function38.Size = new System.Drawing.Size(1128, 32);
            this.function38.Text = "100*(x3 - 0,25*(x1 + x2)^2)^2 + (1 - x1)^2 + (1 - x2)^2";
            this.function38.ToolTipText = "Минимум функции: [1 ; 1 ; 1]";
            this.function38.Click += new System.EventHandler(this.function38_Click);
            // 
            // дополнительныеНастройкиToolStripMenuItem
            // 
            this.дополнительныеНастройкиToolStripMenuItem.Name = "дополнительныеНастройкиToolStripMenuItem";
            this.дополнительныеНастройкиToolStripMenuItem.Size = new System.Drawing.Size(359, 32);
            this.дополнительныеНастройкиToolStripMenuItem.Text = "Дополнительные настройки";
            this.дополнительныеНастройкиToolStripMenuItem.Click += new System.EventHandler(this.дополнительныеНастройкиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(359, 32);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(316, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 21;
            this.button2.Text = "Записать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 645);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ChekFunction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Сalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StartingPoint);
            this.Controls.Add(this.Limitation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fault);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DimensionalMethods);
            this.Controls.Add(this.MethodName);
            this.Controls.Add(this.ThemeName);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.InitialEquation);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Исследование многомерных функций";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        /// <summary>
        /// TextBox, который служит окошком для ввода целевой функции
        /// </summary>
        private System.Windows.Forms.TextBox InitialEquation;
        /// <summary>
        /// Кнопка выхода из программы
        /// </summary>
        private System.Windows.Forms.Button Exit;
        /// <summary>
        /// ListBox, который выводит классификацию методов многомерного поиска
        /// </summary>
        private System.Windows.Forms.ListBox ThemeName;
        /// <summary>
        /// ListBox, который выводит названия методов многомерного поиска
        /// </summary>
        private System.Windows.Forms.ListBox MethodName;
        /// <summary>
        /// ListBox, который выводит названия методов одномерного писка
        /// </summary>
        private System.Windows.Forms.ListBox DimensionalMethods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// TextBox точности локализации
        /// </summary>
        private System.Windows.Forms.TextBox Fault;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        /// <summary>
        /// TextBox ограничения количества итераций
        /// </summary>
        private System.Windows.Forms.TextBox Limitation;
        /// <summary>
        /// TextBox начальных точек
        /// </summary>
        private System.Windows.Forms.TextBox StartingPoint;
        private System.Windows.Forms.Label label6;
        /// <summary>
        /// Button, который запускает выбранный алгоритм и выводит результат на экран
        /// </summary>
        private System.Windows.Forms.Button Сalculate;
        /// <summary>
        /// Клавиша, которая реагирует на нажате Enter
        /// </summary>
        private System.Windows.Forms.Button button1;
        /// <summary>
        /// Button для проверки парсера
        /// </summary>
        private System.Windows.Forms.Button ChekFunction;
        /// <summary>
        /// TextBox для вывода результата работ программы
        /// </summary>
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныеФункцииToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem function33;
        private System.Windows.Forms.ToolStripMenuItem function34;
        private System.Windows.Forms.ToolStripMenuItem function35;
        private System.Windows.Forms.ToolStripMenuItem function36;
        private System.Windows.Forms.ToolStripMenuItem function37;
        private System.Windows.Forms.ToolStripMenuItem function38;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}

