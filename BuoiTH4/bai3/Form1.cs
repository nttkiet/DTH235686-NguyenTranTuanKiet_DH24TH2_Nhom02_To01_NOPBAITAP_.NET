namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        int n;
        public void Taomang(int n)
        {
            a = new int[n];
            int num1;
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                num1 = rd.Next(-10, 100);
                a[i] = num1;
            }

        }
        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < n; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtkq.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtkq.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtkq.Text);
                if (n < 0)
                {
                    MessageBox.Show("Bạn vừa nhập n = " + n + ". Số phần tử mảng phải > 0", "Thông  báo");
                    txtkq.Focus();
                }
                else
                {
                    Taomang(n);
                    txtkq.Text = "Mảng với các phần tử phát sinh ngẫu nhiên vừa tạo xong";
                    btnin.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int max;
            if (n== 0)
                txtkq.Text = "Mảng rỗng!";
            else
            {
                max = TimMax();
                txtkq.Text = "Phần tử lớn nhất trong mảng là: " + max.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this .Close();
        }
    }
}
