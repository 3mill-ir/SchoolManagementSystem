using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMS1
{
    public partial class Form_Test : Form
    {
        public Form_Test()
        {
            InitializeComponent();
        }

       // SqlConnection con;
        private void Form_Test_Load(object sender, EventArgs e)
        {
         /*   try
            {
                Form1 frm = new Form1();
                con = frm.con;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.SelectCommand.CommandText = "select * from lesson";
                DataSet1 ds = new DataSet1();
                ds.lesson.Clear();
                adp.Fill(ds.lesson);
                dataGridView1.DataSource = ds.lesson;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
