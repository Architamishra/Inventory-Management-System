using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS
{
    public partial class Users : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str;

        public Users()
        {
            InitializeComponent();
            // Initialize connection string here or in LoadData
        }

        private void Users_Load(object sender, EventArgs e)
        {
            str = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            LoadData(); // Call LoadData after setting the connection string
        }

        private void LoadData()
        {
            conn = new SqlConnection(str); // Move this line to LoadData

            try
            {
                conn.Open();
                string query = "SELECT Id, Name, Email FROM Customers"; // Update column names as necessary

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to dataGridViewUsers
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close(); // Ensure connection is closed
                }
            }
        }
    }
}
