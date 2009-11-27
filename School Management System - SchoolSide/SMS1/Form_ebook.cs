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
using farhaniPersianDate;
using System.IO;
using System.Threading;

namespace SMS1
{
    public partial class Form_ebook : Form
    {
        string path;
        cDate date = new cDate();
        SqlCommand cmd = new SqlCommand();
        Form1 frm = new Form1();

        int jj;
       // int kk;

        public Form_ebook()
        {
            InitializeComponent();
            jj = this.Height;
       //     kk = this.Width;
            this.Height = 0;
        //    this.Width = 0;
        }


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
         //       int width = kk;
                int i = 0;
         //       int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
            //        if (k1 < (width - 128))
           //         {
            //            this.Width += 5;
            //        }
            //        k1 += 5;
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



       
        private void button2_Click(object sender, EventArgs e)
        {
            string strabs=null;
            if (richTextBox1.Text != "")
            {
                strabs = richTextBox1.Text;
            }
            if (textBox1.Text == "")
            {
                FMessageBox.Show("لطفا نام کتاب یا جزوه را وارد کنید", "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
            }
            else if(path=="")
            {
                FMessageBox.Show("لطفا فایل کتاب یا جزوه را انتخاب کنید", "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

            }
            else { 
             byte[] filebyte;
            
                   
            cmd.Connection = frm.con;
            try
            {
                filebyte = File.ReadAllBytes(path);
                frm.con.Open();
                cmd.CommandText = "insert into  ebook values(N'" + comboBox1.SelectedItem.ToString() + "',N'" + textBox1.Text + "',N'" + strabs + "'," + frm.ID + ",N'" + date.getPersianDate() + "',@file)";
                cmd.Parameters.Add("@file", SqlDbType.Binary).Value = filebyte;
                cmd.ExecuteNonQuery();
                FMessageBox.Show("آپلود کتاب تمام شد","پیغام",FMessageBoxButtons.OK,FMessageBoxIcons.Information);
                this.Close();

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

        private void Form_ebook_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.ShowDialog();
            path = ofd.FileName;
            label4.Text = ofd.SafeFileName;
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
