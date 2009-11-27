using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarsiMessageBox;

namespace homepage
{
    public partial class Form_election : Form
    {
        public Form_election()
        {
            InitializeComponent();
        }
        Form1 frm=new Form1();
        SqlDataReader rdr;
        SqlCommand cmd=new SqlCommand();
        static int op1, op2, op3, op4;
        int id_election;

        private void Form_election_Load(object sender, EventArgs e)
        {
            cmd.Connection=frm.con;
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.CommandText = "active_election";
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                     label1.Text=rdr.GetString(1);
                     radioButton1.Text=rdr.GetString(2);
                     radioButton2.Text=rdr.GetString(3);
                     radioButton3.Text=rdr.GetString(4);
                     radioButton4.Text=rdr.GetString(5);
                     op1 = rdr.GetInt32(10);
                     op2 = rdr.GetInt32(11);
                     op3 = rdr.GetInt32(12);
                     op4 = rdr.GetInt32(13);
                     id_election = rdr.GetInt32(0);
                  
                    
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                op1 = op1 + 1;
            if (radioButton2.Checked)
                op2 += 1;
            if (radioButton3.Checked)
                op3 += 1;
            if (radioButton4.Checked)
                op4 += 1;
            
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.CommandText = "election_update";
            cmd.Parameters.Add("@op1", SqlDbType.Int).Value = op1;
            cmd.Parameters.Add("@op2", SqlDbType.Int).Value = op2;
            cmd.Parameters.Add("@op3", SqlDbType.Int).Value = op3;
            cmd.Parameters.Add("@op4", SqlDbType.Int).Value = op4;
            cmd.Parameters.Add("@id_election", SqlDbType.Int).Value = id_election;
            cmd.Parameters.Add("@p5", SqlDbType.Int).Value = id_election;
            cmd.Parameters.Add("@p6", SqlDbType.BigInt).Value = Int64.Parse(frm.ID);
            try
            {
                MessageBox.Show(op1+"   "+op2+"     "+op3+"      "+op4);
                frm.con.Open();
                cmd.ExecuteNonQuery();
                FMessageBox.Show("نظر شما با موفقیت ثبت شد", " پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                button1.Enabled = false;
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

