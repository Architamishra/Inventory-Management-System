using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS
{
    public class ListItem
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public ListItem(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name; // Display only the product name in ListBox
        }
    }

    public partial class CustomerForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";

        public CustomerForm()
        {
            InitializeComponent();
            LoadProducts(); // Load products when the form initializes
            InitializeMenuStrip(); // Initialize ToolStripMenu
        }

        private void LoadProducts()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT product_id, product_name FROM prod";

                    using (var command = new SqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        listBox2.Items.Clear();
                        while (reader.Read())
                        {
                            var item = new ListItem(reader["product_name"].ToString(), Convert.ToInt32(reader["product_id"]));
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

        private void InitializeMenuStrip()
        {
            MenuStrip menuStrip = new MenuStrip();

            // Add "Brand" menu item
            ToolStripMenuItem brandMenuItem = new ToolStripMenuItem("Brand");
            brandMenuItem.Click += BrandMenuItem_Click;
            menuStrip.Items.Add(brandMenuItem);

            // Add "Category" menu item
            ToolStripMenuItem categoryMenuItem = new ToolStripMenuItem("Category");
            categoryMenuItem.Click += CategoryMenuItem_Click;
            menuStrip.Items.Add(categoryMenuItem);

            // Add "All Products" menu item
            ToolStripMenuItem allProductsMenuItem = new ToolStripMenuItem("All Products");
            allProductsMenuItem.Click += AllProductsMenuItem_Click;
            menuStrip.Items.Add(allProductsMenuItem);

            // Add the menuStrip to the form's controls
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void BrandMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brand menu item clicked"); // Replace with actual brand logic
        }

        private void CategoryMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Category menu item clicked"); // Replace with actual category logic
        }

        private void AllProductsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Products menu item clicked"); // Replace with logic to load all products
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is ListItem selectedItem)
            {
                int customerId = 123; // Replace with actual customer ID logic
              //  ProductDetailsForm productDetailsForm = new ProductDetailsForm(selectedItem.Name, customerId);
                //productDetailsForm.ShowDialog();
            }
        }
    }
}
