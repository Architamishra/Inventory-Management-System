namespace IMS
{
    partial class LogInForm
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            textBox4 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.BurlyWood;
            textBox2.Location = new Point(409, 168);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(165, 34);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.BurlyWood;
            textBox1.Location = new Point(409, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 34);
            textBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(248, 168);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(111, 32);
            label5.TabIndex = 11;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(248, 104);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 10;
            label4.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(367, 420);
            button1.Name = "button1";
            button1.Size = new Size(118, 52);
            button1.TabIndex = 14;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.BurlyWood;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(13, 13);
            button2.Name = "button2";
            button2.Size = new Size(133, 46);
            button2.TabIndex = 22;
            button2.Text = "Sign-in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(13, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(405, 168);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.BurlyWood;
            textBox4.Location = new Point(450, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 34);
            textBox4.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 237);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 25;
            label2.Text = "Enter Captcha";
            label2.Click += label2_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(880, 504);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInForm";
            Load += LogInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Label label1;
        private Button pictureBoxCaptcha;
        private Button btnRegister;
        private Button button2;
        private PictureBox pictureBox2;
        private TextBox textBox4;
        private Label label2;
    }
}