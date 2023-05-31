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


namespace marketManagement
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elma\OneDrive\Documents\Marketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                conn.Open();
                string myquery = "select * from CustomerLogin";
                SqlDataAdapter da = new SqlDataAdapter(myquery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustGrid.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CustGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = CustGrid.Rows[e.RowIndex];
                CustName.Text = selectedRow.Cells["username"].Value.ToString();
                CustEmail.Text = selectedRow.Cells["email"].Value.ToString();
                CustPhone.Text = selectedRow.Cells["phone"].Value.ToString();
                gender.Text = selectedRow.Cells["gender"].Value.ToString();
            }
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM OrdersTb WHERE CustName = @CustName", conn);
            sda.SelectCommand.Parameters.AddWithValue("@CustName", CustName.Text);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            OrdersLbl.Text = dt.Rows[0][0].ToString();



            SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(TotalAmount) FROM OrdersTb WHERE CustName = @CustName", conn);
            sd.SelectCommand.Parameters.AddWithValue("@CustName", CustName.Text);

            DataTable dt1 = new DataTable();
            sd.Fill(dt1);

            OrdersAmt.Text = dt1.Rows[0][0].ToString();


            SqlDataAdapter sd1 = new SqlDataAdapter("SELECT MAX(OrderDate) FROM OrdersTb WHERE CustName = @CustName", conn);
            sd1.SelectCommand.Parameters.AddWithValue("@CustName", CustName.Text);

            DataTable dt2 = new DataTable();
            sd1.Fill(dt2);

            DateLbl.Text = dt2.Rows[0][0].ToString();
            conn.Close();


        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CustName.Text == "")
            {
                MessageBox.Show("Enter customer's username!");
            }
            else
            {
                conn.Open();
                string myquery = "delete from CustomerLogin where username='" + CustName.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer deleted successfully");
                conn.Close();
                populate();
            }
        }

        private void HBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();
            this.Hide();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string updateQuery = "UPDATE CustomerLogin SET email = @email, phone = @phone, gender = @gender WHERE username = @username";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@username", CustName.Text);
                cmd.Parameters.AddWithValue("@email", CustEmail.Text);
                cmd.Parameters.AddWithValue("@phone", CustPhone.Text);
                cmd.Parameters.AddWithValue("@gender", gender.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer's details edited successfully!");
                    populate();
                }
                else
                {
                    MessageBox.Show("No rows updated");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }
    }

}
