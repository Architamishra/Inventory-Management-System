using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS
{
    public partial class Pro : Form
    {
        private SqlConnection conn;
        private string currentAction = "";

        public Pro()
        {
            InitializeComponent();
            this.Load += Pro_Load;
            conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            LoadproductList();
            LoadCategoryList();
            LoadBrandList();


        }

        private void Pro_Load(object sender, EventArgs e)
        {
            button1.Click += buttonNew_Click;
            button2.Click += buttonSave_Click;
            button3.Click += buttonUpdate_Click;
            button4.Click += buttonDelete_Click;
            SetButtonState(true, true, true, false);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            currentAction = "add";
            SetButtonState(false, true, false, false);
            //SetButtonState(true, false, false, false);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (currentAction == "add")
            {
                sql = $"INSERT INTO prod (product_name,price,category_id,brand_id, description,Quantity, date_added, date_updated) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{comboBoxCategory.SelectedValue}','{comboBoxBrand.SelectedValue}','{textBox5.Text}','{textBox4.Text}',GETDATE(),GETDATE()); SELECT SCOPE_IDENTITY();";
            }
            else if (currentAction == "update")
            {
                int productId = GetSelectedproductId();
                sql = $"UPDATE prod SET product_name = '{textBox1.Text}', price = '{textBox2.Text}', category_id  ='{comboBoxCategory.SelectedValue}',brand_id='{comboBoxBrand.SelectedValue}',description='{textBox5.Text}',Quantity='{textBox4.Text}',date_added = GETDATE(), date_updated = GETDATE() WHERE product_id = {productId}";
            }
            else
            {
                return;
            }

            try
            {
                using (conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        if (currentAction == "add")
                        {

                            int newId = Convert.ToInt32(cmd.ExecuteScalar());
                            MessageBox.Show($"Product added successfully! Product ID: {newId}");
                        }
                        else if (currentAction == "update")
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product updated successfully!");
                        }
                    }
                }
                LoadproductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                ClearFields();
                SetButtonState(true, false, true, true);
                currentAction = "";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }
            currentAction = "update";
            SetButtonState(false, true, true, true);
            LoadSelectedproductData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int productId = GetSelectedproductId();
                string sql = $"DELETE FROM prod WHERE product_id = {productId}";

                try
                {
                    using (conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        conn.Open();
                        using (var cmd = new SqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product deleted successfully!");
                        }
                    }
                    LoadproductList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    ClearFields();
                    SetButtonState(true, false, true, true);
                }
            }
        }

        private void LoadproductList()
        {
            listBox1.Items.Clear();
            string sql = "SELECT product_id, product_name FROM prod";

            try
            {
                using (conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add($"ID: {reader["product_id"]}, Name: {reader["product_name"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void LoadCategoryList()
        {
            string sql = "SELECT category_id, name FROM Category";
            DataTable dt = new DataTable();

            try
            {
                using (conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                comboBoxCategory.DisplayMember = "name";
                comboBoxCategory.ValueMember = "category_id";
                comboBoxCategory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void LoadBrandList()
        {
            string sql = "SELECT brand_id, brand_name FROM Brand";
            DataTable dt = new DataTable();

            try
            {
                using (conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                comboBoxBrand.DisplayMember = "brand_name";
                comboBoxBrand.ValueMember = "brand_id";
                comboBoxBrand.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading brands: " + ex.Message);
            }
        }



        private void LoadSelectedproductData()
        {
            int productId = GetSelectedproductId();
            string sql = $"SELECT product_name, price, category_id, brand_id, description,Quantity, date_added, date_updated FROM prod WHERE product_id = {productId}";

            try
            {
                using (conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["product_name"].ToString();
                            textBox2.Text = reader["price"].ToString();
                            comboBoxCategory.SelectedValue = reader["category_id"].ToString();
                            comboBoxBrand.SelectedValue = reader["brand_id"].ToString();
                            textBox4.Text = reader["Quantity"].ToString();
                            textBox5.Text = reader["description"].ToString();

                            // Set the date_added and date_updated to respective TextBox controls
                            textBox6.Text = Convert.ToDateTime(reader["date_added"]).ToString("yyyy-MM-dd HH:mm:ss");
                            textBox7.Text = Convert.ToDateTime(reader["date_updated"]).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message);
            }
        }


        private int GetSelectedproductId()
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
