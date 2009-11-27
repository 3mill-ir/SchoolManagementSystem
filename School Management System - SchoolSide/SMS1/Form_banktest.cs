using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using farhaniPersianDate;
using FarsiMessageBox;
using System.Threading;

namespace SMS1
{
    public partial class Form_banktest : Form
    {
        int jj;
       // int kk;
        public Form_banktest()
        {
            InitializeComponent();
            jj = this.Height;
          //  kk = this.Width;
            this.Height = 0;
          //  this.Width = 0;
        }
        Form1 frm = new Form1();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        cDate Date = new cDate();


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
              //  int width = kk;
                int i = 0;
              //  int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
               //     if (k1 < (width - 128))
                 //   {
                //        this.Width += 5;
                //    }
               //     k1 += 5;
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

        private void Form_banktest_Load(object sender, EventArgs e)
        {
            try
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

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    if(richTextBox1.Text!="" && textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="")
                    {
                    frm.con.Open();
                    cmd.Connection = frm.con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Insert_testbank";
                    cmd.Parameters.Add("@p1", SqlDbType.BigInt).Value = frm.ID;
                    cmd.Parameters.Add("@p2", SqlDbType.NVarChar).Value = Date.Year + "/" + Date.Month + "/" + Date.Day;
                    cmd.Parameters.Add("@p3", SqlDbType.NVarChar).Value = comboBox1.SelectedItem.ToString();
                    cmd.Parameters.Add("@p4", SqlDbType.NVarChar).Value = richTextBox1.Text + "\n\r" + label1.Text + textBox1.Text + "\n\r" +
                        label2.Text + textBox2.Text + "\n\r" + label3.Text + textBox3.Text + "\n\r" +
                        label4.Text + textBox4.Text+"\n\r" + label5.Text + textBox5.Text;
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show("عملیات با موفقیت اجرا شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    }
                    else
                    {
                         FMessageBox.Show("فیلدها را بدقت پر کنید", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    }
                }
                else
                {
                    FMessageBox.Show("درس مورد نظر را انتخاب کنید", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
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
    }
}
