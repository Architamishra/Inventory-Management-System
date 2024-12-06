namespace IMS
{
    partial class Sup
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            listBox1 = new ListBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 99);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 164);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(423, 228);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 290);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 359);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 4;
            label5.Text = "created date";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.BurlyWood;
            textBox1.Location = new Point(614, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 34);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.BurlyWood;
            textBox2.Location = new Point(614, 161);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 34);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.BurlyWood;
            textBox3.Location = new Point(614, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 34);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.BurlyWood;
            textBox4.Location = new Point(614, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 34);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.BurlyWood;
            textBox5.Location = new Point(614, 356);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 34);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.BurlyWood;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(2, 99);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(351, 312);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 68);
            label6.Name = "label6";
            label6.Size = new Size(111, 28);
            label6.TabIndex = 11;
            label6.Text = "Supplier Id";
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.Location = new Point(250, 433);
            button1.Name = "button1";
            button1.Size = new Size(123, 38);
            button1.TabIndex = 12;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.BurlyWood;
            button2.Location = new Point(406, 433);
            button2.Name = "button2";
            button2.Size = new Size(123, 38);
            button2.TabIndex = 13;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.BurlyWood;
            button3.Location = new Point(544, 433);
            button3.Name = "button3";
            button3.Size = new Size(123, 38);
            button3.TabIndex = 14;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.BurlyWood;
            button4.Location = new Point(689, 433);
            button4.Name = "button4";
            button4.Size = new Size(123, 38);
            button4.TabIndex = 15;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.BurlyWood;
            button5.Location = new Point(2, 1);
            button5.Name = "button5";
            button5.Size = new Size(123, 38);
            button5.TabIndex = 16;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Sup
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(880, 504);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Sup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sup";
            Load += Sup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ListBox listBox1;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}