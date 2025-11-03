namespace bai2
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
            txtNhap = new TextBox();
            button1 = new Button();
            txtkq = new TextBox();
            btnin = new Button();
            btnxoa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "nhap so phan tu mang";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(217, 43);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(220, 27);
            txtNhap.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(468, 43);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 2;
            button1.Text = "tao mang random";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(36, 78);
            txtkq.Multiline = true;
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(528, 135);
            txtkq.TabIndex = 3;
            // 
            // btnin
            // 
            btnin.Enabled = false;
            btnin.Location = new Point(139, 259);
            btnin.Name = "btnin";
            btnin.Size = new Size(94, 29);
            btnin.TabIndex = 4;
            btnin.Text = "in mang";
            btnin.UseVisualStyleBackColor = true;
            btnin.Click += btnin_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(361, 259);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 5;
            btnxoa.Text = "xoa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnxoa);
            Controls.Add(btnin);
            Controls.Add(txtkq);
            Controls.Add(button1);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private Button button1;
        private TextBox txtkq;
        private Button btnin;
        private Button btnxoa;
    }
}
