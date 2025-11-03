namespace Bai10
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
            label4 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            btncv = new Button();
            btndt = new Button();
            btndc = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 61);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Hinh chu nhat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 117);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Thong tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 153);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 2;
            label3.Text = "a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 182);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 3;
            label4.Text = "b:";
            // 
            // txta
            // 
            txta.Location = new Point(309, 150);
            txta.Name = "txta";
            txta.Size = new Size(125, 27);
            txta.TabIndex = 4;
            // 
            // txtb
            // 
            txtb.Location = new Point(309, 183);
            txtb.Name = "txtb";
            txtb.Size = new Size(125, 27);
            txtb.TabIndex = 5;
            // 
            // btncv
            // 
            btncv.Location = new Point(115, 256);
            btncv.Name = "btncv";
            btncv.Size = new Size(94, 29);
            btncv.TabIndex = 6;
            btncv.Text = "Chu Vi";
            btncv.UseVisualStyleBackColor = true;
            btncv.Click += btncv_Click;
            // 
            // btndt
            // 
            btndt.Location = new Point(256, 256);
            btndt.Name = "btndt";
            btndt.Size = new Size(94, 29);
            btndt.TabIndex = 7;
            btndt.Text = "Dien Tich";
            btndt.UseVisualStyleBackColor = true;
            btndt.Click += btndt_Click;
            // 
            // btndc
            // 
            btndc.Location = new Point(403, 256);
            btndc.Name = "btndc";
            btndc.Size = new Size(120, 29);
            btndc.TabIndex = 8;
            btndc.Text = "Duong Cheo";
            btndc.UseVisualStyleBackColor = true;
            btndc.Click += btndc_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(590, 256);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 9;
            btnthoat.Text = "Thoat";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnthoat);
            Controls.Add(btndc);
            Controls.Add(btndt);
            Controls.Add(btncv);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txta;
        private TextBox txtb;
        private Button btncv;
        private Button btndt;
        private Button btndc;
        private Button btnthoat;
    }
}
