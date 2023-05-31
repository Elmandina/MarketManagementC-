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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(panel1.BackColor), 0, 0, panel1.Width, panel1.Height);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Enabled)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PassTxt.PasswordChar = '\0';//nqs klikojme show password shfaqet passwordi /0 prd per te shfaq karakteret aktuale
            }
            else
            {
                PassTxt.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserNameTxt.Text = "";
            PassTxt.Text = "";
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elma\OneDrive\Documents\Marketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username, password;
            string query = string.Empty;

            UserNameTxt.Focus();
            username = UserNameTxt.Text;
            password = PassTxt.Text;

            try
            {
                conn.Open();
                if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Be sure you have selected a role in the combobox");
                    UserNameTxt.Clear();
                    PassTxt.Clear();
                    UserNameTxt.Focus();
                }
                else
                {
                    if (comboBox1.SelectedItem.ToString() == "Admin")
                    {
                        query = "SELECT * FROM Login WHERE Username = @Username AND Password = @Password";
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Customer")
                    {
                        query = "SELECT * FROM CustomerLogin WHERE username = @Username AND password = @Password";
                    }


                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                    sda.SelectCommand.Parameters.AddWithValue("@Username", UserNameTxt.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@Password", PassTxt.Text);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        username = UserNameTxt.Text;
                        password = PassTxt.Text;

                        if (comboBox1.SelectedItem.ToString() == "Admin")
                        {
                            //query = "SELECT * FROM Login WHERE Username='" + UserNameTxt.Text + "' AND Password='" + PassTxt.Text + "'";
                            AdminDashboard admin = new AdminDashboard();
                            admin.Show();
                        }
                        else if (comboBox1.SelectedItem.ToString() == "Customer")
                        {
                            // query = "SELECT * FROM CustomerLogin WHERE username='" + UserNameTxt.Text + "' AND password='" + PassTxt.Text + "'";
                            ManageOrders order = new ManageOrders();
                            order.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details!");
                        UserNameTxt.Clear();
                        PassTxt.Clear();

                        UserNameTxt.Focus();
                    }/*
                if (comboBox1.SelectedItem.ToString() == "Admin")
                {
                    if(UserNameTxt.Text == "Admin" && PassTxt.Text == "admin123")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                        this.Hide();
                    }
                }*/
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CustomerRegistration customer = new CustomerRegistration();
            customer.Show();
        }

        private void UserNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}