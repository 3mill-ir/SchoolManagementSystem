namespace SMS1
{
    partial class Form_election
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
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(12, 29);
            this.rtb1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(512, 112);
            this.rtb1.TabIndex = 1;
            this.rtb1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(564, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "گزينه چهارم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(570, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "گزينه سوم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "گزينه دوم";
            this.label5.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "گزينه اول";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(32, 41);
            this.tb1.Name = "tb1";
            this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb1.Size = new System.Drawing.Size(512, 34);
            this.tb1.TabIndex = 2;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(32, 82);
            this.tb2.Name = "tb2";
            this.tb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb2.Size = new System.Drawing.Size(512, 34);
            this.tb2.TabIndex = 3;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // tb4
            // 
            this.tb4.Enabled = false;
            this.tb4.Location = new System.Drawing.Point(32, 164);
            this.tb4.Name = "tb4";
            this.tb4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb4.Size = new System.Drawing.Size(512, 34);
            this.tb4.TabIndex = 5;
            // 
            // tb3
            // 
            this.tb3.Enabled = false;
            this.tb3.Location = new System.Drawing.Point(32, 124);
            this.tb3.Name = "tb3";
            this.tb3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb3.Size = new System.Drawing.Size(512, 34);
            this.tb3.TabIndex = 4;
            this.tb3.TextChanged += new System.EventHandler(this.tb3_TextChanged);
            // 
            // b2
            // 
            this.b2.BackgroundImage = global::SMS1.Properties.Resources.return_homee;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Location = new System.Drawing.Point(512, 478);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(48, 48);
            this.b2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.b2, "بستن پنجره");
            this.b2.UseVisualStyleBackColor = true;
            this.b2.MouseLeave += new System.EventHandler(this.b2_MouseLeave);
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseEnter += new System.EventHandler(this.b2_MouseEnter);
            // 
            // b1
            // 
            this.b1.BackgroundImage = global::SMS1.Properties.Resources.accept;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Location = new System.Drawing.Point(425, 478);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(48, 48);
            this.b1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.b1, "تاييد");
            this.b1.UseVisualStyleBackColor = true;
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb1);
            this.groupBox1.Location = new System.Drawing.Point(224, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 160);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "متن نظرسنجي";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb3);
            this.groupBox2.Controls.Add(this.tb4);
            this.groupBox2.Controls.Add(this.tb2);
            this.groupBox2.Controls.Add(this.tb1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(172, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 221);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "گزينه ها";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Lotus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(418, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "برگزاري نظرسنجي";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 559);
            this.panel1.TabIndex = 11;
            // 
            // Form_election
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b2;
            this.ClientSize = new System.Drawing.Size(985, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(155, 190);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form_election";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "برگزاري نظرسنجي";
            this.Load += new System.EventHandler(this.Form_election_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}