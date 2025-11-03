namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int n=int.Parse(txtnhap.Text);
            if (n < 1)
            {
                MessageBox.Show($"{n} khong phai la so nguyen to");

            }
            
                int sum = 0;
                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0)
                        sum += i;
                }
            if (sum == n)
            {
                MessageBox.Show($"{n}  la so nguyen to");
            }
            else
            {
                MessageBox.Show($"{n} khong phai la so nguyen to");
            }
                
        }
    }
}
