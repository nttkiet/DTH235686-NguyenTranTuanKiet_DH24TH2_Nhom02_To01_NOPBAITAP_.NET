namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
    private void btndangnhap_Click(object sender, EventArgs e)
        {
            if ((this.txtuser.Text == "") || (this.txtpass.Text == ""))
                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            else
            {
                if ((this.txtuser.Text == "nguyenvanhung") && (this.txtpass.Text == "abc12345"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                   

                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txtuser.Clear();
                    this.txtpass.Clear(); this.txtuser.Focus();
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.txtuser.Clear();
            this.txtpass.Clear();
            this.txtuser.Focus();
        }

    }
}
