namespace SMS1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmd = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Lotus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(257, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 105);
            this.button1.TabIndex = 3;
            this.button1.Text = "ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.LightSalmon;
            this.tb1.Font = new System.Drawing.Font("B Lotus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb1.ForeColor = System.Drawing.Color.Lime;
            this.tb1.Location = new System.Drawing.Point(20, 544);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb1.Size = new System.Drawing.Size(154, 31);
            this.tb1.TabIndex = 1;
            this.tb1.Text = "نام کاربری";
            this.tb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb1_MouseClick);
            this.tb1.TabIndexChanged += new System.EventHandler(this.textBox1_TabIndexChanged);
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.Color.LightSalmon;
            this.tb2.Font = new System.Drawing.Font("B Lotus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb2.ForeColor = System.Drawing.Color.Lime;
            this.tb2.Location = new System.Drawing.Point(20, 578);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.PasswordChar = '*';
            this.tb2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb2.Size = new System.Drawing.Size(155, 30);
            this.tb2.TabIndex = 2;
            this.tb2.Text = "کلمه عبور";
            this.tb2.TabIndexChanged += new System.EventHandler(this.textBox2_TabIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("B Lotus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(333, 575);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(543, 758);
            this.ControlBox = false;
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تاييد هويت";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Data.SqlClient.SqlCommand cmd;




    }
}

