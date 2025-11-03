namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkq_Click(object sender, EventArgs e)
        {
            if (this.txtnhap.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtnhap.Focus();
            }
            else
            {
                string hoten = this.txtnhap.Text;
                if (this.ckthuong.Checked == true)
                {
                    this.txtkq.Text = hoten.ToLower();
                }
                if (this.ckhoa.Checked == true)
                {
                    this.txtkq.Text = hoten.ToUpper();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.txtnhap.Clear();
            this.txtkq.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
