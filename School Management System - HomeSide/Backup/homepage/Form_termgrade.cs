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
    public partial class Form_termgrade : Form
    {
        public Form_termgrade()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        SqlDataReader rdr;
        SqlCommand cmd = new SqlCommand();

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

      
         

       

        private void Form_termgrade_Load(object sender, EventArgs e)
        {
            int x = 0;
            string id = frm.ID;
            if (id.Substring(0, 1) == "p")
                id = id.Substring(1,id.Length-1);
            cmd.Connection = frm.con;
            cmd.CommandText = "select distinct lesson.lesson from days_sch,lesson,student  where lesson.id_lesson=days_sch.Id_lesson and days_sch.id_class=student.id_class and student.id_student=" + id ;
            MessageBox.Show(cmd.CommandText);
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
      /*      comboBox3.SelectedIndex = 0;
            domainUpDown1.SelectedIndex = 0;
            cmd.Connection = frm.con;
            cmd.CommandText = "select * from class";
            
            try
            {
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmb1.Items.Add(rdr.GetString(1) + "(" + rdr.GetString(0) + ")");
                }
               
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                frm.con.Close();
                rdr.Close();

            }*/
        }



        private void button1_Click(object sender, EventArgs e)
        {

            int y1 = 0;
            while (y1 < dataGridView1.RowCount)
            {
                dataGridView1.Rows[y1].Cells[1].Tag = null;

                y1++;

            }

            int r = 0;
            int t = 0;
            for (t = 0; t < dataGridView1.RowCount; t++)
                for (r = 1; r < dataGridView1.ColumnCount; r++)
                    dataGridView1.Rows[t].Cells[r].Value = "";

            dataGridView1.Enabled = true;
            string id = frm.ID;
            if (id.Substring(0, 1) == "p")
                id = id.Substring(1, id.Length - 1);
            // button1.Enabled = true;
            // string str;
            int y = 0;
            // int k = 0;
            cmd.CommandText = "select * from term_view where Id_term in (select Id_term from class_lesson where Id_student=" + id + ") and "
            + " year = " + comboBox3.SelectedItem.ToString() + " and term_number=" + domainUpDown1.SelectedItem.ToString();
            try
            {

                frm.con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    y = 0;
                    while (y < dataGridView1.RowCount)
                    {
                        if (dataGridView1.Rows[y].Cells[0].Value.ToString() == rdr.GetString(0))
                        {
                            dataGridView1.Rows[y].Cells[1].Value = rdr.GetDouble(3).ToString();
                            dataGridView1.Rows[y].Cells[1].Tag = "true";
                            break;
                        }
                        y++;

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
    }
}
