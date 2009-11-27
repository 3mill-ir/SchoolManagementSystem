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

namespace homepage
{
    public partial class Form_dailywords : Form
    {
        public Form_dailywords()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_dailywords_Load(object sender, EventArgs e)
        {
            cmd.Connection=frm.con;
            cmd.CommandText="select * from daily_words where date='1388/12/01'";
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    richTextBox1.Text = rdr.GetString(1);
                    
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
}
