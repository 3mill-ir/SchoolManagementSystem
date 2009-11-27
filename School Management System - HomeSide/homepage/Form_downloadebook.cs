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

namespace homepage
{
    public partial class Form_downloadebook : Form
    {
        public Form_downloadebook()
        {
            InitializeComponent();
        }
        SqlDataReader rdr;
        SqlCommand cmd = new SqlCommand();
        Form1 frm = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGrid1.CurrentRowIndex != -1)
            {
                byte[] filebyte;
                cmd.Connection = frm.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "select_ebook";
                //cmd.Parameters.Add("@id_ebook", SqlDbType.Int).Value = null;
                try
                {
                    cmd.Parameters.Add("@id_ebook", SqlDbType.Int).Value = ds.Tables["ebook"].Rows[dataGrid1.CurrentRowIndex][0];
                    frm.con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        filebyte = rdr.GetSqlBinary(6).Value;
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.ShowDialog();
                        File.WriteAllBytes(sfd.FileName, filebyte);
                    }

                    FMessageBox.Show("عملیات با موفقیت اجرا شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_downloadebook_Load(object sender, EventArgs e)
        {
            try
            {
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Connection = frm.con;
                adp.SelectCommand.CommandText = "select_ebookid";
                adp.Fill(ds, "ebook");
                dataGrid1.SetDataBinding(ds, "ebook");
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
