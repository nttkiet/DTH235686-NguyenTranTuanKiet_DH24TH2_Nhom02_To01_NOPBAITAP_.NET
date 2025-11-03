namespace Chuong4_bai7
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
            btntinh = new Button();
            txts = new TextBox();
            txtn = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btntinh
            // 
            btntinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btntinh.Location = new Point(373, 265);
            btntinh.Name = "btntinh";
            btntinh.Size = new Size(94, 29);
            btntinh.TabIndex = 34;
            btntinh.Text = "Tinh";
            btntinh.UseVisualStyleBackColor = true;
            btntinh.Click += btntinh_Click;
            // 
            // txts
            // 
            txts.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txts.Location = new Point(361, 198);
            txts.Name = "txts";
            txts.Size = new Size(125, 30);
            txts.TabIndex = 33;
            // 
            // txtn
            // 
            txtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtn.Location = new Point(361, 157);
            txtn.Name = "txtn";
            txtn.Size = new Size(125, 30);
            txtn.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(314, 198);
            label2.Name = "label2";
            label2.Size = new Size(25, 23);
            label2.TabIndex = 31;
            label2.Text = "S:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(314, 157);
            label1.Name = "label1";
            label1.Size = new Size(25, 23);
            label1.TabIndex = 30;
            label1.Text = "n:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btntinh);
            Controls.Add(txts);
            Controls.Add(txtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btntinh;
        private TextBox txts;
        private TextBox txtn;
        private Label label2;
        private Label label1;
    }
}
