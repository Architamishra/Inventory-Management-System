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
    public partial class AddData : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        String str, sql;
        SqlDataReader dr;
        SqlDataAdapter da;
        string currentAction = "";


        public AddData()
        {
            InitializeComponent();
        }

        private void AddData_Load(object sender, EventArgs e)
        {
            str = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(str);
            button1.Click += buttonNew_Click;
            button2.Click += buttonSave_Click;
            button3.Click += buttonUpdate_Click;
            button4.Click += buttonDelete_Click;

            // Load products into ListBox
            LoadProductList();
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            currentAction = "add";
            SetButtonState(false, true, false, false);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }
            currentAction = "update";
            SetButtonState(false, true, false, true);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }
            currentAction = "delete";
            SetButtonState(false, true, false, true);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql;

                switch (currentAction)
                {
                    case "add":
                        sql = $"INSERT INTO Products (ProductName, Category, Quantity, Price) VALUES ('{textBox1.Text}', '{textBox2.Text}', {int.Parse(textBox3.Text)}, {decimal.Parse(textBox4.Text)}); SELECT SCOPE_IDENTITY();";
                        cmd = new SqlCommand(sql, conn);
                        int newId = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Product added successfully!");
                        listBox1.Items.Add($"p{newId:D3}: {textBox1.Text}");
                        break;

                    case "update":
                        int productId = int.Parse(listBox1.SelectedItem.ToString().Substring(1, listBox1.SelectedItem.ToString().IndexOf(":") - 1));
                        sql = $"UPDATE Products SET ProductName = '{textBox1.Text}', Category = '{textBox2.Text}', Quantity = {int.Parse(textBox3.Text)}, Price = {decimal.Parse(textBox4.Text)} WHERE ProductId = {productId}";
                        cmd = new SqlCommand(sql, conn);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully!");
                            listBox1.Items[listBox1.SelectedIndex] = $"p{productId:D3}: {textBox1.Text}";
                        }
                        else
                        {
                            MessageBox.Show("No records updated. Please check the Product ID.");
                        }
                        break;

                    case "delete":
                        productId = int.Parse(listBox1.SelectedItem.ToString().Substring(1, listBox1.SelectedItem.ToString().IndexOf(":") - 1));
                        sql = $"DELETE FROM Products WHERE ProductId = {productId}";
                        cmd = new SqlCommand(sql, conn);
                        int deleteRowsAffected = cmd.ExecuteNonQuery();
                        if (deleteRowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully!");
                            listBox1.Items.Remove(listBox1.SelectedItem);
                        }
                        else
                        {
                            MessageBox.Show("No records deleted. Please check the Product ID.");
                        }
                        break;

                    default:
                        MessageBox.Show("No action specified.");
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                ClearFields();
                SetButtonState(true, false, true, true);
                currentAction = ""; // Reset action after Save
                LoadProductList();
            }
        }

        private void LoadProductList()
        {
            listBox1.Items.Clear();

            try
            {
                conn.Open();
                string sql = "SELECT ProductId, ProductName FROM Products";
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add($"p{((int)dr["ProductId"]):D3}: {dr["ProductName"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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

    }
}
