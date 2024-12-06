using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace IMS
{
    public partial class ProductDetailsForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
        private readonly int productId;
        private readonly int customerId;
        private readonly string customerName;

        // Constructor that accepts productId, customerId, and customerName
        public ProductDetailsForm(int productId, int customerId, string customerName)
        {
            InitializeComponent();
            this.productId = productId;
            this.customerId = customerId;
            this.customerName = customerName;
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
            button1.Hide();
        }

        private void LoadProductDetails()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT product_name, price, description FROM prod WHERE product_id = @productId";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@productId", productId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    label2.Text = reader["product_name"].ToString();
                                    label3.Text = reader["price"].ToString();
                                    label4.Text = reader["description"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No products found with the given ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product details: {ex.Message}");
            }
        }

        private void SaveOrder(int quantity, string address, string phoneNo)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    decimal unitPrice = decimal.Parse(label3.Text); // Price from label3
                    decimal totalPrice = quantity * unitPrice; // Calculate total price

                    string insertOrderQuery = @"
            INSERT INTO Orders (product_id, product_name, customer_id, product_description, price, quantity, order_date, customer_name, Phone_no, Address, Total_price)
            VALUES (@productId, @productName, @customerId, @productDescription, @price, @quantity, GETDATE(), @customerName, @Phone_no, @Address, @totalPrice)";

                    using (var command = new SqlCommand(insertOrderQuery, connection))
                    {
                        command.Parameters.AddWithValue("@productId", productId);
                        command.Parameters.AddWithValue("@productName", label2.Text); // Product name from label2
                        command.Parameters.AddWithValue("@customerId", customerId);
                        command.Parameters.AddWithValue("@productDescription", label4.Text); // Description from label4
                        command.Parameters.AddWithValue("@price", unitPrice);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@customerName", customerName);
                        command.Parameters.AddWithValue("@Phone_no", phoneNo);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@totalPrice", totalPrice);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order placed successfully.");

                            // Update the inventory
                            UpdateInventory(quantity);
                        }
                        else
                        {
                            MessageBox.Show("Failed to place order.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving order: {ex.Message}");
            }
        }

        private void UpdateInventory(int quantity)
        {
            // try
            // {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to update the inventory by subtracting the order quantity
                string updateInventoryQuery = @"
            UPDATE Inventory
            SET quantity = quantity - @quantity
            WHERE product_id = @productId";

                using (var command = new SqlCommand(updateInventoryQuery, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inventory updated successfully.");


                    }
                    else
                    {
                        MessageBox.Show("Failed to update inventory.");
                    }
                }
            }
            // }
            /*catch (Exception ex)
            {
                MessageBox.Show($"Error updating inventory: {ex.Message}");
            }*/
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int quantity) && quantity > 0)
            {
                string address = textBox3.Text;
                string phoneNo = textBox4.Text;

                if (!string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(phoneNo))
                {
                    SaveOrder(quantity, address, phoneNo);
                }
                else
                {
                    MessageBox.Show("Please fill in all the customer details (Address, Phone Number).");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inv inv = new Inv();
            inv.Show();
            inv.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
