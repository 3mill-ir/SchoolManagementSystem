using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiMessageBox;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
using SMS1;

namespace SMS1
{
    public partial class Form_student_register : Form
    {
        int jj;
        Form2 rp = new Form2();
      
        public Form_student_register()
        {
            InitializeComponent();
            jj = this.Height;
        //    kk = this.Width;
            this.Height = 0;
        //    this.Width = 0;
        }
        SqlDataReader rdr;
        Random rd = new Random();

        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
          //      int width = kk;
                int i = 0;
            //    int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
         //           if (k1 < (width - 128))
          //          {
          //              this.Width += 5;
            //        }
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

            Form1 frm1=new Form1();
             static string path;
             private string id;
             public string ID
             {
                 get
                 {
                     return id;
                 }
                 set
                 {
                     id = value;
                 }
             }

        private void tb6_TextChanged(object sender, EventArgs e)
        {
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if ((tb1.Text == "") || (tb2.Text == "") || (tb3.Text == "") || (tb4.SelectedIndex == -1) || (tb5.SelectedIndex == -1) || (tb6.Text == "") || (tb7.Text == "") || (tb8.Text == "") || (cmb1.SelectedIndex == -1) || (cmb2.SelectedIndex == -1) || (cmb3.SelectedIndex == -1) || (cmb4.SelectedIndex == -1) || (cmb5.SelectedIndex == -1))
                {
                    FMessageBox.Show("             تمامی فیلدها را به دقت پر کنید", "توجه", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                }
                else
                {
                    //******************************************************
                    // id = tb1.Text;
                    frm1.con.Open();
                    cmd.Connection = frm1.con;
                    cmd.CommandText = "insert into parrents(Id_parrents,pass_parrents,name_parrents,last_name,tel_parrents,gender ) values (N'" +
                       "P" + tb1.Text + "' ,N'" +
                       rd.Next(1000000) + "' ,N'" +
                       tb6.Text + "' ,N'" +
                       tb7.Text + "' ,N'" +
                       tb8.Text + "' ,N'" +
                       cmb5.SelectedItem.ToString() + "')";

                    cmd.ExecuteNonQuery();

                    //******************************************************

                    cmd.CommandText = "insert into Student(Id_student,pass_student,Id_parrents,first_name,last_name,gender,birthday,level,picture,Id_class ) values (N'" +
                        Int64.Parse(tb1.Text) + "' ,N'" +
                        rd.Next(1000000).ToString() + "',N'" +
                        "p" + tb1.Text + "' ,N'" +
                        tb2.Text + "' ,N'" +
                        tb3.Text + "' ,N'" +
                        cmb1.SelectedItem.ToString() + "', N'" +
                        cmb2.SelectedItem.ToString() + cmb3.SelectedItem.ToString() + cmb4.SelectedItem.ToString() + "' , N'" +
                        tb4.SelectedItem.ToString() + "'," +
                        "@image,N'" +
                         tb5.SelectedItem.ToString() + "')";


                    byte[] filebyte;
                    filebyte = File.ReadAllBytes(path);
                    cmd.Parameters.Add("@image", SqlDbType.Binary).Value = filebyte;

                    cmd.ExecuteNonQuery();

                    //*****************************************************

                    FMessageBox.Show("عملیات با موفقیت اجرا شد", "توجه", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

                    this.Close();

                    DataSet2 ds = new DataSet2();
                    adp.SelectCommand.Connection = frm1.con;
                    adp.SelectCommand.CommandText = "SELECT  * from student where Id_student=" + tb1.Text;
                    
                    ds.Student.Clear();
                    adp.Fill(ds.Student);
                    adp.SelectCommand.CommandText = "select * from parrents where Id_parrents='p" + tb1.Text + "'";
                    ds.parrents.Clear();

                    adp.Fill(ds.parrents);
                    
                    crystalReport31.SetDataSource(ds);
                    rp.crystalReportViewer1.ReportSource = crystalReport31;
                    rp.ShowDialog();

                }
            }
            catch (Exception)
            {
                FMessageBox.Show("ذخیره اطلاعات ناموفق بود", "خطا", FMessageBoxButtons.RetryCancel, FMessageBoxIcons.Error);
            }
            finally
            {
               frm1.con.Close();
            }

        }



             private void Form_student_register_Load(object sender, EventArgs e)
             {
                 cmb1.SelectedIndex = 0;
                 cmb2.SelectedIndex = 0;
                 cmb3.SelectedIndex = 0;
                 cmb4.SelectedIndex = 0;
                 cmb5.SelectedIndex = 0;
            
                 cmd.Connection = frm1.con;
                 try
                 {
                     cmd.CommandText = "select distinct class_level from class";
                     frm1.con.Open();
                     rdr = cmd.ExecuteReader();

                     while (rdr.Read())
                     {
                         
                       tb4.Items.Add(rdr.GetString(0));                     
                     }
                     tb4.SelectedIndex = 0;
                    
                 }
                 catch (Exception E)
                 {
                     MessageBox.Show(E.Message);

                 }
                 finally
                 {
                     frm1.con.Close();
                 }
             }

             private void button1_Click(object sender, EventArgs e)
             {

                 //MessageBoxOptions.RightAlign = this.RightToLeft ;

                 FMessageBox.Show(
                     label1.Text + tb1.Text + "\n\r" +
                     label5.Text + tb2.Text + "\n\r" +
                     label4.Text + tb3.Text + "\n\r" +
                     label19.Text + tb5.Text + "\n\r" +
                     label18.Text + tb7.Text + "\n\r" +
                     label17.Text + tb8.Text + "\n\r"

                     );
             }

             private void button2_Click(object sender, EventArgs e)
             {
                 openf.ShowDialog();
                 pictureBox1.ImageLocation = openf.FileName;
                 path = openf.FileName;
             }

            

             private void tb4_SelectionChangeCommitted(object sender, EventArgs e)
             {
                 tb5.Items.Clear();
                 try
                 {
                     cmd.CommandText = "select Id_class from class where class_level=N'" + tb4.SelectedItem.ToString() + "'";
                     frm1.con.Open();
                     rdr = cmd.ExecuteReader();

                     while (rdr.Read())
                     {
                         tb5.Items.Add(rdr.GetString(0));
                         tb5.SelectedIndex = 0;
                     }
                 }
                 catch (Exception E)
                 {
                     MessageBox.Show(E.Message);

                 }
                 finally
                 {
                     frm1.con.Close();
                 }
             }

             private void tb5_DropDown(object sender, EventArgs e)
             {
                 tb5.Items.Clear();
                 try
                 {
                     cmd.CommandText = "select Id_class from class where class_level=N'" + tb4.SelectedItem.ToString() + "'";
                     frm1.con.Open();
                     rdr = cmd.ExecuteReader();

                     while (rdr.Read())
                     {
                         tb5.Items.Add(rdr.GetString(0));
                         tb5.SelectedIndex = 0;
                     }
                 }
                 catch (Exception E)
                 {
                     MessageBox.Show(E.Message);

                 }
                 finally
                 {
                     frm1.con.Close();
                 }
             }

             private void button3_MouseEnter(object sender, EventArgs e)
             {
                 button3.Size = new System.Drawing.Size(64, 64);
             }

             private void button3_MouseLeave(object sender, EventArgs e)
             {
                 button3.Size = new System.Drawing.Size(48, 48);
             }

             private void button4_MouseEnter(object sender, EventArgs e)
             {
                 button4.Size = new System.Drawing.Size(64, 64);
             }

             private void button4_MouseLeave(object sender, EventArgs e)
             {
                 button4.Size = new System.Drawing.Size(48, 48);
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
