namespace Chuong3_bai4
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            txtkq = new TextBox();
            btngiai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 41);
            label1.TabIndex = 0;
            label1.Text = "Giai Phuong Trinh Bac 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 86);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "phuong trinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 131);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 2;
            label3.Text = "a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 165);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 3;
            label4.Text = "b:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 202);
            label5.Name = "label5";
            label5.Size = new Size(19, 20);
            label5.TabIndex = 4;
            label5.Text = "c:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 255);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "ket qua:";
            // 
            // txta
            // 
            txta.Location = new Point(286, 135);
            txta.Name = "txta";
            txta.Size = new Size(125, 27);
            txta.TabIndex = 6;
            // 
            // txtb
            // 
            txtb.Location = new Point(286, 168);
            txtb.Name = "txtb";
            txtb.Size = new Size(125, 27);
            txtb.TabIndex = 7;
            // 
            // txtc
            // 
            txtc.Location = new Point(286, 201);
            txtc.Name = "txtc";
            txtc.Size = new Size(125, 27);
            txtc.TabIndex = 8;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(261, 252);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(287, 27);
            txtkq.TabIndex = 9;
            // 
            // btngiai
            // 
            btngiai.Location = new Point(300, 305);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(94, 29);
            btngiai.TabIndex = 10;
            btngiai.Text = "Giai";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += btngiai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btngiai);
            Controls.Add(txtkq);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
        private TextBox txtkq;
        private Button btngiai;
    }
}
