using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS
{
    public partial class Ord : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";

        public Ord()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void LoadOrderData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT order_id, product_id, product_name, customer_id, product_description, price, quantity, order_date, customer_name, Phone_no, Address FROM Orders";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order data: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string orderId = row.Cells["order_id"].Value.ToString();
                string orderName = row.Cells["product_name"].Value.ToString();
                decimal totalAmount = Convert.ToDecimal(row.Cells["price"].Value) * Convert.ToInt32(row.Cells["quantity"].Value);
                string address = row.Cells["Address"].Value.ToString();
                string quantity = row.Cells["quantity"].Value.ToString();

                Billing bill = new Billing(orderId, orderName, quantity, totalAmount, address);
                bill.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inv in1 = new Inv();
            in1.ShowDialog();
            in1.Hide();
        }
    }

}
