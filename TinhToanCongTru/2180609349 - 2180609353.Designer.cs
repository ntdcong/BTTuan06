namespace TinhToanCongTru
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 63);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 4;
            label2.Text = "+";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 63);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 5;
            label3.Text = "=";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(40, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 158);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phép cộng - Duy Công làm";
            // 
            // button1
            // 
            button1.Location = new Point(395, 111);
            button1.Name = "button1";
            button1.Size = new Size(97, 26);
            button1.TabIndex = 6;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(40, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(558, 158);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Phép trừ  - Gia Hân làm";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(395, 111);
            button2.Name = "button2";
            button2.Size = new Size(97, 26);
            button2.TabIndex = 6;
            button2.Text = "Tính";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 63);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 5;
            label1.Text = "=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 63);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 4;
            label4.Text = "-";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(213, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(98, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(58, 60);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(98, 27);
            textBox4.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "2180609349 - 2180609353";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
