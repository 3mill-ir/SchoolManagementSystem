using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
//using System.dr
using FarsiMessageBox;
using System.IO;
using farhaniPersianDate;
namespace SMS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] c = new char[3];
        SqlDataReader rdr;
         static string id_office_user;
         static string type_office_user;
         cDate date = new cDate();
        public string ID
        {
            get
            {
                return id_office_user;
            }
            set
            {
                id_office_user = value;
            }
        }
        public string user_type
        {
            get
            {
                return type_office_user;
            }
            set
            {
                type_office_user = value;
            }
        }
        public SqlConnection con=new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename="+Application.StartupPath+"\\pipo-sms1.mdf"+";Integrated Security=True;User Instance=True");
        
        private GraphicsPath gpath = new GraphicsPath();
        private void Form1_Load(object sender, EventArgs e)
        {

            Rectangle rc;//
            Image MYBGimage = this.BackgroundImage;
            Bitmap MYBGbmp = new Bitmap(MYBGimage);
            for (int i = 0; i < MYBGbmp.Width; i++)
            {
                for (int j = 0; j < MYBGbmp.Height; j++)
                {
                    rc=new Rectangle(i,j,1,1);
                    if (MYBGbmp.GetPixel(i, j).ToArgb()!=Color.Black.ToArgb())
                    {
                        gpath.AddRectangle(rc);
                    }
                }
            }
            this.Region = new Region(gpath);
            InputLanguage.CurrentInputLanguage = System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-IR"));
        }
      
        private void textBox2_TabIndexChanged(object sender, EventArgs e)
        {
            tb2.Text = "";
        }

        private void textBox1_TabIndexChanged(object sender, EventArgs e)
        {
            tb1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date1=date.Year+"/"+date.Month+"/"+date.Day+"_____"+System.DateTime.Now.TimeOfDay.ToString().Substring(0,8);
           

         //   File.Open(@"c:\WINDOWS\path.txt",0);
            File.WriteAllText(@"c:\WINDOWS\path.txt",con.ConnectionString);
          
            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select Id_office_user,pass_office_user,user_type FROM office_user where Id_office_user='" + Int64.Parse(tb1.Text) + "'";
                con.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                    id_office_user = rdr.GetInt64(0).ToString();
                    type_office_user = rdr.GetString(2);
                    //MessageBox.Show(type_office_user);
                    if ((rdr.GetInt64(0).ToString() + rdr.GetString(1)) == (tb1.Text + tb2.Text))
                    {
                        rdr.Close();
                        cmd.CommandText = "insert into loggin_statistics values('"+date1+"',"+Int64.Parse(tb1.Text)+")";
                        cmd.ExecuteNonQuery();   
                            main_form mainfrm = new main_form();
                            mainfrm.Show();
                            this.Hide();    
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
                MessageBox.Show(E.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void tb1_MouseClick(object sender, MouseEventArgs e)
        {
            tb1.Text = "";
        }
        private void tb2_MouseClick(object sender, MouseEventArgs e)
        {
            tb2.Text = "";
        }
    }
}