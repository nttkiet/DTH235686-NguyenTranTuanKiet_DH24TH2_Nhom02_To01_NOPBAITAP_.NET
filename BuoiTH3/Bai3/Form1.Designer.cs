namespace Bai3
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
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "Tuổi Trẻ", "Tuổi Trẻ" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0));
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "Thanh Niên", "Thanh Niên" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "VNExpress", "VNExpress" }, -1);
            ListViewItem listViewItem16 = new ListViewItem(new string[] { "Dân Trí", "Dân Trí" }, -1);
            lstname = new ListView();
            linklabel = new LinkLabel();
            btnok = new Button();
            btnrelst = new Button();
            txtkq = new TextBox();
            SuspendLayout();
            // 
            // lstname
            // 
            listViewItem13.Tag = "Tuổi trẻ";
            lstname.Items.AddRange(new ListViewItem[] { listViewItem13, listViewItem14, listViewItem15, listViewItem16 });
            lstname.Location = new Point(167, 83);
            lstname.Name = "lstname";
            lstname.Size = new Size(168, 91);
            lstname.TabIndex = 0;
            lstname.UseCompatibleStateImageBehavior = false;
            lstname.View = View.Tile;
            lstname.SelectedIndexChanged += this.lstname_SelectedIndexChanged;
            // 
            // linklabel
            // 
            linklabel.AutoSize = true;
            linklabel.LinkColor = Color.FromArgb(64, 64, 64);
            linklabel.Location = new Point(167, 65);
            linklabel.Name = "linklabel";
            linklabel.Size = new Size(115, 15);
            linklabel.TabIndex = 1;
            linklabel.TabStop = true;
            linklabel.Text = "Link liên kết Website";
            linklabel.LinkClicked += this.linklabel_LinkClicked;
            // 
            // btnok
            // 
            btnok.Location = new Point(166, 180);
            btnok.Name = "btnok";
            btnok.Size = new Size(75, 23);
            btnok.TabIndex = 5;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // btnrelst
            // 
            btnrelst.Location = new Point(247, 180);
            btnrelst.Name = "btnrelst";
            btnrelst.Size = new Size(75, 23);
            btnrelst.TabIndex = 6;
            btnrelst.Text = "Reset";
            btnrelst.UseVisualStyleBackColor = true;
            btnrelst.Click += this.btnrelst_Click;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(338, 86);
            txtkq.Multiline = true;
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(210, 88);
            txtkq.TabIndex = 7;
            txtkq.TextChanged += txtkq_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtkq);
            Controls.Add(btnrelst);
            Controls.Add(btnok);
            Controls.Add(linklabel);
            Controls.Add(lstname);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstname;
        private LinkLabel linklabel;
        private Button btnok;
        private Button btnrelst;
        private TextBox txtkq;
    }
}
