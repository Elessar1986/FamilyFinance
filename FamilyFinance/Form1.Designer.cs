namespace FamilyFinance
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFamilyMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.del_income_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.del_outcome_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ed_members_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ed_income_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ed_outcome_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.add_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familyMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_income_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_outcome_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_fMembers = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_incomeTypes = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_outcomeTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPersInMon = new System.Windows.Forms.Label();
            this.labelPersOutMon = new System.Windows.Forms.Label();
            this.labelPerResMon = new System.Windows.Forms.Label();
            this.labelAllInMon = new System.Windows.Forms.Label();
            this.labelAllOutMon = new System.Windows.Forms.Label();
            this.labelAllResMon = new System.Windows.Forms.Label();
            this.sum_income_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown_outcome_value = new System.Windows.Forms.NumericUpDown();
            this.button_edit_outcome = new System.Windows.Forms.Button();
            this.button_add_outcome = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum_income_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outcome_value)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.editToolStripMenuItem,
            this.add_ToolStripMenuItem,
            this.info_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mainToolStripMenuItem.Text = "Главное";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete_ToolStripMenuItem1,
            this.edit_ToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.editToolStripMenuItem.Text = "Редактировать";
            // 
            // delete_ToolStripMenuItem1
            // 
            this.delete_ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFamilyMemberToolStripMenuItem,
            this.del_income_ToolStripMenuItem,
            this.del_outcome_ToolStripMenuItem});
            this.delete_ToolStripMenuItem1.Name = "delete_ToolStripMenuItem1";
            this.delete_ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.delete_ToolStripMenuItem1.Text = "Удалить";
            // 
            // deleteFamilyMemberToolStripMenuItem
            // 
            this.deleteFamilyMemberToolStripMenuItem.Name = "deleteFamilyMemberToolStripMenuItem";
            this.deleteFamilyMemberToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteFamilyMemberToolStripMenuItem.Text = "Члена семьи";
            this.deleteFamilyMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteFamilyMemberToolStripMenuItem_Click);
            // 
            // del_income_ToolStripMenuItem
            // 
            this.del_income_ToolStripMenuItem.Name = "del_income_ToolStripMenuItem";
            this.del_income_ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.del_income_ToolStripMenuItem.Text = "Источник дохода";
            this.del_income_ToolStripMenuItem.Click += new System.EventHandler(this.del_income_ToolStripMenuItem_Click);
            // 
            // del_outcome_ToolStripMenuItem
            // 
            this.del_outcome_ToolStripMenuItem.Name = "del_outcome_ToolStripMenuItem";
            this.del_outcome_ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.del_outcome_ToolStripMenuItem.Text = "Статью расхода";
            this.del_outcome_ToolStripMenuItem.Click += new System.EventHandler(this.del_outcome_ToolStripMenuItem_Click);
            // 
            // edit_ToolStripMenuItem
            // 
            this.edit_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ed_members_ToolStripMenuItem1,
            this.ed_income_ToolStripMenuItem1,
            this.ed_outcome_ToolStripMenuItem1});
            this.edit_ToolStripMenuItem.Name = "edit_ToolStripMenuItem";
            this.edit_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.edit_ToolStripMenuItem.Text = "Изменить";
            // 
            // ed_members_ToolStripMenuItem1
            // 
            this.ed_members_ToolStripMenuItem1.Name = "ed_members_ToolStripMenuItem1";
            this.ed_members_ToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.ed_members_ToolStripMenuItem1.Text = "Члена семьи";
            this.ed_members_ToolStripMenuItem1.Click += new System.EventHandler(this.ed_members_ToolStripMenuItem1_Click);
            // 
            // ed_income_ToolStripMenuItem1
            // 
            this.ed_income_ToolStripMenuItem1.Name = "ed_income_ToolStripMenuItem1";
            this.ed_income_ToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.ed_income_ToolStripMenuItem1.Text = "Источник дохода";
            // 
            // ed_outcome_ToolStripMenuItem1
            // 
            this.ed_outcome_ToolStripMenuItem1.Name = "ed_outcome_ToolStripMenuItem1";
            this.ed_outcome_ToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.ed_outcome_ToolStripMenuItem1.Text = "Статью расхода";
            // 
            // add_ToolStripMenuItem
            // 
            this.add_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familyMemberToolStripMenuItem,
            this.add_income_ToolStripMenuItem,
            this.add_outcome_ToolStripMenuItem});
            this.add_ToolStripMenuItem.Name = "add_ToolStripMenuItem";
            this.add_ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.add_ToolStripMenuItem.Text = "Добавить";
            // 
            // familyMemberToolStripMenuItem
            // 
            this.familyMemberToolStripMenuItem.Name = "familyMemberToolStripMenuItem";
            this.familyMemberToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.familyMemberToolStripMenuItem.Text = "Члена семьи";
            this.familyMemberToolStripMenuItem.Click += new System.EventHandler(this.familyMemberToolStripMenuItem_Click);
            // 
            // add_income_ToolStripMenuItem
            // 
            this.add_income_ToolStripMenuItem.Name = "add_income_ToolStripMenuItem";
            this.add_income_ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.add_income_ToolStripMenuItem.Text = "Источник дохода";
            this.add_income_ToolStripMenuItem.Click += new System.EventHandler(this.add_income_ToolStripMenuItem_Click);
            // 
            // add_outcome_ToolStripMenuItem
            // 
            this.add_outcome_ToolStripMenuItem.Name = "add_outcome_ToolStripMenuItem";
            this.add_outcome_ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.add_outcome_ToolStripMenuItem.Text = "Статью расхода";
            this.add_outcome_ToolStripMenuItem.Click += new System.EventHandler(this.add_outcome_ToolStripMenuItem_Click);
            // 
            // info_ToolStripMenuItem
            // 
            this.info_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_ToolStripMenuItem});
            this.info_ToolStripMenuItem.Name = "info_ToolStripMenuItem";
            this.info_ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.info_ToolStripMenuItem.Text = "Инфо";
            // 
            // about_ToolStripMenuItem
            // 
            this.about_ToolStripMenuItem.Name = "about_ToolStripMenuItem";
            this.about_ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.about_ToolStripMenuItem.Text = "О программе...";
            this.about_ToolStripMenuItem.Click += new System.EventHandler(this.about_ToolStripMenuItem_Click);
            // 
            // comboBox_fMembers
            // 
            this.comboBox_fMembers.FormattingEnabled = true;
            this.comboBox_fMembers.Items.AddRange(new object[] {
            "1"});
            this.comboBox_fMembers.Location = new System.Drawing.Point(6, 47);
            this.comboBox_fMembers.Name = "comboBox_fMembers";
            this.comboBox_fMembers.Size = new System.Drawing.Size(171, 21);
            this.comboBox_fMembers.TabIndex = 2;
            this.comboBox_fMembers.SelectedIndexChanged += new System.EventHandler(this.comboBox_fMembers_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM  yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Член семьи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(212, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текущий месяц";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 141);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_edit);
            this.tabPage1.Controls.Add(this.button_add);
            this.tabPage1.Controls.Add(this.sum_income_numericUpDown1);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox_incomeTypes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(325, 115);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Доходы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вид дохода";
            // 
            // comboBox_incomeTypes
            // 
            this.comboBox_incomeTypes.FormattingEnabled = true;
            this.comboBox_incomeTypes.Items.AddRange(new object[] {
            "1"});
            this.comboBox_incomeTypes.Location = new System.Drawing.Point(125, 6);
            this.comboBox_incomeTypes.Name = "comboBox_incomeTypes";
            this.comboBox_incomeTypes.Size = new System.Drawing.Size(191, 21);
            this.comboBox_incomeTypes.TabIndex = 0;
            this.comboBox_incomeTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox_incomeTypes_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_edit_outcome);
            this.tabPage2.Controls.Add(this.button_add_outcome);
            this.tabPage2.Controls.Add(this.numericUpDown_outcome_value);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboBox_outcomeTypes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(325, 115);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расходы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вид расхода";
            // 
            // comboBox_outcomeTypes
            // 
            this.comboBox_outcomeTypes.FormattingEnabled = true;
            this.comboBox_outcomeTypes.Location = new System.Drawing.Point(125, 6);
            this.comboBox_outcomeTypes.Name = "comboBox_outcomeTypes";
            this.comboBox_outcomeTypes.Size = new System.Drawing.Size(191, 21);
            this.comboBox_outcomeTypes.TabIndex = 1;
            this.comboBox_outcomeTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox_outcomeTypes_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(373, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Личный доход:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(365, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Личный расход:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(429, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Итого:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(381, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Общий доход:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(373, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Общий расход:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(429, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Итого:";
            // 
            // labelPersInMon
            // 
            this.labelPersInMon.AutoSize = true;
            this.labelPersInMon.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPersInMon.Location = new System.Drawing.Point(491, 50);
            this.labelPersInMon.Name = "labelPersInMon";
            this.labelPersInMon.Size = new System.Drawing.Size(16, 18);
            this.labelPersInMon.TabIndex = 7;
            this.labelPersInMon.Text = "0";
            // 
            // labelPersOutMon
            // 
            this.labelPersOutMon.AutoSize = true;
            this.labelPersOutMon.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPersOutMon.Location = new System.Drawing.Point(491, 75);
            this.labelPersOutMon.Name = "labelPersOutMon";
            this.labelPersOutMon.Size = new System.Drawing.Size(16, 18);
            this.labelPersOutMon.TabIndex = 7;
            this.labelPersOutMon.Text = "0";
            // 
            // labelPerResMon
            // 
            this.labelPerResMon.AutoSize = true;
            this.labelPerResMon.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerResMon.Location = new System.Drawing.Point(491, 101);
            this.labelPerResMon.Name = "labelPerResMon";
            this.labelPerResMon.Size = new System.Drawing.Size(16, 18);
            this.labelPerResMon.TabIndex = 7;
            this.labelPerResMon.Text = "0";
            // 
            // labelAllInMon
            // 
            this.labelAllInMon.AutoSize = true;
            this.labelAllInMon.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllInMon.Location = new System.Drawing.Point(491, 151);
            this.labelAllInMon.Name = "labelAllInMon";
            this.labelAllInMon.Size = new System.Drawing.Size(16, 18);
            this.labelAllInMon.TabIndex = 7;
            this.labelAllInMon.Text = "0";
            // 
            // labelAllOutMon
            // 
            this.labelAllOutMon.AutoSize = true;
            this.labelAllOutMon.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllOutMon.Location = new System.Drawing.Point(491, 176);
            this.labelAllOutMon.Name = "labelAllOutMon";
            this.labelAllOutMon.Size = new System.Drawing.Size(16, 18);
            this.labelAllOutMon.TabIndex = 7;
            this.labelAllOutMon.Text = "0";
            // 
            // labelAllResMon
            // 
            this.labelAllResMon.AutoSize = true;
            this.labelAllResMon.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllResMon.Location = new System.Drawing.Point(491, 201);
            this.labelAllResMon.Name = "labelAllResMon";
            this.labelAllResMon.Size = new System.Drawing.Size(16, 18);
            this.labelAllResMon.TabIndex = 7;
            this.labelAllResMon.Text = "0";
            // 
            // sum_income_numericUpDown1
            // 
            this.sum_income_numericUpDown1.DecimalPlaces = 2;
            this.sum_income_numericUpDown1.Location = new System.Drawing.Point(125, 34);
            this.sum_income_numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.sum_income_numericUpDown1.Name = "sum_income_numericUpDown1";
            this.sum_income_numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.sum_income_numericUpDown1.TabIndex = 8;
            this.sum_income_numericUpDown1.ThousandsSeparator = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(12, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 18);
            this.label17.TabIndex = 7;
            this.label17.Text = "Сумма";
            // 
            // button_add
            // 
            this.button_add.Enabled = false;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(241, 83);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Enabled = false;
            this.button_edit.Location = new System.Drawing.Point(160, 83);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 10;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(12, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 18);
            this.label18.TabIndex = 8;
            this.label18.Text = "Сумма";
            // 
            // numericUpDown_outcome_value
            // 
            this.numericUpDown_outcome_value.DecimalPlaces = 2;
            this.numericUpDown_outcome_value.Location = new System.Drawing.Point(125, 34);
            this.numericUpDown_outcome_value.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_outcome_value.Name = "numericUpDown_outcome_value";
            this.numericUpDown_outcome_value.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_outcome_value.TabIndex = 9;
            this.numericUpDown_outcome_value.ThousandsSeparator = true;
            // 
            // button_edit_outcome
            // 
            this.button_edit_outcome.Enabled = false;
            this.button_edit_outcome.Location = new System.Drawing.Point(160, 83);
            this.button_edit_outcome.Name = "button_edit_outcome";
            this.button_edit_outcome.Size = new System.Drawing.Size(75, 23);
            this.button_edit_outcome.TabIndex = 12;
            this.button_edit_outcome.Text = "Изменить";
            this.button_edit_outcome.UseVisualStyleBackColor = true;
            this.button_edit_outcome.Click += new System.EventHandler(this.button_edit_outcome_Click);
            // 
            // button_add_outcome
            // 
            this.button_add_outcome.Enabled = false;
            this.button_add_outcome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add_outcome.Location = new System.Drawing.Point(241, 83);
            this.button_add_outcome.Name = "button_add_outcome";
            this.button_add_outcome.Size = new System.Drawing.Size(75, 23);
            this.button_add_outcome.TabIndex = 11;
            this.button_add_outcome.Text = "Добавить";
            this.button_add_outcome.UseVisualStyleBackColor = true;
            this.button_add_outcome.Click += new System.EventHandler(this.button_add_outcome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 245);
            this.Controls.Add(this.labelAllResMon);
            this.Controls.Add(this.labelAllOutMon);
            this.Controls.Add(this.labelAllInMon);
            this.Controls.Add(this.labelPerResMon);
            this.Controls.Add(this.labelPersOutMon);
            this.Controls.Add(this.labelPersInMon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_fMembers);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Семейный бюджет";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum_income_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outcome_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familyMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteFamilyMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem del_income_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem del_outcome_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ed_members_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ed_income_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ed_outcome_ToolStripMenuItem1;
        private System.Windows.Forms.ComboBox comboBox_fMembers;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem add_income_ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_incomeTypes;
        private System.Windows.Forms.ToolStripMenuItem add_outcome_ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_outcomeTypes;
        private System.Windows.Forms.ToolStripMenuItem info_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPersInMon;
        private System.Windows.Forms.Label labelPersOutMon;
        private System.Windows.Forms.Label labelPerResMon;
        private System.Windows.Forms.Label labelAllInMon;
        private System.Windows.Forms.Label labelAllOutMon;
        private System.Windows.Forms.Label labelAllResMon;
        private System.Windows.Forms.NumericUpDown sum_income_numericUpDown1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit_outcome;
        private System.Windows.Forms.Button button_add_outcome;
        private System.Windows.Forms.NumericUpDown numericUpDown_outcome_value;
        private System.Windows.Forms.Label label18;
    }
}

