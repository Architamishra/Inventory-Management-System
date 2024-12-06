using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS
{
    public partial class Min1 : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";

        public Min1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void Min1_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        // Method to load data from the Inventory table and display it in DataGridView
        public void LoadInventoryData()
        {
            string sql = "SELECT * FROM Inventory";  // Modify this based on actual table structure
            DataTable inventoryTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(inventoryTable);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = inventoryTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inv inv = new Inv();
            inv.Show();
        }
    }
}
