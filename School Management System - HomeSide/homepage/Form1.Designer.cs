namespace homepage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b2 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Transparent;
            this.b2.BackgroundImage = global::homepage.Properties.Resources.dienter;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Location = new System.Drawing.Point(25, 191);
            this.b2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(48, 48);
            this.b2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.b2, "انصراف");
            this.b2.UseVisualStyleBackColor = false;
            this.b2.MouseLeave += new System.EventHandler(this.b2_MouseLeave);
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseEnter += new System.EventHandler(this.b2_MouseEnter);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(178, 104);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(223, 34);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "نام کاربری";
            this.tb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb1_MouseClick);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(178, 155);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(223, 34);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "کلمه عبور";
            this.tb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb2_MouseClick);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Transparent;
            this.b1.BackgroundImage = global::homepage.Properties.Resources.enter;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(50)))));
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Location = new System.Drawing.Point(94, 191);
            this.b1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(48, 48);
            this.b1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.b1, "ورود");
            this.b1.UseVisualStyleBackColor = false;
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AcceptButton = this.b1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::homepage.Properties.Resources.login_greenJPG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.b2;
            this.ClientSize = new System.Drawing.Size(440, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.b2);
            this.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تاييد هويت";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

