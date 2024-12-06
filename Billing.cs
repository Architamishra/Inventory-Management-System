using System;
using System.Windows.Forms;

namespace IMS
{
    public partial class Billing : Form
    {
        // Parameterized constructor
        public Billing(string orderId, string orderName, string quantity, decimal totalAmount, string address)
        {
            InitializeComponent();

            // Assign values to the text boxes
            textBox1.Text = orderId;          // Order ID
            textBox2.Text = orderName;        // Order Name
            textBox3.Text = quantity;         // Quantity
            textBox4.Text = totalAmount.ToString("C"); // Total Amount (formatted as currency)
            textBox5.Text = address;          // Address
        }

        // Parameterless constructor (if needed)
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            // Handle any additional setup on load
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inv in1 = new Inv();
            in1.Show();
            in1.Hide();
        }
    }
}
