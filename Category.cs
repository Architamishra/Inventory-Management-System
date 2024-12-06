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
    public partial class Category : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string currentAction = "";
        public Category()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            button1.Click += buttonNew_Click;
            button2.Click += buttonSave_Click;
            button3.Click += buttonUpdate_Click;
            button4.Click += buttonDelete_Click;
            LoadCategoryList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Category_Load(object sender, EventArgs e)
        {
            SetButtonState(true, false, true, true);
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
                MessageBox.Show("Please select a category to update.");
                return;
            }
            currentAction = "update";
            SetButtonState(false, true, false, true);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a category to delete.");
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
                        // Adding created_date to the insert statement
                        sql = $"INSERT INTO Category (name, description, created_date) VALUES ('{textBox1.Text}', '{textBox2.Text}', GETDATE()); SELECT SCOPE_IDENTITY();";
                        cmd = new SqlCommand(sql, conn);
                        int newId = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Category added successfully!");
                        listBox1.Items.Add($"c{newId:D3}: {textBox1.Text}");
                        break;

                    case "update":
                        int categoryId = int.Parse(listBox1.SelectedItem.ToString().Substring(1, listBox1.SelectedItem.ToString().IndexOf(":") - 1));
                        // Updating updated_date in the update statement
                        sql = $"UPDATE Category SET name = '{textBox1.Text}', description = '{textBox2.Text}', updation_date = GETDATE() WHERE category_id = {categoryId}";
                        cmd = new SqlCommand(sql, conn);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category updated successfully!");
                            listBox1.Items[listBox1.SelectedIndex] = $"c{categoryId:D3}: {textBox1.Text}";
                        }
                        else
                        {
                            MessageBox.Show("No records updated. Please check the Category ID.");
                        }
                        break;

                    case "delete":
                        categoryId = int.Parse(listBox1.SelectedItem.ToString().Substring(1, listBox1.SelectedItem.ToString().IndexOf(":") - 1));
                        sql = $"DELETE FROM Category WHERE category_id = {categoryId}";
                        cmd = new SqlCommand(sql, conn);
                        int deleteRowsAffected = cmd.ExecuteNonQuery();
                        if (deleteRowsAffected > 0)
                        {
                            MessageBox.Show("Category deleted successfully!");
                            listBox1.Items.Remove(listBox1.SelectedItem);
                        }
                        else
                        {
                            MessageBox.Show("No records deleted. Please check the Category ID.");
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
                LoadCategoryList();
            }
        }

        private void LoadCategoryList()
        {
            listBox1.Items.Clear();

            try
            {
                conn.Open();
                string sql = "SELECT category_id, name FROM Category";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add($"c{((int)reader["category_id"]):D3}: {reader["name"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
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
        }

        private void SetButtonState(bool newEnabled, bool saveEnabled, bool updateEnabled, bool deleteEnabled)
        {
            button1.Enabled = newEnabled;
            button2.Enabled = saveEnabled;
            button3.Enabled = updateEnabled;
            button4.Enabled = deleteEnabled;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inv inv = new Inv();
            inv.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
