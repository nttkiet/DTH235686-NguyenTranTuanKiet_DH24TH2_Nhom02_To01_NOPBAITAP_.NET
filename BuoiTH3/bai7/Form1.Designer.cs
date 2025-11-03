namespace bai7
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
            menuStrip1 = new MenuStrip();
            tinhtoan = new ToolStripMenuItem();
            tong = new ToolStripMenuItem();
            hieu = new ToolStripMenuItem();
            tich = new ToolStripMenuItem();
            thuong = new ToolStripMenuItem();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtb = new TextBox();
            texta = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtkq = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tinhtoan });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tinhtoan
            // 
            tinhtoan.DropDownItems.AddRange(new ToolStripItem[] { tong, hieu, tich, thuong });
            tinhtoan.Name = "tinhtoan";
            tinhtoan.Size = new Size(85, 24);
            tinhtoan.Text = "Tinh toan";
            tinhtoan.Click += tinhtoan_Click;
            // 
            // tong
            // 
            tong.Name = "tong";
            tong.Size = new Size(224, 26);
            tong.Text = "Tong ";
            tong.Click += tong_Click;
            // 
            // hieu
            // 
            hieu.Name = "hieu";
            hieu.Size = new Size(224, 26);
            hieu.Text = "Hieu";
            hieu.Click += hieu_Click;
            // 
            // tich
            // 
            tich.Name = "tich";
            tich.Size = new Size(224, 26);
            tich.Text = "Tich";
            tich.Click += tich_Click;
            // 
            // thuong
            // 
            thuong.Name = "thuong";
            thuong.Size = new Size(224, 26);
            thuong.Text = "Thuong";
            thuong.Click += thuong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 69);
            label1.Name = "label1";
            label1.Size = new Size(237, 31);
            label1.TabIndex = 1;
            label1.Text = "Phép  Toán Đơn Giản ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtb);
            groupBox1.Controls.Add(texta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(115, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 149);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtb
            // 
            txtb.Location = new Point(72, 67);
            txtb.Name = "txtb";
            txtb.Size = new Size(125, 27);
            txtb.TabIndex = 3;
            // 
            // texta
            // 
            texta.Location = new Point(72, 28);
            texta.Name = "texta";
            texta.Size = new Size(125, 27);
            texta.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 70);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 1;
            label3.Text = "b:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 31);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 0;
            label2.Text = "a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 328);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Kết quả";
            // 
            // txtkq
            // 
            txtkq.Location = new Point(181, 325);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(204, 27);
            txtkq.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtkq);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tinhtoan;
        private ToolStripMenuItem tong;
        private ToolStripMenuItem hieu;
        private ToolStripMenuItem tich;
        private ToolStripMenuItem thuong;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtb;
        private TextBox texta;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtkq;
    }
}
