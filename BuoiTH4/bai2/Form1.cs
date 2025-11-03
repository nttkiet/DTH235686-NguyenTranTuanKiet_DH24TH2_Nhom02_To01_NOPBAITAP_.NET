namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        int n;

        public void TaoMang(int n)
        {
            a = new int[n];
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                num1 = rd.Next(-10, 100);
                a[i] = num1;
            }
        }

        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < a.Length; i++)
                chuoi += a[i] + "  ";
            return chuoi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if (n < 0)
                {
                    MessageBox.Show("Bạn vừa nhập n = " + n + ". Số phần tử mảng phải > 0", "Thông báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    txtkq.Text = "Mảng với các phần tử phát sinh ngẫu nhiên vừa tạo xong";
                    btnin.Enabled = true;
                }
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            {
                txtkq.Text = "Các phần tử của mảng: " + InMang();
            }
        }
    }
}
