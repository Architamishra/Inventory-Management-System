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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }



        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData ad = new AddData();
            ad.Show();
            this.Hide();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Inv inv = new Inv();
            inv.Show();
            this.Hide();
        }

        

        private void usersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Users us = new Users();
            us.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Report rp = new Report();
            rp.Show();
            this.Hide();
        }
    }
}
