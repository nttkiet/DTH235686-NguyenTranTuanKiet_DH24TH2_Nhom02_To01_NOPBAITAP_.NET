namespace Bai8
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
            this.btnchia = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnhieu = new System.Windows.Forms.Button();
            this.btntong = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(507, 296);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(75, 23);
            this.btnchia.TabIndex = 19;
            this.btnchia.Text = "Thuong";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(408, 296);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 18;
            this.btn.Text = "Tich";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnhieu
            // 
            this.btnhieu.Location = new System.Drawing.Point(313, 296);
            this.btnhieu.Name = "btnhieu";
            this.btnhieu.Size = new System.Drawing.Size(75, 23);
            this.btnhieu.TabIndex = 17;
            this.btnhieu.Text = "Hieu";
            this.btnhieu.UseVisualStyleBackColor = true;
            this.btnhieu.Click += new System.EventHandler(this.btnhieu_Click);
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(219, 296);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(75, 23);
            this.btntong.TabIndex = 16;
            this.btntong.Text = "Tong";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // txtb
            // 
            this.txtb.AutoSize = true;
            this.txtb.Location = new System.Drawing.Point(291, 176);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(16, 13);
            this.txtb.TabIndex = 13;
            this.txtb.Text = "b:";
            // 
            // txta
            // 
            this.txta.AutoSize = true;
            this.txta.Location = new System.Drawing.Point(291, 144);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(16, 13);
            this.txta.TabIndex = 12;
            this.txta.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Thong tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "PHEP TOAN";
            // 
            // txtkq
            // 
            this.txtkq.AutoSize = true;
            this.txtkq.Location = new System.Drawing.Point(281, 211);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(50, 13);
            this.txtkq.TabIndex = 20;
            this.txtkq.Text = "Ket qua: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(328, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnhieu);
            this.Controls.Add(this.btntong);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnhieu;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtb;
        private System.Windows.Forms.Label txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtkq;
        private System.Windows.Forms.TextBox textBox3;
    }
}

