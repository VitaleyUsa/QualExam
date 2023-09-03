namespace QualExam
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.group_politics = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.group_network = new System.Windows.Forms.GroupBox();
            this.label_cvalexam = new System.Windows.Forms.Label();
            this.label_test_cvalexam = new System.Windows.Forms.Label();
            this.label_contest = new System.Windows.Forms.Label();
            this.label_test_contest = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.group_usb = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_politics_start = new System.Windows.Forms.Button();
            this.btn_politics_default = new System.Windows.Forms.Button();
            this.btn_network_start = new System.Windows.Forms.Button();
            this.btn_network_default = new System.Windows.Forms.Button();
            this.btn_usb_start = new System.Windows.Forms.Button();
            this.btn_usb_default = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.group_politics.SuspendLayout();
            this.group_network.SuspendLayout();
            this.group_usb.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_politics
            // 
            this.group_politics.BackColor = System.Drawing.SystemColors.Control;
            this.group_politics.Controls.Add(this.label2);
            this.group_politics.Controls.Add(this.label1);
            this.group_politics.Controls.Add(this.label11);
            this.group_politics.Controls.Add(this.label10);
            this.group_politics.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.group_politics.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.group_politics.Location = new System.Drawing.Point(386, 12);
            this.group_politics.Name = "group_politics";
            this.group_politics.Size = new System.Drawing.Size(331, 194);
            this.group_politics.TabIndex = 0;
            this.group_politics.TabStop = false;
            this.group_politics.Text = "Шаг 1: Настройка групповых политик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F);
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(124, 90);
            this.label2.TabIndex = 0;
            this.label2.Text = "   Opera\r\n   Yandex browser\r\n   Google Chrome\r\n   Mozilla Firefox\r\n   Microsoft E" +
    "dge";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "   Запрет запуска любых исполняемых\r\n   программ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label11.Location = new System.Drawing.Point(3, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Запрещающие политики:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label10.Location = new System.Drawing.Point(3, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Разрешающие политики:";
            // 
            // group_network
            // 
            this.group_network.BackColor = System.Drawing.SystemColors.Control;
            this.group_network.Controls.Add(this.label_cvalexam);
            this.group_network.Controls.Add(this.label_test_cvalexam);
            this.group_network.Controls.Add(this.label_contest);
            this.group_network.Controls.Add(this.label_test_contest);
            this.group_network.Controls.Add(this.label8);
            this.group_network.Controls.Add(this.label3);
            this.group_network.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.group_network.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.group_network.Location = new System.Drawing.Point(386, 212);
            this.group_network.Name = "group_network";
            this.group_network.Size = new System.Drawing.Size(331, 188);
            this.group_network.TabIndex = 1;
            this.group_network.TabStop = false;
            this.group_network.Text = "Шаг 2: Сетевые настройки";
            // 
            // label_cvalexam
            // 
            this.label_cvalexam.AutoSize = true;
            this.label_cvalexam.Font = new System.Drawing.Font("Cambria", 9F);
            this.label_cvalexam.Location = new System.Drawing.Point(25, 111);
            this.label_cvalexam.Name = "label_cvalexam";
            this.label_cvalexam.Padding = new System.Windows.Forms.Padding(5);
            this.label_cvalexam.Size = new System.Drawing.Size(154, 24);
            this.label_cvalexam.TabIndex = 0;
            this.label_cvalexam.Text = "https://cvalexam.eisnot.ru";
            // 
            // label_test_cvalexam
            // 
            this.label_test_cvalexam.AutoSize = true;
            this.label_test_cvalexam.Font = new System.Drawing.Font("Cambria", 9F);
            this.label_test_cvalexam.Location = new System.Drawing.Point(25, 87);
            this.label_test_cvalexam.Name = "label_test_cvalexam";
            this.label_test_cvalexam.Padding = new System.Windows.Forms.Padding(5);
            this.label_test_cvalexam.Size = new System.Drawing.Size(177, 24);
            this.label_test_cvalexam.TabIndex = 0;
            this.label_test_cvalexam.Text = "https://test-cvalexam.eisnot.ru";
            // 
            // label_contest
            // 
            this.label_contest.AutoSize = true;
            this.label_contest.Font = new System.Drawing.Font("Cambria", 9F);
            this.label_contest.Location = new System.Drawing.Point(25, 63);
            this.label_contest.Name = "label_contest";
            this.label_contest.Padding = new System.Windows.Forms.Padding(5);
            this.label_contest.Size = new System.Drawing.Size(143, 24);
            this.label_contest.TabIndex = 0;
            this.label_contest.Text = "https://contest.eisnot.ru";
            // 
            // label_test_contest
            // 
            this.label_test_contest.AutoSize = true;
            this.label_test_contest.Font = new System.Drawing.Font("Cambria", 9F);
            this.label_test_contest.Location = new System.Drawing.Point(25, 39);
            this.label_test_contest.Name = "label_test_contest";
            this.label_test_contest.Padding = new System.Windows.Forms.Padding(5);
            this.label_test_contest.Size = new System.Drawing.Size(166, 24);
            this.label_test_contest.TabIndex = 0;
            this.label_test_contest.Text = "https://test-contest.eisnot.ru";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10F);
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Настройка днс-сервера. \r\nИзменение файла hosts.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Доступность сервисов:";
            // 
            // group_usb
            // 
            this.group_usb.BackColor = System.Drawing.SystemColors.Control;
            this.group_usb.Controls.Add(this.label9);
            this.group_usb.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.group_usb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.group_usb.Location = new System.Drawing.Point(386, 406);
            this.group_usb.Name = "group_usb";
            this.group_usb.Size = new System.Drawing.Size(331, 107);
            this.group_usb.TabIndex = 2;
            this.group_usb.TabStop = false;
            this.group_usb.Text = "Шаг 3: Настройка внешних носителей";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10F);
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 64);
            this.label9.TabIndex = 0;
            this.label9.Text = "Запрещающие политики:\r\n\r\n   Доступ к usb - устройствам \r\n   Использование авторск" +
    "ого режима";
            // 
            // btn_politics_start
            // 
            this.btn_politics_start.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_politics_start.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_politics_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_politics_start.Font = new System.Drawing.Font("Arial", 8F);
            this.btn_politics_start.Location = new System.Drawing.Point(723, 21);
            this.btn_politics_start.Name = "btn_politics_start";
            this.btn_politics_start.Size = new System.Drawing.Size(107, 29);
            this.btn_politics_start.TabIndex = 1;
            this.btn_politics_start.Text = "Выполнить";
            this.btn_politics_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_politics_start.UseVisualStyleBackColor = false;
            this.btn_politics_start.Click += new System.EventHandler(this.Btn_politics_start_Click);
            // 
            // btn_politics_default
            // 
            this.btn_politics_default.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_politics_default.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_politics_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_politics_default.Font = new System.Drawing.Font("Arial", 8F);
            this.btn_politics_default.Location = new System.Drawing.Point(723, 56);
            this.btn_politics_default.Name = "btn_politics_default";
            this.btn_politics_default.Size = new System.Drawing.Size(107, 29);
            this.btn_politics_default.TabIndex = 1;
            this.btn_politics_default.Text = "Отменить";
            this.btn_politics_default.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_politics_default.UseVisualStyleBackColor = false;
            this.btn_politics_default.Click += new System.EventHandler(this.Btn_politics_default_Click);
            // 
            // btn_network_start
            // 
            this.btn_network_start.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_network_start.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_network_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_network_start.Font = new System.Drawing.Font("Arial", 8F);
            this.btn_network_start.Location = new System.Drawing.Point(723, 222);
            this.btn_network_start.Name = "btn_network_start";
            this.btn_network_start.Size = new System.Drawing.Size(107, 29);
            this.btn_network_start.TabIndex = 1;
            this.btn_network_start.Text = "Выполнить";
            this.btn_network_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_network_start.UseVisualStyleBackColor = false;
            this.btn_network_start.Click += new System.EventHandler(this.Btn_network_start_Click);
            // 
            // btn_network_default
            // 
            this.btn_network_default.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_network_default.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_network_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_network_default.Font = new System.Drawing.Font("Arial", 8F);
            this.btn_network_default.Location = new System.Drawing.Point(723, 257);
            this.btn_network_default.Name = "btn_network_default";
            this.btn_network_default.Size = new System.Drawing.Size(107, 29);
            this.btn_network_default.TabIndex = 1;
            this.btn_network_default.Text = "Отменить";
            this.btn_network_default.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_network_default.UseVisualStyleBackColor = false;
            this.btn_network_default.Click += new System.EventHandler(this.Btn_network_default_Click);
            // 
            // btn_usb_start
            // 
            this.btn_usb_start.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_usb_start.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_usb_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usb_start.Font = new System.Drawing.Font("Arial", 8F);
            this.btn_usb_start.Location = new System.Drawing.Point(723, 415);
            this.btn_usb_start.Name = "btn_usb_start";
            this.btn_usb_start.Size = new System.Drawing.Size(107, 29);
            this.btn_usb_start.TabIndex = 1;
            this.btn_usb_start.Text = "Выполнить";
            this.btn_usb_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usb_start.UseVisualStyleBackColor = false;
            this.btn_usb_start.Click += new System.EventHandler(this.Btn_usb_start_Click);
            // 
            // btn_usb_default
            // 
            this.btn_usb_default.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_usb_default.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_usb_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usb_default.Font = new System.Drawing.Font("Arial", 8F);
            this.btn_usb_default.Location = new System.Drawing.Point(723, 450);
            this.btn_usb_default.Name = "btn_usb_default";
            this.btn_usb_default.Size = new System.Drawing.Size(107, 29);
            this.btn_usb_default.TabIndex = 1;
            this.btn_usb_default.Text = "Отменить";
            this.btn_usb_default.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usb_default.UseVisualStyleBackColor = false;
            this.btn_usb_default.Click += new System.EventHandler(this.Btn_usb_default_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.LightGray;
            this.textBox2.Location = new System.Drawing.Point(12, 519);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 36);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Ситников Виталий\r\nit@npso66.ru\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Квалификационный экзамен";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.Location = new System.Drawing.Point(13, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.linkLabel1.Size = new System.Drawing.Size(200, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Руководство администраторов";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel2.Location = new System.Drawing.Point(13, 30);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.linkLabel2.Size = new System.Drawing.Size(153, 20);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Руководство секретаря";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel3.Location = new System.Drawing.Point(13, 10);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.linkLabel3.Size = new System.Drawing.Size(154, 20);
            this.linkLabel3.TabIndex = 8;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Процедура проведения";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.linkLabel3);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel2);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 79);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(16, 237);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 276);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Конкурс";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.linkLabel5);
            this.flowLayoutPanel2.Controls.Add(this.linkLabel6);
            this.flowLayoutPanel2.Controls.Add(this.linkLabel7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(36, 151);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(237, 80);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.linkLabel5.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel5.Location = new System.Drawing.Point(13, 10);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.linkLabel5.Size = new System.Drawing.Size(154, 20);
            this.linkLabel5.TabIndex = 8;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Процедура проведения";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.linkLabel6.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel6.Location = new System.Drawing.Point(13, 30);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.linkLabel6.Size = new System.Drawing.Size(153, 20);
            this.linkLabel6.TabIndex = 8;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Руководство секретаря";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel6_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.linkLabel7.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel7.Location = new System.Drawing.Point(13, 50);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.linkLabel7.Size = new System.Drawing.Size(200, 20);
            this.linkLabel7.TabIndex = 8;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Руководство администраторов";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel7_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(852, 555);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_usb_default);
            this.Controls.Add(this.btn_network_default);
            this.Controls.Add(this.btn_usb_start);
            this.Controls.Add(this.btn_network_start);
            this.Controls.Add(this.btn_politics_default);
            this.Controls.Add(this.btn_politics_start);
            this.Controls.Add(this.group_usb);
            this.Controls.Add(this.group_network);
            this.Controls.Add(this.group_politics);
            this.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка рабочего места для квал. экзамена / конкурса";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.group_politics.ResumeLayout(false);
            this.group_politics.PerformLayout();
            this.group_network.ResumeLayout(false);
            this.group_network.PerformLayout();
            this.group_usb.ResumeLayout(false);
            this.group_usb.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_politics;
        private System.Windows.Forms.GroupBox group_network;
        private System.Windows.Forms.GroupBox group_usb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_politics_start;
        private System.Windows.Forms.Button btn_politics_default;
        private System.Windows.Forms.Button btn_network_start;
        private System.Windows.Forms.Button btn_network_default;
        private System.Windows.Forms.Button btn_usb_start;
        private System.Windows.Forms.Button btn_usb_default;
        private System.Windows.Forms.Label label_cvalexam;
        private System.Windows.Forms.Label label_test_cvalexam;
        private System.Windows.Forms.Label label_contest;
        private System.Windows.Forms.Label label_test_contest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
    }
}

