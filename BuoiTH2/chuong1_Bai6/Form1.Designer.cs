namespace Bai6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btntong = new System.Windows.Forms.Button();
            this.btnhieu = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHEP TOAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thong tin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txta
            // 
            this.txta.AutoSize = true;
            this.txta.Location = new System.Drawing.Point(255, 140);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(16, 13);
            this.txta.TabIndex = 2;
            this.txta.Text = "a:";
            this.txta.Click += new System.EventHandler(this.txta_Click);
            // 
            // txtb
            // 
            this.txtb.AutoSize = true;
            this.txtb.Location = new System.Drawing.Point(255, 172);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(16, 13);
            this.txtb.TabIndex = 3;
            this.txtb.Text = "b:";
            this.txtb.Click += new System.EventHandler(this.txtb_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(183, 226);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(75, 23);
            this.btntong.TabIndex = 6;
            this.btntong.Text = "Tong";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btnhieu
            // 
            this.btnhieu.Location = new System.Drawing.Point(277, 226);
            this.btnhieu.Name = "btnhieu";
            this.btnhieu.Size = new System.Drawing.Size(75, 23);
            this.btnhieu.TabIndex = 7;
            this.btnhieu.Text = "Hieu";
            this.btnhieu.UseVisualStyleBackColor = true;
            this.btnhieu.Click += new System.EventHandler(this.btnhieu_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(372, 226);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 8;
            this.btn.Text = "Tich";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(471, 226);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(75, 23);
            this.btnchia.TabIndex = 9;
            this.btnchia.Text = "Thuong";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txta;
        private System.Windows.Forms.Label txtb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btnhieu;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnchia;
    }
}

