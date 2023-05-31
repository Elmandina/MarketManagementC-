using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace marketManagement
{
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elma\OneDrive\Documents\Marketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            string username, password, confPassword, email, phone, gender;

            username = textBox1.Text;
            password = textBox2.Text;
            confPassword = textBox3.Text;
            email = textBox4.Text;
            phone = textBox5.Text;
            if(radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            if(password != confPassword)
            {
                MessageBox.Show("Passwords fields don't match!\nCheck them again.");
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();
            }
            try
            {
                conn.Open();
                //string query = "insert into Table values('"+IdTxt.Text+",'"+PrdNameTxt.Text+"','"+QtyTxt.Text+"','"+PrdPriceTxt.Text+"')";
                SqlCommand cmd = new SqlCommand("insert into CustomerLogin values(@username, @password, @email, @phone, @gender)", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", gender);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thank you for choosing us!");
                conn.Close();
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            catch
            {
                MessageBox.Show("Please fill all the required fields!");
        
            }
        }
    }
}
