namespace bai5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "mảng gốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "kết quả";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 187);
            button1.Name = "button1";
            button1.Size = new Size(238, 29);
            button1.TabIndex = 4;
            button1.Text = "xuất mảng ngẫu nhiên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 239);
            button2.Name = "button2";
            button2.Size = new Size(238, 29);
            button2.TabIndex = 5;
            button2.Text = "Tính tổng giá trị mảng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 299);
            button3.Name = "button3";
            button3.Size = new Size(238, 29);
            button3.TabIndex = 6;
            button3.Text = "Đếm số phần tử lẻ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 359);
            button4.Name = "button4";
            button4.Size = new Size(238, 29);
            button4.TabIndex = 7;
            button4.Text = "Tính tổng giá trị phần lẻ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(333, 187);
            button5.Name = "button5";
            button5.Size = new Size(238, 29);
            button5.TabIndex = 8;
            button5.Text = "Tìm phần tử nhỏ nhất";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(333, 239);
            button6.Name = "button6";
            button6.Size = new Size(238, 29);
            button6.TabIndex = 9;
            button6.Text = "tăng mỗi phần tử mảng lên hai";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(333, 299);
            button7.Name = "button7";
            button7.Size = new Size(238, 29);
            button7.TabIndex = 10;
            button7.Text = "sắp xếp tăng";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(333, 359);
            button8.Name = "button8";
            button8.Size = new Size(238, 29);
            button8.TabIndex = 11;
            button8.Text = "sắp xếp giảm";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
