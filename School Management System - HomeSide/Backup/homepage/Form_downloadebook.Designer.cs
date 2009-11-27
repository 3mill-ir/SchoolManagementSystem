namespace homepage
{
    partial class Form_downloadebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_downloadebook));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.adp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.ds = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(211, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "بازگشت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "دانلود";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.BackColor = System.Drawing.Color.White;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.Maroon;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.White;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Maroon;
            this.dataGrid1.Location = new System.Drawing.Point(136, 27);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(380, 375);
            this.dataGrid1.TabIndex = 3;
            // 
            // adp
            // 
            this.adp.SelectCommand = this.sqlSelectCommand1;
            this.adp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "class_lesson", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id_class", "Id_class"),
                        new System.Data.Common.DataColumnMapping("class_level", "class_level"),
                        new System.Data.Common.DataColumnMapping("Id_term", "Id_term"),
                        new System.Data.Common.DataColumnMapping("Id_student", "Id_student"),
                        new System.Data.Common.DataColumnMapping("Id_class1", "Id_class1"),
                        new System.Data.Common.DataColumnMapping("Id_lesson", "Id_lesson"),
                        new System.Data.Common.DataColumnMapping("Id_teacher", "Id_teacher"),
                        new System.Data.Common.DataColumnMapping("Id_test", "Id_test"),
                        new System.Data.Common.DataColumnMapping("Id_uploader", "Id_uploader"),
                        new System.Data.Common.DataColumnMapping("date", "date"),
                        new System.Data.Common.DataColumnMapping("type", "type"),
                        new System.Data.Common.DataColumnMapping("test", "test"),
                        new System.Data.Common.DataColumnMapping("Id_term1", "Id_term1"),
                        new System.Data.Common.DataColumnMapping("term_number", "term_number"),
                        new System.Data.Common.DataColumnMapping("grade", "grade"),
                        new System.Data.Common.DataColumnMapping("year", "year"),
                        new System.Data.Common.DataColumnMapping("Id_student1", "Id_student1"),
                        new System.Data.Common.DataColumnMapping("pass_student", "pass_student"),
                        new System.Data.Common.DataColumnMapping("Id_parrents", "Id_parrents"),
                        new System.Data.Common.DataColumnMapping("first_name", "first_name"),
                        new System.Data.Common.DataColumnMapping("last_name", "last_name"),
                        new System.Data.Common.DataColumnMapping("gender", "gender"),
                        new System.Data.Common.DataColumnMapping("birthday", "birthday"),
                        new System.Data.Common.DataColumnMapping("level", "level"),
                        new System.Data.Common.DataColumnMapping("picture", "picture"),
                        new System.Data.Common.DataColumnMapping("Id_class2", "Id_class2"),
                        new System.Data.Common.DataColumnMapping("Id_election", "Id_election"),
                        new System.Data.Common.DataColumnMapping("Id_sudent_participated", "Id_sudent_participated"),
                        new System.Data.Common.DataColumnMapping("Id_parrents1", "Id_parrents1"),
                        new System.Data.Common.DataColumnMapping("pass_parrents", "pass_parrents"),
                        new System.Data.Common.DataColumnMapping("name_parrents", "name_parrents"),
                        new System.Data.Common.DataColumnMapping("last_name1", "last_name1"),
                        new System.Data.Common.DataColumnMapping("tel_parrents", "tel_parrents"),
                        new System.Data.Common.DataColumnMapping("gender1", "gender1"),
                        new System.Data.Common.DataColumnMapping("Id_office_user", "Id_office_user"),
                        new System.Data.Common.DataColumnMapping("pass_office_user", "pass_office_user"),
                        new System.Data.Common.DataColumnMapping("first_name1", "first_name1"),
                        new System.Data.Common.DataColumnMapping("last_name2", "last_name2"),
                        new System.Data.Common.DataColumnMapping("user_type", "user_type"),
                        new System.Data.Common.DataColumnMapping("birthday1", "birthday1"),
                        new System.Data.Common.DataColumnMapping("record_of_service", "record_of_service"),
                        new System.Data.Common.DataColumnMapping("gender2", "gender2"),
                        new System.Data.Common.DataColumnMapping("picture1", "picture1"),
                        new System.Data.Common.DataColumnMapping("interested", "interested"),
                        new System.Data.Common.DataColumnMapping("info", "info"),
                        new System.Data.Common.DataColumnMapping("Id_term2", "Id_term2"),
                        new System.Data.Common.DataColumnMapping("date1", "date1"),
                        new System.Data.Common.DataColumnMapping("grade1", "grade1"),
                        new System.Data.Common.DataColumnMapping("present", "present"),
                        new System.Data.Common.DataColumnMapping("Id_mail_box", "Id_mail_box"),
                        new System.Data.Common.DataColumnMapping("Id_receiver", "Id_receiver"),
                        new System.Data.Common.DataColumnMapping("Id-sender", "Id-sender"),
                        new System.Data.Common.DataColumnMapping("date2", "date2"),
                        new System.Data.Common.DataColumnMapping("subject", "subject"),
                        new System.Data.Common.DataColumnMapping("message", "message"),
                        new System.Data.Common.DataColumnMapping("read", "read"),
                        new System.Data.Common.DataColumnMapping("attachment", "attachment"),
                        new System.Data.Common.DataColumnMapping("date3", "date3"),
                        new System.Data.Common.DataColumnMapping("Id_logged_user", "Id_logged_user"),
                        new System.Data.Common.DataColumnMapping("logged_number", "logged_number"),
                        new System.Data.Common.DataColumnMapping("Id_lesson1", "Id_lesson1"),
                        new System.Data.Common.DataColumnMapping("lesson", "lesson"),
                        new System.Data.Common.DataColumnMapping("id_electioneer", "id_electioneer"),
                        new System.Data.Common.DataColumnMapping("id_election1", "id_election1"),
                        new System.Data.Common.DataColumnMapping("Id_election2", "Id_election2"),
                        new System.Data.Common.DataColumnMapping("Election_message", "Election_message"),
                        new System.Data.Common.DataColumnMapping("Election_opt1", "Election_opt1"),
                        new System.Data.Common.DataColumnMapping("Election_opt2", "Election_opt2"),
                        new System.Data.Common.DataColumnMapping("Election_opt3", "Election_opt3"),
                        new System.Data.Common.DataColumnMapping("Election_opt4", "Election_opt4"),
                        new System.Data.Common.DataColumnMapping("Id_Electioneer1", "Id_Electioneer1"),
                        new System.Data.Common.DataColumnMapping("date4", "date4"),
                        new System.Data.Common.DataColumnMapping("election_type", "election_type"),
                        new System.Data.Common.DataColumnMapping("active", "active"),
                        new System.Data.Common.DataColumnMapping("op1", "op1"),
                        new System.Data.Common.DataColumnMapping("op2", "op2"),
                        new System.Data.Common.DataColumnMapping("op3", "op3"),
                        new System.Data.Common.DataColumnMapping("op4", "op4"),
                        new System.Data.Common.DataColumnMapping("Id_ebook", "Id_ebook"),
                        new System.Data.Common.DataColumnMapping("ebook_type", "ebook_type"),
                        new System.Data.Common.DataColumnMapping("ebook_name", "ebook_name"),
                        new System.Data.Common.DataColumnMapping("ebook_abstract", "ebook_abstract"),
                        new System.Data.Common.DataColumnMapping("Id_uploader1", "Id_uploader1"),
                        new System.Data.Common.DataColumnMapping("upload_date", "upload_date"),
                        new System.Data.Common.DataColumnMapping("ebook_file", "ebook_file"),
                        new System.Data.Common.DataColumnMapping("Id_student2", "Id_student2"),
                        new System.Data.Common.DataColumnMapping("term", "term"),
                        new System.Data.Common.DataColumnMapping("year1", "year1"),
                        new System.Data.Common.DataColumnMapping("grade2", "grade2"),
                        new System.Data.Common.DataColumnMapping("Id_class3", "Id_class3"),
                        new System.Data.Common.DataColumnMapping("Id_lesson2", "Id_lesson2"),
                        new System.Data.Common.DataColumnMapping("day", "day"),
                        new System.Data.Common.DataColumnMapping("time", "time"),
                        new System.Data.Common.DataColumnMapping("date5", "date5"),
                        new System.Data.Common.DataColumnMapping("message1", "message1"),
                        new System.Data.Common.DataColumnMapping("Id_sender", "Id_sender"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Id_sms", "Id_sms"),
                        new System.Data.Common.DataColumnMapping("subject1", "subject1"),
                        new System.Data.Common.DataColumnMapping("message2", "message2"),
                        new System.Data.Common.DataColumnMapping("date6", "date6"),
                        new System.Data.Common.DataColumnMapping("Id_office_user1", "Id_office_user1"),
                        new System.Data.Common.DataColumnMapping("Receivered", "Receivered")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Table1";
            // 
            // Form_downloadebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Font = new System.Drawing.Font("B Lotus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form_downloadebook";
            this.Text = "Form_downloadebook";
            this.Load += new System.EventHandler(this.Form_downloadebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Data.SqlClient.SqlDataAdapter adp;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.DataSet ds;
        private System.Data.DataTable dataTable1;
    }
}