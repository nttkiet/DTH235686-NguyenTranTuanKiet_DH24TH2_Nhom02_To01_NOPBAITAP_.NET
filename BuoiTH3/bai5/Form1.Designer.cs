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
            btnthoat = new Button();
            chon = new GroupBox();
            cklon = new CheckBox();
            ckucchung = new CheckBox();
            txtnhapn = new TextBox();
            label1 = new Label();
            txtkq = new TextBox();
            btntinh = new Button();
            btnxoa = new Button();
            label2 = new Label();
            txtnhapm = new TextBox();
            chon.SuspendLayout();
            SuspendLayout();
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(536, 275);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 12;
            btnthoat.Text = "thoat";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // chon
            // 
            chon.Controls.Add(cklon);
            chon.Controls.Add(ckucchung);
            chon.Location = new Point(460, 28);
            chon.Name = "chon";
            chon.Size = new Size(310, 157);
            chon.TabIndex = 10;
            chon.TabStop = false;
            chon.Text = "chon ";
            // 
            // cklon
            // 
            cklon.AutoSize = true;
            cklon.Location = new Point(27, 65);
            cklon.Name = "cklon";
            cklon.Size = new Size(223, 24);
            cklon.TabIndex = 1;
            cklon.Text = "uc chung lon nhat cua n va m";
            cklon.UseVisualStyleBackColor = true;
            // 
            // ckucchung
            // 
            ckucchung.AutoSize = true;
            ckucchung.Location = new Point(27, 35);
            ckucchung.Name = "ckucchung";
            ckucchung.RightToLeft = RightToLeft.No;
            ckucchung.Size = new Size(165, 24);
            ckucchung.TabIndex = 0;
            ckucchung.Text = "uc chung cua n va m";
            ckucchung.UseVisualStyleBackColor = true;
            // 
            // txtnhapn
            // 
            txtnhapn.Location = new Point(121, 35);
            txtnhapn.Margin = new Padding(3, 4, 3, 4);
            txtnhapn.Name = "txtnhapn";
            txtnhapn.Size = new Size(88, 27);
            txtnhapn.TabIndex = 9;
            txtnhapn.TextChanged += txtnhapn_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 8;
            label1.Text = "Nhập n:";
            // 
            // txtkq
            // 
            txtkq.Location = new Point(65, 211);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(723, 27);
            txtkq.TabIndex = 14;
            // 
            // btntinh
            // 
            btntinh.Location = new Point(65, 275);
            btntinh.Name = "btntinh";
            btntinh.Size = new Size(94, 29);
            btntinh.TabIndex = 13;
            btntinh.Text = "Tinh";
            btntinh.UseVisualStyleBackColor = true;
            btntinh.Click += btntinh_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(315, 275);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 11;
            btnxoa.Text = "xoa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(39, 79);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 15;
            label2.Text = "Nhập m:";
            // 
            // txtnhapm
            // 
            txtnhapm.Location = new Point(121, 79);
            txtnhapm.Margin = new Padding(3, 4, 3, 4);
            txtnhapm.Name = "txtnhapm";
            txtnhapm.Size = new Size(88, 27);
            txtnhapm.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnhapm);
            Controls.Add(label2);
            Controls.Add(btnthoat);
            Controls.Add(chon);
            Controls.Add(txtnhapn);
            Controls.Add(label1);
            Controls.Add(txtkq);
            Controls.Add(btntinh);
            Controls.Add(btnxoa);
            Name = "Form1";
            Text = "Form1";
            chon.ResumeLayout(false);
            chon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnthoat;
        private GroupBox chon;
        private CheckBox cklon;
        private CheckBox ckucchung;
        private TextBox txtnhapn;
        private Label label1;
        private TextBox txtkq;
        private Button btntinh;
        private Button btnxoa;
        private Label label2;
        private TextBox txtnhapm;
    }
}
