using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS
{
    public partial class SignInForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql, str;
        SqlDataReader dr;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            str = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(str);


            comboBox1.Items.Add("Seller");
            comboBox1.Items.Add("Customer");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string email = textBox3.Text;
            string username = textBox4.Text;
            string password = textBox5.Text;
            string role = comboBox1.SelectedItem.ToString();


            if (!email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email must end with '@gmail.com'.");
                return;
            }

            try
            {
                conn.Open();


                sql = $"SELECT Username FROM Sellers WHERE Username='{username}' UNION SELECT Username FROM Customers WHERE Username='{username}'";
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Username already exists! Please choose another one.");
                    dr.Close();
                    return;
                }
                dr.Close();

                if (role == "Seller")
                {

                    sql = "SELECT COUNT(*) FROM Sellers";
                    cmd = new SqlCommand(sql, conn);
                    int sellerCount = (int)cmd.ExecuteScalar();

                    if (sellerCount > 0)
                    {
                        MessageBox.Show("A seller account already exists. Only one seller is allowed.");
                        return;
                    }
                    else
                    {

                        sql = $"INSERT INTO Sellers (Name, Email, Username, Password) VALUES ('{name}', '{email}', '{username}', '{password}')";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller account created successfully!");
                    }
                }
                else if (role == "Customer")
                {

                    sql = $"INSERT INTO Customers (Name, Email, Username, Password) VALUES ('{name}', '{email}', '{username}', '{password}')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer account created successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                conn.Close();
                cmd.Dispose();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
