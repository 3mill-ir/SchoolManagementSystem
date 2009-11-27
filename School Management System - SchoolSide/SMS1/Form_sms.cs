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
using System.IO;
using System.Threading;

namespace SMS1
{
    public partial class Form_sms : Form
    {
        int jj;
      //  int kk;
        public Form_sms()
        {
            InitializeComponent();
            jj = this.Height;
        //    kk = this.Width;
            this.Height = 0;
       //     this.Width = 0;
        }
        Form1 frm = new Form1();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        String reciever;


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
               int height = jj;
           //     int width = kk;
                int i = 0;
         //       int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
           //         if (k1 < (width - 128))
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


        private void Form_sms_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("--همه--");
            cmd.Connection = frm.con;
            cmd.CommandText = "select * from class ";
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBox1.Items.Add(rdr.GetString(1) + "(" + rdr.GetString(0) + ")");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                frm.con.Close();
            }
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            if (comboBox1.SelectedIndex != 0)
            {
                string str = comboBox1.SelectedItem.ToString();
                int i = str.IndexOf('(');
                int j = str.IndexOf(')');
                string str2 = str.Substring(i + 1, j - i - 1);

           
                cmd.CommandText = "select first_name,last_name,id_student from student where Id_class=N'" + str2 + "'";
            }
            else
            {
                cmd.CommandText = "select first_name,last_name,id_student from student ";
            }

            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    checkedListBox1.Items.Add(rdr.GetString(1) + " " + rdr.GetString(0) + " (" + rdr.GetSqlInt64(2).ToString() + ")");
                }
            }
            catch (Exception )
            {
                FMessageBox.Show("مشكلي در ديتابيس وجود دارد", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
            }
            finally
            {
                frm.con.Close();
            }
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            string str2, str;
            CheckedListBox.CheckedItemCollection chi = checkedListBox1.CheckedItems;
            if (richTextBox1.Text!="")
            {
                if (chi.Count != 0)
                {
                    for (int x = 0; x < chi.Count; x++)
                    {

                        str = chi[x].ToString();
                        int i = str.IndexOf('(');
                        int j = str.IndexOf(')');
                        str2 = str.Substring(i + 1, j - i - 1);

                        cmd.CommandText = "select parrents.tel_parrents from student,parrents where parrents.Id_parrents=student.Id_parrents and Id_student='" + str2 + "'";


                        try
                        {
                            frm.con.Open();
                            rdr = cmd.ExecuteReader();
                            if (rdr.Read())
                                reciever += rdr.GetInt64(0).ToString() + ",";

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
                    ///////////////////////////////

                    cmd.CommandText = "insert into sms_archive values(N'" + textBox1.Text + "',N'" + richTextBox1.Text + "','" +
                        System.DateTime.Now.ToString() + "','" + frm.ID + "','" + reciever + "')";
                    try
                    {
                        frm.con.Open();

                        cmd.ExecuteNonQuery();
                        FMessageBox.Show("عمليات با موفقيت اجرا شد", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

                    }
                    catch (Exception)
                    {
                        FMessageBox.Show("مشكلي در ارسال پيامك به وجود آمده است", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
                    }
                    finally
                    {
                        frm.con.Close();

                    }
                    File.WriteAllText("C:\\GSM_OutPut.txt", reciever + "\n\r\n\r" + richTextBox1.Text);
                }
                else
                {
                    FMessageBox.Show("گیرنده ای انتخاب نشده است", "توجه", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                }
            }
            else
            {
                FMessageBox.Show("متن پیامک خود را وارد کنید", "توجه", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
            }

        }

        private void b1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
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
