using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using FarsiMessageBox;
using System.Threading;
//using System.dr
namespace SMS1
{
    public partial class Form_lesson : Form
    {
        int jj;
   //     int kk;
        public Form_lesson()
        {
            InitializeComponent();
            jj = this.Height;
  //          kk = this.Width;
            this.Height = 0;
   //         this.Width = 0;
        }
        Form1 frm1 = new Form1();

        private GraphicsPath gpath = new GraphicsPath();
        SqlDataReader rdr;
        char[] c = new char[3];
        Boolean update=false;
        static string str_lesson;



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
          //          if (k1 < (width - 128))
          //          {
          //              this.Width += 5;
          //          }
          //          k1 += 5;
                    i += 5;
                }
                label1.Visible = true;
                label2.Visible = true;
                listBox1.Visible = true;
                tb1.Visible = true;
                b1.Visible = true;
                b4.Visible = true;
                b3.Visible = true;
                button1.Visible = true;
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

       
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.lesson' table. You can move, or remove it, as needed.
         
         /*   Rectangle rc;//
            Image MYBGimage = this.BackgroundImage;
            Bitmap MYBGbmp = new Bitmap(MYBGimage);
            for (int i = 0; i < MYBGbmp.Width; i++)
            {
                for (int j = 0; j < MYBGbmp.Height; j++)
                {
                    rc = new Rectangle(i, j, 1, 1);
                    if (MYBGbmp.GetPixel(i, j).ToArgb()!=Color.Red.ToArgb())
                    {
                        gpath.AddRectangle(rc);
                    }
                }
            }
            this.Region = new Region(gpath);

            */

            //****************************************
            cmd.Connection = frm1.con;
            try
            {
                cmd.CommandText = "select lesson from lesson";
                frm1.con.Open();
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetString(0));

                }
               
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }
            finally
            {
                frm1.con.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            listBox1.Visible = false;
            tb1.Visible = false;
            b1.Visible = false;
            b4.Visible = false;
            b3.Visible = false;
            button1.Visible = false;
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

        private void b1_Click(object sender, EventArgs e)
        {
            if (tb1.Text != "")
                if(listBox1.FindStringExact(tb1.Text).Equals(-1))
              try
            {
                if (update == false)
                {
                    cmd.CommandText = "insert into lesson (lesson) values (N'" + tb1.Text + "')";
                    frm1.con.Open();
                    cmd.ExecuteNonQuery();
                    listBox1.Items.Clear();
                }
                else
                {
                    cmd.CommandText = "update lesson set lesson=N'" + tb1.Text +"'where lesson=N'"+str_lesson+"'";
                    
                    frm1.con.Open();
                    cmd.ExecuteNonQuery();
                    listBox1.Items.Clear();

                }
                cmd.CommandText = "select lesson from lesson";
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetString(0));

                }
            
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }
            finally
            {
                frm1.con.Close();
                update = false;
            }
            else{
                    FMessageBox.Show("این درس در لیست وجود دارد","توجه ",FMessageBoxButtons.OK,FMessageBoxIcons.Warning);
        
        }
    }

        private void b2_Click(object sender, EventArgs e)
        {
         try
            {
                cmd.CommandText = "select lesson from lesson  ";
                frm1.con.Open();
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetString(0));

                }
               
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }
            finally
            {
                frm1.con.Close();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (FMessageBox.Show("درس مورد نظر حذف شود؟", "پیغام", FMessageBoxButtons.OKCancel, FMessageBoxIcons.Information) == DialogResult.OK)
                {
                    try
                    {
                        cmd.CommandText = "Delete from lesson where lesson=N'" + listBox1.SelectedItem.ToString() + "'";
                        frm1.con.Open();
                        cmd.ExecuteNonQuery();
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        FMessageBox.Show("عملیات با موفقیت اجرا شد", "توجه", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);

                    }
                    finally
                    {
                        frm1.con.Close();

                    }
                }
            }
            else
            {
                FMessageBox.Show("هيچ ركوردي انتخاب نشده است", "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

                update = true;
                str_lesson = listBox1.SelectedItem.ToString();
                tb1.Text = str_lesson;
            }
            else
                FMessageBox.Show("هيچ ركوردي انتخاب نشده است", "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.Size = new System.Drawing.Size(64, 30);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.Size = new System.Drawing.Size(48, 30);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(64, 64);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(48, 48);
        }

        private void b3_MouseEnter(object sender, EventArgs e)
        {
            b3.Size = new System.Drawing.Size(64, 64);
        }

        private void b3_MouseLeave(object sender, EventArgs e)
        {
            b3.Size = new System.Drawing.Size(48, 48);
        }

        private void b4_MouseEnter(object sender, EventArgs e)
        {
            b4.Size = new System.Drawing.Size(64, 64);
        }

        private void b4_MouseLeave(object sender, EventArgs e)
        {
            b4.Size = new System.Drawing.Size(48, 48);
        }
        
        }
}