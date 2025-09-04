using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Sharp\\DesktopApp\\Database1.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Student(EnrollNo, Age, Name, City) VALUES (@EnrollNo, @Age, @Name, @City)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EnrollNo", txtEnroll.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text); // Fixed: was txtCity.Text
                    cmd.Parameters.AddWithValue("@City", txtCity.Text); // Fixed: was txtName.Text
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Sharp\\DesktopApp\\Database1.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Student SET Age=@Age, Name=@Name, City=@City WHERE EnrollNo=@EnrollNo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EnrollNo", txtEnroll.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void Age_Click(object sender, EventArgs e)
        {

        }

        private void Enroll_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Sharp\\DesktopApp\\Database1.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Student WHERE EnrollNo=@EnrollNo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EnrollNo", txtEnroll.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }
                
        private void Reset_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Sharp\\DesktopApp\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string query = "UPDATE Student SET Age=NULL, Name='', City='' WHERE EnrollNo=@EnrollNo";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EnrollNo", txtEnroll.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void txtEnroll_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
