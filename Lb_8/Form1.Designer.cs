namespace Lb_8
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
            textBox6 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 77);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Код товару";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 77);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Назва товару";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 183);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Ціна за одиницю";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 183);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Кількість";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 237);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Знижка";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyUp;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.KeyUp += textBox1_KeyUp;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(372, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyDown += textBox1_KeyUp;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.KeyUp += textBox1_KeyUp;
            textBox2.Leave += textBox1_Leave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            textBox3.KeyDown += textBox1_KeyUp;
            textBox3.KeyPress += textBox3_KeyPress;
            textBox3.KeyUp += textBox1_KeyUp;
            textBox3.Leave += textBox1_Leave;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(372, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.KeyDown += textBox1_KeyUp;
            textBox4.KeyPress += textBox4_KeyPress;
            textBox4.KeyUp += textBox1_KeyUp;
            textBox4.Leave += textBox1_Leave;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(239, 255);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            textBox5.KeyDown += textBox1_KeyUp;
            textBox5.KeyPress += textBox5_KeyPress;
            textBox5.KeyUp += textBox1_KeyUp;
            textBox5.Leave += textBox5_Leave;
            // 
            // textBox6
            // 
            textBox6.CausesValidation = false;
            textBox6.Enabled = false;
            textBox6.Location = new Point(239, 334);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 316);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 11;
            label6.Text = "Кінцева ціна";
            // 
            // button1
            // 
            button1.Location = new Point(93, 417);
            button1.Name = "button1";
            button1.Size = new Size(91, 21);
            button1.TabIndex = 12;
            button1.Text = "Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(372, 417);
            button2.Name = "button2";
            button2.Size = new Size(91, 21);
            button2.TabIndex = 13;
            button2.Text = "Clean";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox6);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private TextBox textBox6;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}
