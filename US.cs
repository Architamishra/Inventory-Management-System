using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace IMS
{
    public partial class US : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
        public US()
        {
            InitializeComponent();
            LoadCustomerData();
        }

        private void US_Load(object sender, EventArgs e)
        {


        }
        private void LoadCustomerData()
        {
            string sql = "SELECT * FROM Customers"; // Adjust the query to select specific columns if needed

            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        var adapter = new SqlDataAdapter(cmd);
                        var customerTable = new DataTable();
                        adapter.Fill(customerTable);

                        dataGridView1.DataSource = customerTable; // Bind the data to the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer data: " + ex.Message);
                }
            }
        }

        // Refresh button event to reload data
        private void button1_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
            button1.Hide();// Reload data when the button is clicked
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inv inv = new Inv();
            inv.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
