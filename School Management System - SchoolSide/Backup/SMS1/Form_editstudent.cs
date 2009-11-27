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
    public partial class Form_editstudent : Form
    {
        int jj;
     //   int kk;
        public Form_editstudent()
        {
            InitializeComponent();
            jj = this.Height;
       //     kk = this.Width;
            this.Height = 0;
      //      this.Width = 0;
        }
        Form1 frm = new Form1();
        SqlDataReader rdr;
        string str1;


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
       //         int width = kk;
                int i = 0;
       //         int k1 = 0;
                while (i < height - 39)// || k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
       //             if (k1 < (width - 128))
       //             {
        //                this.Width += 5;
        //            }
        //            k1 += 5;
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


        private void Form_editstudent_Load(object sender, EventArgs e)
        {
            cmd.Connection = frm.con;
           


            cmd.CommandText = "select * from class";
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBox1.Items.Add(rdr.GetString(1) + "(" + rdr.GetString(0) + ")");
                    cmb2.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                frm.con.Close();
                rdr.Close();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "")
            {
                cmd.CommandText = "select id_student,first_name,last_name from student where first_name Like N'" + textBox1.Text + "%'";
                try
                {
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listBox1.Items.Add(rdr.GetString(1) + " " + rdr.GetString(2) + " (" + rdr.GetValue(0).ToString() + ")");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
                finally
                {
                    frm.con.Close();
                    rdr.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (comboBox1.Items.Count != 0)
            {
                string str = comboBox1.SelectedItem.ToString();
                int i = str.IndexOf('(');
                int j = str.IndexOf(')');
                str = str.Substring(i + 1, j - i - 1);
                cmd.CommandText = "select id_student,first_name,last_name from student where id_class=N'" + str + "'";

                try
                {
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        listBox2.Items.Add(rdr.GetString(1) + " " + rdr.GetString(2) + " (" + rdr.GetValue(0).ToString() + ")");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
                finally
                {
                    frm.con.Close();
                    rdr.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb1.Text = "";
            cmb2.Text = "";


            //**********************************************************************************
            if (listBox1.SelectedIndex != -1 || listBox2.SelectedIndex != -1)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                button3.Enabled = true;
                string str;
                //*****************************************************
                if (tabControl1.SelectedIndex == 0)
                {
                    str = listBox2.SelectedItem.ToString();
                }
                else
                {
                    str = listBox1.SelectedItem.ToString();
                }
                int i = str.IndexOf('(');
                int j = str.IndexOf(')');
                str = str.Substring(i + 1, j - i - 1);

                cmd.CommandText = "select student.id_student,student.pass_student,student.first_name,student.last_name,student.level,student.id_class,parrents.name_parrents,parrents.last_name,parrents.tel_parrents from student,parrents where parrents.id_parrents=student.id_parrents And student.id_student=" + str;



                try
                {
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        tb1.Text = rdr.GetValue(0).ToString();
                        tb2.Text = rdr.GetValue(1).ToString();
                        tb3.Text = rdr.GetString(2);
                        tb4.Text = rdr.GetString(3);
                        cmb1.SelectedText = rdr.GetString(4);
                        cmb2.SelectedText = rdr.GetString(5);
                        tb5.Text = rdr.GetString(6);
                        tb6.Text = rdr.GetString(7);
                        tb7.Text = rdr.GetValue(8).ToString();

                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
                finally
                {
                    frm.con.Close();
                    rdr.Close();

                }
            }
        }

        private void tb7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if ((tabControl1.SelectedIndex == 1 &&listBox1.SelectedIndex != -1) || (tabControl1.SelectedIndex == 0&&listBox2.SelectedIndex != -1))
            {
               

                if (tabControl1.SelectedIndex == 0)
                {
                    str1 = listBox2.SelectedItem.ToString();
                }
                else if (tabControl1.SelectedIndex == 1)
                {
                    str1 = listBox1.SelectedItem.ToString();
                }

                int i = str1.IndexOf('(');
              int j = str1.IndexOf(')');
                   string str = str1.Substring(i + 1, j - i - 1);

                   if (FMessageBox.Show("آيا مايل به حذف دانش آموز هستيد؟", "پیغام", FMessageBoxButtons.OKCancel, FMessageBoxIcons.Information) == DialogResult.OK)
                   {
                       cmd.CommandText = "delete  from student where id_student=" + str;
                       try
                       {
                           frm.con.Open();
                           cmd.ExecuteNonQuery();

                           // cmd.CommandText = "delete frome class_lesson where Id_student="+str;
                           FMessageBox.Show("داده با موفقیت حذف شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                           listBox1.Items.Remove(str1);
                           listBox2.Items.Remove(str1);
                       }
                       catch (Exception e1)
                       {
                           MessageBox.Show(e1.Message);
                       }
                       finally
                       {
                           frm.con.Close();
                       }
                   }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
             cmd.CommandText = "update student set pass_student="+tb2.Text+",first_name=N'"+tb3.Text+"',last_name=N'"+tb4.Text+"',level=N'"+cmb1.Text.ToString()+"',id_class=N'"+cmb2.Text.ToString()+"' where id_student="+tb1.Text;
                try
                {
                   // MessageBox.Show(cmd.CommandText.ToString());
                    frm.con.Open();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update parrents set name_parrents=N'"+tb5.Text+"',last_name=N'"+tb6.Text+"',tel_parrents="+tb7.Text;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update class_lesson set Id_class=N'" + cmb2.Text.ToString() + "' where id_student=" + tb1.Text;
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show("تغییرات  با موفقیت انجام شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                }
                catch (Exception )
                {
                    FMessageBox.Show("اطلاعات به درستی ذخیره نشد", "اخطار ", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);              
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

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Size = new System.Drawing.Size(64, 64);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new System.Drawing.Size(48, 48);
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Size = new System.Drawing.Size(64, 64);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new System.Drawing.Size(48, 48);
        }

    }
}
