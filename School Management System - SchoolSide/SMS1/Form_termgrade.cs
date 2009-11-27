using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FarsiMessageBox;
using System.Threading;
using System.Collections;
using SMS1;


namespace SMS1
{
    public partial class Form_termgrade : Form
    {
        int jj;
        string name, family;
      //  string id_class;
    
        public Form_termgrade()
        {
            InitializeComponent();
            jj = this.Height;
    
            this.Height = 0;
       
        }
        Form1 frm = new Form1();
        SqlDataReader rdr;
        SqlCommand cmd = new SqlCommand();


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
         
                int i = 0;
      
                while (i < height - 39 )
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
      
                    i += 5;
                }
                panel1.Visible = false;
            }
            base.OnShown(e);
        }


        private void EffectiveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int height = jj;
            int i = 0;
            while (i < height)
            {
                this.Height -= 7;
             

                Application.DoEvents();
                Thread.Sleep(1);
                i += 7;
            }

        }
        ///////////////////////

        private void button2_Click(object sender, EventArgs e)
        {
            int height = jj;
            int i = 0;
            while (i < height)
            {
                this.Height -= 7;
              

                Application.DoEvents();
                Thread.Sleep(1);
                i += 7;
            }
            this.Close();
           
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int x = 0;
            string str = cmb1.SelectedItem.ToString();
            int i = str.IndexOf('(');
            int j = str.IndexOf(')');
            string str2 = str.Substring(i + 1, j - i - 1);

            //***********************************************************
            cmd.CommandText = "select last_name,first_name,id_student from student where id_class='" + str2 + "'";
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetString(0) + " " + rdr.GetString(1) + " (" + rdr.GetValue(2).ToString() + ")");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
            finally
            {
                frm.con.Close();
            }
            cmd.CommandText = "select distinct lesson.lesson from days_sch,lesson  where lesson.id_lesson=days_sch.Id_lesson and id_class='" + str2 + "'";
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

        private void Form_termgrade_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 0;
            domainUpDown1.SelectedIndex = 0;
            cmd.Connection = frm.con;
            cmd.CommandText = "select * from class";
            
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmb1.Items.Add(rdr.GetString(1) + "(" + rdr.GetString(0) + ")");
                }
               
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();
                rdr.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) {
                FMessageBox.Show("دانش آموز مورد نظر را انتخاب کنید", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
            }
            else
            {
                string str = listBox1.SelectedItem.ToString();
                label2.Text = str;
                int i = str.IndexOf('(');
                int j = str.IndexOf(')');
                string str2 = str.Substring(i + 1, j - i - 1);
                int x = 0;
                string day;

                for (int r = 0; r < dataGridView1.RowCount; r++)
                {
                    for (int c = 1; c < dataGridView1.ColumnCount; c++)
                    {
                        if (c < 10)
                            day = "0" + c.ToString();
                        else
                            day = c.ToString();
                        if (dataGridView1.Rows[r].Cells[c].Value.ToString() != "")
                        {
                            if (dataGridView1.Rows[r].Cells[c].Tag != null)
                            {

                                cmd.CommandText = "update  term_garde set grade=" + dataGridView1.Rows[r].Cells[1].Value.ToString() + " where year=" + comboBox3.SelectedItem.ToString() +
                                    "and term_number=" + domainUpDown1.SelectedItem.ToString() + " and id_term in(select id_term from class_lesson,lesson where  lesson.Id_lesson=class_lesson.Id_lesson and id_student=" + str2 +
                                    " and lesson=N'" + dataGridView1.Rows[r].Cells[0].Value.ToString() + "')";
                            }
                            else
                            {
                                cmd.CommandText = "select id_term from class_lesson,lesson where  lesson.Id_lesson=class_lesson.Id_lesson and id_student=" + str2 + " and lesson=N'" + dataGridView1.Rows[r].Cells[0].Value.ToString() + "'";
                                try
                                {
                                    frm.con.Open();

                                    rdr = cmd.ExecuteReader();
                                    rdr.Read();
                                    x = rdr.GetInt32(0);

                                }
                                catch (Exception E1)
                                {
                                    MessageBox.Show(E1.Message);
                                }
                                finally
                                {
                                    rdr.Close();
                                    frm.con.Close();
                                }

                                cmd.CommandText = "insert into term_garde (Id_term,term_number,grade,year)  values " +
                                     "(" + x + "," +
                                      domainUpDown1.SelectedItem.ToString() + "," + dataGridView1.Rows[r].Cells[c].Value.ToString() + "," + comboBox3.SelectedItem.ToString() + ")";

                            }
                            try
                            {

                                frm.con.Open();
                                cmd.ExecuteNonQuery();

                                FMessageBox.Show("عمليات با موفقيت اجرا شد", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                  

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

                    }

                }

            }
            
           
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int y1=0;
            double sum = 0;
            int s = 0;
            int q=0;
                    while (y1 < dataGridView1.RowCount)
                    {
                        dataGridView1.Rows[y1].Cells[1].Tag = null;
                      
                        y1++;

                    }
            label3.Text = listBox1.SelectedItem.ToString();
            int r = 0;
            int t = 0;
            for (t = 0; t < dataGridView1.RowCount; t++)
                for (r = 1; r < dataGridView1.ColumnCount; r++)
                    dataGridView1.Rows[t].Cells[r].Value = "";
            string strw = listBox1.SelectedItem.ToString();
            int i = strw.IndexOf('(');
            int j = strw.IndexOf(')');
            string str2 = strw.Substring(i + 1, j - i - 1);
            dataGridView1.Enabled = true;
           // button1.Enabled = true;
           // string str;
            int y = 0;
            
            cmd.CommandText = "select * from term_view where Id_term in (select Id_term from class_lesson where Id_student=" + str2 + ") and "
            + " year = " + comboBox3.SelectedItem.ToString()+ " and term_number=" + domainUpDown1.SelectedItem.ToString();
            try
            {

                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    y = 0;
                   
                    while (y < dataGridView1.RowCount)
                    {
                        if (dataGridView1.Rows[y].Cells[0].Value.ToString() == rdr.GetString(0))
                        {
                            dataGridView1.Rows[y].Cells[1].Value = rdr.GetDouble(3).ToString();
                            dataGridView1.Rows[y].Cells[1].Tag = "true";
                            break;
                        }
                        y++;

                    }
                }
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = "معدل";
                while (q < dataGridView1.RowCount)
                {
                    if (dataGridView1.Rows[q].Cells[1].Tag != null)
                    {
                        sum += Int32.Parse(dataGridView1.Rows[q].Cells[1].Value.ToString());
                        s++;

                    }
                  //  MessageBox.Show(s.ToString());
                    q++;
                }

                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = (sum / s).ToString().Substring(0,5);
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(64, 64);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(48, 48);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Size = new System.Drawing.Size(64, 64);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new System.Drawing.Size(48, 48);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
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
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        crystalReport21.SetParameterValue(array[i + 20].ToString(), dataGridView1.Rows[i].Cells[0].Value.ToString());
                    }
                    if (domainUpDown1.SelectedItem.ToString() == "2")
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            crystalReport21.SetParameterValue(array[i].ToString(), dataGridView1.Rows[i].Cells[1].Value);
                        }
                        crystalReport21.SetParameterValue("a2", dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value);
                    }
                    else
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            crystalReport21.SetParameterValue(array[i + 10].ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString());
                        }
                        crystalReport21.SetParameterValue("a1", dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value);
                    }
                    string strw = listBox1.SelectedItem.ToString();
                    int i1 = strw.IndexOf(' ');
                    int j1 = strw.IndexOf('(');
                    name = strw.Substring(0, i1);
                    family = strw.Substring(i1 + 1, j1);
                    crystalReport21.SetParameterValue("name", name);
                    crystalReport21.SetParameterValue("family", family);
                    crystalReport21.SetParameterValue("title", "کارنامه تحصیلی سال" + comboBox3.SelectedItem.ToString());
                    rp.ShowDialog();

                }
                else
                {
                    
                    FMessageBox.Show("دانش آموز مورد نظر را انتخاب کنید","پیغام",FMessageBoxButtons.OK,FMessageBoxIcons.Warning);
                }
            }
            catch
            {
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
