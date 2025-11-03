namespace Chuong3_bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkt_Click(object sender, EventArgs e)
        {
            int ngay=int.Parse(txtngay.Text);


            int thang=int.Parse(txtthang.Text);
          if(thang ==1 || thang==3 || thang==5 || thang==7 || thang==8 || thang==10 || thang==12)
            {
                if(ngay<1 || ngay>31)
                {
                    MessageBox.Show("Ngày không hợp lệ");
                }
                else
                {
                    MessageBox.Show("Ngày hợp lệ");
                }
            }
          if(thang==4 || thang==6 || thang==9 || thang==11)
            {
                if(ngay<1 || ngay>30)
                {
                    MessageBox.Show("Ngày không hợp lệ");
                }
                else
                {
                    MessageBox.Show("Ngày hợp lệ");
                }
            }
          if(thang==2)
                {
                    if(ngay<1 || ngay>29)
                    {
                        MessageBox.Show("Ngày không hợp lệ");
                    }
                    else
                    {
                        MessageBox.Show("Ngày hợp lệ");
                    }
            }
            int nam=int.Parse(txtnam.Text);
            
        }
    }
}
