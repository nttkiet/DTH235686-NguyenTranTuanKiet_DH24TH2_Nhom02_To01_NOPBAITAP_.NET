namespace Bai3
{
    partial class Form2
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
            txtkq = new TextBox();
            btnrelst = new Button();
            btnok = new Button();
            linklabel = new LinkLabel();
            cblk = new ComboBox();
            SuspendLayout();
            // 
            // txtkq
            // 
            txtkq.Location = new Point(210, 177);
            txtkq.Multiline = true;
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(353, 88);
            txtkq.TabIndex = 12;
            txtkq.Text = "Z";
            txtkq.TextChanged += txtkq_TextChanged;
            // 
            // btnrelst
            // 
            btnrelst.Location = new Point(469, 148);
            btnrelst.Name = "btnrelst";
            btnrelst.Size = new Size(75, 23);
            btnrelst.TabIndex = 11;
            btnrelst.Text = "Reset";
            btnrelst.UseVisualStyleBackColor = true;
            btnrelst.Click += btnrelst_Click;
            // 
            // btnok
            // 
            btnok.Location = new Point(388, 148);
            btnok.Name = "btnok";
            btnok.Size = new Size(75, 23);
            btnok.TabIndex = 10;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // linklabel
            // 
            linklabel.AutoSize = true;
            linklabel.LinkColor = Color.FromArgb(64, 64, 64);
            linklabel.Location = new Point(209, 119);
            linklabel.Name = "linklabel";
            linklabel.Size = new Size(115, 15);
            linklabel.TabIndex = 9;
            linklabel.TabStop = true;
            linklabel.Text = "Link liên kết Website";
            // 
            // cblk
            // 
            cblk.FormattingEnabled = true;
            cblk.Location = new Point(210, 148);
            cblk.Name = "cblk";
            cblk.Size = new Size(121, 23);
            cblk.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cblk);
            Controls.Add(txtkq);
            Controls.Add(btnrelst);
            Controls.Add(btnok);
            Controls.Add(linklabel);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtkq;
        private Button btnrelst;
        private Button btnok;
        private LinkLabel linklabel;
        private ComboBox cblk;
    }
}