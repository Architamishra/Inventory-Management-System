using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Inv : Form
    {
        public Inv()
        {
            InitializeComponent();
        }

        private void Inv_Load(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide(); //
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brand br = new Brand();
            br.Show();
            this.Hide(); //
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro pr = new Pro();
            pr.Show();
            this.Hide(); //
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sup sp = new Sup();
            sp.Show();
            this.Hide(); //
        }

        private void manageInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void manageInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Min mi = new Min();
            mi.Show();
            this.Hide(); //
        }

        private void showInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Min1 mi1 = new Min1();
            mi1.Show();
            this.Hide();
        }

        private void showSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sup1 sp1 = new Sup1();
            sp1.Show();
            this.Hide(); //
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            US us = new US();
            us.Show();
            this.Hide();
        }

        private void ordersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ord od = new Ord();
            od.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }
    }
}
