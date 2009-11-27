using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FarsiMessageBox;
using System.IO;
using System.Threading;

namespace SMS1

{
    public partial class Form_Amozesh_register : Form
    {
        int jj;
      //  int kk;
        public Form_Amozesh_register()
        {
            InitializeComponent();

            jj = this.Height;
          //  kk = this.Width;
            this.Height = 0;
           // this.Width = 0;
        }
        
        static string path;
        Form1 frm = new Form1();
       // main_form adm = new main_form();

        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
            //    int width = kk;
                int i = 0;
             //   int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
                //    if (k1 < (width - 128))
                //    {
                //        this.Width += 5;
                //    }
                //    k1 += 5;
                    i += 5;
                }
                panel5.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            pictureBox1.ImageLocation = ofd.FileName;
            path = ofd.FileName;
        }

       

       private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if ((tb1.Text == "") || (tb2.Text == "") || (tb3.Text == "") || (tb4.Text == "") || (tb5.Text == "") || (cmb1.SelectedIndex == -1) || (cmb2.SelectedIndex == -1) ||
                    (cmb3.SelectedIndex == -1) || (cmb4.SelectedIndex == -1) || (cmb5.SelectedIndex == -1) || (cmb6.SelectedIndex == -1))
                    FMessageBox.Show("  فیلدها را به دقت پر نمایید", "توجه", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

                else
                {
                    //********ثبت اطلاعات کاربر

                    cmd.CommandText = "insert into office_user(Id_office_user,pass_office_user,first_name,last_name,user_type,birthday,gender,picture,interested,info ) values (N'" +
                        tb1.Text + "' ,N'" +
                        tb2.Text + "' ,N'" +
                        tb3.Text + "' ,N'" +
                        tb4.Text + "' ,N'" +
                        cmb1.SelectedItem.ToString() + "' , N'" +
                        cmb2.SelectedItem.ToString() + cmb3.SelectedItem.ToString() + cmb4.SelectedItem.ToString() + "' , N'" +
                        cmb5.SelectedItem.ToString() + "'," +
                        "@image,N'" +
                         tb5.Text + "' ,N'" +
                         tb6.Text + "')";

                    cmd.Connection = frm.con;
                    frm.con.Open();
                    //***************************
                    byte[] filebyte;
                    filebyte = File.ReadAllBytes(path);
                    cmd.Parameters.Add("@image", SqlDbType.Binary).Value = filebyte;
                    //***************************
                  //  MessageBox.Show(cmd.CommandText.ToString());
                    cmd.ExecuteNonQuery();

                    FMessageBox.Show("عملیات با موفقیت اجرا شد", "توجه", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    this.Close();
                }
            }

            catch (Exception )
            {

                FMessageBox.Show("ذخیره اطلاعات ناموفق بود", "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
            }

            finally
            {
                frm.con.Close();
            }
        }

        private void Form_Amozesh_register_Load(object sender, EventArgs e)
        {
            cmb1.SelectedIndex = 0;
            cmb2.SelectedIndex = 0;
            cmb3.SelectedIndex = 0;
            cmb4.SelectedIndex = 0;
            cmb5.SelectedIndex = 0;
            cmb6.SelectedIndex = 0;
            path =Directory.GetCurrentDirectory()+"\\noPhoto.jpg";
           
        }

        private void b3_Click(object sender, EventArgs e)
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

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.Size = new System.Drawing.Size(64, 64);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.Size = new System.Drawing.Size(48, 48);
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

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            b2.Size = new System.Drawing.Size(64, 64);
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b2.Size = new System.Drawing.Size(48, 48);
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            FMessageBox.Show(
                label1.Text+tb1.Text+"\n\r"+
                label2.Text+tb2.Text+"\n\r"+
                label6.Text+tb3.Text+"\n\r"+
                label5.Text+tb4.Text+"\n\r"+
                label8.Text+cmb1.SelectedItem.ToString()+"\n\r"+
                label9.Text+tb5.Text+"\n\r"
                );
        }

     
    
        

        

       

        
    }
}