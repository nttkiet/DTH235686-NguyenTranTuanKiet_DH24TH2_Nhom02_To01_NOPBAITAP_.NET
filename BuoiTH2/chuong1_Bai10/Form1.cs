namespace Bai10
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

        private void btncv_Click(object sender, EventArgs e)
        {
            int chu_vi;
            chu_vi = (int.Parse(txta.Text) + int.Parse(txtb.Text)) * 2;
            MessageBox.Show("Tong :" + chu_vi.ToString());
        }

        private void btndt_Click(object sender, EventArgs e)
        {
            int dientich;
            dientich = (int.Parse(txta.Text) * int.Parse(txtb.Text));
            MessageBox.Show("Tong :" + dientich.ToString());
        }

        private void btndc_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                double d = Math.Sqrt(a * a + b * b);
                MessageBox.Show("Tong :" + d.ToString());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
