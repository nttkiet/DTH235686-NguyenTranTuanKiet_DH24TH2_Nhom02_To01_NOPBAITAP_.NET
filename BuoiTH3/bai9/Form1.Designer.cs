namespace bai9
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
            groupBox1 = new GroupBox();
            datengaysinh = new DateTimePicker();
            checklam = new CheckBox();
            checkhoc = new CheckBox();
            radionu = new RadioButton();
            radionam = new RadioButton();
            txtemail = new TextBox();
            txtso = new TextBox();
            txtdiachi = new TextBox();
            txtten = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnhienthi = new Button();
            btnthoat = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 38);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cá nhân";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(datengaysinh);
            groupBox1.Controls.Add(checklam);
            groupBox1.Controls.Add(checkhoc);
            groupBox1.Controls.Add(radionu);
            groupBox1.Controls.Add(radionam);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtso);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(35, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 305);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // datengaysinh
            // 
            datengaysinh.Location = new Point(127, 110);
            datengaysinh.Name = "datengaysinh";
            datengaysinh.Size = new Size(250, 27);
            datengaysinh.TabIndex = 6;
            // 
            // checklam
            // 
            checklam.AutoSize = true;
            checklam.Location = new Point(280, 248);
            checklam.Name = "checklam";
            checklam.Size = new Size(113, 24);
            checklam.TabIndex = 15;
            checklam.Text = "Đang đi làm";
            checklam.UseVisualStyleBackColor = true;
            // 
            // checkhoc
            // 
            checkhoc.AutoSize = true;
            checkhoc.Location = new Point(137, 248);
            checkhoc.Name = "checkhoc";
            checkhoc.Size = new Size(112, 24);
            checkhoc.TabIndex = 14;
            checkhoc.Text = "Đang đi học";
            checkhoc.UseVisualStyleBackColor = true;
            // 
            // radionu
            // 
            radionu.AutoSize = true;
            radionu.Location = new Point(241, 80);
            radionu.Name = "radionu";
            radionu.Size = new Size(49, 24);
            radionu.TabIndex = 13;
            radionu.TabStop = true;
            radionu.Text = "Nu";
            radionu.UseVisualStyleBackColor = true;
            // 
            // radionam
            // 
            radionam.AutoSize = true;
            radionam.Location = new Point(137, 80);
            radionam.Name = "radionam";
            radionam.Size = new Size(62, 24);
            radionam.TabIndex = 12;
            radionam.TabStop = true;
            radionam.Text = "Nam";
            radionam.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(127, 211);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(287, 27);
            txtemail.TabIndex = 11;
            // 
            // txtso
            // 
            txtso.Location = new Point(127, 178);
            txtso.Name = "txtso";
            txtso.Size = new Size(287, 27);
            txtso.TabIndex = 10;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(127, 145);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(287, 27);
            txtdiachi.TabIndex = 9;
            // 
            // txtten
            // 
            txtten.Location = new Point(127, 42);
            txtten.Name = "txtten";
            txtten.Size = new Size(287, 27);
            txtten.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 248);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 6;
            label8.Text = "Tình trạng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 211);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 5;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 178);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 4;
            label6.Text = "Điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 145);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 110);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 2;
            label4.Text = "ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 80);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 1;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 42);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "họ và tên:";
            // 
            // btnhienthi
            // 
            btnhienthi.Location = new Point(94, 373);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(140, 45);
            btnhienthi.TabIndex = 2;
            btnhienthi.Text = "Hiển thị thông tin";
            btnhienthi.UseVisualStyleBackColor = true;
            btnhienthi.Click += btnhienthi_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(302, 373);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(113, 45);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoat";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Ảnh_chụp_màn_hình__27_;
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(537, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(251, 223);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hình ảnh";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(groupBox2);
            Controls.Add(btnthoat);
            Controls.Add(btnhienthi);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtemail;
        private TextBox txtso;
        private TextBox txtdiachi;
        private TextBox txtten;
        private Label label8;
        private Label label7;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox checklam;
        private CheckBox checkhoc;
        private RadioButton radionu;
        private RadioButton radionam;
        private Button btnhienthi;
        private Button btnthoat;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private DateTimePicker datengaysinh;
    }
}
