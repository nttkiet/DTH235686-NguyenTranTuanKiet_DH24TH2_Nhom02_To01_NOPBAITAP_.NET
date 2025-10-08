namespace Bai_2._5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPhepToan = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.txbSoA = new System.Windows.Forms.TextBox();
            this.txbSoB = new System.Windows.Forms.TextBox();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhepToan
            // 
            this.lblPhepToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhepToan.Location = new System.Drawing.Point(77, 33);
            this.lblPhepToan.Name = "lblPhepToan";
            this.lblPhepToan.Size = new System.Drawing.Size(135, 23);
            this.lblPhepToan.TabIndex = 0;
            this.lblPhepToan.Text = "PHEP TOAN";
            this.lblPhepToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhepToan.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txbSoB);
            this.grbThongTin.Controls.Add(this.txbSoA);
            this.grbThongTin.Controls.Add(this.lblSoB);
            this.grbThongTin.Controls.Add(this.lblSoA);
            this.grbThongTin.Location = new System.Drawing.Point(36, 110);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(200, 100);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thong Tin";
            this.grbThongTin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(98, 244);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(93, 47);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSoA.Location = new System.Drawing.Point(20, 20);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(17, 15);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "a;";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoB.Location = new System.Drawing.Point(20, 66);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(17, 15);
            this.lblSoB.TabIndex = 1;
            this.lblSoB.Text = "b:";
            // 
            // txbSoA
            // 
            this.txbSoA.Location = new System.Drawing.Point(38, 17);
            this.txbSoA.Name = "txbSoA";
            this.txbSoA.Size = new System.Drawing.Size(127, 20);
            this.txbSoA.TabIndex = 2;
            // 
            // txbSoB
            // 
            this.txbSoB.Location = new System.Drawing.Point(38, 66);
            this.txbSoB.Name = "txbSoB";
            this.txbSoB.Size = new System.Drawing.Size(127, 20);
            this.txbSoB.TabIndex = 3;
            this.txbSoB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTong;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 324);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblPhepToan);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 2.5";
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPhepToan;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.TextBox txbSoB;
        private System.Windows.Forms.TextBox txbSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblSoA;
    }
}

