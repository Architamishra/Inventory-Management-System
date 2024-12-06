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
    public partial class Sup1 : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
        public Sup1()
        {
            InitializeComponent();
        }

        private void Sup1_Load(object sender, EventArgs e)
        {
            LoadSupplierData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Reload supplier data when the button is clicked
            LoadSupplierData();
        }

        private void LoadSupplierData()
        {
            string query = "SELECT * FROM Supplier";  // Adjust the query to match your table schema
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable supplierTable = new DataTable();
                        adapter.Fill(supplierTable);

                        dataGridView1.DataSource = supplierTable;  // Bind the data to the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading supplier data: " + ex.Message);
                }
            }
        }

    }
}
