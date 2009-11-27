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
using System.Threading;

namespace SMS1
{
    public partial class Form_election : Form
    {
        int jj;
   //     int kk;
        public Form_election()
        {
            InitializeComponent();
            jj = this.Height;
      //      kk = this.Width;
            this.Height = 0;
     //       this.Width = 0;
        }
        Form1 frm1 = new Form1();
        SqlCommand cmd = new SqlCommand();
        cDate date = new cDate();


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
        //        int width = kk;
                int i = 0;
         //       int k1 = 0;
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
          //          }
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


        private void b1_Click(object sender, EventArgs e)
        {
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;
            string strdate = year.ToString() + "/" + month.ToString() + "/" + day.ToString();
            if (rtb1.Text != "")
            {
                cmd.Connection = frm1.con;
                try
                {
                    frm1.con.Open();
                    cmd.CommandText = "update Election_archive set active='false' where id_electioneer=(select max(Id_electioneer) from election_archive)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into Election_archive values (N'" + rtb1.Text + "',N'" + tb1.Text + "',N'" +
                        tb2.Text + "',N'" + tb3.Text + "',N'" + tb4.Text + "','" + frm1.ID + "',N'" + strdate + "',NULL,'true',0,0,0,0)";
                   
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show("عمليات با موفقيت انجام شد", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

                }
                catch (Exception )
                {
                    FMessageBox.Show("خظا در ارتباط با ديتابيس", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                }
                finally
                {
                    frm1.con.Close();
                }
            }
            else
            {
                FMessageBox.Show("لطفا متن نظرسنجي خود را وارد كنيد", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
            }

            }

        private void b2_Click(object sender, EventArgs e)
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

        private void Form_election_Load(object sender, EventArgs e)
        {
            

        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            tb3.Enabled = true;
            label4.Enabled = true;
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {
            tb4.Enabled = true;
            label2.Enabled = true;
        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.Size = new System.Drawing.Size(64, 64);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.Size = new System.Drawing.Size(48, 48);
        }

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            b2.Size = new System.Drawing.Size(64, 64);
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b2.Size = new System.Drawing.Size(48, 48);
        }
    }
}
