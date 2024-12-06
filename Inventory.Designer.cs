namespace IMS
{
    partial class Inventory
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
           // menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(747, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(10, 225);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
           /* groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(57, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 338);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";*/
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(422, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(173, 338);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // menuStrip1
            // 
           /* menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(3, 27);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(167, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";*/
           // menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            //MainMenuStrip = menuStrip1;
            Name = "Inventory";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        //private MenuStrip menuStrip1;
    }
}