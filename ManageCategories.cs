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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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
                CatGrid.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch
            {

            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elma\OneDrive\Documents\Marketdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //string query = "insert into Table values('"+IdTxt.Text+",'"+PrdNameTxt.Text+"','"+QtyTxt.Text+"','"+PrdPriceTxt.Text+"')";
                SqlCommand cmd = new SqlCommand("insert into CategoryTb values(@CatId, @CatName", conn);
                cmd.Parameters.AddWithValue("@Id", CatIdTxt.Text);
                cmd.Parameters.AddWithValue("@PrdName", CatNameTxt.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added sucessfully!");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CatIdTxt.Text == "")
            {
                MessageBox.Show("Enter category's id");
            }
            else
            {
                conn.Open();
                string myquery = "delete from ProductsTb where Id='" + CatIdTxt.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category deleted successfully");
                conn.Close();
                populate();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CategoryTb SET CatNameTxt = @CatName WHERE CatIdTxt = @CatId", conn);
                cmd.Parameters.AddWithValue("@CatId", CatIdTxt.Text);
                cmd.Parameters.AddWithValue("@CatName", CatNameTxt.Text);


                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category edited successfully!");
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

        private void CatGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CatGrid.Rows[e.RowIndex];
                CatIdTxt.Text = row.Cells["CatId"].Value.ToString();
                CatNameTxt.Text = row.Cells["CatName"].Value.ToString();

            }
        }

        private void HBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();
            this.Hide();
        }
    }
}
