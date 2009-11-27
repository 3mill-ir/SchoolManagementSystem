using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using farhaniPersianDate;
using FarsiMessageBox;
using System.Data.SqlClient;
using System.Threading;

namespace SMS1
{
    public partial class Form_testarchive : Form
    {
        int jj;
        public Form_testarchive()
        {
            InitializeComponent();
            jj = this.Height;
            //    kk = this.Width;
            this.Height = 0;
            //   this.Width = 0;
        }
        Form1 frm = new Form1();
        SqlDataReader rdr;
        SqlCommand cmd = new SqlCommand();


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
                //  int width = kk;
                int i = 0;
                //   int k1 = 0;
                while (i < height - 39)//|| k1 < width - 126)
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
            if (dataGrid1.CurrentRowIndex != 0)
            {
                DialogResult result = FMessageBox.Show("آیا مایل به حذف تست هستید؟", "سوال", FMessageBoxButtons.YesNo, FMessageBoxIcons.Question);
                if (result == DialogResult.Yes)
                {
                    cmd.CommandText = "delete from test_bank where id_test=" + ds.Tables["test_bank"].Rows[dataGrid1.CurrentRowIndex][0];
                    cmd.CommandType = CommandType.Text;
                    try
                    {

                        frm.con.Open();
                        cmd.ExecuteNonQuery();
                        FMessageBox.Show("عملیات با موفقیت اجرا شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                        ds.Clear();
                        adp.Fill(ds, "test_bank");
                        dataGrid1.SetDataBinding(ds, "test_bank");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                adp.SelectCommand.Connection = frm.con;
                adp.SelectCommand.CommandText = "select Id_test,test from test_bank where type=N'"+comboBox1.SelectedItem.ToString()+"'";
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

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Size = new System.Drawing.Size(64, 64);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new System.Drawing.Size(48, 48);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(64, 64);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(48, 48);
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
