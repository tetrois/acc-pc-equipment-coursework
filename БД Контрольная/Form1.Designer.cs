
namespace БД_Контрольная
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
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBaseDataSet = new БД_Контрольная.MyBaseDataSet();
            this.equipmentTableAdapter = new БД_Контрольная.MyBaseDataSetTableAdapters.EquipmentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnDeleteExportOnce = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.myBaseDataSet;
            // 
            // myBaseDataSet
            // 
            this.myBaseDataSet.DataSetName = "MyBaseDataSet";
            this.myBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 377);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 405);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(213, 433);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(213, 461);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(213, 489);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(172, 22);
            this.textBox6.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Департамент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Кабинет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дата принятия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Серийный номер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "ФИО ответственного";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(213, 517);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(172, 22);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(213, 545);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(172, 22);
            this.textBox8.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 60);
            this.button1.TabIndex = 20;
            this.button1.Text = " Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 60);
            this.button2.TabIndex = 21;
            this.button2.Text = "Редактировать/Обновить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 60);
            this.button3.TabIndex = 22;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID";
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(213, 321);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(172, 22);
            this.textBox0.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 48);
            this.button4.TabIndex = 27;
            this.button4.Text = "Сброс фильтра";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(17, 36);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(329, 22);
            this.textBox9.TabIndex = 26;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(417, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 269);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(17, 225);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(141, 21);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.Text = "Серийный номер";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(17, 199);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 21);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.Text = "Тип";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(17, 172);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(143, 21);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.Text = "ФИО сотрудника";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(17, 145);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(116, 21);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "Дата выдачи";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 118);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Кабинет";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Департамент";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Название";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Тип устройства";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Департамент";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(163, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 24);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(794, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 269);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отбор записей";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(207, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 41);
            this.button6.TabIndex = 33;
            this.button6.Text = "Очистить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 41);
            this.button5.TabIndex = 36;
            this.button5.Text = "Выборка по условиям";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "ФИО ответственного";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(163, 136);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(182, 24);
            this.comboBox4.TabIndex = 34;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Кабинет";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(163, 106);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(182, 24);
            this.comboBox3.TabIndex = 32;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1035, 593);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 60);
            this.button7.TabIndex = 33;
            this.button7.Text = "Режим выгрузки выкл";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 21);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1173, 182);
            this.dataGridView2.TabIndex = 34;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(1040, 209);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(148, 50);
            this.btnExportCSV.TabIndex = 37;
            this.btnExportCSV.Text = "Выгрузить в csv";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(323, 209);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 50);
            this.button9.TabIndex = 36;
            this.button9.Text = "Очистить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnDeleteExportOnce
            // 
            this.btnDeleteExportOnce.Location = new System.Drawing.Point(169, 209);
            this.btnDeleteExportOnce.Name = "btnDeleteExportOnce";
            this.btnDeleteExportOnce.Size = new System.Drawing.Size(148, 50);
            this.btnDeleteExportOnce.TabIndex = 35;
            this.btnDeleteExportOnce.Text = "Удалить";
            this.btnDeleteExportOnce.UseVisualStyleBackColor = true;
            this.btnDeleteExportOnce.Click += new System.EventHandler(this.btnDeleteExportOnce_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.btnDeleteExportOnce);
            this.groupBox3.Controls.Add(this.btnExportCSV);
            this.groupBox3.Location = new System.Drawing.Point(29, 659);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1194, 277);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выберите данные из таблицы сверху которые требуется выгрузить";
            this.groupBox3.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(15, 209);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(148, 50);
            this.button11.TabIndex = 38;
            this.button11.Text = "Добавить в экспорт";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1252, 978);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Учет компьютерной техники кафедры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyBaseDataSet myBaseDataSet;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private MyBaseDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnDeleteExportOnce;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button11;
    }
}

