namespace Bai2
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
            txtnhap = new TextBox();
            btntinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 42);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 0;
            label1.Text = "Kiểm Tra số hoàn hảo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(201, 97);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập n:";
            // 
            // txtnhap
            // 
            txtnhap.Location = new Point(269, 97);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(173, 23);
            txtnhap.TabIndex = 2;
            // 
            // btntinh
            // 
            btntinh.ForeColor = SystemColors.ActiveCaptionText;
            btntinh.Location = new Point(313, 197);
            btntinh.Name = "btntinh";
            btntinh.Size = new Size(75, 23);
            btntinh.TabIndex = 3;
            btntinh.Text = "Tính";
            btntinh.UseVisualStyleBackColor = true;
            btntinh.Click += btntinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btntinh);
            Controls.Add(txtnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Red;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnhap;
        private Button btntinh;
    }
}
