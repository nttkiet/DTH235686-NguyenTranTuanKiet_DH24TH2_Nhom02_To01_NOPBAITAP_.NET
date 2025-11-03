namespace chuong3_bai1
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
            txtx = new TextBox();
            txtf = new TextBox();
            btntinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 131);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 0;
            label1.Text = "x=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 177);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "f=";
            // 
            // txtx
            // 
            txtx.Location = new Point(267, 131);
            txtx.Name = "txtx";
            txtx.Size = new Size(125, 27);
            txtx.TabIndex = 2;
            // 
            // txtf
            // 
            txtf.Location = new Point(267, 174);
            txtf.Name = "txtf";
            txtf.Size = new Size(125, 27);
            txtf.TabIndex = 3;
            // 
            // btntinh
            // 
            btntinh.Location = new Point(277, 232);
            btntinh.Name = "btntinh";
            btntinh.Size = new Size(94, 29);
            btntinh.TabIndex = 4;
            btntinh.Text = "Tinh";
            btntinh.UseVisualStyleBackColor = true;
            btntinh.Click += btntinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btntinh);
            Controls.Add(txtf);
            Controls.Add(txtx);
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
        private TextBox txtx;
        private TextBox txtf;
        private Button btntinh;
    }
}
