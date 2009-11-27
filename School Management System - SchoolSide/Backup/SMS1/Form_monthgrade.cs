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

namespace SMS1
{
    public partial class Form_monthgrade : Form
    {
        int jj;
     //   int kk;
        public Form_monthgrade()
        {
            InitializeComponent();
            jj = this.Height;
     //       kk = this.Width;
            this.Height = 0;
      //      this.Width = 0;
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
       //         int width = kk;
                int i = 0;
        //        int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
          //          if (k1 < (width - 128))
          //          {
          //              this.Width += 5;
           //         }
           //         k1 += 5;
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
                //   this.Width-=7;

                Application.DoEvents();
                Thread.Sleep(1);
                i += 7;
            }

        }
        ///////////////////////

        private void Form_monthgrade_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
          //  domainUpDown1.SelectedIndex = 0;

            cmd.CommandText = "select * from class";
            cmd.Connection = frm.con;
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
                cmb1.SelectedIndex = 0;
            }
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
                cmd.CommandText = "select last_name,first_name,id_student from student where id_class='"+str2+"'";
             try
               {
                   frm.con.Open(); 
                   rdr = cmd.ExecuteReader();
                   while (rdr.Read())
                   {
                       listBox1.Items.Add(rdr.GetString(0) + " " + rdr.GetString(1) + " ("+rdr.GetValue(2).ToString()+")");
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

            
            //**************************************************************************************
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    string str = listBox1.SelectedItem.ToString();
                    label2.Text = str;
                    int i = str.IndexOf('(');
                    int j = str.IndexOf(')');
                    string str2 = str.Substring(i + 1, j - i - 1);
                    int x = 0;
                    string day;
                    frm.con.Open();
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
                                    cmd.CommandText = "update  month_grade set grade=" + dataGridView1.Rows[r].Cells[c].Value.ToString() + " where date='" + comboBox3.SelectedItem.ToString() + comboBox4.SelectedItem.ToString() + day + "' and id_term in(select id_term from class_lesson,lesson where  lesson.Id_lesson=class_lesson.Id_lesson and id_student=" + str2 + " and lesson=N'" + dataGridView1.Rows[r].Cells[0].Value.ToString() + "')";
                              
                                }
                                else
                                {
                                    cmd.CommandText = "select id_term from class_lesson,lesson where  lesson.Id_lesson=class_lesson.Id_lesson and id_student=" + str2 + " and lesson=N'" + dataGridView1.Rows[r].Cells[0].Value.ToString() + "'";
                                    
                                       
                                        // MessageBox.Show(cmd.CommandText);
                                        rdr = cmd.ExecuteReader();
                                        rdr.Read();
                                        x = rdr.GetInt32(0);
                                        rdr.Close();
                                    
                               

                                    cmd.CommandText = "insert into month_grade (Id_term,date,grade,present)  values " +
                                         "(" + x + ",'" +
                                          comboBox3.SelectedItem.ToString() + comboBox4.SelectedItem.ToString() + day + "','" + dataGridView1.Rows[r].Cells[c].Value.ToString() + "','true')";

                                }
                               
                                   
                                    cmd.ExecuteNonQuery();
                               
                               
                                
                               

                            }

                        }
                    }
                FMessageBox.Show("عملیات باموفقیت انجام شد", "اخطار ", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                 finally
                                {
                                   
                                    frm.con.Close();
                    
                                }
               
            }
            else {
                FMessageBox.Show("لطفآ دانش آموز مورد نظر خود را انتخاب كنيد ","پيغام",FMessageBoxButtons.OK,FMessageBoxIcons.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

                int r = 0;
                int t = 0;
                for (t = 0; t < dataGridView1.RowCount; t++)
                    for (r = 1; r < dataGridView1.ColumnCount; r++)
                        dataGridView1.Rows[t].Cells[r].Value = "";
                string strw = listBox1.SelectedItem.ToString();
                label2.Text = strw;
                int i = strw.IndexOf('(');
                int j = strw.IndexOf(')');
                string str2 = strw.Substring(i + 1, j - i - 1);
                dataGridView1.Enabled = true;
                button1.Enabled = true;
                string str;
                int y = 0;
                int k = 0;
                cmd.CommandText = "select * from month_view where Id_term in (select Id_term from class_lesson where Id_student=" + str2 + ") and "
                + " date Like N'" + comboBox3.Text + comboBox4.Text + "%'";
                // MessageBox.Show(cmd.CommandText);
                try
                {

                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        y = 0;
                        str = rdr.GetString(2);
                        str = str.Substring(6, 2);
                        //   MessageBox.Show(str);
                        k = Int16.Parse(str);
                        //   MessageBox.Show(k.ToString());
                        //   MessageBox.Show(rdr.GetDouble(3).ToString());
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
                    //   MessageBox.Show(y + "     " + k);
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    frm.con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int height = jj;
            int i = 0;
            while (i < height)
            {
                this.Height -= 7;
                //   this.Width-=7;

                Application.DoEvents();
                Thread.Sleep(1);
                i += 7;
            }
            this.Close();
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

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Size = new System.Drawing.Size(64, 64);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new System.Drawing.Size(48, 48);
        }
    }
}
