using System.Security.Cryptography.Xml;

namespace IMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500; // Blinking interval in milliseconds
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SignInForm signinform = new SignInForm();
            signinform.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LogInForm loginform = new LogInForm();
            loginform.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Visible = !label4.Visible;
        }
    }
}
