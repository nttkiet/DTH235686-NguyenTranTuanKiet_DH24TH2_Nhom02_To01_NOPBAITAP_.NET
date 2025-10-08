namespace Bai_3._1
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblSoX = new System.Windows.Forms.Label();
            this.lblHienThiKQ = new System.Windows.Forms.Label();
            this.txtSoX = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(104, 48);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(238, 23);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "TINH GIA TRI HAM SO";
            // 
            // lblSoX
            // 
            this.lblSoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoX.Location = new System.Drawing.Point(127, 154);
            this.lblSoX.Name = "lblSoX";
            this.lblSoX.Size = new System.Drawing.Size(55, 23);
            this.lblSoX.TabIndex = 1;
            this.lblSoX.Text = "x=";
            // 
            // lblHienThiKQ
            // 
            this.lblHienThiKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiKQ.Location = new System.Drawing.Point(127, 201);
            this.lblHienThiKQ.Name = "lblHienThiKQ";
            this.lblHienThiKQ.Size = new System.Drawing.Size(55, 23);
            this.lblHienThiKQ.TabIndex = 2;
            this.lblHienThiKQ.Text = "f=";
            // 
            // txtSoX
            // 
            this.txtSoX.Location = new System.Drawing.Point(147, 156);
            this.txtSoX.Name = "txtSoX";
            this.txtSoX.Size = new System.Drawing.Size(173, 20);
            this.txtSoX.TabIndex = 3;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(147, 201);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(173, 20);
            this.txtKetQua.TabIndex = 4;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(180, 288);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(99, 41);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoX);
            this.Controls.Add(this.lblHienThiKQ);
            this.Controls.Add(this.lblSoX);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 3.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblSoX;
        private System.Windows.Forms.Label lblHienThiKQ;
        private System.Windows.Forms.TextBox txtSoX;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTinh;
    }
}

