namespace bai4
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
            txtnhap = new TextBox();
            groupBox1 = new GroupBox();
            ckhoa = new CheckBox();
            ckthuong = new CheckBox();
            btnxoa = new Button();
            btnthoat = new Button();
            btnkq = new Button();
            txtkq = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(72, 48);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập Họ và Tên";
            // 
            // txtnhap
            // 
            txtnhap.Location = new Point(210, 46);
            txtnhap.Margin = new Padding(3, 4, 3, 4);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(227, 27);
            txtnhap.TabIndex = 1;
            txtnhap.TextChanged += txtnhap_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckhoa);
            groupBox1.Controls.Add(ckthuong);
            groupBox1.Location = new Point(74, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 157);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "chon kieu chu";
            // 
            // ckhoa
            // 
            ckhoa.AutoSize = true;
            ckhoa.Location = new Point(27, 65);
            ckhoa.Name = "ckhoa";
            ckhoa.Size = new Size(103, 24);
            ckhoa.TabIndex = 1;
            ckhoa.Text = "chu in hoa ";
            ckhoa.UseVisualStyleBackColor = true;
            // 
            // ckthuong
            // 
            ckthuong.AutoSize = true;
            ckthuong.Location = new Point(27, 35);
            ckthuong.Name = "ckthuong";
            ckthuong.Size = new Size(121, 24);
            ckthuong.TabIndex = 0;
            ckthuong.Text = "chu in thuong";
            ckthuong.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(390, 102);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 4;
            btnxoa.Text = "xoa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(390, 137);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 5;
            btnthoat.Text = "thoat";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnkq
            // 
            btnkq.Location = new Point(76, 268);
            btnkq.Name = "btnkq";
            btnkq.Size = new Size(94, 29);
            btnkq.TabIndex = 6;
            btnkq.Text = "ket qua";
            btnkq.UseVisualStyleBackColor = true;
            btnkq.Click += btnkq_Click;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(186, 268);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(157, 27);
            txtkq.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtkq);
            Controls.Add(btnkq);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(groupBox1);
            Controls.Add(txtnhap);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnhap;
        private GroupBox groupBox1;
        private CheckBox ckhoa;
        private CheckBox ckthuong;
        private Button btnxoa;
        private Button btnthoat;
        private Button btnkq;
        private TextBox txtkq;
    }
}
