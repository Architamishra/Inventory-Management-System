namespace IMS
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            menuStrip1 = new MenuStrip();
            addDataToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            productsToolStripMenuItem = new ToolStripMenuItem();
            inventoryStockToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            inventoryTransactionsToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            reorderAlertsToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(23, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 399);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Right;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addDataToolStripMenuItem, inventoryToolStripMenuItem, paymentToolStripMenuItem, usersToolStripMenuItem, reportToolStripMenuItem });
            menuStrip1.Location = new Point(29, 27);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(135, 369);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // addDataToolStripMenuItem
            // 
            addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            addDataToolStripMenuItem.RightToLeft = RightToLeft.Yes;
            addDataToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            addDataToolStripMenuItem.Size = new Size(122, 29);
            addDataToolStripMenuItem.Text = "ManageData";
            addDataToolStripMenuItem.Click += addDataToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productsToolStripMenuItem, inventoryStockToolStripMenuItem, supplierToolStripMenuItem, inventoryTransactionsToolStripMenuItem, categoriesToolStripMenuItem, reorderAlertsToolStripMenuItem });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.RightToLeft = RightToLeft.Yes;
            inventoryToolStripMenuItem.Size = new Size(122, 29);
            inventoryToolStripMenuItem.Text = "Inventory";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;
            // 
            // paymentToolStripMenuItem
            // 
            paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            paymentToolStripMenuItem.Size = new Size(122, 29);
            paymentToolStripMenuItem.Text = "Payment";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(122, 29);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click_1;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(122, 29);
            reportToolStripMenuItem.Text = "Report";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(216, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(572, 380);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(285, 34);
            productsToolStripMenuItem.Text = "Products";
            // 
            // inventoryStockToolStripMenuItem
            // 
            inventoryStockToolStripMenuItem.Name = "inventoryStockToolStripMenuItem";
            inventoryStockToolStripMenuItem.Size = new Size(285, 34);
            inventoryStockToolStripMenuItem.Text = "InventoryStock";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(285, 34);
            supplierToolStripMenuItem.Text = "Supplier";
            // 
            // inventoryTransactionsToolStripMenuItem
            // 
            inventoryTransactionsToolStripMenuItem.Name = "inventoryTransactionsToolStripMenuItem";
            inventoryTransactionsToolStripMenuItem.Size = new Size(285, 34);
            inventoryTransactionsToolStripMenuItem.Text = "InventoryTransactions";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(285, 34);
            categoriesToolStripMenuItem.Text = "Categories";
            // 
            // reorderAlertsToolStripMenuItem
            // 
            reorderAlertsToolStripMenuItem.Name = "reorderAlertsToolStripMenuItem";
            reorderAlertsToolStripMenuItem.Size = new Size(285, 34);
            reorderAlertsToolStripMenuItem.Text = "ReorderAlerts";
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "SellerForm";
            Text = "SellerForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addDataToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem inventoryStockToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem inventoryTransactionsToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem reorderAlertsToolStripMenuItem;
    }
}