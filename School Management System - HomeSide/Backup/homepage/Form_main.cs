using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using farhaniPersianDate;
using FarsiMessageBox;
using System.IO;



namespace homepage
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();

        }
        //***************************************
        protected Timer m_Timer;
        string pass;
        static int op1, op2, op3, op4;
        int id_election;
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataReader rdr;
        ArrayList arr = new ArrayList();
        string name, family;
        string id_class;

        Form1 frm = new Form1();
        //***************************************
        private void b_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ایمیلToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ایمیلToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }

        private void اطلاعیهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // Form_dailywords dailywordsfrm = new Form_dailywords();
            //dailywordsfrm.ShowDialog();
        }

        private void نظرسنجیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from participated where id_sudent_participated=" + frm.ID.ToString() + " and id_election in(select id_election from Election_archive where active='true')";
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                  //  FMessageBox.Show("شما قبلا این نظرسنجی را پاسخ دادهاید ", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    button9.Enabled = false;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();
            }

            tabControl1.SelectedTab = tabPage5;

        }


        int x = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Location.X + 150 == (panel1.Location.X + panel1.Size.Width))
            {
                x = 0;
            }
            x++;
            label1.Location = new System.Drawing.Point(-(label1.Size.Width) + x, 30);
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
           
           
            
            //********************************************************************
            tabControl1.Size = new System.Drawing.Size(this.Size.Width, 518);
            panel1.Size = new System.Drawing.Size(this.Size.Width - 30, 60);
            groupBox1.Size = new System.Drawing.Size(this.Size.Width - 30, 117);
            this.panel1.Location = new System.Drawing.Point((this.Size.Width / 2) - (panel1.Size.Width / 2), 61);
            this.label11.Location = new System.Drawing.Point(283, 11);
            this.comboBox4.Location = new System.Drawing.Point(209, 7);
            this.label12.Location = new System.Drawing.Point(169, 12);
            this.comboBox3.Location = new System.Drawing.Point(74, 6);
            this.button3.Location = new System.Drawing.Point(344, 9);
            this.dataGridView1.Size = new System.Drawing.Size(tabPage1.Size.Width - 130, 319);
            //**********************************************************************tabpage3
            this.dataGridView2.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView2.Size.Width / 2, 134);
            this.comboBox1.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView2.Size.Width / 2, 36);
            this.button2.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView2.Size.Width / 2, 88);
            this.button1.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView2.Size.Width / 2 + 166, 88);

            this.label15.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView2.Size.Width / 2 + 224, 41);

            this.domainUpDown1.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView2.Size.Width / 2 + 134, 36);
            this.label13.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView2.Size.Width / 2 + 95, 41);

            //**********************************************************************tabpage9
            this.dataGrid1.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGrid1.Size.Width / 2, 75);
            this.label14.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGrid1.Size.Width / 2 + 127, 35);
            this.comboBox2.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGrid1.Size.Width / 2, 32);
            this.button4.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGrid1.Size.Width / 2 + 192, 32);

            //***************************************************************************tabpage4
            this.t4.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2, 217);
            this.l6.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2 + 397, 404);
            this.b1.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2, 404);

            this.l4.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2, 182);
            this.t3.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2, 138);
            this.l5.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2 + 425, 404);
            this.l3.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2 + 213, 138);
            this.t2.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2, 98);
            this.l2.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2 + 213, 98);
            this.l1.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2 + 188, 30);
            this.t1.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - t4.Size.Width / 2 + 269, 30);
            //**************************************************************************tabpage8
            this.button7.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - textBox1.Size.Width / 2 + 60, 268);
            this.lb3.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - textBox1.Size.Width / 2 + 220, 206);
            this.lb2.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - textBox1.Size.Width / 2 + 220, 124);
            this.lb1.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - textBox1.Size.Width / 2 + 220, 89);
            this.textBox3.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - textBox1.Size.Width / 2, 199);
            this.textBox2.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - textBox1.Size.Width / 2, 124);
            this.textBox1.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - textBox1.Size.Width / 2, 86);



            //***************************************************************************tabpage7
            this.dataGridView3.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView3.Size.Width / 2, 106);
            this.button5.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView3.Size.Width / 2, 31);
            this.dataGridView4.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGridView3.Size.Width / 2, 72);
            //***********************************************************************tabpage6
            this.dataGrid2.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGrid2.Size.Width / 2, 25);
            this.button6.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - dataGrid2.Size.Width / 2 + 125, 381);
            //************************************************************************tabpage5
            this.groupBox3.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - groupBox3.Size.Width / 2, 112);
            this.button9.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - groupBox3.Size.Width / 2 + 690, 27);
            this.groupBox2.Location = new System.Drawing.Point(tabControl1.Size.Width / 2 - groupBox3.Size.Width / 2, 12);
            //*********************************************************************
            frm.con.Open();
            cDate date = new cDate();
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;
            string strdate = year.ToString() + "/" + month.ToString() + "/" + day.ToString();
            cmd.Connection = frm.con;
            cmd.CommandType = CommandType.Text;
            //  MessageBox.Show(strdate);
            cmd.CommandText = "select * from daily_words where date='" + strdate + "'";
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    panel1.Visible = true;
                    label1.Text = rdr.GetString(1);
                }


            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);

            }
            finally
            {
                frm.con.Close();

            }

            /////////////////////////////////////
            frm.con.Open();
            cmd.Connection = frm.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select student.first_name,student.last_name,student.Id_student,student.level,"
                + "parrents.name_parrents,parrents.tel_parrents from student,parrents where "
                + "student.Id_parrents=parrents.Id_parrents and student.Id_student='" + frm.ID + "'";
            try
            {

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    name = rdr.GetString(0);
                    family = rdr.GetString(1);
                    label3.Text += rdr.GetString(0);
                    label4.Text += rdr.GetString(1);
                    label5.Text += rdr.GetValue(2).ToString();
                    label8.Text += rdr.GetString(3);
                    label6.Text += rdr.GetString(4);
                    label7.Text += rdr.GetValue(5).ToString();
                }


            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }
            finally
            {
                frm.con.Close();

            }
            ///////////////////////////////////////////////////////////
            cmd.Connection = frm.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "active_election";
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    label10.Text = rdr.GetString(1);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();
            }
            /////////////////////////////////////////////////////

            if (tabControl1.SelectedTab == tabPage1)
            {
                cmd.Connection = frm.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "active_election";
                try
                {
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        label10.Text = rdr.GetString(1) + "\n\r" + rdr.GetString(2) + "\n\r" + rdr.GetString(3) + "\n\r" + rdr.GetString(4) + "\n\r" + rdr.GetString(5);

                    }


                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                   
                }
            }
            Form_chart chert = new Form_chart();
            chert.ShowDialog();
        }
        private void اطلاعیهToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   Form_downloadebook downloadfrm = new Form_downloadebook();
           // downloadfrm.ShowDialog();
            tabControl1.SelectedTab = tabPage6;
        }

        private void برنامههفتگیToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  Form_barname barname_frm = new Form_barname();
          //  barname_frm.ShowDialog();
            tabControl1.SelectedTab = tabPage7;
        }

        private void نمراتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ماهیانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form_monthgrade monthgradefrm = new Form_monthgrade();
            // monthgradefrm.ShowDialog();
            tabControl1.SelectedTab = tabPage2;
        }

        private void ترمToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form_termgrade termgradefrm = new Form_termgrade();
          //  termgradefrm.ShowDialog();
            tabControl1.SelectedTab = tabPage3;
        }

        private void تغییرکلمهعبورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void باToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form_testarchive testarchivefrm = new Form_testarchive();
           // testarchivefrm.ShowDialog();
            tabControl1.SelectedTab = tabPage8;
        }

        private void آرشیوToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form_mail mailfrm = new Form_mail();
           /// mailfrm.ShowDialog();
            tabControl1.SelectedTab = tabPage4;
        }

        private void تنظیماتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form_editpass editpassfrm = new Form_editpass();
          //  editpassfrm.ShowDialog();
            tabControl1.SelectedTab = tabPage9;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id;
            id = frm.ID;
            if (frm.ID.Substring(0, 1) == "p")
            {
                id = frm.ID.Substring(1, frm.ID.Length);
            }
            int r = 0;
            int t = 0;
            for (t = 0; t < dataGridView1.RowCount; t++)
                for (r = 1; r < dataGridView1.ColumnCount; r++)
                    dataGridView1.Rows[t].Cells[r].Value = "";
            dataGridView1.Enabled = true;
            string str;
            int y = 0;
            int k = 0;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from month_view where Id_term in (select Id_term from class_lesson where Id_student=" + id + ") and "
            + " date Like N'" + comboBox3.Text + comboBox4.Text + "%'";
            try
            {

                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    y = 0;
                    str = rdr.GetString(2);
                    str = str.Substring(6, 2);
                    k = Int16.Parse(str);
                    while (y < dataGridView1.RowCount)
                    {
                        if (dataGridView1.Rows[y].Cells[0].Value.ToString() == rdr.GetString(0))
                        {
                            dataGridView1.Rows[y].Cells[k].Value = rdr.GetDouble(3).ToString();
                            dataGridView1.Rows[y].Cells[k].Tag = "true";
                            // MessageBox.Show(y+"     "+k);
                            break;
                        }
                        y++;

                    }
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex <= 5)
            {

                dataGridView1.ColumnCount = 32;
                dataGridView1.Columns[31].HeaderText = "31";
            }
            else
            {
                dataGridView1.ColumnCount = 31;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    dataGridView1.Rows[i].Cells[j].Value = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    dataGridView1.Rows[i].Cells[j].Value = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                cmd.Connection = frm.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "active_election";
                try
                {
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {

                        label10.Text = rdr.GetString(1)+"\n\r"  + rdr.GetString(2) +"\n\r" + rdr.GetString(3) + "\n\r" + rdr.GetString(4) + "\n\r" + rdr.GetString(5);
                     
                    }


                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                }
            }
          //************************************************************************************
            if (tabControl1.SelectedTab == tabPage2)
            {
                comboBox3.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;


                //**********************************
                int x = 0;
                string id;
                id = frm.ID;
                if (frm.ID.Substring(0, 1) == "p")
                {
                    id = frm.ID.Substring(1, frm.ID.Length);
                }
                cmd.CommandType = CommandType.Text;
                cmd.Connection = frm.con;
                cmd.CommandText = "select distinct lesson.lesson from days_sch,lesson  where lesson.id_lesson=days_sch.Id_lesson and" +
                    " id_class in(select id_class from student where id_student=" + id + ")";
                dataGridView1.Rows.Clear();
                try
                {

                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[x].Cells[0].Value = rdr.GetString(0);
                        x++;
                    }


                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                }
            }
            //***********************************************************************
            if (tabControl1.SelectedTab == tabPage3)
            {
                int x = 0;
                string id = frm.ID;
                if (id.Substring(0, 1) == "p")
                    id = id.Substring(1, id.Length - 1);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = frm.con;
                cmd.CommandText = "select distinct lesson.lesson from days_sch,lesson,student  where lesson.id_lesson=days_sch.Id_lesson and days_sch.id_class=student.id_class and student.id_student=" + id;
                dataGridView2.Rows.Clear();
                try
                {

                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {

                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[x].Cells[0].Value = rdr.GetString(0);

                        x++;
                    }


                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                }
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                t1.Items.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select mail_box.[id-sender],mail_box.subject,mail_box.id_mail_box from mail_box,office_user where mail_box.[id-sender]=office_user.id_office_user and mail_box.id_receiver=" + frm.ID;
                try
                {
                    cmd.Connection = frm.con;
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        t1.Items.Add(rdr.GetValue(0).ToString() + "   موضوع(" + rdr.GetValue(1).ToString() + ")");
                        arr.Add(rdr.GetValue(2));
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                }
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from participated where id_sudent_participated=" + frm.ID.ToString() + " and id_election in(select id_election from Election_archive where active='true')";
                try
                {
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {

                        //FMessageBox.Show("شما قبلا این نظرسنجی را پاسخ دادهاید ", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                        button9.Enabled = false;
                    }

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                }
                cmd.Connection = frm.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "active_election";
                try
                {
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                   
                        if (rdr.Read())
                        {
                            label16.Text = rdr.GetString(1);
                            radioButton1.Text = rdr.GetString(2);
                            radioButton2.Text = rdr.GetString(3);
                            radioButton3.Text = rdr.GetString(4);
                            radioButton4.Text = rdr.GetString(5);
                            op1 = rdr.GetInt32(10);
                            op2 = rdr.GetInt32(11);
                            op3 = rdr.GetInt32(12);
                            op4 = rdr.GetInt32(13);
                            id_election = rdr.GetInt32(0);


                        }
                    
                    else
                    {
                        groupBox3.Visible = false;
                        groupBox4.Visible = false;
                        button9.Visible = false;
                    }

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                }
            }
            //******************************************************************
            if (tabControl1.SelectedTab == tabPage6)
            {
                try
                {
                    ds.Clear();
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Connection = frm.con;
                    adp.SelectCommand.CommandText = "select_ebookid";
                    adp.Fill(ds, "ebook");
                    dataGrid2.SetDataBinding(ds, "ebook");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    frm.con.Close();
                }
            }
            //*****************************************************************
            if (tabControl1.SelectedTab == tabPage7)
            {
                dataGridView3.RowCount = 6;
                dataGridView3.Rows[0].Cells[0].Value = "شنبه";
                dataGridView3.Rows[1].Cells[0].Value = "یکشنبه";
                dataGridView3.Rows[2].Cells[0].Value = "دوشنبه";
                dataGridView3.Rows[3].Cells[0].Value = "سه شنبه";
                dataGridView3.Rows[4].Cells[0].Value = "چهارشنبه";
                dataGridView3.Rows[5].Cells[0].Value = "پنج شنبه";
                //****************************************************************

                string id_student;
                id_student = frm.ID;
                if (id_student.Substring(0, 1) == "p")
                {
                    id_student = id_student.Substring(1, id_student.Length - 1);
                }
                long id = Int64.Parse(id_student);
                try
                {

                    frm.con.Open();
                    cmd1.Connection = frm.con;
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select days_sch.day,days_sch.time,lesson.lesson,Office_user.last_name" +
                        ",Office_user.first_name,class.id_class from lesson,class_lesson,class,Office_user,days_sch " +
                        "where days_sch.id_class=class.id_class and days_sch.id_lesson=lesson.id_lesson " +
                        "and  lesson.id_lesson=class_lesson.id_lesson and class.id_class=class_lesson.id_class " +
                        "and class_lesson.id_teacher=Office_user.id_office_user and class.id_class=(select id_class from student where id_student=" + id_student + ")" +
                        " and class_lesson.Id_student=" + id;

                    int j = 1;
                    int i = 0;
                    rdr = cmd1.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (i > 6)
                        {
                            i = 0;
                        }
                        if (j > 7)
                        {
                            i += 1;
                            j = 1;
                        }

                        id_class = rdr.GetString(5);
                        dataGridView3.Rows[i].Cells[j].Value = rdr.GetString(2);
                        dataGridView3.Rows[i].Cells[j + 1].Value = rdr.GetString(3);
                        j += 2;
                    }


                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);

                }
                finally
                {
                    frm.con.Close();
                }    

            }
            if (tabControl1.SelectedTab == tabPage8)
            {
                
                try
                {
                    comboBox1.Items.Clear();
                    frm.con.Open();
                    cmd.Connection = frm.con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Select_lesson";
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        comboBox2.Items.Add(rdr.GetString(1));
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();

                }
            }
            if (tabControl1.SelectedTab == tabPage9)
            {
                
            }

        }
        //************************************************************tabpage3
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            int y1 = 0;
            while (y1 < dataGridView2.RowCount)
            {
                dataGridView2.Rows[y1].Cells[1].Tag = null;

                y1++;

            }

            int r = 0;
            int t = 0;
            for (t = 0; t < dataGridView2.RowCount; t++)
                for (r = 1; r < dataGridView2.ColumnCount; r++)
                    dataGridView2.Rows[t].Cells[r].Value = "";

            dataGridView2.Enabled = true;
            string id = frm.ID;
            if (id.Substring(0, 1) == "p")
                id = id.Substring(1, id.Length - 1);
            // button1.Enabled = true;
            // string str;
            int y = 0;
            // int k = 0;
            cmd.CommandText = "select * from term_view where Id_term in (select Id_term from class_lesson where Id_student=" + id + ") and "
            + " year = " + comboBox1.SelectedItem.ToString() + " and term_number=" + domainUpDown1.SelectedItem.ToString();
            

                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    y = 0;
                    while (y < dataGridView2.RowCount)
                    {
                        if (dataGridView2.Rows[y].Cells[0].Value.ToString() == rdr.GetString(0))
                        {
                            dataGridView2.Rows[y].Cells[1].Value = rdr.GetDouble(3).ToString();
                            dataGridView2.Rows[y].Cells[1].Tag = "true";
                            break;
                        }
                        y++;

                    }
                }
                double sum = 0;
                int i = 0;
                int s = 0;
                //dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value = "معدل";
                while (i < dataGridView2.RowCount)
                {
                    if (dataGridView2.Rows[i].Cells[1].Tag != null)
                    {
                        sum += Int32.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        s++;
                    }
                    i++;
                }
                
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[1].Value =( sum / s).ToString().Substring(0,5);
            }
            catch (Exception E)
            {
              //  MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList array = new ArrayList();
                for (int i = 1; i <= 10; i++)
                {
                    array.Add(("p" + i).ToString());
                }
                for (int i = 1; i <= 10; i++)
                {
                    array.Add(("m" + i).ToString());
                }
                for (int i = 1; i <= 10; i++)
                {
                    array.Add(("d" + i).ToString());
                }

                for (int i = 0; i < 30; i++)
                {
                    crystalReport21.SetParameterValue(array[i].ToString(), "");

                }
                crystalReport21.SetParameterValue("a1", "");
                crystalReport21.SetParameterValue("a2", "");

                Form2 rp = new Form2();
                rp.crystalReportViewer1.ReportSource = crystalReport21;
                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {
                    crystalReport21.SetParameterValue(array[i + 20].ToString(), dataGridView2.Rows[i].Cells[0].Value.ToString());
                }
                if (domainUpDown1.SelectedItem.ToString() == "2")
                {
                    for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                    {
                        crystalReport21.SetParameterValue(array[i].ToString(), dataGridView2.Rows[i].Cells[1].Value.ToString());
                    }
                    crystalReport21.SetParameterValue("a2", dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[1].Value);
                }
                else
                {
                    for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                    {
                        crystalReport21.SetParameterValue(array[i + 10].ToString(), dataGridView2.Rows[i].Cells[1].Value.ToString());
                    }
                    crystalReport21.SetParameterValue("a1", dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[1].Value);
                }

                crystalReport21.SetParameterValue("name", name);
                crystalReport21.SetParameterValue("family", family);
                crystalReport21.SetParameterValue("title", "کارنامه تحصیلی سال" + comboBox1.SelectedItem.ToString());
                rp.ShowDialog();
            }
            catch
            {
            }
        }
        //***********************************************************tabpage8
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* try
            {
                frm.con.Open();
                cmd.Connection = frm.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Select_lesson";
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBox1.Items.Add(rdr.GetString(1));
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();

            }*/
            try
            {
                adp.SelectCommand.CommandType = CommandType.Text;
                adp.SelectCommand.Connection = frm.con;
                adp.SelectCommand.CommandText = "select Id_test,test from test_bank where type=N'" + comboBox2.SelectedItem.ToString() + "'";
                ds.Clear();
                adp.Fill(ds, "test_bank");
                dataGrid1.SetDataBinding(ds, "test_bank");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGrid1.CurrentRowIndex != -1)
            {

                FMessageBox.Show(ds.Tables["test_bank"].Rows[dataGrid1.CurrentRowIndex][1].ToString(), "تست");
            }
            else
            {
                FMessageBox.Show("select the question,please", "message", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
            }
        }
        //********************************************************************tabpage4
        private void t1_DoubleClick(object sender, EventArgs e)
        {

            cmd.CommandText = "select mail_box.*,office_user.first_name from mail_box,office_user where mail_box.[id-sender]=office_user.id_office_user And mail_box.id_mail_box=" + arr[t1.SelectedIndex];
            try
            {

                frm.con.Open();
                rdr = cmd.ExecuteReader();

                t4.Enabled = true;
                while (rdr.Read())
                {

                    t2.Text = rdr.GetValue(2).ToString();
                    t3.Text = rdr.GetString(4);
                    t4.Text = rdr.GetString(5);
                    if (rdr.GetValue(7).ToString() != "")
                    {
                        l5.Visible = true;
                        l6.Visible = true;



                    }
                    else if (rdr.GetValue(7).ToString() == "")
                    {
                        l5.Visible = false;
                        l6.Visible = false;
                    }

                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();

            }
        }

        private void l6_Click(object sender, EventArgs e)
        {
            byte[] filebyte;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select attachment from mail_box where mail_box.id_mail_box=" + arr[t1.SelectedIndex];
            try
            {
                cmd.Connection = frm.con;
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    filebyte = rdr.GetSqlBinary(0).Value;
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.ShowDialog();
                    File.WriteAllBytes(sfd.FileName, filebyte);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (t1.SelectedIndex != -1)
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from mail_box where mail_box.id_mail_box=" + arr[t1.SelectedIndex];
                try
                {
                    cmd.Connection = frm.con;
                    frm.con.Open();
                    if (FMessageBox.Show("پست مورد نظر حذف شود؟", "پیغام", FMessageBoxButtons.OKCancel, FMessageBoxIcons.Information) == DialogResult.OK)
                    {
                        cmd.ExecuteNonQuery();
                        t1.Items.RemoveAt(t1.SelectedIndex);
                        t2.Text = "";
                        t3.Text = "";
                        t4.Text = "";
                        l5.Text = "";
                    }


                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                }
            }  

        }
        //*************************************************************************************tabpage7
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 report = new Form2();

            report.crystalReportViewer1.ReportSource = crystalReport11;
            crystalReport11.SetParameterValue("p1", "CLASS");
            crystalReport11.SetParameterValue("t1", dataGridView3.Rows[0].Cells[1].Value.ToString());
            crystalReport11.SetParameterValue("t2", dataGridView3.Rows[1].Cells[1].Value.ToString());
            crystalReport11.SetParameterValue("t3", dataGridView3.Rows[2].Cells[1].Value.ToString());
            crystalReport11.SetParameterValue("t4", dataGridView3.Rows[3].Cells[1].Value.ToString());
            crystalReport11.SetParameterValue("t5", dataGridView3.Rows[4].Cells[1].Value.ToString());
            crystalReport11.SetParameterValue("t6", dataGridView3.Rows[5].Cells[1].Value.ToString());
            crystalReport11.SetParameterValue("t7", dataGridView3.Rows[0].Cells[3].Value.ToString());
            crystalReport11.SetParameterValue("t8", dataGridView3.Rows[1].Cells[3].Value.ToString());
            crystalReport11.SetParameterValue("t9", dataGridView3.Rows[2].Cells[3].Value.ToString());
            crystalReport11.SetParameterValue("t10", dataGridView3.Rows[3].Cells[3].Value.ToString());
            crystalReport11.SetParameterValue("t11", dataGridView3.Rows[4].Cells[3].Value.ToString());
            crystalReport11.SetParameterValue("t12", dataGridView3.Rows[5].Cells[5].Value.ToString());
            crystalReport11.SetParameterValue("t13", dataGridView3.Rows[0].Cells[5].Value.ToString());
            crystalReport11.SetParameterValue("t14", dataGridView3.Rows[1].Cells[5].Value.ToString());
            crystalReport11.SetParameterValue("t15", dataGridView3.Rows[2].Cells[5].Value.ToString());
            crystalReport11.SetParameterValue("t16", dataGridView3.Rows[3].Cells[5].Value.ToString());
            crystalReport11.SetParameterValue("t17", dataGridView3.Rows[4].Cells[5].Value.ToString());
            crystalReport11.SetParameterValue("t18", dataGridView3.Rows[5].Cells[5].Value.ToString());
            crystalReport11.SetParameterValue("t19", dataGridView3.Rows[0].Cells[7].Value.ToString());
            crystalReport11.SetParameterValue("t20", dataGridView3.Rows[1].Cells[7].Value.ToString());
            crystalReport11.SetParameterValue("t21", dataGridView3.Rows[2].Cells[7].Value.ToString());
            crystalReport11.SetParameterValue("t22", dataGridView3.Rows[3].Cells[7].Value.ToString());
            crystalReport11.SetParameterValue("t23", dataGridView3.Rows[4].Cells[7].Value.ToString());
            crystalReport11.SetParameterValue("t24", dataGridView3.Rows[5].Cells[7].Value.ToString());
            crystalReport11.SetParameterValue("t25", dataGridView3.Rows[0].Cells[2].Value.ToString());
            crystalReport11.SetParameterValue("t26", dataGridView3.Rows[1].Cells[2].Value.ToString());
            crystalReport11.SetParameterValue("t27", dataGridView3.Rows[2].Cells[2].Value.ToString());
            crystalReport11.SetParameterValue("t28", dataGridView3.Rows[3].Cells[2].Value.ToString());
            crystalReport11.SetParameterValue("t29", dataGridView3.Rows[4].Cells[2].Value.ToString());
            crystalReport11.SetParameterValue("t30", dataGridView3.Rows[5].Cells[2].Value.ToString());
            crystalReport11.SetParameterValue("t31", dataGridView3.Rows[0].Cells[4].Value.ToString());
            crystalReport11.SetParameterValue("t32", dataGridView3.Rows[1].Cells[4].Value.ToString());
            crystalReport11.SetParameterValue("t33", dataGridView3.Rows[2].Cells[4].Value.ToString());
            crystalReport11.SetParameterValue("t34", dataGridView3.Rows[3].Cells[4].Value.ToString());
            crystalReport11.SetParameterValue("t35", dataGridView3.Rows[4].Cells[4].Value.ToString());
            crystalReport11.SetParameterValue("t36", dataGridView3.Rows[5].Cells[4].Value.ToString());
            crystalReport11.SetParameterValue("t37", dataGridView3.Rows[0].Cells[6].Value.ToString());
            crystalReport11.SetParameterValue("t38", dataGridView3.Rows[1].Cells[6].Value.ToString());
            crystalReport11.SetParameterValue("t39", dataGridView3.Rows[2].Cells[6].Value.ToString());
            crystalReport11.SetParameterValue("t40", dataGridView3.Rows[3].Cells[6].Value.ToString());
            crystalReport11.SetParameterValue("t41", dataGridView3.Rows[4].Cells[6].Value.ToString());
            crystalReport11.SetParameterValue("t42", dataGridView3.Rows[5].Cells[6].Value.ToString());
            crystalReport11.SetParameterValue("t43", dataGridView3.Rows[0].Cells[8].Value.ToString());
            crystalReport11.SetParameterValue("t44", dataGridView3.Rows[1].Cells[8].Value.ToString());
            crystalReport11.SetParameterValue("t45", dataGridView3.Rows[2].Cells[8].Value.ToString());
            crystalReport11.SetParameterValue("t46", dataGridView3.Rows[3].Cells[8].Value.ToString());
            crystalReport11.SetParameterValue("t47", dataGridView3.Rows[4].Cells[8].Value.ToString());
            crystalReport11.SetParameterValue("t48", dataGridView3.Rows[5].Cells[8].Value.ToString());
            crystalReport11.SetParameterValue("p1", id_class);

           report.ShowDialog();
        }
        //********************************************************************************tabpage9
        private void button7_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.Text;
            cmd.Connection = frm.con;
            string id = frm.ID;
            string subid = id.Substring(0, 1);

            if (textBox1.Text == textBox2.Text)
            {
                if (textBox1.Text != "" && textBox3.Text != "")
                {
                    try
                    {
                        frm.con.Open();
                        if (subid != "p")
                        {
                            cmd.CommandText = "select pass_student from student where id_student=" + id;
                        }
                        else
                        {
                            cmd.CommandText = "select pass_parrents from parrents where id_parrents=" + id;
                        }
                        rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            pass = rdr.GetString(0);
                        }

                    }

                    catch (Exception)
                    {

                    }
                    finally
                    {
                        frm.con.Close();
                    }
                    try
                    {
                        frm.con.Open();
                        if (pass == textBox1.Text)
                        {
                            if (subid != "p")
                            {
                                cmd.CommandText = "update student set pass_student='" + textBox3.Text + "'where id_student=" + id;
                            }
                            else
                            {
                                cmd.CommandText = "update parrents set pass_parrents='" + textBox3.Text + "' where id_parrents='" + id + "'";
                            }
                            cmd.ExecuteNonQuery();
                            FMessageBox.Show("کلمه عبور تغییر کرد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

                        }
                        else
                        {
                            FMessageBox.Show("کلمه عبور اشتباه است", "هشدار", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                        }

                    }

                    catch (Exception)
                    {
                    }
                    finally
                    {
                        frm.con.Close();
                    }

                }

            }
            else
            {
                FMessageBox.Show("بین کلمه عبور و تکرار آن مطابقت وجود ندارد", "توجه", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
            }
        }
        //*************************************************************************************tabpage6
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGrid2.CurrentRowIndex != -1)
            {
                byte[] filebyte;
                cmd.Connection = frm.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "select_ebook";
                //cmd.Parameters.Add("@id_ebook", SqlDbType.Int).Value = null;
                try
                {
                    cmd.Parameters.Add("@id_ebook", SqlDbType.Int).Value = ds.Tables["ebook"].Rows[dataGrid2.CurrentRowIndex][0];
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        filebyte = rdr.GetSqlBinary(6).Value;
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.ShowDialog();
                        File.WriteAllBytes(sfd.FileName, filebyte);
                    }

                    FMessageBox.Show("عملیات با موفقیت اجرا شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                op1 = op1 + 1;
            if (radioButton2.Checked)
                op2 += 1;
            if (radioButton3.Checked)
                op3 += 1;
            if (radioButton4.Checked)
                op4 += 1;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "election_update";
            cmd.Parameters.Add("@op1", SqlDbType.Int).Value = op1;
            cmd.Parameters.Add("@op2", SqlDbType.Int).Value = op2;
            cmd.Parameters.Add("@op3", SqlDbType.Int).Value = op3;
            cmd.Parameters.Add("@op4", SqlDbType.Int).Value = op4;
            cmd.Parameters.Add("@id_election", SqlDbType.Int).Value = id_election;
            cmd.Parameters.Add("@p5", SqlDbType.Int).Value = id_election;
            cmd.Parameters.Add("@p6", SqlDbType.BigInt).Value = Int64.Parse(frm.ID);
            try
            {
              //  MessageBox.Show(op1 + "   " + op2 + "     " + op3 + "      " + op4);
                frm.con.Open();
                cmd.ExecuteNonQuery();
                FMessageBox.Show("نظر شما با موفقیت ثبت شد", " پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                button1.Enabled = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();
                cmd.Parameters.Clear();
            }
        }

        private void نموداروضعيتتحصيليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_chart chart = new Form_chart();
            chart.Show();
        }

       
        //*************************************************************************************
    }
}