namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            textBox5 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(513, 43);
            button1.Name = "button1";
            button1.Size = new Size(222, 105);
            button1.TabIndex = 0;
            button1.Text = "Генерировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(44, 25);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 1;
            label1.Text = "Введите почту";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(44, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(397, 43);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(44, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(397, 43);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(44, 122);
            label2.Name = "label2";
            label2.Size = new Size(243, 37);
            label2.TabIndex = 3;
            label2.Text = "Введите фамилию";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(44, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(397, 43);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(44, 225);
            label3.Name = "label3";
            label3.Size = new Size(172, 37);
            label3.TabIndex = 5;
            label3.Text = "Введите имя";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F);
            textBox4.Location = new Point(44, 366);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(397, 43);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(44, 326);
            label4.Name = "label4";
            label4.Size = new Size(232, 37);
            label4.TabIndex = 7;
            label4.Text = "Введите отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(513, 192);
            label5.Name = "label5";
            label5.Size = new Size(197, 37);
            label5.TabIndex = 9;
            label5.Text = "Логин/Пароль";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 16F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(777, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(494, 411);
            listBox1.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 16F);
            textBox5.Location = new Point(777, 473);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(494, 43);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(777, 442);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 12;
            label6.Text = "поиск";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 537);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Генерация логина и пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private TextBox textBox5;
        private Label label6;
    }
}
