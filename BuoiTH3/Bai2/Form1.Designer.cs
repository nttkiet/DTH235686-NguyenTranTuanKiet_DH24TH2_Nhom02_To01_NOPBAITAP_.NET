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
            label3 = new Label();
            btndangnhap = new Button();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 48);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 94);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Người Dùng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 136);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // btndangnhap
            // 
            btndangnhap.Location = new Point(103, 199);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(75, 23);
            btndangnhap.TabIndex = 3;
            btndangnhap.Text = "Đăng Nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(204, 94);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(100, 23);
            txtuser.TabIndex = 4;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(204, 133);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(100, 23);
            txtpass.TabIndex = 5;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(229, 199);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 6;
            btnthoat.Text = "Thoat";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnthoat);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(btndangnhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đăng nhập hệ thống";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btndangnhap;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btnthoat;
    }
}
