namespace bai3
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
            txtNhap = new TextBox();
            btnin = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtkq = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 31);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "nhap so phan tu mang";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(243, 31);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(173, 27);
            txtNhap.TabIndex = 1;
            // 
            // btnin
            // 
            btnin.Location = new Point(459, 29);
            btnin.Name = "btnin";
            btnin.Size = new Size(154, 29);
            btnin.TabIndex = 2;
            btnin.Text = "tao mang random";
            btnin.UseVisualStyleBackColor = true;
            btnin.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(56, 201);
            button2.Name = "button2";
            button2.Size = new Size(154, 29);
            button2.TabIndex = 3;
            button2.Text = "tong màng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(262, 201);
            button3.Name = "button3";
            button3.Size = new Size(154, 29);
            button3.TabIndex = 4;
            button3.Text = "số Lớn nhất";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(459, 201);
            button4.Name = "button4";
            button4.Size = new Size(154, 29);
            button4.TabIndex = 5;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(56, 71);
            txtkq.Multiline = true;
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(557, 102);
            txtkq.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtkq);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnin);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private Button btnin;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtkq;
    }
}
