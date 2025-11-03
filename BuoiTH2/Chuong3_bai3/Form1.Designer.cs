namespace Chuong3_bai3
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
            txtngay = new TextBox();
            txtthang = new TextBox();
            txtnam = new TextBox();
            btnkt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 22);
            label1.Name = "label1";
            label1.Size = new Size(367, 46);
            label1.TabIndex = 0;
            label1.Text = "Kiem Tra Ngay hop Le";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 110);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 150);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Thang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 191);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Nam";
            // 
            // txtngay
            // 
            txtngay.Location = new Point(301, 110);
            txtngay.Name = "txtngay";
            txtngay.Size = new Size(125, 27);
            txtngay.TabIndex = 4;
            // 
            // txtthang
            // 
            txtthang.Location = new Point(301, 147);
            txtthang.Name = "txtthang";
            txtthang.Size = new Size(125, 27);
            txtthang.TabIndex = 5;
            // 
            // txtnam
            // 
            txtnam.Location = new Point(301, 188);
            txtnam.Name = "txtnam";
            txtnam.Size = new Size(125, 27);
            txtnam.TabIndex = 6;
            // 
            // btnkt
            // 
            btnkt.Location = new Point(311, 245);
            btnkt.Name = "btnkt";
            btnkt.Size = new Size(94, 29);
            btnkt.TabIndex = 7;
            btnkt.Text = "Kiem Tra";
            btnkt.UseVisualStyleBackColor = true;
            btnkt.Click += btnkt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnkt);
            Controls.Add(txtnam);
            Controls.Add(txtthang);
            Controls.Add(txtngay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtngay;
        private TextBox txtthang;
        private TextBox txtnam;
        private Button btnkt;
    }
}
