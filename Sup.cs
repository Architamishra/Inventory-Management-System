using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace IMS
{
    public partial class Sup : Form
    {
        private SqlConnection conn;
        private string currentAction = "";

        public Sup()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            LoadSupplierList();
        }

        private void Sup_Load(object sender, EventArgs e)
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
                sql = $"INSERT INTO Supplier (name, phone, email, address, created_date) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', GETDATE()); SELECT SCOPE_IDENTITY();";
            }
            else if (currentAction == "update")
            {
                int supplierId = GetSelectedSupplierId();
                sql = $"UPDATE Supplier SET name = '{textBox1.Text}', phone = '{textBox2.Text}', email = '{textBox3.Text}', address = '{textBox4.Text}', updated_date = GETDATE() WHERE seller_id = {supplierId}";
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
                            MessageBox.Show($"Supplier added successfully! Supplier ID: {newId}");
                        }
                        else if (currentAction == "update")
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Supplier updated successfully!");
                        }
                    }
                }
                LoadSupplierList();
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
                MessageBox.Show("Please select a supplier to update.");
                return;
            }
            currentAction = "update";
            SetButtonState(false, true, false, true);
            LoadSelectedSupplierData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int supplierId = GetSelectedSupplierId();
                string sql = $"DELETE FROM Supplier WHERE supplier_id = {supplierId}";

                try
                {
                    using (conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        conn.Open();
                        using (var cmd = new SqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Supplier deleted successfully!");
                        }
                    }
                    LoadSupplierList();
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

        private void LoadSupplierList()
        {
            listBox1.Items.Clear();
            string sql = "SELECT supplier_id, name FROM Supplier";

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
                            listBox1.Items.Add($"ID: {reader["supplier_id"]}, Name: {reader["name"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier: " + ex.Message);
            }
        }

        private void LoadSelectedSupplierData()
        {
            int supplierId = GetSelectedSupplierId();
            string sql = $"SELECT name, phone, email, address FROM Supplier WHERE supplier_id = {supplierId}";

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
                            textBox1.Text = reader["name"].ToString();
                            textBox2.Text = reader["phone"].ToString();
                            textBox3.Text = reader["email"].ToString();
                            textBox4.Text = reader["address"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading seller data: " + ex.Message);
            }
        }

        private int GetSelectedSupplierId()
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
            textBox3.Clear();
            textBox4.Clear();
        }

        private void SetButtonState(bool newEnabled, bool saveEnabled, bool updateEnabled, bool deleteEnabled)
        {
            button1.Enabled = newEnabled;
            button2.Enabled = saveEnabled;
            button3.Enabled = updateEnabled;
            button4.Enabled = deleteEnabled;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inv inv = new Inv();
            inv.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

