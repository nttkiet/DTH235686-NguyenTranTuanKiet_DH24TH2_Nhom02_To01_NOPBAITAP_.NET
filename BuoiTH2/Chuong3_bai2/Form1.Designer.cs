namespace Chuong_bai2
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
            txtthang = new TextBox();
            btnname = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 49);
            label1.Name = "label1";
            label1.Size = new Size(239, 38);
            label1.TabIndex = 0;
            label1.Text = "Mùa Trong Năm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 129);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "tháng:";
            // 
            // txtthang
            // 
            txtthang.Location = new Point(252, 129);
            txtthang.Name = "txtthang";
            txtthang.Size = new Size(125, 27);
            txtthang.TabIndex = 2;
            // 
            // btnname
            // 
            btnname.Location = new Point(216, 192);
            btnname.Name = "btnname";
            btnname.Size = new Size(94, 29);
            btnname.TabIndex = 3;
            btnname.Text = "Thông báo";
            btnname.UseVisualStyleBackColor = true;
            btnname.Click += btnname_Click;
            // 
            // button1
            // 
            button1.Location = new Point(373, 192);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Thoat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnname);
            Controls.Add(txtthang);
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
        private TextBox txtthang;
        private Button btnname;
        private Button button1;
    }
}
