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
    public partial class Form_dailywords : Form
    {
        int jj;
      //  int kk;
        public Form_dailywords()
        {
            InitializeComponent();
            jj = this.Height;
         //   kk = this.Width;
            this.Height = 0;
         //   this.Width = 0;
        }
        Form1 frm = new Form1();


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
            //    int width = kk;
                int i = 0;
           //     int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
                  //  if (k1 < (width - 128))
                  //  {
                  //      this.Width += 5;
                  //  }
                  //  k1 += 5;
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


        private void cmb4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (richTextBox1.Text != "")
            {
                cmd.CommandText = "insert into daily_words values('" + cmb2.Text + "/" + cmb3.Text + "/" + cmb4.Text + "',N'" + richTextBox1.Text + "'," + frm.ID + ")";
                cmd.Connection = frm.con;
                try
                {
                    frm.con.Open();
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show("عمليات با موفقيت اجرا شد", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

                }
                catch (Exception)
                {
                    FMessageBox.Show("مشكلي در ديتابيس وجود دارد", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
                }
                finally
                {
                    frm.con.Close();
                }
            }
        }

        private void Form_dailywords_Load(object sender, EventArgs e)
        {
            cmb2.SelectedIndex = 0;
            cmb3.SelectedIndex = 0;
            cmb4.SelectedIndex = 0;
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

        private void button3_Click(object sender, EventArgs e)
        {
            cmb2.Items.Add(Int32.Parse(cmb2.Items[cmb2.Items.Count-1].ToString()) + 1);
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
