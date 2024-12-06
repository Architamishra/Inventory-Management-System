namespace IMS
{
    partial class Sup1
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
            label1 = new Label();
            buttonLoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(843, 370);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 23);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 1;
            label1.Text = "Supplier";
            // 
            // buttonLoadData
            // 
            buttonLoadData.BackColor = Color.BurlyWood;
            buttonLoadData.Location = new Point(732, 464);
            buttonLoadData.Name = "buttonLoadData";
            buttonLoadData.Size = new Size(123, 38);
            buttonLoadData.TabIndex = 2;
            buttonLoadData.Text = "Show";
            buttonLoadData.UseVisualStyleBackColor = false;
            // 
            // Sup1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(880, 504);
            Controls.Add(buttonLoadData);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Sup1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sup1";
            Load += Sup1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button buttonLoadData;
    }
}