namespace Bai3
{
    partial class s
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
            groupBox1 = new GroupBox();
            txtmau1 = new TextBox();
            txttu1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            txtmau2 = new TextBox();
            txttu2 = new TextBox();
            groupBox3 = new GroupBox();
            btnchia = new Button();
            btnnhan = new Button();
            btntru = new Button();
            btncong = new Button();
            label6 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            txtkqmau = new TextBox();
            txtkqtu = new TextBox();
            btntieptuc = new Button();
            btnthoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(329, 33);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 0;
            label1.Text = "Phép Tính Phân Số";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtmau1);
            groupBox1.Controls.Add(txttu1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(75, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 134);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phân Số 1";
            // 
            // txtmau1
            // 
            txtmau1.Location = new Point(97, 56);
            txtmau1.Name = "txtmau1";
            txtmau1.Size = new Size(92, 23);
            txtmau1.TabIndex = 3;
            // 
            // txttu1
            // 
            txttu1.Location = new Point(97, 29);
            txttu1.Name = "txttu1";
            txttu1.Size = new Size(92, 23);
            txttu1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 56);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 1;
            label3.Text = "Mẫu Số:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 32);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Tử số:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 56);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 1;
            label4.Text = "Mẫu Số:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 32);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 0;
            label5.Text = "Tử số:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtmau2);
            groupBox2.Controls.Add(txttu2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(449, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(187, 134);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Phân Số 2";
            // 
            // txtmau2
            // 
            txtmau2.Location = new Point(97, 56);
            txtmau2.Name = "txtmau2";
            txtmau2.Size = new Size(84, 23);
            txtmau2.TabIndex = 3;
            // 
            // txttu2
            // 
            txttu2.Location = new Point(97, 29);
            txttu2.Name = "txttu2";
            txttu2.Size = new Size(84, 23);
            txttu2.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnchia);
            groupBox3.Controls.Add(btnnhan);
            groupBox3.Controls.Add(btntru);
            groupBox3.Controls.Add(btncong);
            groupBox3.Location = new Point(75, 267);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(210, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Phép Tính";
            // 
            // btnchia
            // 
            btnchia.Location = new Point(114, 61);
            btnchia.Name = "btnchia";
            btnchia.Size = new Size(75, 23);
            btnchia.TabIndex = 3;
            btnchia.Text = "Chia";
            btnchia.UseVisualStyleBackColor = true;
            btnchia.Click += btnchia_Click;
            // 
            // btnnhan
            // 
            btnnhan.Location = new Point(15, 61);
            btnnhan.Name = "btnnhan";
            btnnhan.Size = new Size(75, 23);
            btnnhan.TabIndex = 2;
            btnnhan.Text = "Nhân";
            btnnhan.UseVisualStyleBackColor = true;
            btnnhan.Click += btnnhan_Click;
            // 
            // btntru
            // 
            btntru.Location = new Point(114, 22);
            btntru.Name = "btntru";
            btntru.Size = new Size(75, 23);
            btntru.TabIndex = 1;
            btntru.Text = "Tru";
            btntru.UseVisualStyleBackColor = true;
            btntru.Click += btntru_Click;
            // 
            // btncong
            // 
            btncong.Location = new Point(15, 22);
            btncong.Name = "btncong";
            btncong.Size = new Size(75, 23);
            btncong.TabIndex = 0;
            btncong.Text = "cong";
            btncong.UseVisualStyleBackColor = true;
            btncong.Click += btncong_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 56);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 1;
            label6.Text = "Mẫu Số:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 32);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 0;
            label7.Text = "Tử số:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtkqmau);
            groupBox4.Controls.Add(txtkqtu);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(449, 267);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(187, 134);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kết quả ";
            // 
            // txtkqmau
            // 
            txtkqmau.Location = new Point(97, 56);
            txtkqmau.Name = "txtkqmau";
            txtkqmau.Size = new Size(84, 23);
            txtkqmau.TabIndex = 3;
            // 
            // txtkqtu
            // 
            txtkqtu.Location = new Point(97, 29);
            txtkqtu.Name = "txtkqtu";
            txtkqtu.Size = new Size(84, 23);
            txtkqtu.TabIndex = 2;
            // 
            // btntieptuc
            // 
            btntieptuc.Location = new Point(237, 443);
            btntieptuc.Name = "btntieptuc";
            btntieptuc.Size = new Size(75, 23);
            btntieptuc.TabIndex = 5;
            btntieptuc.Text = "Tiếp Tục";
            btntieptuc.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(383, 443);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 6;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // s
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(btnthoat);
            Controls.Add(btntieptuc);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "s";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtmau1;
        private TextBox txttu1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox txtmau2;
        private TextBox txttu2;
        private GroupBox groupBox3;
        private Button btnchia;
        private Button btnnhan;
        private Button btntru;
        private Button btncong;
        private Label label6;
        private Label label7;
        private GroupBox groupBox4;
        private TextBox txtkqmau;
        private TextBox txtkqtu;
        private Button btntieptuc;
        private Button btnthoat;
    }
}
