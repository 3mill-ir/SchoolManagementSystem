namespace SMS1
{
    partial class Form_lesson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.b1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd = new System.Data.SqlClient.SqlCommand();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Transparent;
            this.b1.BackgroundImage = global::SMS1.Properties.Resources.add_list;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Location = new System.Drawing.Point(301, 87);
            this.b1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(48, 30);
            this.b1.TabIndex = 2;
            this.b1.Text = ">>>";
            this.toolTip1.SetToolTip(this.b1, "اضافه به ليست  دروس");
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Visible = false;
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(83, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 247);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Transparent;
            this.b4.BackgroundImage = global::SMS1.Properties.Resources.return_homee;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b4.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.b4.FlatAppearance.BorderSize = 0;
            this.b4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Location = new System.Drawing.Point(253, 371);
            this.b4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(48, 48);
            this.b4.TabIndex = 6;
            this.toolTip1.SetToolTip(this.b4, "بستن پنجره");
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Visible = false;
            this.b4.MouseLeave += new System.EventHandler(this.b4_MouseLeave);
            this.b4.Click += new System.EventHandler(this.button2_Click);
            this.b4.MouseEnter += new System.EventHandler(this.b4_MouseEnter);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Transparent;
            this.b3.BackgroundImage = global::SMS1.Properties.Resources.delete;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Location = new System.Drawing.Point(84, 298);
            this.b3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(48, 48);
            this.b3.TabIndex = 5;
            this.toolTip1.SetToolTip(this.b3, "حذف");
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Visible = false;
            this.b3.MouseLeave += new System.EventHandler(this.b3_MouseLeave);
            this.b3.Click += new System.EventHandler(this.b3_Click);
            this.b3.MouseEnter += new System.EventHandler(this.b3_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(431, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام درس:";
            this.label1.Visible = false;
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tb1.Location = new System.Drawing.Point(301, 48);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb1.Name = "tb1";
            this.tb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb1.Size = new System.Drawing.Size(123, 34);
            this.tb1.TabIndex = 1;
            this.tb1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SMS1.Properties.Resources.edit_but;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(176, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button1, "ويرايش");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Lotus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(204, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "معرفي درس جديد";
            this.label2.Visible = false;
            // 
            // Form_lesson
            // 
            this.AcceptButton = this.b1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SMS1.Properties.Resources.lesson_bk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.b4;
            this.ClientSize = new System.Drawing.Size(556, 447);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(360, 250);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form_lesson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "تعريف و حذف دروس";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlCommand cmd;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;




    }
}

