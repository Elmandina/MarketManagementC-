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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
                //product = selectedRow.Cells["PrdName"].Value.ToString();

            }
        }
        void populateProducts()
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
        int num = 0;
        int uprice, totalprice, qty;
        string product;


        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProducts();
        }
        int flag = 0;
        int stock;
        private void ProdGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProdGrid.Rows[e.RowIndex];
                product = row.Cells["PrdName"].Value.ToString();
                //qty = Convert.ToInt32(QtyTxt.Text);
                stock = Convert.ToInt32(row.Cells["Qty"].Value.ToString());
                uprice = Convert.ToInt32(row.Cells["PrdPrice"].Value.ToString());
                //totalprice = qty * uprice;
                flag = 1;

            }
        }

        void updateQuantity()
        {
            conn.Open();
            //int id = Convert.ToInt32(ProdGrid.SelectedRows[0].Cells[0].Value);
            int newQty = stock - Convert.ToInt32(QtyTxt.Text);
            SqlCommand cmd = new SqlCommand("UPDATE ProductsTb SET  @Qty = newQty where @PrdName =  PrdNameTxt", conn);
            //cmd.Parameters.AddWithValue("@Id", id);
            //cmd.Parameters.AddWithValue("@PrdName", PrdNameTxt.Text);
            cmd.Parameters.AddWithValue("@Qty", newQty);
            conn.Close();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int shuma = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTxt.Text == "")

                MessageBox.Show("Enter th quantity of product");

            else if (flag == 0)

                MessageBox.Show("Select the product");

            else if (Convert.ToInt32(QtyTxt.Text) > stock)

                MessageBox.Show("Product is out of stock.Please wait or select another amount!");

            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTxt.Text);
                totalprice = qty * uprice;
                OrderGv.Rows.Add(num, product, qty, uprice, totalprice);
                flag = 0;
                shuma = shuma + totalprice;
                shumTotale.Text = shuma.ToString();
            }
            /*shuma =shuma + totalprice;
            shumTotale.Text = "Rs:" + shuma.ToString();*/
            updateQuantity();
        }

        private void InsertOrder_Click(object sender, EventArgs e)
        {
            if (OrderId.Text == "" || CustName.Text == "" || shumTotale.Text == "")
            {
                MessageBox.Show("Fill all the data fields correctly");
            }
            else
            {
                try
                {
                    //using (SqlConnection conn = new SqlConnection("YourConnectionString"))
                    {
                        conn.Open();
                        if (DateTime.TryParse(orderDate.Text, out DateTime orderDateTime))
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO OrdersTb (OrderId, CustName, OrderDate, TotalAmount) VALUES (@OrderId, @CustName, @OrderDate, @TotalAmount)", conn);

                            cmd.Parameters.AddWithValue("@OrderId", OrderId.Text);
                            cmd.Parameters.AddWithValue("@CustName", CustName.Text);
                            cmd.Parameters.AddWithValue("@OrderDate", orderDate.Text);
                            cmd.Parameters.AddWithValue("@TotalAmount", shumTotale.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Order added successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();

        }
    }
}
