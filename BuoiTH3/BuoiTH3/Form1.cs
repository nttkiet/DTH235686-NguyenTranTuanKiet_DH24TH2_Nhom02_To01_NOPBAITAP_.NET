namespace BuoiTH3
{
    public partial class chknho : Form
    {
        public chknho()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtuser.Text;
            thongbao += "\n\rMật khẩu là:";
            thongbao += this.txtpass.Text;
            if (this.checkBox1.Checked == true)
                thongbao += "\n\rBạn có ghi nhớ.";
            MessageBox.Show(thongbao, "Thông báo");

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.txtuser.Clear();
            this.txtpass.Clear();
            this.txtuser.Focus();

        }

        private void btndung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
