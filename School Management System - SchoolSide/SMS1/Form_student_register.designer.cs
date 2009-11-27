namespace SMS1
{
    partial class Form_student_register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_student_register));
            this.openf = new System.Windows.Forms.OpenFileDialog();
            this.cmd = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adp = new System.Data.SqlClient.SqlDataAdapter();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb8 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb5 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb5 = new System.Windows.Forms.ComboBox();
            this.tb4 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReport31 = new SMS1.CrystalReport3();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     Student.*, parrents.*\r\nFROM         parrents INNER JOIN\r\n             " +
                "         Student ON parrents.Id_parrents = Student.Id_parrents";
            // 
            // adp
            // 
            this.adp.SelectCommand = this.sqlSelectCommand1;
            this.adp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Student", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id_student", "Id_student"),
                        new System.Data.Common.DataColumnMapping("pass_student", "pass_student"),
                        new System.Data.Common.DataColumnMapping("Id_parrents", "Id_parrents"),
                        new System.Data.Common.DataColumnMapping("first_name", "first_name"),
                        new System.Data.Common.DataColumnMapping("last_name", "last_name"),
                        new System.Data.Common.DataColumnMapping("gender", "gender"),
                        new System.Data.Common.DataColumnMapping("birthday", "birthday"),
                        new System.Data.Common.DataColumnMapping("level", "level"),
                        new System.Data.Common.DataColumnMapping("picture", "picture"),
                        new System.Data.Common.DataColumnMapping("Id_class", "Id_class"),
                        new System.Data.Common.DataColumnMapping("Id_parrents1", "Id_parrents1"),
                        new System.Data.Common.DataColumnMapping("pass_parrents", "pass_parrents"),
                        new System.Data.Common.DataColumnMapping("name_parrents", "name_parrents"),
                        new System.Data.Common.DataColumnMapping("last_name1", "last_name1"),
                        new System.Data.Common.DataColumnMapping("tel_parrents", "tel_parrents"),
                        new System.Data.Common.DataColumnMapping("gender1", "gender1")})});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(338, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 27);
            this.label16.TabIndex = 27;
            this.label16.Text = "محل عکس دانش آموز";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb7);
            this.groupBox2.Controls.Add(this.tb6);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tb8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmb5);
            this.groupBox2.Location = new System.Drawing.Point(177, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(277, 276);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "والد";
            // 
            // tb7
            // 
            this.tb7.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb7.Location = new System.Drawing.Point(33, 124);
            this.tb7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(121, 34);
            this.tb7.TabIndex = 11;
            // 
            // tb6
            // 
            this.tb6.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb6.Location = new System.Drawing.Point(33, 79);
            this.tb6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(121, 34);
            this.tb6.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(170, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 27);
            this.label18.TabIndex = 34;
            this.label18.Text = "نام :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.Location = new System.Drawing.Point(170, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 27);
            this.label17.TabIndex = 32;
            this.label17.Text = "نام خانوادگی :";
            // 
            // tb8
            // 
            this.tb8.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb8.Location = new System.Drawing.Point(33, 217);
            this.tb8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb8.Mask = "09000000000";
            this.tb8.Name = "tb8";
            this.tb8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb8.Size = new System.Drawing.Size(121, 34);
            this.tb8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(170, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 27);
            this.label9.TabIndex = 29;
            this.label9.Text = "همراه :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(170, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 27);
            this.label10.TabIndex = 27;
            this.label10.Text = "جنسیت :";
            // 
            // cmb5
            // 
            this.cmb5.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb5.FormattingEnabled = true;
            this.cmb5.Items.AddRange(new object[] {
            "مرد",
            "زن"});
            this.cmb5.Location = new System.Drawing.Point(77, 169);
            this.cmb5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb5.Name = "cmb5";
            this.cmb5.Size = new System.Drawing.Size(77, 35);
            this.cmb5.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb5);
            this.groupBox1.Controls.Add(this.tb4);
            this.groupBox1.Controls.Add(this.cmb2);
            this.groupBox1.Controls.Add(this.cmb3);
            this.groupBox1.Controls.Add(this.cmb4);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb3);
            this.groupBox1.Controls.Add(this.tb2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb1);
            this.groupBox1.Location = new System.Drawing.Point(530, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(278, 403);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دانش آموز";
            // 
            // tb5
            // 
            this.tb5.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb5.FormattingEnabled = true;
            this.tb5.Location = new System.Drawing.Point(7, 329);
            this.tb5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(145, 35);
            this.tb5.TabIndex = 9;
            this.tb5.DropDown += new System.EventHandler(this.tb5_DropDown);
            // 
            // tb4
            // 
            this.tb4.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb4.FormattingEnabled = true;
            this.tb4.Location = new System.Drawing.Point(7, 235);
            this.tb4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(145, 35);
            this.tb4.TabIndex = 5;
            this.tb4.SelectionChangeCommitted += new System.EventHandler(this.tb4_SelectionChangeCommitted);
            // 
            // cmb2
            // 
            this.cmb2.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
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
            "1400  "});
            this.cmb2.Location = new System.Drawing.Point(7, 286);
            this.cmb2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(66, 35);
            this.cmb2.TabIndex = 6;
            // 
            // cmb3
            // 
            this.cmb3.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb3.FormattingEnabled = true;
            this.cmb3.Items.AddRange(new object[] {
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
            this.cmb3.Location = new System.Drawing.Point(77, 286);
            this.cmb3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(48, 35);
            this.cmb3.TabIndex = 7;
            // 
            // cmb4
            // 
            this.cmb4.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb4.FormattingEnabled = true;
            this.cmb4.Items.AddRange(new object[] {
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
            this.cmb4.Location = new System.Drawing.Point(129, 285);
            this.cmb4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(52, 35);
            this.cmb4.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(157, 336);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 27);
            this.label19.TabIndex = 41;
            this.label19.Text = "شناسه کلاس :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(199, 285);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 27);
            this.label15.TabIndex = 38;
            this.label15.Text = "تاریخ تولد  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(166, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "سطح :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(167, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "جنسیت :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(167, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "نام خانوادگی :";
            // 
            // cmb1
            // 
            this.cmb1.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "مرد",
            "زن"});
            this.cmb1.Location = new System.Drawing.Point(6, 195);
            this.cmb1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(145, 35);
            this.cmb1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(166, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 27);
            this.label5.TabIndex = 30;
            this.label5.Text = "نام :";
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb3.Location = new System.Drawing.Point(7, 147);
            this.tb3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(145, 34);
            this.tb3.TabIndex = 3;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb2.Location = new System.Drawing.Point(7, 98);
            this.tb2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(145, 34);
            this.tb2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(163, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "شماره دانش آموزی :";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb1.Location = new System.Drawing.Point(6, 46);
            this.tb1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(145, 34);
            this.tb1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("B Lotus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(393, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 42);
            this.label2.TabIndex = 28;
            this.label2.Text = "تعريف دانش آموز جديد";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::SMS1.Properties.Resources.accept;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(388, 489);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 48);
            this.button3.TabIndex = 16;
            this.toolTip1.SetToolTip(this.button3, "تاييد و چاپ كارت");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::SMS1.Properties.Resources.return_homee;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(468, 489);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 48);
            this.button4.TabIndex = 17;
            this.toolTip1.SetToolTip(this.button4, "بستن پنجره");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::SMS1.Properties.Resources.picture;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(338, 407);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 14;
            this.toolTip1.SetToolTip(this.button2, "افزودن تصوير");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 343);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SMS1.Properties.Resources.display;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(548, 489);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.button1, "نمايش اطلاعات");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 559);
            this.panel1.TabIndex = 29;
            // 
            // Form_student_register
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(985, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Lotus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(155, 190);
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.Name = "Form_student_register";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ثبت نام";
            this.Load += new System.EventHandler(this.Form_student_register_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openf;
        private System.Data.SqlClient.SqlCommand cmd;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter adp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox tb8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.ComboBox cmb3;
        private System.Windows.Forms.ComboBox cmb4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tb5;
        private System.Windows.Forms.ComboBox tb4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private CrystalReport3 crystalReport31;


    }
}