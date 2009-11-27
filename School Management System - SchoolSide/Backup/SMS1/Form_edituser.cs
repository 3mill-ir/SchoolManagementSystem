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
    public partial class Form_edituser : Form
    {
        int jj;
       // int kk;
        public Form_edituser()
        {
            InitializeComponent();
            jj = this.Height;
       //     kk = this.Width;
            this.Height = 0;
      //      this.Width = 0;
        }
        Form1 frm = new Form1();
        SqlDataReader rdr;


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
        //        int width = kk;
                int i = 0;
         //       int k1 = 0;
                while (i < height - 39)// || k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
          //          if (k1 < (width - 128))
         //           {
          //              this.Width += 5;
          //          }
          //          k1 += 5;
                    i += 5;
                }
                panel3.Visible = false;
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


        private void Form_edituser_Load(object sender, EventArgs e)
        {
            cmd.Connection = frm.con;
            cmd.CommandText = "select last_name,id_office_user from office_user ";
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetString(0) + "(" + rdr.GetValue(1).ToString() + ")");
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

        private void button1_Click(object sender, EventArgs e)
        { 
           
            if (listBox1.SelectedIndex != -1)
            {
                panel1.Enabled = true;
                panel2.Enabled = true;

                cmb1.Text = null;

                string str = listBox1.SelectedItem.ToString();
                int i = str.IndexOf('(');
                int j = str.IndexOf(')');
                str = str.Substring(i + 1, j - i - 1);
                cmd.Connection = frm.con;
                cmd.CommandText = "select *  from office_user where id_office_user='" + str + "'";

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

                    }
                }
                catch (Exception)
                {
                    FMessageBox.Show("مشکلی در ارتباط باخواندن اطلاعات وجود دارد", "اخطار ", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                }
                finally
                {
                    frm.con.Close();
                }
            }
            else
            {
                FMessageBox.Show("هیچ گزینه ای انتخاب نشده است", "توجه ", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            int i = str.IndexOf('(');
            int j = str.IndexOf(')');
            str = str.Substring(i + 1, j - i - 1);
            cmd.CommandText = "delete from office_user where id_office_user=" + Int64.Parse(str);
            if (FMessageBox.Show("؟آيا مايل به حذف كاربر هستيد", "پیغام", FMessageBoxButtons.OKCancel, FMessageBoxIcons.Information) == DialogResult.OK)
            {
                try
                {
                    frm.con.Open();
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show("عملیات باموفقیت انجام شد", "اخطار ", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                }
                catch (Exception)
                {
                    FMessageBox.Show("عملیات ناموفق انجام شد", "اخطار ", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                }
                finally
                {
                    frm.con.Close();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
                cmd.CommandText = "update office_user set pass_office_user=" + tb2.Text + ",first_name=N'" + tb3.Text + "',last_name=N'" + tb4.Text + "',user_type=N'" + cmb1.Text.ToString() +  "' where id_office_user=" + tb1.Text;
                try
                {
                    frm.con.Open();
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیغام ", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    listBox1.Items.Add(tb3.Text + "(" + tb1.Text + ")");
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    button3.Enabled = false;

                }
                catch (Exception)
                {
                    FMessageBox.Show("اطلاعات به درستی ذخیره نشد", "اخطار ", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                }
                finally
                {
                    frm.con.Close();
                }

            
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void cmb1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void tb4_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
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
