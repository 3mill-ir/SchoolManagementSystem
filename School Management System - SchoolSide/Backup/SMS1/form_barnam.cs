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
using System.Threading;

namespace SMS1
{
    public partial class form_barnam : Form
    {
        int jj;
       // int kk;
        public form_barnam()
        {
            InitializeComponent();
            jj = this.Height;
        //    kk = this.Width;
            this.Height = 0;
      //      this.Width = 0;
        }
        SqlDataReader rdr;
        SqlDataReader rdr1;
        int[] arr=new int[100];
       long  [] tarr = new long [100];
       string[] strarr=new string[100] ;
       string[] lessarr = new string[100];
       string[] arrless = new string[100];
       string[] arrteac = new string[100];
       
       Form1 frm = new Form1();


       //////////////////////
       protected override void OnShown(EventArgs e)
       {
           if (!this.DesignMode)
           {
               int height = jj;
           //    int width = kk;
               int i = 0;
           //    int k1 = 0;
               while (i < height - 39 )//|| k1 < width - 126)
               {
                   Thread.Sleep(1);
                   if (i < (height - 39))
                   {

                       this.Height += 5;
                   }
            //       if (k1 < (width - 128))
            //       {
            //           this.Width += 5;
            //       }
            //       k1 += 5;
                   i += 5;
               }
               panel1.Visible =false;
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

        private void form_barnam_Load(object sender, EventArgs e)
        {
          

           


            //********************************************************************************************** 
          
            try
            {
                cmd.Connection = frm.con;
              
                cmd.CommandText = "select * from lesson";
                frm.con.Open();
                rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    arr[i] = rdr.GetInt32(0);
                    c11.Items.Add(rdr.GetString(1));
                    c12.Items.Add(rdr.GetString(1));
                    c13.Items.Add(rdr.GetString(1));
                    c14.Items.Add(rdr.GetString(1));
                    c15.Items.Add(rdr.GetString(1));
                    c16.Items.Add(rdr.GetString(1));
                    c31.Items.Add(rdr.GetString(1));
                    c32.Items.Add(rdr.GetString(1));
                    c33.Items.Add(rdr.GetString(1));
                    c34.Items.Add(rdr.GetString(1));
                    c35.Items.Add(rdr.GetString(1));
                    c36.Items.Add(rdr.GetString(1));
                    c51.Items.Add(rdr.GetString(1));
                    c52.Items.Add(rdr.GetString(1));
                    c53.Items.Add(rdr.GetString(1));
                    c54.Items.Add(rdr.GetString(1));
                    c55.Items.Add(rdr.GetString(1));
                    c56.Items.Add(rdr.GetString(1));
                    c71.Items.Add(rdr.GetString(1));
                    c72.Items.Add(rdr.GetString(1));
                    c73.Items.Add(rdr.GetString(1));
                    c74.Items.Add(rdr.GetString(1));
                    c75.Items.Add(rdr.GetString(1));
                    c76.Items.Add(rdr.GetString(1));
                    i++;
                }
               
                rdr.Close();
                cmd.CommandText = "select id_office_user,first_name,last_name from office_user where user_type=N'معلم'";
                rdr1 = cmd.ExecuteReader();
                int x = 0;
                while (rdr1.Read())
                {
                    
                    tarr[x] = rdr1.GetInt64(0);
                    c21.Items.Add(rdr1.GetString(2) +" "+rdr1.GetInt64(0).ToString());
                    c22.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c23.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c24.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c25.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c26.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c41.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c42.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c43.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c44.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c45.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c46.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c61.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c62.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c63.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c64.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c65.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c66.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c81.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c82.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c83.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c84.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c85.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                    c86.Items.Add(rdr1.GetString(2) + " " + rdr1.GetInt64(0).ToString());
                   
                    x++;
                }
                rdr1.Close();
//**********************************************************************************************
                cmd.CommandText = "select Id_class from class";
                rdr1 = cmd.ExecuteReader();
              
                while (rdr1.Read())
                {
                    cmb1.Items.Add(rdr1.GetString(0) );
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
            //**************************************************************************
           /* c11.SelectedIndex = 0;
            c12.SelectedIndex = 0;
            c13.SelectedIndex = 0;
            c14.SelectedIndex = 0;
            c15.SelectedIndex = 0;
            c16.SelectedIndex = 0;

            c21.SelectedIndex = 0;
            c22.SelectedIndex = 0;
            c23.SelectedIndex = 0;
            c24.SelectedIndex = 0;
            c25.SelectedIndex = 0;
            c26.SelectedIndex = 0;

            c31.SelectedIndex = 0;
            c32.SelectedIndex = 0;
            c33.SelectedIndex = 0;
            c34.SelectedIndex = 0;
            c35.SelectedIndex = 0;
            c36.SelectedIndex = 0;

            c41.SelectedIndex = 0;
            c42.SelectedIndex = 0;
            c43.SelectedIndex = 0;
            c44.SelectedIndex = 0;
            c45.SelectedIndex = 0;
            c46.SelectedIndex = 0;

            c51.SelectedIndex = 0;
            c52.SelectedIndex = 0;
            c53.SelectedIndex = 0;
            c54.SelectedIndex = 0;
            c55.SelectedIndex = 0;
            c56.SelectedIndex = 0;

            c61.SelectedIndex = 0;
            c62.SelectedIndex = 0;
            c63.SelectedIndex = 0;
            c64.SelectedIndex = 0;
            c65.SelectedIndex = 0;
            c66.SelectedIndex = 0;

            c71.SelectedIndex = 0;
            c72.SelectedIndex = 0;
            c73.SelectedIndex = 0;
            c74.SelectedIndex = 0;
            c75.SelectedIndex = 0;
            c76.SelectedIndex = 0;

            c81.SelectedIndex = 0;
            c82.SelectedIndex = 0;
            c83.SelectedIndex = 0;
            c84.SelectedIndex = 0;
            c85.SelectedIndex = 0;
            c86.SelectedIndex = 0;*/

            cmb1.SelectedIndex = 0;
    

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            frm.con.Open();
            try
            {
                int i = 0;
                cmd.CommandText = "select id_student from student where id_class=N'" + cmb1.SelectedItem.ToString() + "'";
                
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                   
                    strarr[i] = rdr.GetValue(0).ToString();
                    
                    i++;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                rdr.Close();
                frm.con.Close();
            }




            for (int num = 0; strarr[num] !=null; num++)
            {
               // MessageBox.Show(strarr[num]);
                
                for (int op = 0; arrless[op]!=null; op++)
                {
                  //  MessageBox.Show(arrless[op]);
                    cmd.CommandText = "insert into class_lesson (id_student,Id_class,Id_lesson,Id_teacher)values(" + strarr[num] + ",N'" + cmb1.SelectedItem.ToString() + "',"
                            + arrless[op] + "," + arrteac[op]+")";
                   //MessageBox.Show(cmd.CommandText);
                    try
                    {
                        frm.con.Open();
                        
                       cmd.ExecuteNonQuery();
                        /*  frm.con.Open();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c11.SelectedIndex] + ",N'شنبه',N'ساعت اول')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c12.SelectedIndex] + ",N'یکشنبه',N'ساعت اول')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c13.SelectedIndex] + ",N'دوشنبه',N'ساعت اول')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c14.SelectedIndex] + ",N'سه شنبه',N'ساعت اول')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c15.SelectedIndex] + ",N'چهارشنبه',N'ساعت اول')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c16.SelectedIndex] + ",N'پنجشنبه',N'ساعت اول')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c31.SelectedIndex] + ",N'شنبه',N'ساعت دوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c32.SelectedIndex] + ",N'یکشنبه',N'ساعت دوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c33.SelectedIndex] + ",N'دوشنبه',N'ساعت دوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c34.SelectedIndex] + ",N'سه شنبه',N'ساعت دوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c35.SelectedIndex] + ",N'چهارشنبه',N'ساعت دوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c36.SelectedIndex] + ",N'پنجشنبه',N'ساعت دوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c51.SelectedIndex] + ",N'شنبه',N'ساعت سوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c52.SelectedIndex] + ",N'یکشنبه',N'ساعت سوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c53.SelectedIndex] + ",N'دوشنبه',N'ساعت سوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c54.SelectedIndex] + ",N'سه شنبه',N'ساعت سوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c55.SelectedIndex] + ",N'چهارشنبه',N'ساعت سوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c56.SelectedIndex] + ",N'پنجشنبه',N'ساعت سوم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c71.SelectedIndex] + ",N'شنبه',N'ساعت چهارم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c72.SelectedIndex] + ",N'یکشنبه',N'ساعت چهارم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c73.SelectedIndex] + ",N'دوشنبه',N'ساعت چهارم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c74.SelectedIndex] + ",N'سه شنبه',N'ساعت چهارم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c75.SelectedIndex] + ",N'چهارشنبه',N'ساعت چهارم')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into class_lesson (id_class,Id_lesson,day,time)values(N'" + cmb1.SelectedItem.ToString() + "'," + arr[c76.SelectedIndex] + ",N'پنجشنبه',N'ساعت چهارم')";
                          cmd.ExecuteNonQuery();


                          /************************************************************/

                        /*  cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c21.SelectedIndex] + "',N'" + arr[c11.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c22.SelectedIndex] + "',N'" + arr[c12.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c23.SelectedIndex] + "',N'" + arr[c13.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c24.SelectedIndex] + "',N'" + arr[c14.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c25.SelectedIndex] + "',N'" + arr[c15.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c26.SelectedIndex] + "',N'" + arr[c16.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c41.SelectedIndex] + "',N'" + arr[c31.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c42.SelectedIndex] + "',N'" + arr[c32.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c43.SelectedIndex] + "',N'" + arr[c33.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c44.SelectedIndex] + "',N'" + arr[c34.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c45.SelectedIndex] + "',N'" + arr[c35.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c46.SelectedIndex] + "',N'" + arr[c36.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c61.SelectedIndex] + "',N'" + arr[c51.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c62.SelectedIndex] + "',N'" + arr[c52.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c63.SelectedIndex] + "',N'" + arr[c53.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c64.SelectedIndex] + "',N'" + arr[c54.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c65.SelectedIndex] + "',N'" + arr[c55.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c66.SelectedIndex] + "',N'" + arr[c56.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c81.SelectedIndex] + "',N'" + arr[c71.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c82.SelectedIndex] + "',N'" + arr[c72.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c83.SelectedIndex] + "',N'" + arr[c73.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c84.SelectedIndex] + "',N'" + arr[c74.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c85.SelectedIndex] + "',N'" + arr[c75.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();
                          cmd.CommandText = "insert into teacher_lesson (Id_teacher,Id_lesson)values(N'" + tarr[c86.SelectedIndex] + "',N'" + arr[c76.SelectedIndex] + "')";
                          cmd.ExecuteNonQuery();*/
                        ////************************************************


                        //**********************************************************88



                       // FMessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                      //  cmb1.Items.RemoveAt(cmb1.SelectedIndex);
                    }
                    catch (Exception )
                    {
                  //      MessageBox.Show(E.Message);
                        FMessageBox.Show("در زمانبندي كلاس ها دقت كنيد", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                    }
                    finally
                    {
                        frm.con.Close();
                    }
                }
            }

           // MessageBox.Show("end of claas _lesson ");
            try
            {  
                frm.con.Open();
                for (int q = 0; q < 24; q++)
                {
                    cmd.CommandText = "insert into days_sch values(N'" + cmb1.SelectedItem.ToString() + "'," + dataGridView1.Rows[q].Cells[1].Value + ",N'" +
                        dataGridView1.Rows[q].Cells[0].Value + "',N'" + dataGridView1.Rows[q].Cells[2].Value+"')";
                    
                    cmd.ExecuteNonQuery();

                }
                FMessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    
            }
            catch(Exception )
            {
              //  MessageBox.Show(E.Message);
                FMessageBox.Show("در زمانبندي كلاس ها دقت كنيد", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                    
            }
            finally
            {
                frm.con.Close();
                button1.Enabled = false;
            }
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ColumnCount = 4;
                dataGridView1.RowCount = 24;

                dataGridView1.Rows[0].Cells[0].Value = "شنبه";
                dataGridView1.Rows[0].Cells[1].Value = arr[c11.SelectedIndex];
                dataGridView1.Rows[0].Cells[2].Value = "ساعت اول";
                dataGridView1.Rows[0].Cells[3].Value = tarr[c21.SelectedIndex];

                dataGridView1.Rows[1].Cells[0].Value = "يك شنبه";
                dataGridView1.Rows[1].Cells[1].Value = arr[c12.SelectedIndex];
                dataGridView1.Rows[1].Cells[2].Value = "ساعت اول";
                dataGridView1.Rows[1].Cells[3].Value = tarr[c22.SelectedIndex];

                dataGridView1.Rows[2].Cells[0].Value = "دو شنبه";
                dataGridView1.Rows[2].Cells[1].Value = arr[c13.SelectedIndex];
                dataGridView1.Rows[2].Cells[2].Value = "ساعت اول";
                dataGridView1.Rows[2].Cells[3].Value = tarr[c23.SelectedIndex];

                dataGridView1.Rows[3].Cells[0].Value = "سه شنبه";
                dataGridView1.Rows[3].Cells[1].Value = arr[c14.SelectedIndex];
                dataGridView1.Rows[3].Cells[2].Value = "ساعت اول";
                dataGridView1.Rows[3].Cells[3].Value = tarr[c24.SelectedIndex];

                dataGridView1.Rows[4].Cells[0].Value = "چهار شنبه";
                dataGridView1.Rows[4].Cells[1].Value = arr[c15.SelectedIndex];
                dataGridView1.Rows[4].Cells[2].Value = "ساعت اول";
                dataGridView1.Rows[4].Cells[3].Value = tarr[c25.SelectedIndex];

                dataGridView1.Rows[5].Cells[0].Value = "پنج شنبه";
                dataGridView1.Rows[5].Cells[1].Value = arr[c16.SelectedIndex];
                dataGridView1.Rows[5].Cells[2].Value = "ساعت اول";
                dataGridView1.Rows[5].Cells[3].Value = tarr[c26.SelectedIndex];

                dataGridView1.Rows[6].Cells[0].Value = "شنبه";
                dataGridView1.Rows[6].Cells[1].Value = arr[c31.SelectedIndex];
                dataGridView1.Rows[6].Cells[2].Value = "ساعت دوم";
                dataGridView1.Rows[6].Cells[3].Value = tarr[c41.SelectedIndex];

                dataGridView1.Rows[7].Cells[0].Value = "يك شنبه";
                dataGridView1.Rows[7].Cells[1].Value = arr[c32.SelectedIndex];
                dataGridView1.Rows[7].Cells[2].Value = "ساعت دوم";
                dataGridView1.Rows[7].Cells[3].Value = tarr[c42.SelectedIndex];

                dataGridView1.Rows[8].Cells[0].Value = "دو شنبه";
                dataGridView1.Rows[8].Cells[1].Value = arr[c33.SelectedIndex];
                dataGridView1.Rows[8].Cells[2].Value = "ساعت دوم";
                dataGridView1.Rows[8].Cells[3].Value = tarr[c43.SelectedIndex];

                dataGridView1.Rows[9].Cells[0].Value = "سه شنبه";
                dataGridView1.Rows[9].Cells[1].Value = arr[c34.SelectedIndex];
                dataGridView1.Rows[9].Cells[2].Value = "ساعت دوم";
                dataGridView1.Rows[9].Cells[3].Value = tarr[c44.SelectedIndex];

                dataGridView1.Rows[10].Cells[0].Value = "چهار شنبه";
                dataGridView1.Rows[10].Cells[1].Value = arr[c35.SelectedIndex];
                dataGridView1.Rows[10].Cells[2].Value = "ساعت دوم";
                dataGridView1.Rows[10].Cells[3].Value = tarr[c45.SelectedIndex];

                dataGridView1.Rows[11].Cells[0].Value = "پنج شنبه";
                dataGridView1.Rows[11].Cells[1].Value = arr[c36.SelectedIndex];
                dataGridView1.Rows[11].Cells[2].Value = "ساعت دوم";
                dataGridView1.Rows[11].Cells[3].Value = tarr[c46.SelectedIndex];

                dataGridView1.Rows[12].Cells[0].Value = "شنبه";
                dataGridView1.Rows[12].Cells[1].Value = arr[c51.SelectedIndex];
                dataGridView1.Rows[12].Cells[2].Value = "ساعت سوم";
                dataGridView1.Rows[12].Cells[3].Value = tarr[c61.SelectedIndex];

                dataGridView1.Rows[13].Cells[0].Value = "يك شنبه";
                dataGridView1.Rows[13].Cells[1].Value = arr[c52.SelectedIndex];
                dataGridView1.Rows[13].Cells[2].Value = "ساعت سوم";
                dataGridView1.Rows[13].Cells[3].Value = tarr[c62.SelectedIndex];

                dataGridView1.Rows[14].Cells[0].Value = "دو شنبه";
                dataGridView1.Rows[14].Cells[1].Value = arr[c53.SelectedIndex];
                dataGridView1.Rows[14].Cells[2].Value = "ساعت سوم";
                dataGridView1.Rows[14].Cells[3].Value = tarr[c63.SelectedIndex];

                dataGridView1.Rows[15].Cells[0].Value = "سه شنبه";
                dataGridView1.Rows[15].Cells[1].Value = arr[c54.SelectedIndex];
                dataGridView1.Rows[15].Cells[2].Value = "ساعت سوم";
                dataGridView1.Rows[15].Cells[3].Value = tarr[c64.SelectedIndex];

                dataGridView1.Rows[16].Cells[0].Value = "چهار شنبه";
                dataGridView1.Rows[16].Cells[1].Value = arr[c55.SelectedIndex];
                dataGridView1.Rows[16].Cells[2].Value = "ساعت سوم";
                dataGridView1.Rows[16].Cells[3].Value = tarr[c65.SelectedIndex];

                dataGridView1.Rows[17].Cells[0].Value = "پنج شنبه";
                dataGridView1.Rows[17].Cells[1].Value = arr[c56.SelectedIndex];
                dataGridView1.Rows[17].Cells[2].Value = "ساعت سوم";
                dataGridView1.Rows[17].Cells[3].Value = tarr[c66.SelectedIndex];

                dataGridView1.Rows[18].Cells[0].Value = "شنبه";
                dataGridView1.Rows[18].Cells[1].Value = arr[c71.SelectedIndex];
                dataGridView1.Rows[18].Cells[2].Value = "ساعت چهارم";
                dataGridView1.Rows[18].Cells[3].Value = tarr[c81.SelectedIndex];

                dataGridView1.Rows[19].Cells[0].Value = "يك شنبه";
                dataGridView1.Rows[19].Cells[1].Value = arr[c72.SelectedIndex];
                dataGridView1.Rows[19].Cells[2].Value = "ساعت چهارم";
                dataGridView1.Rows[19].Cells[3].Value = tarr[c82.SelectedIndex];

                dataGridView1.Rows[20].Cells[0].Value = "دو شنبه";
                dataGridView1.Rows[20].Cells[1].Value = arr[c73.SelectedIndex];
                dataGridView1.Rows[20].Cells[2].Value = "ساعت چهارم";
                dataGridView1.Rows[20].Cells[3].Value = tarr[c83.SelectedIndex];

                dataGridView1.Rows[21].Cells[0].Value = "سه شنبه";
                dataGridView1.Rows[21].Cells[1].Value = arr[c74.SelectedIndex];
                dataGridView1.Rows[21].Cells[2].Value = "ساعت چهارم";
                dataGridView1.Rows[21].Cells[3].Value = tarr[c84.SelectedIndex];

                dataGridView1.Rows[22].Cells[0].Value = "چهار شنبه";
                dataGridView1.Rows[22].Cells[1].Value = arr[c75.SelectedIndex];
                dataGridView1.Rows[22].Cells[2].Value = "ساعت چهارم";
                dataGridView1.Rows[22].Cells[3].Value = tarr[c85.SelectedIndex];

                dataGridView1.Rows[23].Cells[0].Value = "پنج شنبه";
                dataGridView1.Rows[23].Cells[1].Value = arr[c76.SelectedIndex];
                dataGridView1.Rows[23].Cells[2].Value = "ساعت چهارم";
                dataGridView1.Rows[23].Cells[3].Value = tarr[c86.SelectedIndex];


                Boolean tb = true;

                int index = 0;
                int fr = 0;
                int lr = 23;
                for (fr = 0; fr < dataGridView1.RowCount; fr++)
                {
                    tb = true;
                    for (lr = fr + 1; lr < dataGridView1.RowCount; lr++)
                        if (dataGridView1.Rows[lr].Cells[1].Value.ToString() == dataGridView1.Rows[fr].Cells[1].Value.ToString())                        
                            tb = false;                        
                    if (tb == true)
                    {
                        arrless[index] = dataGridView1.Rows[fr].Cells[1].Value.ToString();
                        arrteac[index] = dataGridView1.Rows[fr].Cells[3].Value.ToString();
                        // MessageBox.Show(arrless[index]);
                        index++;

                    }

                }
               FMessageBox.Show("تحليل با موفقيت انجام شد.اكنون ميتوانيد برنامه را ذخيره كنيد.", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
            }
            catch
            {

         //       FMessageBox.Show("تحليل برنامه درست نيست،لطفآ دقت كنيد.", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);                 
          }
         //   finally
        //    {
              button1.Enabled = true;
          //  }
        //MessageBox.Show(arrless[0]);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(64, 64);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(48, 48);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Size = new System.Drawing.Size(64, 64);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new System.Drawing.Size(48, 48);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Size = new System.Drawing.Size(64, 64);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new System.Drawing.Size(48, 48);
        }

    }

       

      
    }

