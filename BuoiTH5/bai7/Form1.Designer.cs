namespace bai7
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
            txtnhapmang = new TextBox();
            txtketqua = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txtTongLe = new TextBox();
            txtTongChan = new TextBox();
            txtTongMang = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            txtMin = new TextBox();
            txtMax = new TextBox();
            label8 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            button5 = new Button();
            txtSoThayThe = new TextBox();
            txtViTriThayThe = new TextBox();
            label7 = new Label();
            label10 = new Label();
            groupBox4 = new GroupBox();
            rdbGiam = new RadioButton();
            rdbTang = new RadioButton();
            button6 = new Button();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 0;
            label1.Text = "Mảng số nguyên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 94);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "nhập mảng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 138);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "kết quả";
            // 
            // txtnhapmang
            // 
            txtnhapmang.Location = new Point(154, 94);
            txtnhapmang.Name = "txtnhapmang";
            txtnhapmang.Size = new Size(282, 27);
            txtnhapmang.TabIndex = 3;
            // 
            // txtketqua
            // 
            txtketqua.Location = new Point(154, 138);
            txtketqua.Name = "txtketqua";
            txtketqua.Size = new Size(282, 27);
            txtketqua.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(509, 94);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Xuất mảng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(509, 138);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Làm lại";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txtTongLe);
            groupBox1.Controls.Add(txtTongChan);
            groupBox1.Controls.Add(txtTongMang);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(44, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 140);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            button3.Location = new Point(290, 17);
            button3.Name = "button3";
            button3.Size = new Size(63, 117);
            button3.TabIndex = 13;
            button3.Text = "Tổng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(97, 107);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(128, 27);
            txtTongLe.TabIndex = 12;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(97, 71);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(128, 27);
            txtTongChan.TabIndex = 11;
            // 
            // txtTongMang
            // 
            txtTongMang.Location = new Point(97, 34);
            txtTongMang.Name = "txtTongMang";
            txtTongMang.Size = new Size(128, 27);
            txtTongMang.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 110);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 9;
            label6.Text = "Tổng lẻ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 71);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 9;
            label5.Text = "Tổng chẵn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 34);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 8;
            label4.Text = "Tổng mảng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(txtMin);
            groupBox2.Controls.Add(txtMax);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(446, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 140);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Min-Max";
            // 
            // button4
            // 
            button4.Location = new Point(262, 17);
            button4.Name = "button4";
            button4.Size = new Size(63, 117);
            button4.TabIndex = 13;
            button4.Text = "Tìm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(97, 77);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(128, 27);
            txtMin.TabIndex = 11;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(97, 34);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(128, 27);
            txtMax.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 84);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 9;
            label8.Text = "Tìm Min";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 34);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 8;
            label9.Text = "Tìm Max";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(txtSoThayThe);
            groupBox3.Controls.Add(txtViTriThayThe);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(440, 352);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(337, 140);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thay thế";
            // 
            // button5
            // 
            button5.Location = new Point(268, 17);
            button5.Name = "button5";
            button5.Size = new Size(63, 117);
            button5.TabIndex = 13;
            button5.Text = "Thay thế";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtSoThayThe
            // 
            txtSoThayThe.Location = new Point(115, 81);
            txtSoThayThe.Name = "txtSoThayThe";
            txtSoThayThe.Size = new Size(128, 27);
            txtSoThayThe.TabIndex = 11;
            // 
            // txtViTriThayThe
            // 
            txtViTriThayThe.Location = new Point(115, 31);
            txtViTriThayThe.Name = "txtViTriThayThe";
            txtViTriThayThe.Size = new Size(128, 27);
            txtViTriThayThe.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 84);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 9;
            label7.Text = "Số thay thế";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 34);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 8;
            label10.Text = "Vị trí thay thế";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rdbGiam);
            groupBox4.Controls.Add(rdbTang);
            groupBox4.Controls.Add(button6);
            groupBox4.Location = new Point(66, 352);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(337, 140);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "sắp xếp";
            // 
            // rdbGiam
            // 
            rdbGiam.AutoSize = true;
            rdbGiam.Location = new Point(46, 84);
            rdbGiam.Name = "rdbGiam";
            rdbGiam.Size = new Size(119, 24);
            rdbGiam.TabIndex = 15;
            rdbGiam.TabStop = true;
            rdbGiam.Text = "sắp xếp giảm";
            rdbGiam.UseVisualStyleBackColor = true;
            // 
            // rdbTang
            // 
            rdbTang.AutoSize = true;
            rdbTang.Location = new Point(46, 34);
            rdbTang.Name = "rdbTang";
            rdbTang.Size = new Size(115, 24);
            rdbTang.TabIndex = 14;
            rdbTang.TabStop = true;
            rdbTang.Text = "sắp xếp tăng";
            rdbTang.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(268, 17);
            button6.Name = "button6";
            button6.Size = new Size(63, 117);
            button6.TabIndex = 13;
            button6.Text = "sắp xếp";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(666, 94);
            button7.Name = "button7";
            button7.Size = new Size(94, 73);
            button7.TabIndex = 11;
            button7.Text = "Thoát";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 514);
            Controls.Add(button7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtketqua);
            Controls.Add(txtnhapmang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnhapmang;
        private TextBox txtketqua;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private TextBox txtTongLe;
        private TextBox txtTongChan;
        private TextBox txtTongMang;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private Button button4;
        private TextBox txtMin;
        private TextBox txtMax;
        private Label label8;
        private Label label9;
        private GroupBox groupBox3;
        private Button button5;
        private TextBox txtSoThayThe;
        private TextBox txtViTriThayThe;
        private Label label7;
        private Label label10;
        private GroupBox groupBox4;
        private RadioButton rdbGiam;
        private RadioButton rdbTang;
        private Button button6;
        private Button button7;
    }
}
