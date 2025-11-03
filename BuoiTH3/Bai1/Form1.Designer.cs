namespace Bai1
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
            btnxoa = new Button();
            txtpass = new TextBox();
            txtuser = new TextBox();
            btndangnhap = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btndung = new Button();
            chknho = new CheckBox();
            SuspendLayout();
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(325, 262);
            btnxoa.Margin = new Padding(3, 4, 3, 4);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(86, 31);
            btnxoa.TabIndex = 13;
            btnxoa.Text = "xoa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(296, 174);
            txtpass.Margin = new Padding(3, 4, 3, 4);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(114, 27);
            txtpass.TabIndex = 12;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(296, 122);
            txtuser.Margin = new Padding(3, 4, 3, 4);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(114, 27);
            txtuser.TabIndex = 11;
            // 
            // btndangnhap
            // 
            btndangnhap.Location = new Point(181, 262);
            btndangnhap.Margin = new Padding(3, 4, 3, 4);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(86, 31);
            btndangnhap.TabIndex = 10;
            btndangnhap.Text = "Đăng Nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 178);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 9;
            label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 122);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 8;
            label2.Text = "Tên Người Dùng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 61);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 7;
            label1.Text = "Thông Tin Đăng Nhập";
            // 
            // btndung
            // 
            btndung.Location = new Point(492, 264);
            btndung.Name = "btndung";
            btndung.Size = new Size(94, 29);
            btndung.TabIndex = 14;
            btndung.Text = "Dung";
            btndung.UseVisualStyleBackColor = true;
            btndung.Click += btndung_Click;
            // 
            // chknho
            // 
            chknho.AutoSize = true;
            chknho.Location = new Point(194, 217);
            chknho.Name = "chknho";
            chknho.Size = new Size(85, 24);
            chknho.TabIndex = 15;
            chknho.Text = "Ghi Nho";
            chknho.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chknho);
            Controls.Add(btndung);
            Controls.Add(btnxoa);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(btndangnhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnxoa;
        private TextBox txtpass;
        private TextBox txtuser;
        private Button btndangnhap;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btndung;
        private CheckBox chknho;
    }
}
