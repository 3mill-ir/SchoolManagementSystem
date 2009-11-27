using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using _UseFull;

namespace SMS1
{
    public partial class main_form : Form
    { 
        public main_form()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        Screen screen = Screen.PrimaryScreen;
        int orginal_hight;
        int orginal_width;
        private void playSound_enter()
        {
            
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();
            player.SoundLocation = Application.StartupPath + "//6_Enter.wav";
            player.Load();
            player.Play();
        }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            CResolution orginal_resolution = new CResolution(orginal_width, orginal_hight);
            Application.Restart();
        }

        private void دانشآموزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_student_register studentfrm = new Form_student_register();
            studentfrm.ShowDialog();
        }

        private void آموزشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Amozesh_register amozeshfrm = new Form_Amozesh_register();
            amozeshfrm.ShowDialog();
        }

        private void درسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_lesson lessonfrm = new Form_lesson();
            lessonfrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Test frm = new Form_Test();
            frm.ShowDialog();
        }

        private void کلاسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_class classfrm = new Form_class();
            classfrm.ShowDialog();
        }

        private void زمانبنديToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_barnam barnamefrm = new form_barnam();
            barnamefrm.ShowDialog();
        }

        private void برگزاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_election electionfrm = new Form_election();
            electionfrm.ShowDialog();
           
        }

        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void دانشآموزToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_edituser edituserfrm = new Form_edituser();
            edituserfrm.ShowDialog();
        }

        private void دانشآموزToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_editstudent editstudentfrm = new Form_editstudent();
            editstudentfrm.ShowDialog();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
          orginal_width=screen.Bounds.Width;
           orginal_hight = screen.Bounds.Height;
          CResolution tmpresolution = new CResolution(1280,768);
           // panel1.Location = new System.Drawing.Point((this.Size.Width / 2) - (panel1.Size.Width / 2), (this.Size.Height / 2) - (panel1.Size.Height / 2));
            string type = frm.user_type;
           // MessageBox.Show(type);
            if (type=="مدیر")
            {
                menuStrip1.Items[1].Enabled = false;
              
            }
        //    textScreenAnimator1.Text = File.ReadAllText(@""+Application.StartupPath+"\\detail.txt");
           // textScreenAnimator1.Start();
         
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void اطلاعیهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_dailywords dailyfrm = new Form_dailywords();
            dailyfrm.ShowDialog();
        }

        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_sms smsfrm = new Form_sms();
            smsfrm.ShowDialog();
        }

        private void جديدToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form_email emailfrm = new Form_email();
            emailfrm.ShowDialog();
        }

        private void وضعيتتحصيليToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void آخريننظرسنجيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_recentelcection recentelefrm = new Form_recentelcection();
            recentelefrm.ShowDialog();
        }

        private void كلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_elearchive elefrm = new Form_elearchive();
            elefrm.ShowDialog();
        }

        private void آرشيوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_smsarchive smsarchfrm = new Form_smsarchive();
            smsarchfrm.ShowDialog();
        }

        private void آرشيوToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_mailarchive mailarchfrm = new Form_mailarchive();
            mailarchfrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void نمراتماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_monthgrade monthgradefrm = new Form_monthgrade();
            monthgradefrm.ShowDialog();
        }

        private void نمايشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_barname displaybarnamefrm = new Form_barname();
            displaybarnamefrm.ShowDialog();
        }

        private void آپلودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ebook ebookfrm = new Form_ebook();
            ebookfrm.ShowDialog();
        }

        private void آرشیوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ebookarchive ebookarchivefrm = new Form_ebookarchive();
            ebookarchivefrm.ShowDialog();
        }

        private void پايانترمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm.con.Close();
            Form_termgrade termgradefrm = new Form_termgrade();
            termgradefrm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form_student_register studentfrm = new Form_student_register();
            studentfrm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_Amozesh_register amozeshfrm = new Form_Amozesh_register();
            amozeshfrm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_class classfrm = new Form_class();
            classfrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_lesson lessonfrm = new Form_lesson();
            lessonfrm.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            form_barnam barnamefrm = new form_barnam();
            barnamefrm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form_election electionfrm = new Form_election();
            electionfrm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_sms smsfrm = new Form_sms();
            smsfrm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form_email emailfrm = new Form_email();
            emailfrm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form_dailywords dailyfrm = new Form_dailywords();
            dailyfrm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form_monthgrade monthgradefrm = new Form_monthgrade();
            monthgradefrm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm.con.Close();
            Form_monthgrade termgradefrm = new Form_monthgrade();
            termgradefrm.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form_ebook ebookfrm = new Form_ebook();
            ebookfrm.ShowDialog();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button6.Image = global::SMS1.Properties.Resources.user_new_gif;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {         
            button6.Image = global::SMS1.Properties.Resources.user_new;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button3.Image = global::SMS1.Properties.Resources.student_new_gif;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = global::SMS1.Properties.Resources.student_new;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button5.Image = global::SMS1.Properties.Resources.class_new_gif;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Image = global::SMS1.Properties.Resources.class_new;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button4.Image = global::SMS1.Properties.Resources.lesson_new_gif;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Image = global::SMS1.Properties.Resources.lesson_new;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button10.Image = global::SMS1.Properties.Resources.schedualin_new_gif;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Image = global::SMS1.Properties.Resources.schedualin__new;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button8.Image = global::SMS1.Properties.Resources.sms_icon_new_gif;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Image = global::SMS1.Properties.Resources.sms_icon_new;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button18.Image = global::SMS1.Properties.Resources.mail_new_gif;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.Image = global::SMS1.Properties.Resources.mail_new_copy;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button9.Image = global::SMS1.Properties.Resources.comment_new_gif;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Image = global::SMS1.Properties.Resources.comments_new;
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button13.Image = global::SMS1.Properties.Resources.daily_word_gif;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.Image = global::SMS1.Properties.Resources.dayli_word_new;
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button17.Image = global::SMS1.Properties.Resources.uploadin_new_gif;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.Image = global::SMS1.Properties.Resources.uploading_new;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            playSound_enter();
            button7.Image = global::SMS1.Properties.Resources.edu_state_gif;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Image = global::SMS1.Properties.Resources.edu_state_new;
        }

        private void جديدToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_banktest newtestfrm = new Form_banktest();
            newtestfrm.ShowDialog();
        }

        private void آرشيوToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_testarchive testarchivefrm = new Form_testarchive();
            testarchivefrm.ShowDialog();
        }

        private void دربارهبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        int yp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (label2.Location.Y == (panel2.Location.Y - panel2.Size.Height))
            {
                yp = 188;
            }
            yp--;
            label2.Location = new System.Drawing.Point(83,(label2.Size.Height) +yp);
        }
        

   

    }
}
