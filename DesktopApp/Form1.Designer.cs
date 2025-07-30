namespace DesktopApp
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
            this.welCome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welCome
            // 
            this.welCome.AutoSize = true;
            this.welCome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.welCome.Location = new System.Drawing.Point(191, 73);
            this.welCome.Name = "welCome";
            this.welCome.Size = new System.Drawing.Size(153, 16);
            this.welCome.TabIndex = 0;
            this.welCome.Text = "Additor Of Two Numbers";
            this.welCome.Click += new System.EventHandler(this.welCome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter A val1 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a val2 : ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(289, 170);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(110, 22);
            this.num1.TabIndex = 4;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(286, 234);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(110, 22);
            this.num2.TabIndex = 5;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(289, 304);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(107, 31);
            this.ans.TabIndex = 7;
            this.ans.Text = "Answer";
            this.ans.UseVisualStyleBackColor = true;
            this.ans.Visible = false;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 443);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welCome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welCome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ans;
    }
}

