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
using System.Threading;
using SMS1;

namespace SMS1
{
    public partial class Form_barname : Form
    {
        int jj;
      //  int kk;
        public Form_barname()
        {
            InitializeComponent();
            jj = this.Height;
        //    kk = this.Width;
            this.Height = 0;
         //   this.Width = 0;
        }
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        Form1 frm = new Form1();
        SqlDataReader rdr;
        


        //////////////////////
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
            {
                int height = jj;
           //     int width = kk;
                int i = 0;
           //     int k1 = 0;
                while (i < height - 39 )//|| k1 < width - 126)
                {
                    Thread.Sleep(1);
                    if (i < (height - 39))
                    {

                        this.Height += 5;
                    }
               //     if (k1 < (width - 128))
              //      {
               //         this.Width += 5;
                //    }
                //    k1 += 5;
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


        private void Form_barname_Load(object sender, EventArgs e)
        {
            dataGridView2.RowCount = 6;
                dataGridView2.Rows[0].Cells[0].Value = "شنبه";
                dataGridView2.Rows[1].Cells[0].Value = "یکشنبه";
                dataGridView2.Rows[2].Cells[0].Value = "دوشنبه";
                dataGridView2.Rows[3].Cells[0].Value = "سه شنبه";
                dataGridView2.Rows[4].Cells[0].Value = "چهارشنبه";
                dataGridView2.Rows[5].Cells[0].Value = "پنج شنبه";
            //****************************************************************

                try
                {
                    frm.con.Open();
                    cmd.Connection = frm.con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "selectclass";
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        comboBox1.Items.Add(rdr.GetString(0));
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
            int r = 0;
            int t = 0;
            for (t = 0; t < dataGridView2.RowCount; t++)
                for (r = 1; r < dataGridView2.ColumnCount; r++)
                    dataGridView2.Rows[t].Cells[r].Value = "";
            try
            {
                frm.con.Open();
                cmd1.Connection = frm.con;
               /* cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "select_barname";
                cmd1.Parameters.Add("@id_class", SqlDbType.NVarChar).Value = comboBox1.SelectedItem.ToString();*/
               cmd1.CommandText = "select days_sch.day,days_sch.time,lesson.lesson,Office_user.last_name"+
                    ",Office_user.first_name from lesson,class_lesson,class,Office_user,days_sch "+
                    "where days_sch.id_class=class.id_class and days_sch.id_lesson=lesson.id_lesson "+
                    "and  lesson.id_lesson=class_lesson.id_lesson and class.id_class=class_lesson.id_class "+
                    "and class_lesson.id_teacher=Office_user.id_office_user and class.id_class='"
                    +comboBox1.SelectedItem.ToString()+"'";
               // MessageBox.Show(cmd1.CommandText);
                int j = 1;
                int i = 0;
                rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                {
                    if (i > 6)
                    {
                        i = 0;
                    }
                    if (j > 7)
                    {
                        i+= 1;
                        j = 1;
                    }
                   
                   
                    dataGridView2.Rows[i].Cells[j].Value = rdr.GetString(2);
                    dataGridView2.Rows[i].Cells[j+1].Value = rdr.GetString(3);
                    j+=2;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedIndex != -1)
                {
                    Form2 report = new Form2();
                  
                    string id_class = comboBox1.SelectedItem.ToString();
                    report.crystalReportViewer1.ReportSource = crystalReport11;
                    crystalReport11.SetParameterValue("p1", "CLASS");
                    crystalReport11.SetParameterValue("t1", dataGridView2.Rows[0].Cells[1].Value.ToString());
                    crystalReport11.SetParameterValue("t2", dataGridView2.Rows[1].Cells[1].Value.ToString());
                    crystalReport11.SetParameterValue("t3", dataGridView2.Rows[2].Cells[1].Value.ToString());
                    crystalReport11.SetParameterValue("t4", dataGridView2.Rows[3].Cells[1].Value.ToString());
                    crystalReport11.SetParameterValue("t5", dataGridView2.Rows[4].Cells[1].Value.ToString());
                    crystalReport11.SetParameterValue("t6", dataGridView2.Rows[5].Cells[1].Value.ToString());
                    crystalReport11.SetParameterValue("t7", dataGridView2.Rows[0].Cells[3].Value.ToString());
                    crystalReport11.SetParameterValue("t8", dataGridView2.Rows[1].Cells[3].Value.ToString());
                    crystalReport11.SetParameterValue("t9", dataGridView2.Rows[2].Cells[3].Value.ToString());
                    crystalReport11.SetParameterValue("t10", dataGridView2.Rows[3].Cells[3].Value.ToString());
                    crystalReport11.SetParameterValue("t11", dataGridView2.Rows[4].Cells[3].Value.ToString());
                    crystalReport11.SetParameterValue("t12", dataGridView2.Rows[5].Cells[5].Value.ToString());
                    crystalReport11.SetParameterValue("t13", dataGridView2.Rows[0].Cells[5].Value.ToString());
                    crystalReport11.SetParameterValue("t14", dataGridView2.Rows[1].Cells[5].Value.ToString());
                    crystalReport11.SetParameterValue("t15", dataGridView2.Rows[2].Cells[5].Value.ToString());
                    crystalReport11.SetParameterValue("t16", dataGridView2.Rows[3].Cells[5].Value.ToString());
                    crystalReport11.SetParameterValue("t17", dataGridView2.Rows[4].Cells[5].Value.ToString());
                    crystalReport11.SetParameterValue("t18", dataGridView2.Rows[5].Cells[5].Value.ToString());
                    crystalReport11.SetParameterValue("t19", dataGridView2.Rows[0].Cells[7].Value.ToString());
                    crystalReport11.SetParameterValue("t20", dataGridView2.Rows[1].Cells[7].Value.ToString());
                    crystalReport11.SetParameterValue("t21", dataGridView2.Rows[2].Cells[7].Value.ToString());
                    crystalReport11.SetParameterValue("t22", dataGridView2.Rows[3].Cells[7].Value.ToString());
                    crystalReport11.SetParameterValue("t23", dataGridView2.Rows[4].Cells[7].Value.ToString());
                    crystalReport11.SetParameterValue("t24", dataGridView2.Rows[5].Cells[7].Value.ToString());
                    crystalReport11.SetParameterValue("t25", dataGridView2.Rows[0].Cells[2].Value.ToString());
                    crystalReport11.SetParameterValue("t26", dataGridView2.Rows[1].Cells[2].Value.ToString());
                    crystalReport11.SetParameterValue("t27", dataGridView2.Rows[2].Cells[2].Value.ToString());
                    crystalReport11.SetParameterValue("t28", dataGridView2.Rows[3].Cells[2].Value.ToString());
                    crystalReport11.SetParameterValue("t29", dataGridView2.Rows[4].Cells[2].Value.ToString());
                    crystalReport11.SetParameterValue("t30", dataGridView2.Rows[5].Cells[2].Value.ToString());
                    crystalReport11.SetParameterValue("t31", dataGridView2.Rows[0].Cells[4].Value.ToString());
                    crystalReport11.SetParameterValue("t32", dataGridView2.Rows[1].Cells[4].Value.ToString());
                    crystalReport11.SetParameterValue("t33", dataGridView2.Rows[2].Cells[4].Value.ToString());
                    crystalReport11.SetParameterValue("t34", dataGridView2.Rows[3].Cells[4].Value.ToString());
                    crystalReport11.SetParameterValue("t35", dataGridView2.Rows[4].Cells[4].Value.ToString());
                    crystalReport11.SetParameterValue("t36", dataGridView2.Rows[5].Cells[4].Value.ToString());
                    crystalReport11.SetParameterValue("t37", dataGridView2.Rows[0].Cells[6].Value.ToString());
                    crystalReport11.SetParameterValue("t38", dataGridView2.Rows[1].Cells[6].Value.ToString());
                    crystalReport11.SetParameterValue("t39", dataGridView2.Rows[2].Cells[6].Value.ToString());
                    crystalReport11.SetParameterValue("t40", dataGridView2.Rows[3].Cells[6].Value.ToString());
                    crystalReport11.SetParameterValue("t41", dataGridView2.Rows[4].Cells[6].Value.ToString());
                    crystalReport11.SetParameterValue("t42", dataGridView2.Rows[5].Cells[6].Value.ToString());
                    crystalReport11.SetParameterValue("t43", dataGridView2.Rows[0].Cells[8].Value.ToString());
                    crystalReport11.SetParameterValue("t44", dataGridView2.Rows[1].Cells[8].Value.ToString());
                    crystalReport11.SetParameterValue("t45", dataGridView2.Rows[2].Cells[8].Value.ToString());
                    crystalReport11.SetParameterValue("t46", dataGridView2.Rows[3].Cells[8].Value.ToString());
                    crystalReport11.SetParameterValue("t47", dataGridView2.Rows[4].Cells[8].Value.ToString());
                    crystalReport11.SetParameterValue("t48", dataGridView2.Rows[5].Cells[8].Value.ToString());
                    crystalReport11.SetParameterValue("p1", id_class);
                    report.ShowDialog();
                    
                }
                else
                {
                    FMessageBox.Show("کلاس مورد نظر را انتخاب کنید", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                }
            }
            catch
            {

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
