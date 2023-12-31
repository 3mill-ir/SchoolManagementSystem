using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using farhaniPersianDate;

namespace homepage
{
    public partial class Form_chart : Form
    {
        Form1 frm = new Form1();
        Form_main mainf=new Form_main();
        int[] alWeight;
        Rectangle rectangle;
        public SqlConnection con = new SqlConnection(File.ReadAllText(@"c:\WINDOWS\path.txt"));
        SqlCommand cmd = new SqlCommand();
    
        SqlDataReader rdr;

        ArrayList lessonlist = new ArrayList();
        cDate date = new cDate();
        public Form_chart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(mainf.Width/2-this.Width/2+70, mainf.tabControl1.Location.Y+60);
            {
                try
                {


                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "select distinct lesson.lesson from days_sch,lesson  where lesson.id_lesson=days_sch.Id_lesson and id_class='" + frm.ID_class + "'";
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        lessonlist.Add(rdr.GetString(0));
                    }

                    for (int y=0; y < lessonlist.Count; y++)
                    {
                        listBox1.Items.Add("ستونهای"+(y+1).ToString()+"درس----"+lessonlist[y].ToString());
                    }
                }
                catch (Exception e1)
                {
                   // MessageBox.Show(e1.Message);
                  
                }
             
            }
            try
            {
                {
                    int k = 0;
                    ArrayList n = new ArrayList();
                    n.Add(20);

                    while (k < lessonlist.Count)
                    {

                        con.Close();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "select * from month_view where Id_term in (select Id_term from class_lesson where Id_student=" + frm.ID + ") and "
                    + " date Like N'" + date.Year + "" + date.Month +"%' and lesson=N'" + lessonlist[k] + "'";
                        //MessageBox.Show(cmd.CommandText);
                        double sum = 0;

                        int rdrn = 0;
                        int avarage;
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            sum += rdr.GetDouble(3);
                          //  MessageBox.Show(rdr.GetDouble(3).ToString());
                            rdrn++;
                        }
                     
                        if (sum == 0)
                        {
                            avarage = 0;
                            n.Add(avarage);
                        }
                        else
                        {

                            avarage = (int)Double.Parse((sum / rdrn).ToString());
                            n.Add(avarage);
                        }

                        k++;
                    }
                    alWeight = new int[lessonlist.Count * 2 + 1];
                    int s = 1;

                    for (int i = 1; i <n.Count; i += 1)
                    {
                      

                        alWeight[s] = Int32.Parse(n[i].ToString());
                      
                        s += 2;
                    }
                  
                   alWeight[0] = Int32.Parse(n[0].ToString());
                }
             //  *******************************************************************************  

                {
                    int k = 0;
                    ArrayList n1 = new ArrayList();


                    while (k < lessonlist.Count)
                    {

                        con.Close();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "select * from month_view where Id_term in (select Id_term from class_lesson where id_class='"+frm.ID_class+"' )and "
                    + " date Like N'" +date.Year+""+date.Month + "%' and lesson=N'" + lessonlist[k] + "'";
                      //MessageBox.Show(cmd.CommandText);
                        double sum = 0;

                        int rdrn = 0;
                        int avarage;
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            sum += rdr.GetDouble(3);
                           // MessageBox.Show(rdr.GetDouble(3).ToString());
                            rdrn++;
                        }
                        //MessageBox.Show(sum.ToString());
                        if (sum == 0)
                        {
                            avarage = 0;
                            n1.Add(avarage);
                        }
                        else
                        {

                            avarage = (int)Double.Parse((sum / rdrn).ToString());
                           // MessageBox.Show(sum.ToString());
                            n1.Add(avarage);
                        }

                        k++;
                    }
                  //  MessageBox.Show(n1.Count.ToString()+"  "+n1[2].ToString());
                    int s = 2;
                    for (int i = 0; i < n1.Count; i += 1)
                    {


                        alWeight[s] = Int32.Parse(n1[i].ToString());
                       // MessageBox.Show(alWeight[s].ToString());
                        s += 2;
                    }

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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawBarChart(e, alWeight);
       }

       

        private void DrawBarChart(PaintEventArgs e, int[] alWeight)
        {
            try
            {
                int numberOfSections = alWeight.Length;
                int lengthArea = 250;
                int heightArea = 300;
                int topX = 300;
                int topY = 20;
                int maxWeight = MaxValue(alWeight);
                int[] height = new int[numberOfSections];
                int total = SumOfArray(alWeight);
                Random rnd = new Random();
                SolidBrush brush = new SolidBrush(Color.Aquamarine);
                Pen pen = new Pen(Color.Gray);
                Rectangle rec = new Rectangle(topX, topY, lengthArea, heightArea);
                e.Graphics.DrawRectangle(pen, rec);
                pen.Color = Color.Black;
                int smallX = topX;
                int smallY = 0;
                int smallLength = (lengthArea / alWeight.Length);
                int smallHeight = 0;
                for (int i = 0; i < numberOfSections; i++)
                {
                    smallHeight = ((alWeight[i] * heightArea) / maxWeight);
                    smallY = topY + heightArea - smallHeight;
                
  

                     if (((i + 1) % 2) == 0 && i != 0)
                    {
                        rectangle = new Rectangle(smallX, smallY, smallLength - 5, smallHeight);
                        brush.Color = Color.FromArgb(255, 255, 0, 0);
                    }
                    else if (((i) % 2) == 0 && i != 0)
                    {
                        rectangle = new Rectangle(smallX - 5, smallY, smallLength, smallHeight);
                        brush.Color = Color.FromArgb(255, 0, 255, 0);
                    }
                    e.Graphics.DrawRectangle(pen, rectangle);
                    e.Graphics.FillRectangle(brush, rectangle);
                    brush.Color = Color.FromKnownColor(KnownColor.Black);
                    e.Graphics.DrawRectangle(pen, rectangle);
                    smallX = smallX + smallLength;

                }
            }
            catch
            {
            }
        }

       

        private void DrawDots(PaintEventArgs e, Point p1)
        {
            Pen pen = new Pen(Color.SeaGreen);
            e.Graphics.DrawPie(pen, p1.X-5 , p1.Y-5, 10, 10, 0, 360);
            e.Graphics.FillPie(new SolidBrush(Color.Purple), p1.X - 5, p1.Y - 5, 10, 10, 0, 360);
        }

        private static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            }
            return maxVal;
        }
        private static int SumOfArray(int[] intArray)
        {
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                
                    sum += intArray[i];
            }
            return sum;
        }

       
    }
}