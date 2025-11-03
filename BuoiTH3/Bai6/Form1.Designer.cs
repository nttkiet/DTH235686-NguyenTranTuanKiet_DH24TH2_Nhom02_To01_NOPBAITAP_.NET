namespace Bai6
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
            txtnhap = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            btnmauchu = new Button();
            btnfontchu = new Button();
            btnnenmau = new Button();
            lisname = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 57);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập chuỗi";
            // 
            // txtnhap
            // 
            txtnhap.Location = new Point(80, 85);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(199, 23);
            txtnhap.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(80, 114);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(204, 114);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 99);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnmauchu
            // 
            btnmauchu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmauchu.Location = new Point(303, 190);
            btnmauchu.Name = "btnmauchu";
            btnmauchu.Size = new Size(110, 50);
            btnmauchu.TabIndex = 6;
            btnmauchu.Text = "Chọn màu chữ";
            btnmauchu.UseVisualStyleBackColor = true;
            btnmauchu.Click += btnmauchu_Click_1;
            // 
            // btnfontchu
            // 
            btnfontchu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnfontchu.Location = new Point(431, 190);
            btnfontchu.Name = "btnfontchu";
            btnfontchu.Size = new Size(121, 50);
            btnfontchu.TabIndex = 7;
            btnfontchu.Text = "Chọn Font chữ";
            btnfontchu.UseVisualStyleBackColor = true;
            btnfontchu.Click += btnfontchu_Click;
            // 
            // btnnenmau
            // 
            btnnenmau.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnenmau.Location = new Point(570, 190);
            btnnenmau.Name = "btnnenmau";
            btnnenmau.Size = new Size(142, 50);
            btnnenmau.TabIndex = 8;
            btnnenmau.Text = "Chọn nền màu chữ";
            btnnenmau.UseVisualStyleBackColor = true;
            btnnenmau.Click += btnnenmau_Click;
            // 
            // lisname
            // 
            lisname.FormattingEnabled = true;
            lisname.ItemHeight = 15;
            lisname.Location = new Point(80, 146);
            lisname.Name = "lisname";
            lisname.Size = new Size(199, 94);
            lisname.TabIndex = 9;
            lisname.SelectedIndexChanged += lisname_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lisname);
            Controls.Add(btnnenmau);
            Controls.Add(btnfontchu);
            Controls.Add(btnmauchu);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtnhap);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnhap;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button btnmauchu;
        private Button btnfontchu;
        private Button btnnenmau;
        private ListBox lisname;
    }
}
