using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//paketa qe na duhet per me ba lidhjen me db
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketManagement
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        //krijojme lidhjen me db duke marre connection string nga db
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elma\OneDrive\Documents\Marketdb.mdf;Integrated Security=True;Connect Timeout=30");


        void populateOrders()// ndertojme nje funksion nepermjet te cilit do te mbushim me te dhena formen -DataGridView
        {
            try
            {
                conn.Open();// hapim lidhjen me db
                string myquery = "select * from OrdersTb";//ndertojme querin per te marre te dhenat nga tabela OrdersTb ne db dhe e ruajme 
                                                          //ne nje variabel
                SqlDataAdapter da = new SqlDataAdapter(myquery, conn);//funks build-in SqlDataAdapter na lejon qe te aksesojme te dhenat ne db
                                                                      //duke krijuar nje objekt te kesaj klase da
                SqlCommandBuilder builder = new SqlCommandBuilder(da);//funks build-in SqlCommandBuilder gjeneron automatikisht veprime ne db 
                                                                  //psh update etj nepermjet argumentit qe merr ne deklarim ne kete rast gjenerohet
                                                                  //veprimi select 
                var ds = new DataSet();//DataSet eshte nje funks build-in qe mban te dhena te medha ne tabela dhe keto i rujme nje var instance qe 
                                     //te kemi me te lehte veprimin
                da.Fill(ds);//ketu te dhenat qe morem me lart nga db nepermjet SqlDataAdapter mushim tabelat e ds  
                ProdGrid.DataSource = ds.Tables[0];//te dhenat e rreshtave te elementit gridview qe e kena ri-emertu me emer ProdGrid mbushen me te 
                                                //dhenat nepermjet vecoris(propertis) se saj DataSource qe ruajtem ne instancen ds duke i marre sipas nje indeksi
                conn.Close();
            }
            catch
            {

            }
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateOrders();//therrasim funks qe krijuam per te mbushur me te dhena formen ne mjedisin e formes
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();//nepermjet picturebox behet e mundur mbyllja e formes
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            ManageOrders orders = new ManageOrders();//kur klikojme butonin back ne fund te formes na qon ne nje form tj qe eshte manageorders
            //per kete krijojme nje objekt te formes ManageOrders dhe objekti eshte orders
            orders.Show();// me pas nepermjet funks build-in Show() ne shfaqim formen
            this.Hide();// dhe me this.hide ne mbyllim formen aktuale qe eshte viewOrders
        }

        private void ProdGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Document1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            



        }
    }
}
