namespace Chuong3_bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            int c = int.Parse(txtc.Text);
            if(a==0)
            {
                if(b==0)
                {
                    if(c==0)
                    {
                        txtkq.Text = "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        txtkq.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    double x = -c / (double)b;
                    txtkq.Text = "x= "+x;
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if(delta<0)
                {
                    txtkq.Text = "Phương trình vô nghiệm";
                }
                else if(delta==0)
                {
                    double x = -b / (2.0 * a);
                    txtkq.Text = "Phương trình có nghiệm kép x1=x2="+x;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                    txtkq.Text = $"hai nghiệm x1={x1}, x2={x2}";
                }
            }
        }
    }
}
