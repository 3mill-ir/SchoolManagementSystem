using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using FarsiMessageBox;
using System.IO;

namespace homepage
{
    public partial class Form_mail : Form
    {
        public Form_mail()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        SqlDataReader rdr;
        SqlCommand cmd = new SqlCommand();
        ArrayList arr = new ArrayList();


        private void Form_mail_Load(object sender, EventArgs e)
        {
           
            cmd.CommandText = "select mail_box.[id-sender],mail_box.subject,mail_box.id_mail_box from mail_box,office_user where mail_box.[id-sender]=office_user.id_office_user and mail_box.id_receiver="+frm.ID;
            try
            {
                cmd.Connection = frm.con;
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetValue(0).ToString()+"   موضوع(" + rdr.GetValue(1).ToString()+")");
                    arr.Add(rdr.GetValue(2));
                }
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

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          

            cmd.CommandText = "select mail_box.*,office_user.first_name from mail_box,office_user where mail_box.[id-sender]=office_user.id_office_user And mail_box.id_mail_box="+arr[listBox1.SelectedIndex];
            try
            {

                frm.con.Open();
                rdr = cmd.ExecuteReader();
                
                richTextBox1.Enabled = true;
                while (rdr.Read())
                {

                    tb1.Text = rdr.GetValue(2).ToString();
                    tb2.Text = rdr.GetString(4);
                    richTextBox1.Text = rdr.GetString(5);
                    if (rdr.GetValue(7).ToString() != "")
                    {
                        label2.Visible = true;
                        label6.Visible = true;



                    }
                    else if(rdr.GetValue(7).ToString() == "")
                    {
                        label2.Visible = false;
                        label6.Visible = false;
                    }
                    
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                cmd.CommandText = "delete from mail_box where mail_box.id_mail_box=" + arr[listBox1.SelectedIndex];
                try
                {
                    cmd.Connection = frm.con;
                    frm.con.Open();
                    if (FMessageBox.Show("پست مورد نظر حذف شود؟", "پیغام", FMessageBoxButtons.OKCancel, FMessageBoxIcons.Information) == DialogResult.OK)
                    {
                        cmd.ExecuteNonQuery();
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        tb1.Text = "";
                        tb2.Text = "";
                        richTextBox1.Text = "";
                        label6.Text = "";
                    }


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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            byte[] filebyte;
            cmd.CommandText = "select attachment from mail_box where mail_box.id_mail_box=" + arr[listBox1.SelectedIndex];
            try
            {
                cmd.Connection = frm.con;
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                     filebyte = rdr.GetSqlBinary(0).Value;
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.ShowDialog();
                    File.WriteAllBytes(sfd.FileName, filebyte);
                }
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
}
