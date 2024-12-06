using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace IMS
{
    public partial class Cust : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
        private bool isBrandSelected = false;
        private bool isCategorySelected = false;

        // Add fields to store customer information
        private int customerId;
        private string customerName;

        // Modify constructor to accept customerId and customerName
        public Cust(int customerId, string customerName)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.customerName = customerName;

            InitializeMenuEvents();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
        }

        private void InitializeMenuEvents()
        {
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            isBrandSelected = true;
            isCategorySelected = false;
            LoadBrands();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            isBrandSelected = false;
            isCategorySelected = true;
            LoadCategories();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            isBrandSelected = false;
            isCategorySelected = false;
            LoadAllProducts();
        }

        private void LoadBrands()
        {
            listBox1.Items.Clear();
            string query = "SELECT brand_id, brand_name FROM Brand";
            LoadDataIntoListBox(listBox1, query, isProductList: false);
        }

        private void LoadCategories()
        {
            listBox1.Items.Clear();
            string query = "SELECT category_id, name FROM Category";
            LoadDataIntoListBox(listBox1, query, isProductList: false);
        }

        private void LoadAllProducts()
        {
            listBox2.Items.Clear();
            string query = "SELECT product_id, product_name FROM prod";
            LoadDataIntoListBox(listBox2, query, isProductList: true);
        }

        private void LoadDataIntoListBox(ListBox listBox, string query, bool isProductList)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var itemName = reader[1].ToString();
                            var itemId = Convert.ToInt32(reader[0]);
                            var item = new CustomListItem(itemName, itemId);

                            listBox.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void LoadProductsByBrandOrCategory(int id)
        {
            listBox2.Items.Clear();
            string query = "SELECT product_id, product_name FROM prod WHERE brand_id = @Id OR category_id = @Id";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new CustomListItem(reader["product_name"].ToString(), Convert.ToInt32(reader["product_id"]));
                            listBox2.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is CustomListItem selectedItem)
            {
                LoadProductsByBrandOrCategory(selectedItem.Id);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is CustomListItem selectedProduct)
            {
                OpenProductDetailsForm(selectedProduct.Id);
            }
        }

        // Updated method to include customerName in addition to customerId
        private void OpenProductDetailsForm(int productId)
        {
            if (customerId != 0 && !string.IsNullOrEmpty(customerName))
            {
                // Use the parameterized constructor if customer info is available
                ProductDetailsForm productDetailsForm = new ProductDetailsForm(productId, customerId, customerName);
                productDetailsForm.ShowDialog();
            }

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Ord ordForm = new Ord();

            ordForm.Show();
        }
    }

    public class CustomListItem
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public CustomListItem(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
