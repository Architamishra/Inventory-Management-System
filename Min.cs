using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS
{
    public partial class Min : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
        private string currentAction = "";

        public Min()
        {
            InitializeComponent();
            LoadInventoryList();
            LoadProductData();
            LoadSupplierData();
        }

        private void Min_Load(object sender, EventArgs e)
        {
            button1.Click += buttonNew_Click;
            button2.Click += buttonSave_Click;
            button3.Click += buttonUpdate_Click;
            button4.Click += buttonDelete_Click;
            SetButtonState(true, true, true, true);
        }

        private void LoadProductData()
        {
            string sql = "SELECT product_id, product_name FROM prod";
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        var adapter = new SqlDataAdapter(cmd);
                        var productTable = new DataTable();
                        adapter.Fill(productTable);

                        comboBox1.DataSource = productTable;
                        comboBox1.DisplayMember = "product_name";
                        comboBox1.ValueMember = "product_id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product data: " + ex.Message);
                }
            }
        }

        private void LoadSupplierData()
        {
            string sql = "SELECT supplier_id, name FROM Supplier";
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        var adapter = new SqlDataAdapter(cmd);
                        var supplierTable = new DataTable();
                        adapter.Fill(supplierTable);

                        comboBox2.DataSource = supplierTable;
                        comboBox2.DisplayMember = "name";
                        comboBox2.ValueMember = "supplier_id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading supplier data: " + ex.Message);
                }
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            currentAction = "add";
            SetButtonState(false, true, false, false);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (currentAction == "add")
            {
                sql = $"INSERT INTO Inventory (product_id, quantity, reorder_level, date_added, last_updated, supplier_id, cost_price, selling_price) " +
                      $"VALUES ('{comboBox1.SelectedValue}', {textBox1.Text}, {textBox2.Text}, GETDATE(), GETDATE(), '{comboBox2.SelectedValue}', {textBox5.Text}, {textBox6.Text});";
            }
            else if (currentAction == "update")
            {
                int inventoryId = GetSelectedInventoryId();
                sql = $"UPDATE Inventory SET product_id = '{comboBox1.SelectedValue}', quantity = {textBox1.Text}, reorder_level = {textBox2.Text}, " +
                      $"last_updated = GETDATE(), supplier_id = '{comboBox2.SelectedValue}', cost_price = {textBox5.Text}, selling_price = {textBox6.Text} " +
                      $"WHERE inventory_id = {inventoryId}";
            }
            else
            {
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(currentAction == "add" ? "Inventory item added successfully!" : "Inventory item updated successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    LoadInventoryList();
                    ClearFields();
                    SetButtonState(false, true, true, false);
                    currentAction = "";
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an inventory item to update.");
                return;
            }
            currentAction = "update";
            SetButtonState(false, true, false, true);
            LoadSelectedInventoryData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an inventory item to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this inventory item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int inventoryId = GetSelectedInventoryId();
                string sql = $"DELETE FROM Inventory WHERE inventory_id = {inventoryId}";

                using (var conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (var cmd = new SqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Inventory item deleted successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        LoadInventoryList();
                        ClearFields();
                        SetButtonState(false, true, false, true);
                    }
                }
            }
        }

        private void LoadInventoryList()
        {
            listBox1.Items.Clear();
            string sql = "SELECT inventory_id, product_id FROM Inventory";

            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add($"ID: {reader["inventory_id"]}, Product ID: {reader["product_id"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory list: " + ex.Message);
                }
            }
        }

        private void LoadSelectedInventoryData()
        {
            int inventoryId = GetSelectedInventoryId();
            string sql = $"SELECT product_id, quantity, reorder_level, supplier_id, cost_price, selling_price FROM Inventory WHERE inventory_id = {inventoryId}";

            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            comboBox1.SelectedValue = reader["product_id"].ToString();
                            textBox1.Text = reader["quantity"].ToString();
                            textBox2.Text = reader["reorder_level"].ToString();
                            comboBox2.SelectedValue = reader["supplier_id"].ToString();
                            textBox5.Text = reader["cost_price"].ToString();
                            textBox6.Text = reader["selling_price"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory data: " + ex.Message);
                }
            }
        }

        private int GetSelectedInventoryId()
        {
            string selectedItem = listBox1.SelectedItem?.ToString();
            if (selectedItem == null)
            {
                throw new InvalidOperationException("No item is selected in the list.");
            }

            string[] parts = selectedItem.Split(',');
            string idPart = parts[0].Split(':')[1].Trim();
            return int.Parse(idPart);
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void SetButtonState(bool newEnabled, bool saveEnabled, bool updateEnabled, bool deleteEnabled)
        {
            button1.Enabled = newEnabled;
            button2.Enabled = saveEnabled;
            button3.Enabled = updateEnabled;
            button4.Enabled = deleteEnabled;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inv inv = new Inv();
            inv.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
