namespace Bai9
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(328, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 33;
            // 
            // txtkq
            // 
            this.txtkq.AutoSize = true;
            this.txtkq.Location = new System.Drawing.Point(281, 241);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(50, 13);
            this.txtkq.TabIndex = 32;
            this.txtkq.Text = "Ket qua: ";
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(507, 326);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(75, 23);
            this.btnchia.TabIndex = 31;
            this.btnchia.Text = "Thoat";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(409, 326);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 30;
            this.btn.Text = "Duong cheo";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnhieu
            // 
            this.btnhieu.Location = new System.Drawing.Point(313, 326);
            this.btnhieu.Name = "btnhieu";
            this.btnhieu.Size = new System.Drawing.Size(75, 23);
            this.btnhieu.TabIndex = 29;
            this.btnhieu.Text = "Dien tich";
            this.btnhieu.UseVisualStyleBackColor = true;
            this.btnhieu.Click += new System.EventHandler(this.btnhieu_Click);
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(219, 326);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(75, 23);
            this.btntong.TabIndex = 28;
            this.btntong.Text = "chu vi";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // txtb
            // 
            this.txtb.AutoSize = true;
            this.txtb.Location = new System.Drawing.Point(291, 206);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(16, 13);
            this.txtb.TabIndex = 25;
            this.txtb.Text = "b:";
            // 
            // txta
            // 
            this.txta.AutoSize = true;
            this.txta.Location = new System.Drawing.Point(291, 174);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(16, 13);
            this.txta.TabIndex = 24;
            this.txta.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Thong tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hinh Chu Nhat";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtkq;
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
    }
}

