namespace IMS
{
    partial class Billing
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.BurlyWood;
            textBox1.Location = new Point(431, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 34);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.BurlyWood;
            textBox2.Location = new Point(431, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 34);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.BurlyWood;
            textBox3.Location = new Point(431, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 34);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.BurlyWood;
            textBox4.Location = new Point(431, 292);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 34);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.BurlyWood;
            textBox5.Location = new Point(431, 365);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 34);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 90);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 5;
            label1.Text = "Order Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 156);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 6;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 220);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 7;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 292);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 8;
            label4.Text = "Total Amount";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 365);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 9;
            label5.Text = "Address";
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.Location = new Point(11, 6);
            button1.Name = "button1";
            button1.Size = new Size(123, 38);
            button1.TabIndex = 10;
            button1.Text = "Home Page";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(880, 504);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Billing";
            Text = "Billing";
            Load += Billing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}