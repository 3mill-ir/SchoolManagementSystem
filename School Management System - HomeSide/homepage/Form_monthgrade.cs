using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace homepage
{
    public partial class Form_monthgrade : Form
    {
        public Form_monthgrade()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();
        Form1 frm = new Form1();
        SqlDataReader rdr;
        private void button3_Click(object sender, EventArgs e)
        {
           
            string id;
            id = frm.ID;
            if (frm.ID.Substring(0, 1) == "p")
            {
                id = frm.ID.Substring(1, frm.ID.Length);
            }
            int r = 0;
            int t = 0;
            for (t = 0; t < dataGridView1.RowCount; t++)
                for (r = 1; r < dataGridView1.ColumnCount; r++)
                    dataGridView1.Rows[t].Cells[r].Value = "";
            dataGridView1.Enabled = true;
            string str;
            int y = 0;
            int k = 0;
            cmd.CommandText = "select * from month_view where Id_term in (select Id_term from class_lesson where Id_student=" + id + ") and "
            + " date Like N'" + comboBox3.Text + comboBox4.Text + "%'";
            // MessageBox.Show(cmd.CommandText);
            try
            {

                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    y = 0;
                    str = rdr.GetString(2);
                    str = str.Substring(6, 2);
                    //   MessageBox.Show(str);
                    k = Int16.Parse(str);
                    //   MessageBox.Show(k.ToString());
                    //   MessageBox.Show(rdr.GetDouble(3).ToString());
                    while (y < dataGridView1.RowCount)
                    {
                        if (dataGridView1.Rows[y].Cells[0].Value.ToString() == rdr.GetString(0))
                        {
                            dataGridView1.Rows[y].Cells[k].Value = rdr.GetDouble(3).ToString();
                            dataGridView1.Rows[y].Cells[k].Tag = "true";
                            // MessageBox.Show(y+"     "+k);
                            break;
                        }
                        y++;

                    }
                }

            }
            catch (Exception E)
            {
                //   MessageBox.Show(y + "     " + k);
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex <= 5)
            {
                
                dataGridView1.ColumnCount = 32;
                dataGridView1.Columns[31].HeaderText = "31";
            }
            else
            {
                dataGridView1.ColumnCount = 31;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    dataGridView1.Rows[i].Cells[j].Value = "";
        }

        private void Form_monthgrade_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;

            
            //**********************************
            int x = 0;
            string id;
            id = frm.ID;
            if (frm.ID.Substring(0, 1) == "p")
            {
                id = frm.ID.Substring(1, frm.ID.Length);
            }
            cmd.Connection = frm.con;
            cmd.CommandText = "select distinct lesson.lesson from days_sch,lesson  where lesson.id_lesson=days_sch.Id_lesson and" +
                " id_class in(select id_class from student where id_student=" + id+")";
            dataGridView1.Rows.Clear();
            try
            {

                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[x].Cells[0].Value = rdr.GetString(0);
                    x++;
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    dataGridView1.Rows[i].Cells[j].Value = "";
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    dataGridView1.Rows[i].Cells[j].Value = "";
        }
    }
}

