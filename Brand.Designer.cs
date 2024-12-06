namespace IMS
{
    partial class Brand
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 113);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.Location = new Point(116, 390);
            button1.Name = "button1";
            button1.Size = new Size(123, 38);
            button1.TabIndex = 15;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.BurlyWood;
            textBox1.Location = new Point(600, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 34);
            textBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 160);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 17;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 202);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 18;
            label3.Text = "created Date";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.BurlyWood;
            button2.Location = new Point(282, 390);
            button2.Name = "button2";
            button2.Size = new Size(123, 38);
            button2.TabIndex = 20;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.BurlyWood;
            button3.Location = new Point(465, 390);
            button3.Name = "button3";
            button3.Size = new Size(123, 38);
            button3.TabIndex = 21;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.BurlyWood;
            button4.Location = new Point(642, 390);
            button4.Name = "button4";
            button4.Size = new Size(123, 38);
            button4.TabIndex = 22;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.BurlyWood;
            textBox2.Location = new Point(600, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 34);
            textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.BurlyWood;
            textBox3.Location = new Point(600, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 34);
            textBox3.TabIndex = 24;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.BurlyWood;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(40, 113);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 172);
            listBox1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 67);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 27;
            label4.Text = "Brand ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 257);
            label5.Name = "label5";
            label5.Size = new Size(134, 28);
            label5.TabIndex = 28;
            label5.Text = "updated date";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.BurlyWood;
            textBox4.Location = new Point(600, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 34);
            textBox4.TabIndex = 29;
            // 
            // button5
            // 
            button5.BackColor = Color.BurlyWood;
            button5.Location = new Point(3, 3);
            button5.Name = "button5";
            button5.Size = new Size(123, 38);
            button5.TabIndex = 30;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Brand
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(904, 554);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Brand";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brand";
            Load += Brand_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Button button5;
    }
}