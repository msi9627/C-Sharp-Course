namespace Employee
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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btSortByExp = new System.Windows.Forms.Button();
            this.tbSortedByExp = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.spinnerPercents = new System.Windows.Forms.NumericUpDown();
            this.btSaveIncreasing = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAfterIncreasing = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbEmpRemove = new System.Windows.Forms.ComboBox();
            this.btRemoveEmp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbEmpInfo = new System.Windows.Forms.ComboBox();
            this.btSaveChanges = new System.Windows.Forms.Button();
            this.spinnerNewYear = new System.Windows.Forms.NumericUpDown();
            this.spinnerNewSalary = new System.Windows.Forms.NumericUpDown();
            this.cbNewMonth = new System.Windows.Forms.ComboBox();
            this.cbNewDay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btShowAll = new System.Windows.Forms.Button();
            this.tbListAll = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.spinnerYear = new System.Windows.Forms.NumericUpDown();
            this.spinnerSalary = new System.Windows.Forms.NumericUpDown();
            this.btSaveNewEmp = new System.Windows.Forms.Button();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.spinnerBonus = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerPercents)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerNewYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerNewSalary)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSalary)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btSortByExp);
            this.tabPage6.Controls.Add(this.tbSortedByExp);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(768, 393);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Сортировка по стажу";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btSortByExp
            // 
            this.btSortByExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSortByExp.Location = new System.Drawing.Point(63, 146);
            this.btSortByExp.Name = "btSortByExp";
            this.btSortByExp.Size = new System.Drawing.Size(250, 93);
            this.btSortByExp.TabIndex = 22;
            this.btSortByExp.Text = "Отсортировать по стажу";
            this.btSortByExp.UseVisualStyleBackColor = true;
            this.btSortByExp.Click += new System.EventHandler(this.btSortByExp_Click);
            // 
            // tbSortedByExp
            // 
            this.tbSortedByExp.Location = new System.Drawing.Point(383, 9);
            this.tbSortedByExp.Multiline = true;
            this.tbSortedByExp.Name = "tbSortedByExp";
            this.tbSortedByExp.Size = new System.Drawing.Size(368, 381);
            this.tbSortedByExp.TabIndex = 21;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.spinnerPercents);
            this.tabPage5.Controls.Add(this.btSaveIncreasing);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.tbAfterIncreasing);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 393);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Изменить ЗП всем";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "процентов";
            // 
            // spinnerPercents
            // 
            this.spinnerPercents.Location = new System.Drawing.Point(223, 165);
            this.spinnerPercents.Name = "spinnerPercents";
            this.spinnerPercents.Size = new System.Drawing.Size(75, 26);
            this.spinnerPercents.TabIndex = 21;
            this.spinnerPercents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btSaveIncreasing
            // 
            this.btSaveIncreasing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveIncreasing.Location = new System.Drawing.Point(175, 339);
            this.btSaveIncreasing.Name = "btSaveIncreasing";
            this.btSaveIncreasing.Size = new System.Drawing.Size(201, 39);
            this.btSaveIncreasing.TabIndex = 20;
            this.btSaveIncreasing.Text = "Сохранить";
            this.btSaveIncreasing.UseVisualStyleBackColor = true;
            this.btSaveIncreasing.Click += new System.EventHandler(this.btSaveIncreasing_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Изменить всем зарплату на";
            // 
            // tbAfterIncreasing
            // 
            this.tbAfterIncreasing.Location = new System.Drawing.Point(394, 9);
            this.tbAfterIncreasing.Multiline = true;
            this.tbAfterIncreasing.Name = "tbAfterIncreasing";
            this.tbAfterIncreasing.Size = new System.Drawing.Size(368, 381);
            this.tbAfterIncreasing.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbEmpRemove);
            this.tabPage4.Controls.Add(this.btRemoveEmp);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbEmpRemove
            // 
            this.cbEmpRemove.FormattingEnabled = true;
            this.cbEmpRemove.Location = new System.Drawing.Point(10, 52);
            this.cbEmpRemove.Name = "cbEmpRemove";
            this.cbEmpRemove.Size = new System.Drawing.Size(752, 28);
            this.cbEmpRemove.TabIndex = 21;
            // 
            // btRemoveEmp
            // 
            this.btRemoveEmp.Location = new System.Drawing.Point(561, 332);
            this.btRemoveEmp.Name = "btRemoveEmp";
            this.btRemoveEmp.Size = new System.Drawing.Size(201, 55);
            this.btRemoveEmp.TabIndex = 20;
            this.btRemoveEmp.Text = "Удалить";
            this.btRemoveEmp.UseVisualStyleBackColor = true;
            this.btRemoveEmp.Click += new System.EventHandler(this.btRemoveEmp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Удалить данные о сотруднике";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbEmpInfo);
            this.tabPage3.Controls.Add(this.btSaveChanges);
            this.tabPage3.Controls.Add(this.spinnerNewYear);
            this.tabPage3.Controls.Add(this.spinnerNewSalary);
            this.tabPage3.Controls.Add(this.cbNewMonth);
            this.tabPage3.Controls.Add(this.cbNewDay);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbNewName);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Редактировать";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbEmpInfo
            // 
            this.cbEmpInfo.FormattingEnabled = true;
            this.cbEmpInfo.Location = new System.Drawing.Point(309, 4);
            this.cbEmpInfo.Name = "cbEmpInfo";
            this.cbEmpInfo.Size = new System.Drawing.Size(453, 28);
            this.cbEmpInfo.TabIndex = 20;
            this.cbEmpInfo.SelectedIndexChanged += new System.EventHandler(this.cbEmpInfo_SelectedIndexChanged);
            // 
            // btSaveChanges
            // 
            this.btSaveChanges.Location = new System.Drawing.Point(561, 332);
            this.btSaveChanges.Name = "btSaveChanges";
            this.btSaveChanges.Size = new System.Drawing.Size(201, 55);
            this.btSaveChanges.TabIndex = 19;
            this.btSaveChanges.Text = "Сохранить";
            this.btSaveChanges.UseVisualStyleBackColor = true;
            this.btSaveChanges.Click += new System.EventHandler(this.btSaveChanges_Click);
            // 
            // spinnerNewYear
            // 
            this.spinnerNewYear.Enabled = false;
            this.spinnerNewYear.Location = new System.Drawing.Point(432, 227);
            this.spinnerNewYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.spinnerNewYear.Minimum = new decimal(new int[] {
            1922,
            0,
            0,
            0});
            this.spinnerNewYear.Name = "spinnerNewYear";
            this.spinnerNewYear.Size = new System.Drawing.Size(120, 26);
            this.spinnerNewYear.TabIndex = 18;
            this.spinnerNewYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // spinnerNewSalary
            // 
            this.spinnerNewSalary.DecimalPlaces = 2;
            this.spinnerNewSalary.Enabled = false;
            this.spinnerNewSalary.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.spinnerNewSalary.Location = new System.Drawing.Point(123, 158);
            this.spinnerNewSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinnerNewSalary.Name = "spinnerNewSalary";
            this.spinnerNewSalary.Size = new System.Drawing.Size(283, 26);
            this.spinnerNewSalary.TabIndex = 17;
            // 
            // cbNewMonth
            // 
            this.cbNewMonth.Enabled = false;
            this.cbNewMonth.FormattingEnabled = true;
            this.cbNewMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNewMonth.Location = new System.Drawing.Point(284, 226);
            this.cbNewMonth.Name = "cbNewMonth";
            this.cbNewMonth.Size = new System.Drawing.Size(121, 28);
            this.cbNewMonth.TabIndex = 16;
            this.cbNewMonth.Text = "Месяц";
            // 
            // cbNewDay
            // 
            this.cbNewDay.Enabled = false;
            this.cbNewDay.FormattingEnabled = true;
            this.cbNewDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbNewDay.Location = new System.Drawing.Point(143, 226);
            this.cbNewDay.Name = "cbNewDay";
            this.cbNewDay.Size = new System.Drawing.Size(121, 28);
            this.cbNewDay.TabIndex = 15;
            this.cbNewDay.Text = "День";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "Введите дату\r\nприема";
            // 
            // tbNewName
            // 
            this.tbNewName.Enabled = false;
            this.tbNewName.Location = new System.Drawing.Point(123, 97);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(639, 26);
            this.tbNewName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Введите ЗП";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Введите имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Редактировать данные о сотруднике";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btShowAll);
            this.tabPage2.Controls.Add(this.tbListAll);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(79, 155);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(200, 69);
            this.btShowAll.TabIndex = 1;
            this.btShowAll.Text = "Вывести список всех сотрудников";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // tbListAll
            // 
            this.tbListAll.Location = new System.Drawing.Point(394, 12);
            this.tbListAll.Multiline = true;
            this.tbListAll.Name = "tbListAll";
            this.tbListAll.Size = new System.Drawing.Size(368, 381);
            this.tbListAll.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.spinnerBonus);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbPosition);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.spinnerYear);
            this.tabPage1.Controls.Add(this.spinnerSalary);
            this.tabPage1.Controls.Add(this.btSaveNewEmp);
            this.tabPage1.Controls.Add(this.cbMonth);
            this.tabPage1.Controls.Add(this.cbDay);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.labelSalary);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // spinnerYear
            // 
            this.spinnerYear.Location = new System.Drawing.Point(432, 192);
            this.spinnerYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.spinnerYear.Minimum = new decimal(new int[] {
            1922,
            0,
            0,
            0});
            this.spinnerYear.Name = "spinnerYear";
            this.spinnerYear.Size = new System.Drawing.Size(120, 26);
            this.spinnerYear.TabIndex = 10;
            this.spinnerYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // spinnerSalary
            // 
            this.spinnerSalary.DecimalPlaces = 2;
            this.spinnerSalary.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.spinnerSalary.Location = new System.Drawing.Point(123, 123);
            this.spinnerSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinnerSalary.Name = "spinnerSalary";
            this.spinnerSalary.Size = new System.Drawing.Size(283, 26);
            this.spinnerSalary.TabIndex = 9;
            // 
            // btSaveNewEmp
            // 
            this.btSaveNewEmp.Location = new System.Drawing.Point(561, 332);
            this.btSaveNewEmp.Name = "btSaveNewEmp";
            this.btSaveNewEmp.Size = new System.Drawing.Size(201, 55);
            this.btSaveNewEmp.TabIndex = 8;
            this.btSaveNewEmp.Text = "Сохранить";
            this.btSaveNewEmp.UseVisualStyleBackColor = true;
            this.btSaveNewEmp.Click += new System.EventHandler(this.btSaveNewEmp_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(284, 191);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 28);
            this.cbMonth.TabIndex = 6;
            this.cbMonth.Text = "Месяц";
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDay.Location = new System.Drawing.Point(143, 191);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 28);
            this.cbDay.TabIndex = 5;
            this.cbDay.Text = "День";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите дату\r\nприема";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(123, 62);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(639, 26);
            this.tbName.TabIndex = 2;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(7, 125);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(103, 20);
            this.labelSalary.TabIndex = 1;
            this.labelSalary.Text = "Введите ЗП";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Введите имя";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выберите должность";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Сотрудник",
            "Менеджер"});
            this.cbPosition.Location = new System.Drawing.Point(188, 13);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(574, 28);
            this.cbPosition.TabIndex = 12;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // spinnerBonus
            // 
            this.spinnerBonus.DecimalPlaces = 2;
            this.spinnerBonus.Enabled = false;
            this.spinnerBonus.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.spinnerBonus.Location = new System.Drawing.Point(543, 123);
            this.spinnerBonus.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinnerBonus.Name = "spinnerBonus";
            this.spinnerBonus.Size = new System.Drawing.Size(219, 26);
            this.spinnerBonus.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Размер премии";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Работа с сотрудниками";
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerPercents)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerNewYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerNewSalary)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSalary)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinnerBonus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btSortByExp;
        private System.Windows.Forms.TextBox tbSortedByExp;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spinnerPercents;
        private System.Windows.Forms.Button btSaveIncreasing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAfterIncreasing;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btRemoveEmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btSaveChanges;
        private System.Windows.Forms.NumericUpDown spinnerNewYear;
        private System.Windows.Forms.NumericUpDown spinnerNewSalary;
        private System.Windows.Forms.ComboBox cbNewMonth;
        private System.Windows.Forms.ComboBox cbNewDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btShowAll;
        private System.Windows.Forms.TextBox tbListAll;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown spinnerYear;
        private System.Windows.Forms.NumericUpDown spinnerSalary;
        private System.Windows.Forms.Button btSaveNewEmp;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cbEmpInfo;
        private System.Windows.Forms.ComboBox cbEmpRemove;
        private System.Windows.Forms.NumericUpDown spinnerBonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label4;
    }
}

