namespace SMS1
{
    partial class Form_Amozesh_register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        main_form adm = new main_form();
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Amozesh_register));
            this.tb1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb6 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.cmb5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.تا = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.Label();
            this.ت = new System.Windows.Forms.Label();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.cmd = new System.Data.SqlClient.SqlCommand();
            this.panel3 = new System.Windows.Forms.Panel();
            this.b3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb1.Location = new System.Drawing.Point(14, 18);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(180, 36);
            this.tb1.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Control;
            this.b1.BackgroundImage = global::SMS1.Properties.Resources.accept;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Location = new System.Drawing.Point(383, 489);
            this.b1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(48, 48);
            this.b1.TabIndex = 13;
            this.toolTip1.SetToolTip(this.b1, "تاييد و چاپ كارت");
            this.b1.UseVisualStyleBackColor = false;
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            this.b1.Click += new System.EventHandler(this.button1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(219, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(14, 59);
            this.tb2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb2.Name = "tb2";
            this.tb2.PasswordChar = '*';
            this.tb2.Size = new System.Drawing.Size(180, 31);
            this.tb2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb2);
            this.panel1.Controls.Add(this.tb1);
            this.panel1.Location = new System.Drawing.Point(499, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 166);
            this.panel1.TabIndex = 6;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "مدير",
            "آموزش",
            "معلم"});
            this.cmb1.Location = new System.Drawing.Point(14, 95);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(180, 32);
            this.cmb1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(217, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "نوع کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(222, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "کلمه عبور :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmb6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmb4);
            this.panel2.Controls.Add(this.cmb3);
            this.panel2.Controls.Add(this.cmb2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tb5);
            this.panel2.Controls.Add(this.cmb5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.تا);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb4);
            this.panel2.Controls.Add(this.tb3);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(499, 226);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 247);
            this.panel2.TabIndex = 7;
            // 
            // cmb6
            // 
            this.cmb6.FormattingEnabled = true;
            this.cmb6.Items.AddRange(new object[] {
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
            "30"});
            this.cmb6.Location = new System.Drawing.Point(118, 166);
            this.cmb6.Name = "cmb6";
            this.cmb6.Size = new System.Drawing.Size(101, 32);
            this.cmb6.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(234, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "سابقه:";
            // 
            // cmb4
            // 
            this.cmb4.FormattingEnabled = true;
            this.cmb4.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            this.cmb4.Location = new System.Drawing.Point(171, 89);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(48, 32);
            this.cmb4.TabIndex = 5;
            // 
            // cmb3
            // 
            this.cmb3.FormattingEnabled = true;
            this.cmb3.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmb3.Location = new System.Drawing.Point(121, 89);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(47, 32);
            this.cmb3.TabIndex = 6;
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "1330",
            "1331",
            "1332",
            "1333",
            "1334",
            "1335",
            "1336",
            "1337",
            "1338",
            "1339",
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400"});
            this.cmb2.Location = new System.Drawing.Point(39, 89);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(76, 32);
            this.cmb2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(234, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "درس تخصصی :";
            // 
            // tb5
            // 
            this.tb5.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb5.Location = new System.Drawing.Point(39, 206);
            this.tb5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(180, 34);
            this.tb5.TabIndex = 10;
            // 
            // cmb5
            // 
            this.cmb5.FormattingEnabled = true;
            this.cmb5.Items.AddRange(new object[] {
            "مرد",
            "زن"});
            this.cmb5.Location = new System.Drawing.Point(118, 130);
            this.cmb5.Name = "cmb5";
            this.cmb5.Size = new System.Drawing.Size(101, 32);
            this.cmb5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(234, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "جنسیت :";
            // 
            // تا
            // 
            this.تا.AutoSize = true;
            this.تا.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.تا.Location = new System.Drawing.Point(234, 89);
            this.تا.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.تا.Name = "تا";
            this.تا.Size = new System.Drawing.Size(60, 24);
            this.تا.TabIndex = 7;
            this.تا.Text = "تاریخ تولد :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(225, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "نام خانوادگی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(247, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "نام :";
            // 
            // tb4
            // 
            this.tb4.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb4.Location = new System.Drawing.Point(39, 48);
            this.tb4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(180, 36);
            this.tb4.TabIndex = 4;
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb3.Location = new System.Drawing.Point(39, 7);
            this.tb3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(180, 36);
            this.tb3.TabIndex = 3;
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.h.ForeColor = System.Drawing.Color.Red;
            this.h.Location = new System.Drawing.Point(274, 40);
            this.h.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(50, 24);
            this.h.TabIndex = 14;
            this.h.Text = "(اختیاری)";
            // 
            // ت
            // 
            this.ت.AutoSize = true;
            this.ت.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ت.Location = new System.Drawing.Point(269, 16);
            this.ت.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ت.Name = "ت";
            this.ت.Size = new System.Drawing.Size(59, 24);
            this.ت.TabIndex = 11;
            this.ت.Text = "توضیحات :";
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(15, 5);
            this.tb6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb6.Multiline = true;
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(240, 232);
            this.tb6.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(81, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "محل تصویر کاربر";
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Transparent;
            this.b2.BackgroundImage = global::SMS1.Properties.Resources.picture;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Location = new System.Drawing.Point(96, 94);
            this.b2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(48, 48);
            this.b2.TabIndex = 11;
            this.b2.Text = "افزودن تصوير";
            this.toolTip1.SetToolTip(this.b2, "افزودن تصوير");
            this.b2.UseVisualStyleBackColor = false;
            this.b2.MouseLeave += new System.EventHandler(this.b2_MouseLeave);
            this.b2.Click += new System.EventHandler(this.button3_Click);
            this.b2.MouseEnter += new System.EventHandler(this.b2_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.b2);
            this.panel3.Location = new System.Drawing.Point(146, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 166);
            this.panel3.TabIndex = 11;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.LavenderBlush;
            this.b3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Location = new System.Drawing.Point(-5, 524);
            this.b3.Margin = new System.Windows.Forms.Padding(1);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(5, 5);
            this.b3.TabIndex = 12;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tb6);
            this.panel4.Controls.Add(this.h);
            this.panel4.Controls.Add(this.ت);
            this.panel4.Location = new System.Drawing.Point(146, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 247);
            this.panel4.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("B Lotus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(414, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 39);
            this.label10.TabIndex = 16;
            this.label10.Text = "معرفي كاربر جديد";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SMS1.Properties.Resources.return_homee;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(468, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 14;
            this.toolTip1.SetToolTip(this.button1, "بستن پنجره");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SMS1.Properties.Resources.display;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(553, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 15;
            this.toolTip1.SetToolTip(this.button2, "نمايش اطلاعات");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(985, 560);
            this.panel5.TabIndex = 19;
            // 
            // Form_Amozesh_register
            // 
            this.AcceptButton = this.b1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b3;
            this.ClientSize = new System.Drawing.Size(985, 560);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label10);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(155, 190);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Amozesh_register";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "معرفي کاربر جدید";
            this.Load += new System.EventHandler(this.Form_Amozesh_register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label تا;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label ت;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.ComboBox cmb5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Data.SqlClient.SqlCommand cmd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.ComboBox cmb4;
        private System.Windows.Forms.ComboBox cmb3;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmb6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel5;
    }
}