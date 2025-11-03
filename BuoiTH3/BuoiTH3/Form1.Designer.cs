namespace BuoiTH3
{
    partial class chknho
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
            checkBox1 = new CheckBox();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btndangnhap = new Button();
            btnxoa = new Button();
            btndung = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 65);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 97);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khảu:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(158, 129);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Ghi nhớ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.Cyan;
            txtuser.Cursor = Cursors.IBeam;
            txtuser.ForeColor = Color.Navy;
            txtuser.Location = new Point(269, 62);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(100, 23);
            txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.Cursor = Cursors.IBeam;
            txtpass.Location = new Point(269, 94);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(100, 23);
            txtpass.TabIndex = 4;
            // 
            // btndangnhap
            // 
            btndangnhap.Cursor = Cursors.AppStarting;
            btndangnhap.Location = new Point(168, 180);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(75, 23);
            btndangnhap.TabIndex = 5;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = true;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // btnxoa
            // 
            btnxoa.Cursor = Cursors.AppStarting;
            btnxoa.Location = new Point(281, 180);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(75, 23);
            btnxoa.TabIndex = 6;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btndung
            // 
            btndung.Cursor = Cursors.AppStarting;
            btndung.Location = new Point(401, 180);
            btndung.Name = "btndung";
            btndung.Size = new Size(75, 23);
            btndung.TabIndex = 7;
            btndung.Text = "Dừng";
            btndung.UseVisualStyleBackColor = true;
            btndung.Click += btndung_Click;
            // 
            // chknho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndung);
            Controls.Add(btnxoa);
            Controls.Add(btndangnhap);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "chknho";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btndangnhap;
        private Button btnxoa;
        private Button btndung;
    }
}
