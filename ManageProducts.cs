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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();
            this.Hide();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elma\OneDrive\Documents\Marketdb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
           
            try
            {
                conn.Open();
                string myquery = "select * from ProductsTb";
                SqlDataAdapter da = new SqlDataAdapter(myquery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProdGrid.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch
            {

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //string query = "insert into Table values('"+IdTxt.Text+",'"+PrdNameTxt.Text+"','"+QtyTxt.Text+"','"+PrdPriceTxt.Text+"')";
                SqlCommand cmd = new SqlCommand("insert into ProductsTb values(@Id, @PrdName, @Qty, @PrdPrice)", conn);
                cmd.Parameters.AddWithValue("@Id", IdTxt.Text);
                cmd.Parameters.AddWithValue("@PrdName", PrdNameTxt.Text);
                cmd.Parameters.AddWithValue("@Qty", QtyTxt.Text);
                cmd.Parameters.AddWithValue("@PrdPrice", PrdPriceTxt.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added sucessfully!");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (IdTxt.Text == "")
            {
                MessageBox.Show("Enter products id");
            }
            else
            {
                conn.Open();
                string myquery = "delete from ProductsTb where Id='" + IdTxt.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully");
                conn.Close();
                populate();
            }
        }

        private void ProdV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProdGrid.Rows[e.RowIndex];
                IdTxt.Text = row.Cells["Id"].Value.ToString();
                PrdNameTxt.Text = row.Cells["PrdName"].Value.ToString();
                QtyTxt.Text = row.Cells["Qty"].Value.ToString();
                PrdPriceTxt.Text = row.Cells["PrdPrice"].Value.ToString();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ProductsTb SET @PrdName = PrdNameTxt, @Qty = Qty, @PrdPrice = PrdPrice WHERE @Id = IdTxt", conn);
                cmd.Parameters.AddWithValue("@Id", IdTxt.Text);
                cmd.Parameters.AddWithValue("@PrdName", PrdNameTxt.Text);
                cmd.Parameters.AddWithValue("@Qty", QtyTxt.Text);
                cmd.Parameters.AddWithValue("@PrdPrice", PrdPriceTxt.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product edited successfully!");
                    populate();
                }
                else
                {
                    MessageBox.Show("No rows updated");
                }

                conn.Close();

                /* conn.Close();
                 populate();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ProdGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
