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
    public partial class Inventory : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql, str;
        SqlDataReader dr;
        public Inventory()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            str = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(str);
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ProductID, ProductName, Quantity, Price FROM products"; // Update column names as necessary

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to dataList
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        
    }
}
