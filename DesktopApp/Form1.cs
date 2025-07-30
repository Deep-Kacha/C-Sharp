using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void welCome_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(num1.Text);
            int b=Convert.ToInt32(num2.Text);

            //MessageBox.Show("The sum is: " + (a + b).ToString()/, "Sum Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ans.Text = "Answer: " + (int.Parse(num1.Text) + int.Parse(num2.Text)).ToString();
            ans.Visible = true;
        }

        private void ans_Click(object sender, EventArgs e)
        {
            
        }
    }
}
