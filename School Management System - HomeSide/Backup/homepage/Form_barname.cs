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
    public partial class Form_barname : Form
    {
        public Form_barname()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        Form1 frm = new Form1();
        SqlDataReader rdr;

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

                string id_student;
                id_student = frm.ID;
                if (id_student.Substring(0, 1) == "p")
                {
                    id_student = id_student.Substring(1, id_student.Length-1);
                }
                long id = Int64.Parse(id_student);
                try
                {

                    frm.con.Open();
                    cmd1.Connection = frm.con;
                    // cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.CommandText = "selectclass";
                    cmd1.CommandText = "select days_sch.day,days_sch.time,lesson.lesson,Office_user.last_name" +
                        ",Office_user.first_name from lesson,class_lesson,class,Office_user,days_sch " +
                        "where days_sch.id_class=class.id_class and days_sch.id_lesson=lesson.id_lesson " +
                        "and  lesson.id_lesson=class_lesson.id_lesson and class.id_class=class_lesson.id_class " +
                        "and class_lesson.id_teacher=Office_user.id_office_user and class.id_class=(select id_class from student where id_student="+id_student+")"+
                        " and class_lesson.Id_student=" + id;

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
                            i += 1;
                            j = 1;
                        }


                        dataGridView2.Rows[i].Cells[j].Value = rdr.GetString(2);
                        dataGridView2.Rows[i].Cells[j + 1].Value = rdr.GetString(3);
                        j += 2;
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
            PrintDGV.Print_DataGridView(dataGridView2);
            PrintOptions printfrm = new PrintOptions();
            printfrm.ShowDialog();
        }

       
    }
}
