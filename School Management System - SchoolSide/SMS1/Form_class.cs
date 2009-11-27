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
    public partial class Form_class : Form
    {
        int jj;
       // int kk;
        public Form_class()
        {
            InitializeComponent();
            jj = this.Height;
        //    kk = this.Width;
            this.Height = 0;
         //   this.Width = 0;
        }
        Form1 frm1 = new Form1();
        SqlDataReader rdr;
        Boolean update = false;
        static string str_edit;


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
              //  int width = kk;
                int i = 0;
             //   int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
              //      if (k1 < (width - 128))
              //      {
              //          this.Width += 5;
              //      }
             //       k1 += 5;
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text != "" && tb2.Text != "")

                if (listBox1.FindStringExact(tb1.Text + "(" + tb2.Text + ")").Equals(-1))

                    try
                    {

                        if (update == false)
                        {
                            cmd.CommandText = "insert into class (Id_class,class_level) values (N'" + tb2.Text + "',N'" + tb1.Text + "')";
                            frm1.con.Open();
                            cmd.ExecuteNonQuery();
                            listBox1.Items.Clear();

                        }
                        else
                        {
                            cmd.CommandText = "update class set id_class=N'" + tb2.Text + "',class_level=N'" + tb1.Text + "'where id_class=N'" + str_edit + "'";
                            frm1.con.Open();
                            cmd.ExecuteNonQuery();
                            listBox1.Items.Clear();


                        }
                        cmd.CommandText = "select * from class";
                        rdr = cmd.ExecuteReader();




                        while (rdr.Read())
                        {
                            listBox1.Items.Add(rdr.GetString(1) + "(" + rdr.GetString(0) + ")");

                        }

                    }
                    catch (Exception )
                    {
                       FMessageBox.Show("كلاسي با اين شناسه وجود دارد","خطا",FMessageBoxButtons.OK,FMessageBoxIcons.Warning);

                    }
                    finally
                    {
                        frm1.con.Close();
                        update = false;

                    }
                else
                {
                    FMessageBox.Show("این درس در لیست وجود دارد", "توجه ", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                   
                }
            else
            {
                FMessageBox.Show("فيلدهاي مورد نظر را پر كنيد", "توجه ", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
            }
        }

        private void Form_class_Load(object sender, EventArgs e)
        {
            cmd.Connection = frm1.con;
            try
            {
                cmd.CommandText = "select * from class";
                frm1.con.Open();
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetString(1) + "(" + rdr.GetString(0) + ")");

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string str = listBox1.SelectedItem.ToString();
                int i = str.IndexOf('(');
                int j = str.IndexOf(')');
                str = str.Substring(i + 1, j - i - 1);
                if (FMessageBox.Show("كلاس مورد نظر حذف شود؟", "پیغام", FMessageBoxButtons.OKCancel, FMessageBoxIcons.Information) == DialogResult.OK)
                {
                    try
                    {
                        cmd.CommandText = "Delete from class where Id_class=N'" + str + "'";
                        frm1.con.Open();
                        cmd.ExecuteNonQuery();
                        FMessageBox.Show("عملیات با موفقیت اجرا شد", "توجه ", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                        listBox1.Items.Remove(listBox1.SelectedItem);


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
            }
            else
                FMessageBox.Show("هيچ ركوردي انتخاب نشده است!", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {               
                 update = true;
                 string str2, str1;
                 string str = listBox1.SelectedItem.ToString();
                 int i = str.IndexOf('(');
                 int j = str.IndexOf(')');
                 str2 = str.Substring(i + 1, j - i - 1);
                 str1 = str.Substring(0, i);
                 str_edit = str2;
                 tb1.Text = str1;
                 tb2.Text = str2;

            }

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(64, 30);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(48, 30);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Size = new System.Drawing.Size(64, 64);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new System.Drawing.Size(48, 48);
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
    

