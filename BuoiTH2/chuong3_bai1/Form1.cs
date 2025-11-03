namespace chuong3_bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int x,sum=0;
            x = int.Parse(txtx.Text);
            if (x>2)
            {
                sum = -8 * x * x - 12 * x - 1;
            }
            else if(1<x && x<=2)
            {
                sum = x * x - 6 * x - 19;
            }
            else if(x<=1)
            {
                sum = 7 * x;
            }
            txtf.Text = sum.ToString();
        }
    }
}
