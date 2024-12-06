using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS
{
    public partial class Brand : Form
    {
        private SqlConnection conn;
        private string currentAction = "";

        public Brand()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            LoadbrandList();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            button1.Click += buttonNew_Click;
            button2.Click += buttonSave_Click;
            button3.Click += buttonUpdate_Click;
            button4.Click += buttonDelete_Click;
            SetButtonState(true, false, true, true);
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
                sql = $"INSERT INTO Brand (brand_name, description, created_date) VALUES ('{textBox1.Text}', '{textBox2.Text}', GETDATE()); SELECT SCOPE_IDENTITY();";
            }
            else if (currentAction == "update")
            {
                int brandId = GetSelectedbrandId();
                sql = $"UPDATE Brand SET brand_name = '{textBox1.Text}', description = '{textBox2.Text}', updated_date = GETDATE() WHERE brand_id = {brandId}";
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
                            MessageBox.Show($"Brand added successfully! Brand ID: {newId}");
                        }
                        else if (currentAction == "update")
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Category updated successfully!");
                        }
                    }
                }
                LoadbrandList();
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
                MessageBox.Show("Please select a brand to update.");
                return;
            }
            currentAction = "update";
            SetButtonState(false, true, false, true);
            LoadSelectedbrandData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a brand to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this brand?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int brandId = GetSelectedbrandId();
                string sql = $"DELETE FROM Brand WHERE brand_id = {brandId}";

                try
                {
                    using (conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        conn.Open();
                        using (var cmd = new SqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Brand deleted successfully!");
                        }
                    }
                    LoadbrandList();
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

        private void LoadbrandList()
        {
            listBox1.Items.Clear();
            string sql = "SELECT brand_id, brand_name FROM Brand";

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
                            listBox1.Items.Add($"ID: {reader["brand_id"]}, Name: {reader["brand_name"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading brands: " + ex.Message);
            }
        }

        private void LoadSelectedbrandData()
        {
            int brandId = GetSelectedbrandId();
            string sql = $"SELECT brand_name, description FROM Brand WHERE brand_id = {brandId}";

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
                            textBox1.Text = reader["brand_name"].ToString();
                            textBox2.Text = reader["description"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading brand data: " + ex.Message);
            }
        }

        private int GetSelectedbrandId()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
