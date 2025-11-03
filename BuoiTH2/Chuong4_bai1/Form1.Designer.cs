namespace Chuong4_bai1
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
            txtn = new TextBox();
            txts = new TextBox();
            btntinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 94);
            label1.Name = "label1";
            label1.Size = new Size(25, 23);
            label1.TabIndex = 0;
            label1.Text = "n:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 135);
            label2.Name = "label2";
            label2.Size = new Size(25, 23);
            label2.TabIndex = 1;
            label2.Text = "S:";
            // 
            // txtn
            // 
            txtn.Location = new Point(256, 94);
            txtn.Name = "txtn";
            txtn.Size = new Size(125, 30);
            txtn.TabIndex = 2;
            // 
            // txts
            // 
            txts.Location = new Point(256, 135);
            txts.Name = "txts";
            txts.Size = new Size(125, 30);
            txts.TabIndex = 3;
            // 
            // btntinh
            // 
            btntinh.Location = new Point(268, 202);
            btntinh.Name = "btntinh";
            btntinh.Size = new Size(94, 29);
            btntinh.TabIndex = 4;
            btntinh.Text = "Tinh";
            btntinh.UseVisualStyleBackColor = true;
            btntinh.Click += btntinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 518);
            Controls.Add(btntinh);
            Controls.Add(txts);
            Controls.Add(txtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "cau truc lap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtn;
        private TextBox txts;
        private Button btntinh;
    }
}
