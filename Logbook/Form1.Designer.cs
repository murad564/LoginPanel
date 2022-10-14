namespace LoginPanel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Country = new System.Windows.Forms.TextBox();
            this.MotherName = new System.Windows.Forms.TextBox();
            this.FatherName = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Enter);
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Controls.Add(this.Country);
            this.groupBox1.Controls.Add(this.MotherName);
            this.groupBox1.Controls.Add(this.FatherName);
            this.groupBox1.Controls.Add(this.Age);
            this.groupBox1.Controls.Add(this.Surname);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log in";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 71);
            this.button1.TabIndex = 16;
            this.button1.Text = "DESERIALIZE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(18, 320);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(91, 71);
            this.Enter.TabIndex = 15;
            this.Enter.Text = "SERIALIZE";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(139, 254);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(63, 19);
            this.Female.TabIndex = 14;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender: ";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(72, 254);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(51, 19);
            this.Male.TabIndex = 12;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(116, 164);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(148, 23);
            this.Country.TabIndex = 11;
            // 
            // MotherName
            // 
            this.MotherName.Location = new System.Drawing.Point(116, 135);
            this.MotherName.Name = "MotherName";
            this.MotherName.Size = new System.Drawing.Size(148, 23);
            this.MotherName.TabIndex = 10;
            // 
            // FatherName
            // 
            this.FatherName.Location = new System.Drawing.Point(116, 106);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(148, 23);
            this.FatherName.TabIndex = 9;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(116, 78);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(148, 23);
            this.Age.TabIndex = 8;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(116, 52);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(148, 23);
            this.Surname.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.AcceptsReturn = true;
            this.Name.Location = new System.Drawing.Point(116, 23);
            this.Name.Name = "Name";
            this.Name.PlaceholderText = "Please enter";
            this.Name.Size = new System.Drawing.Size(148, 23);
            this.Name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mother Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Father Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.groupBox1);
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Country;
        private TextBox MotherName;
        private TextBox FatherName;
        private TextBox Age;
        private TextBox Surname;
        private TextBox Name;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Enter;
        private RadioButton Female;
        private Label label7;
        private RadioButton Male;
        private Button button1;
    }
}