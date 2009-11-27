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
using System.Data.OleDb;

namespace homepage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        OleDbConnection oledbcon1=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\speech.accdb");
        public SqlConnection con = new SqlConnection(File.ReadAllText(@"c:\WINDOWS\path.txt"));
        OleDbCommand oledbcmd = new OleDbCommand();
        OleDbDataReader oledbrdr;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        //**********************************************************
        static string id_student;
        public string ID
        {
            get
            {
                return id_student;
            }
            set
            {
                id_student = value;
            }
        }
        //*************************************************************
        static string id_class;
        public string ID_class
        {
            get
            {
                return id_class;
            }
            set
            {
                id_class = value;
            }
        }
        //*********************************************************************
        private void b1_Click(object sender, EventArgs e)
        {

            if (tb1.Text != "" && tb2.Text!="")
            {
                try
                {

                string s = tb1.Text;
                s = s.Substring(0, 1);
                cmd.Connection = con;
               
                if (s == "p")
                {
                    /*cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "select_id_parrent";
                    cmd.Parameters.Add("@id_parrent", SqlDbType.NVarChar).Value = tb1.Text;
                */
                    cmd.CommandText="select parrents.id_parrents,parrents.pass_parrents,student.id_student,student.id_class FROM parrents,student "
                 	+"where student.id_parrents=parrents.id_parrents AND parrents.id_parrents='"+tb1.Text+"'";
                      }
                else
                {

                    cmd.CommandText = "select student.id_student,student.pass_student,id_student,id_class  FROM student where Id_student=" + Int64.Parse(tb1.Text);
                }
                
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    if (rdr.HasRows)
                    {

                        id_student = rdr.GetValue(2).ToString();
                        if (rdr.GetValue(1).ToString() == tb2.Text)
                        {
                            id_class = rdr.GetString(3);
                            this.Hide();
                            Form_main mainfrm = new Form_main();
                            mainfrm.Show();
                            
                        }
                        else
                        {
                            FMessageBox.Show("کلمه عبور را اشتباه وارد کرده اید ", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
                        }

                    }
                    else
                    {
                        FMessageBox.Show(" نام کاربری را اشتباه وارد کرده اید ", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
                    }


                }
                catch (Exception E)
                {
                    FMessageBox.Show(" نام کاربری را اشتباه وارد کرده اید ", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Error);

                }
                finally
                {
                    con.Close();
                }
            }
            
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb1_MouseClick(object sender, MouseEventArgs e)
        {
            tb1.Text = null;
        }

        private void tb2_MouseClick(object sender, MouseEventArgs e)
        {
            tb2.Text = null;
        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.Size = new System.Drawing.Size(64, 64);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.Size = new System.Drawing.Size(48, 48);
        }

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            b2.Size = new System.Drawing.Size(64,64);
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b2.Size = new System.Drawing.Size(48, 48);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Random rn=new Random();
                oledbcmd.Connection = oledbcon1;
                oledbcon1.Open();
                oledbcmd.CommandText = "select * from speeches where counter="+rn.Next(1,15);
                oledbrdr = oledbcmd.ExecuteReader();
                if (oledbrdr.Read())
                {
                    label1.Text = oledbrdr.GetString(2);
                    label2.Text = oledbrdr.GetString(1);
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

       
       

       
    }
}
