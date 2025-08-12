namespace DesktopApp
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NAMETEXT = new System.Windows.Forms.TextBox();
            this.PWDTEXT = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Rajkot = new System.Windows.Forms.ListBox();
            this.MALE_radioButton1 = new System.Windows.Forms.RadioButton();
            this.FEMALE_radioButton2 = new System.Windows.Forms.RadioButton();
            this.REGISTER_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "City : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NAMETEXT
            // 
            this.NAMETEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAMETEXT.Location = new System.Drawing.Point(227, 43);
            this.NAMETEXT.Name = "NAMETEXT";
            this.NAMETEXT.Size = new System.Drawing.Size(186, 30);
            this.NAMETEXT.TabIndex = 5;
            // 
            // PWDTEXT
            // 
            this.PWDTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWDTEXT.Location = new System.Drawing.Point(227, 91);
            this.PWDTEXT.Name = "PWDTEXT";
            this.PWDTEXT.PasswordChar = '$';
            this.PWDTEXT.Size = new System.Drawing.Size(186, 30);
            this.PWDTEXT.TabIndex = 6;
            this.PWDTEXT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "B.Tech CE",
            "B.Tech IT",
            "B.Tech CIVIL",
            "B.Tech CS"});
            this.comboBox1.Location = new System.Drawing.Point(227, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // Rajkot
            // 
            this.Rajkot.FormattingEnabled = true;
            this.Rajkot.ItemHeight = 16;
            this.Rajkot.Items.AddRange(new object[] {
            "RAJKOT",
            "MORBI",
            "SURAT",
            "JAMNAGAR"});
            this.Rajkot.Location = new System.Drawing.Point(231, 239);
            this.Rajkot.Name = "Rajkot";
            this.Rajkot.Size = new System.Drawing.Size(182, 84);
            this.Rajkot.TabIndex = 8;
            this.Rajkot.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MALE_radioButton1
            // 
            this.MALE_radioButton1.AutoSize = true;
            this.MALE_radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MALE_radioButton1.Location = new System.Drawing.Point(231, 188);
            this.MALE_radioButton1.Name = "MALE_radioButton1";
            this.MALE_radioButton1.Size = new System.Drawing.Size(76, 29);
            this.MALE_radioButton1.TabIndex = 9;
            this.MALE_radioButton1.TabStop = true;
            this.MALE_radioButton1.Text = "Male";
            this.MALE_radioButton1.UseVisualStyleBackColor = true;
            this.MALE_radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FEMALE_radioButton2
            // 
            this.FEMALE_radioButton2.AutoSize = true;
            this.FEMALE_radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FEMALE_radioButton2.Location = new System.Drawing.Point(326, 186);
            this.FEMALE_radioButton2.Name = "FEMALE_radioButton2";
            this.FEMALE_radioButton2.Size = new System.Drawing.Size(98, 29);
            this.FEMALE_radioButton2.TabIndex = 10;
            this.FEMALE_radioButton2.TabStop = true;
            this.FEMALE_radioButton2.Text = "Female";
            this.FEMALE_radioButton2.UseVisualStyleBackColor = true;
            this.FEMALE_radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // REGISTER_BTN
            // 
            this.REGISTER_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTER_BTN.Location = new System.Drawing.Point(84, 357);
            this.REGISTER_BTN.Name = "REGISTER_BTN";
            this.REGISTER_BTN.Size = new System.Drawing.Size(329, 40);
            this.REGISTER_BTN.TabIndex = 11;
            this.REGISTER_BTN.Text = "Register";
            this.REGISTER_BTN.UseVisualStyleBackColor = true;
            this.REGISTER_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.REGISTER_BTN);
            this.Controls.Add(this.FEMALE_radioButton2);
            this.Controls.Add(this.MALE_radioButton1);
            this.Controls.Add(this.Rajkot);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PWDTEXT);
            this.Controls.Add(this.NAMETEXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NAMETEXT;
        private System.Windows.Forms.TextBox PWDTEXT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox Rajkot;
        private System.Windows.Forms.RadioButton MALE_radioButton1;
        private System.Windows.Forms.RadioButton FEMALE_radioButton2;
        private System.Windows.Forms.Button REGISTER_BTN;
    }
}