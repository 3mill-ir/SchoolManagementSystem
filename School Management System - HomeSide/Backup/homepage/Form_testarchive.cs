using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using farhaniPersianDate;
using FarsiMessageBox;

namespace homepage
{
    public partial class Form_testarchive : Form
    {
        public Form_testarchive()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;

        private void Form_testarchive_Load(object sender, EventArgs e)
        {
            try
            {
                frm.con.Open();
                cmd.Connection = frm.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Select_lesson";
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBox1.Items.Add(rdr.GetString(1));
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
            MessageBox.Show(ds.Tables["test_bank"].Rows[dataGrid1.CurrentRowIndex][1].ToString(),"تست");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                adp.SelectCommand.Connection = frm.con;
                adp.SelectCommand.CommandText = "select Id_test,test from test_bank where type=N'" + comboBox1.SelectedItem.ToString() + "'";
                ds.Clear();
                adp.Fill(ds, "test_bank");
                dataGrid1.SetDataBinding(ds, "test_bank");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.con.Close();
            }
        }
    }
}
