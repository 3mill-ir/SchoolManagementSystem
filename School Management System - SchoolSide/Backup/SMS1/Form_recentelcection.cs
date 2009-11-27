using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace SMS1
{
    public partial class Form_recentelcection : Form
    {
        int jj;
     //   int kk;
        public Form_recentelcection()
        {
            InitializeComponent();
            jj = this.Height;
     //       kk = this.Width;
            this.Height = 0;
       //     this.Width = 0;
        }
        Form1 frm = new Form1();
        SqlDataReader rdr;

        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
      //          int width = kk;
                int i = 0;
     //           int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
        //            if (k1 < (width - 128))
         //           {
         //               this.Width += 5;
         //           }
          //          k1 += 5;
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


        private void Form_recentelcection_Load(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from election_archive where active='true'";
            cmd.Connection = frm.con;
            frm.con.Open();
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    label11.Text = rdr.GetString(7);
                    richTextBox1.Text = rdr.GetString(1);
                    textBox1.Text+= rdr.GetString(2);
                    textBox2.Text += rdr.GetString(3);
                    textBox3.Text += rdr.GetString(4);
                    textBox4.Text += rdr.GetString(5);
                   
                    a1.Text = rdr.GetValue(10).ToString();
                    a2.Text = rdr.GetValue(11).ToString();
                    a3.Text = rdr.GetValue(12).ToString();
                    a4.Text = rdr.GetValue(13).ToString();
                    
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally{
                frm.con.Close();
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
