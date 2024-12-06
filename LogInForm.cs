using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IMS
{
    public partial class LogInForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql, str;
        SqlDataReader dr;
        string captchaValue; // Store the correct CAPTCHA value

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            // Initialize connection string
            str = "Data Source=DESKTOP-QF9NG6G\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(str);

            // Load CAPTCHA on form load
            LoadCaptcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string enteredCaptcha = textBox4.Text.Trim(); // Get the entered CAPTCHA value

            try
            {
                // Validate CAPTCHA
                if (enteredCaptcha != captchaValue)
                {
                    MessageBox.Show("Invalid CAPTCHA. Please try again.");
                    LoadCaptcha(); // Reload CAPTCHA for another attempt
                    return;
                }

                conn.Open();

                // Check in Sellers table
                sql = "SELECT * FROM Sellers WHERE Username = @username AND Password = @password";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Close();
                    Inv inv = new Inv();
                    inv.Show();
                    this.Hide();
                }
                else
                {
                    dr.Close();

                    // Check in Customers table
                    sql = "SELECT * FROM Customers WHERE Username = @username AND Password = @password";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        int customerId = (int)dr["Id"];
                        string customerName = dr["Name"].ToString();

                        dr.Close();
                        Cust c = new Cust(customerId, customerName);
                        c.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                        LoadCaptcha(); // Reload CAPTCHA after failed login attempt
                    }
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
            }
        }

        private void LoadCaptcha()
        {
            try
            {
                conn.Open();

                // Fetch a random CAPTCHA from the imagee table
                sql = "SELECT TOP 1 imgpath, imgval FROM imagee ORDER BY NEWID()";
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string imagePath = dr["imgpath"].ToString();
                    captchaValue = dr["imgval"].ToString(); // Store the correct value for validation

                    // Ensure PictureBox is initialized and check if the file exists
                    if (pictureBox2 == null)
                    {
                        MessageBox.Show("PictureBox is not initialized.");
                        return;
                    }

                    if (File.Exists(imagePath))
                    {
                        pictureBox2.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("Captcha image file not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to load CAPTCHA.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading CAPTCHA: " + ex.Message);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignInForm form = new SignInForm();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
