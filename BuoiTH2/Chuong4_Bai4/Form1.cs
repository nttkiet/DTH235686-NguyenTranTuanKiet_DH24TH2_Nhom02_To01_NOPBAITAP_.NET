namespace Chuong4_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtn.Text);
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 2*i-1;
            }
            txts.Text = s.ToString();
        }
    }
}
