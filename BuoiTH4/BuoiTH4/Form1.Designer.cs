namespace BuoiTH4
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
            txtnhap = new TextBox();
            btnnhap = new Button();
            btnin = new Button();
            button1 = new Button();
            btnthoat = new Button();
            btntang = new Button();
            btngiam = new Button();
            btntonghaimang = new Button();
            btnlonnhat = new Button();
            btsohoanhao = new Button();
            btnsonhonhat = new Button();
            btnsonguyento = new Button();
            btntrungbinh = new Button();
            btndemsole = new Button();
            btndemsochan = new Button();
            btnucln = new Button();
            txtkq = new TextBox();
            SuspendLayout();
            // 
            // txtnhap
            // 
            txtnhap.Location = new Point(165, 51);
            txtnhap.Margin = new Padding(3, 4, 3, 4);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(170, 27);
            txtnhap.TabIndex = 1;
            // 
            // btnnhap
            // 
            btnnhap.Location = new Point(14, 51);
            btnnhap.Margin = new Padding(3, 4, 3, 4);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(133, 31);
            btnnhap.TabIndex = 2;
            btnnhap.Text = "Nhập 1 phần tử";
            btnnhap.UseVisualStyleBackColor = true;
            btnnhap.Click += btnnhap_Click;
            // 
            // btnin
            // 
            btnin.Location = new Point(361, 51);
            btnin.Margin = new Padding(3, 4, 3, 4);
            btnin.Name = "btnin";
            btnin.Size = new Size(131, 31);
            btnin.TabIndex = 3;
            btnin.Text = "In mảng";
            btnin.UseVisualStyleBackColor = true;
            btnin.Click += btnin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(499, 49);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(128, 31);
            button1.TabIndex = 4;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(634, 51);
            btnthoat.Margin = new Padding(3, 4, 3, 4);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(129, 31);
            btnthoat.TabIndex = 5;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btntang
            // 
            btntang.Location = new Point(634, 108);
            btntang.Margin = new Padding(3, 4, 3, 4);
            btntang.Name = "btntang";
            btntang.Size = new Size(129, 31);
            btntang.TabIndex = 7;
            btntang.Text = "Sắp xếp tăng dần";
            btntang.UseVisualStyleBackColor = true;
            btntang.Click += btntang_Click;
            // 
            // btngiam
            // 
            btngiam.Location = new Point(634, 169);
            btngiam.Margin = new Padding(3, 4, 3, 4);
            btngiam.Name = "btngiam";
            btngiam.Size = new Size(129, 31);
            btngiam.TabIndex = 8;
            btngiam.Text = "sắp xếp giảm dần";
            btngiam.UseVisualStyleBackColor = true;
            btngiam.Click += btngiam_Click;
            // 
            // btntonghaimang
            // 
            btntonghaimang.Location = new Point(634, 229);
            btntonghaimang.Margin = new Padding(3, 4, 3, 4);
            btntonghaimang.Name = "btntonghaimang";
            btntonghaimang.Size = new Size(129, 31);
            btntonghaimang.TabIndex = 9;
            btntonghaimang.Text = "Tổng hai mảng";
            btntonghaimang.UseVisualStyleBackColor = true;
            btntonghaimang.Click += btntonghaimang_Click;
            // 
            // btnlonnhat
            // 
            btnlonnhat.Location = new Point(634, 289);
            btnlonnhat.Margin = new Padding(3, 4, 3, 4);
            btnlonnhat.Name = "btnlonnhat";
            btnlonnhat.Size = new Size(129, 31);
            btnlonnhat.TabIndex = 10;
            btnlonnhat.Text = "Số lớn nhất";
            btnlonnhat.UseVisualStyleBackColor = true;
            btnlonnhat.Click += btnlonnhat_Click;
            // 
            // btsohoanhao
            // 
            btsohoanhao.Location = new Point(453, 229);
            btsohoanhao.Margin = new Padding(3, 4, 3, 4);
            btsohoanhao.Name = "btsohoanhao";
            btsohoanhao.Size = new Size(131, 31);
            btsohoanhao.TabIndex = 11;
            btsohoanhao.Text = "Số hoàn hảo ";
            btsohoanhao.UseVisualStyleBackColor = true;
            // 
            // btnsonhonhat
            // 
            btnsonhonhat.Location = new Point(453, 289);
            btnsonhonhat.Margin = new Padding(3, 4, 3, 4);
            btnsonhonhat.Name = "btnsonhonhat";
            btnsonhonhat.Size = new Size(131, 31);
            btnsonhonhat.TabIndex = 12;
            btnsonhonhat.Text = "Số nhỏ nhất";
            btnsonhonhat.UseVisualStyleBackColor = true;
            btnsonhonhat.Click += btnsonhonhat_Click;
            // 
            // btnsonguyento
            // 
            btnsonguyento.Location = new Point(288, 229);
            btnsonguyento.Margin = new Padding(3, 4, 3, 4);
            btnsonguyento.Name = "btnsonguyento";
            btnsonguyento.Size = new Size(131, 31);
            btnsonguyento.TabIndex = 13;
            btnsonguyento.Text = "Số nguyên tố";
            btnsonguyento.UseVisualStyleBackColor = true;
            btnsonguyento.Click += btnsonguyento_Click;
            // 
            // btntrungbinh
            // 
            btntrungbinh.Location = new Point(291, 289);
            btntrungbinh.Margin = new Padding(3, 4, 3, 4);
            btntrungbinh.Name = "btntrungbinh";
            btntrungbinh.Size = new Size(128, 31);
            btntrungbinh.TabIndex = 14;
            btntrungbinh.Text = "Trung bình mảng";
            btntrungbinh.UseVisualStyleBackColor = true;
            btntrungbinh.Click += btntrungbinh_Click;
            // 
            // btndemsole
            // 
            btndemsole.Location = new Point(146, 229);
            btndemsole.Margin = new Padding(3, 4, 3, 4);
            btndemsole.Name = "btndemsole";
            btndemsole.Size = new Size(110, 31);
            btndemsole.TabIndex = 15;
            btndemsole.Text = "Đếm số lẻ";
            btndemsole.UseVisualStyleBackColor = true;
            btndemsole.Click += btndemsole_Click;
            // 
            // btndemsochan
            // 
            btndemsochan.Location = new Point(14, 229);
            btndemsochan.Margin = new Padding(3, 4, 3, 4);
            btndemsochan.Name = "btndemsochan";
            btndemsochan.Size = new Size(107, 31);
            btndemsochan.TabIndex = 16;
            btndemsochan.Text = "Đếm số chẵn";
            btndemsochan.UseVisualStyleBackColor = true;
            btndemsochan.Click += btndemsochan_Click;
            // 
            // btnucln
            // 
            btnucln.Location = new Point(14, 289);
            btnucln.Margin = new Padding(3, 4, 3, 4);
            btnucln.Name = "btnucln";
            btnucln.Size = new Size(242, 31);
            btnucln.TabIndex = 17;
            btnucln.Text = "Ước chung lơn nhất 2 phần tử đầu tiên";
            btnucln.UseVisualStyleBackColor = true;
            btnucln.Click += btnucln_Click;
            // 
            // txtkq
            // 
            txtkq.BackColor = Color.Bisque;
            txtkq.ForeColor = SystemColors.MenuText;
            txtkq.Location = new Point(14, 89);
            txtkq.Margin = new Padding(3, 4, 3, 4);
            txtkq.Multiline = true;
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(613, 131);
            txtkq.TabIndex = 18;
            txtkq.TextChanged += txtkq_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(914, 600);
            Controls.Add(txtkq);
            Controls.Add(btnucln);
            Controls.Add(btndemsochan);
            Controls.Add(btndemsole);
            Controls.Add(btntrungbinh);
            Controls.Add(btnsonguyento);
            Controls.Add(btnsonhonhat);
            Controls.Add(btsohoanhao);
            Controls.Add(btnlonnhat);
            Controls.Add(btntonghaimang);
            Controls.Add(btngiam);
            Controls.Add(btntang);
            Controls.Add(btnthoat);
            Controls.Add(button1);
            Controls.Add(btnin);
            Controls.Add(btnnhap);
            Controls.Add(txtnhap);
            ForeColor = Color.FromArgb(64, 64, 64);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "mang so nguen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnhap;
        private Button btnnhap;
        private Button btnin;
        private Button button1;
        private Button btnthoat;
        private Button btntang;
        private Button btngiam;
        private Button btntonghaimang;
        private Button btnlonnhat;
        private Button btsohoanhao;
        private Button btnsonhonhat;
        private Button btnsonguyento;
        private Button btntrungbinh;
        private Button btndemsole;
        private Button btndemsochan;
        private Button btnucln;
        private TextBox txtkq;
    }
}
