using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarsiMessageBox;
using System.Data.SqlClient;

namespace homepage
{
    public partial class Form_editpass : Form
    {
        public Form_editpass()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        string pass;

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Connection = frm.con;
            string id=frm.ID;
            string subid=id.Substring(0,1);
            
            if (textBox1.Text == textBox2.Text)
            {
                if (textBox1.Text != "" && textBox3.Text!="")
                {
                    try
                    {
                        frm.con.Open();
                        if (subid != "p")
                        {
                            cmd.CommandText = "select pass_student from student where id_student=" + id ;
                        }
                        else
                        {
                            cmd.CommandText = "select pass_parrents from parrents where id_parrents=" + id;
                        }
                        rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            pass = rdr.GetString(0);
                        }

                    }

                    catch (Exception)
                    {
                        
                    }
                    finally
                    {
                        frm.con.Close();
                    } 
                    try
                    {
                        frm.con.Open();
                        if (pass == textBox1.Text)
                        {
                            if (subid != "p")
                            {
                                cmd.CommandText = "update student set pass_student='" + textBox3.Text + "'where id_student="+id;
                            }
                            else
                            {
                                cmd.CommandText = "update parrents set pass_parrents='" + textBox3.Text + "' where id_parrents='"+id+"'";
                            }
                            cmd.ExecuteNonQuery();
                            FMessageBox.Show("کلمه عبور تغییر کرد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

                        }
                        else
                        {
                            FMessageBox.Show("کلمه عبور اشتباه است","هشدار",FMessageBoxButtons.OK,FMessageBoxIcons.Warning);
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

            }
            else
            {
                FMessageBox.Show("بین کلمه عبور و تکرار آن مطابقت وجود ندارد","توجه",FMessageBoxButtons.OK,FMessageBoxIcons.Warning);
            }
        }
    }
}
