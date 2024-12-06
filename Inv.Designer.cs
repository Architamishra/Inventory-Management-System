namespace IMS
{
    partial class Inv
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
            menuStrip1 = new MenuStrip();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            brandToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            manageInventoryToolStripMenuItem = new ToolStripMenuItem();
            showInventoryToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            showSupplierToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem2 = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventoryToolStripMenuItem, usersToolStripMenuItem, supplierToolStripMenuItem, customerToolStripMenuItem, ordersToolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.BackColor = Color.BurlyWood;
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoryToolStripMenuItem, brandToolStripMenuItem, productToolStripMenuItem });
            inventoryToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(137, 29);
            inventoryToolStripMenuItem.Text = "ManageData";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.BackColor = Color.BurlyWood;
            categoryToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(270, 34);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // brandToolStripMenuItem
            // 
            brandToolStripMenuItem.BackColor = Color.BurlyWood;
            brandToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            brandToolStripMenuItem.Size = new Size(270, 34);
            brandToolStripMenuItem.Text = "Brand";
            brandToolStripMenuItem.Click += brandToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.BackColor = Color.BurlyWood;
            productToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(270, 34);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.BackColor = Color.BurlyWood;
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageInventoryToolStripMenuItem, showInventoryToolStripMenuItem });
            usersToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(112, 29);
            usersToolStripMenuItem.Text = "Inventory";
            // 
            // manageInventoryToolStripMenuItem
            // 
            manageInventoryToolStripMenuItem.BackColor = Color.BurlyWood;
            manageInventoryToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageInventoryToolStripMenuItem.Name = "manageInventoryToolStripMenuItem";
            manageInventoryToolStripMenuItem.Size = new Size(270, 34);
            manageInventoryToolStripMenuItem.Text = "Manage Inventory";
            manageInventoryToolStripMenuItem.Click += manageInventoryToolStripMenuItem_Click;
            // 
            // showInventoryToolStripMenuItem
            // 
            showInventoryToolStripMenuItem.BackColor = Color.BurlyWood;
            showInventoryToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showInventoryToolStripMenuItem.Name = "showInventoryToolStripMenuItem";
            showInventoryToolStripMenuItem.Size = new Size(270, 34);
            showInventoryToolStripMenuItem.Text = "Show Inventory";
            showInventoryToolStripMenuItem.Click += showInventoryToolStripMenuItem_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.BackColor = Color.BurlyWood;
            supplierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showSupplierToolStripMenuItem });
            supplierToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(98, 29);
            supplierToolStripMenuItem.Text = "Supplier";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // showSupplierToolStripMenuItem
            // 
            showSupplierToolStripMenuItem.BackColor = Color.BurlyWood;
            showSupplierToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showSupplierToolStripMenuItem.Name = "showSupplierToolStripMenuItem";
            showSupplierToolStripMenuItem.Size = new Size(270, 34);
            showSupplierToolStripMenuItem.Text = "Show Supplier";
            showSupplierToolStripMenuItem.Click += showSupplierToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.BackColor = Color.BurlyWood;
            customerToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(109, 29);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem2
            // 
            ordersToolStripMenuItem2.BackColor = Color.BurlyWood;
            ordersToolStripMenuItem2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordersToolStripMenuItem2.Name = "ordersToolStripMenuItem2";
            ordersToolStripMenuItem2.Size = new Size(85, 29);
            ordersToolStripMenuItem2.Text = "Orders";
            ordersToolStripMenuItem2.Click += ordersToolStripMenuItem2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(676, 36);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Inv
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Name = "Inv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inv";
            Load += Inv_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem brandToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem manageInventoryToolStripMenuItem;
        private ToolStripMenuItem showInventoryToolStripMenuItem;
        private ToolStripMenuItem showSupplierToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem2;
        private Button button1;
    }
}