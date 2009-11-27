using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using FarsiMessageBox;
using System.Threading;

namespace SMS1
{
    public partial class Form_email : Form
    {
        int jj;
      //  int kk;
        public Form_email()
        {
            InitializeComponent();
            jj = this.Height;
      //      kk = this.Width;
            this.Height = 0;
      //      this.Width = 0;
        }
        string filepath;
        Form1 frm = new Form1();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
       static byte[] filebyte;
       static Boolean b=false;



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
       //            if (k1 < (width - 128))
       //            {
        //               this.Width += 5;
        //           }
        //           k1 += 5;
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


        private void Form_email_Load(object sender, EventArgs e)
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
            //********************************************************************


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            checkedListBox1.Items.Clear();
            if (comboBox1.SelectedIndex != 0)
            {  string str = comboBox1.SelectedItem.ToString();
                int i = str.IndexOf('(');
                int j = str.IndexOf(')');
                string str2 = str.Substring(i + 1, j - i - 1);
                cmd.CommandText = "select first_name,last_name,id_student from student where Id_class=N'" + str2 + "'";
            }
            else{
                cmd.CommandText = "select first_name,last_name,id_student from student ";
            }
              

                
                try
                {
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        checkedListBox1.Items.Add(rdr.GetString(1) + " " + rdr.GetString(0)+" ("+rdr.GetSqlInt64(2).ToString()+")");
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

        

        private void button4_Click(object sender, EventArgs e)
        {

            tb1.Text = "";
            CheckedListBox.CheckedItemCollection chi = checkedListBox1.CheckedItems;
           for (int i = 0; i < chi.Count; i++)
             tb1.Text +=chi[i]+",";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            filepath=opf.FileName;
            if (filepath != "")
                b = true;

            label6.Text = opf.SafeFileName;
            filebyte = File.ReadAllBytes(filepath);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string str2, str;

           
            CheckedListBox.CheckedItemCollection chi = checkedListBox1.CheckedItems;
            if (chi.Count != 0)
                for (int x = 0; x < chi.Count; x++)
                {

                    str = chi[x].ToString();
                    int i = str.IndexOf('(');
                    int j = str.IndexOf(')');
                    str2 = str.Substring(i + 1, j - i - 1);
                    if (b==false)
                    {

                        cmd.CommandText = "insert into mail_box values ('" + str2 + "','" + frm.ID + "','" + System.DateTime.Now.ToString() + "',N'" +
                            tb2.Text + "',N'" + richTextBox1.Text + "','false',NULL)";
                    }
                    else
                    {
                        cmd.CommandText = "insert into mail_box values ('" + str2 + "','" + frm.ID + "','" + System.DateTime.Now.ToString() + "',N'" +
                                                   tb2.Text + "',N'" + richTextBox1.Text + "','false',@file" + x + ")";
                        cmd.Parameters.Add("@file" + x, SqlDbType.Binary).Value = filebyte;
                    }
                    //******************************************

                   

                    //******************************************
                   
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
                        b = false;
                    }
                }
            else
            {
                FMessageBox.Show("گیرنده ای انتخاب نشده است", "توجه", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
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

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Size = new System.Drawing.Size(64, 30);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new System.Drawing.Size(48, 30);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Size = new System.Drawing.Size(64, 64);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new System.Drawing.Size(48, 48);
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

   
     
        }


    }


