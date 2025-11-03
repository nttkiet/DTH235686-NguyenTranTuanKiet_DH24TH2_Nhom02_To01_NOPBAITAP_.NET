using System.ComponentModel;

namespace bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string n = txtten.Text;
            string ngaySinh = datengaysinh.Value.ToString("dd/MM/yyyy");
            if(radionam.Checked)
            {
                n += " - Nam";
            }    
            else if(radionu.Checked)
            {
                n+= " - Nu";
            }    
            else
            {
                n += " - Khac";
            }
            int so=int.Parse(txtso.Text);
            if(checkhoc.Checked)
            {
                n += " - Di hoc";
            }
            if(checklam.Checked)
            {
                n += " - Dai bieu";
            }
            string diachi= txtdiachi.Text;
            string email= txtemail.Text;
            MessageBox.Show("ho va ten la: " + n + "\nnam sinh la: " + ngaySinh +"\ngioi tinh "+n + "\nso dien thoai "
                +so+"\ncong viec hien tai"+n+ "\ndia chi "+diachi + "\nemail la "+email);
            
           
        }
    }
}
