using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class TamGiac
    {
        private int _canh1;
        private int _canh2;
        private int _canh3;
        private int _chuvi;
        private int _loaitamgiaic;
        private float _dientich;


        public int canh1
        {
            get { return _canh1; }
            set { _canh1 = value; }
        }
        public int canh2
        {
            get { return _canh2; }
            set { _canh2 = value; }
        }
        public int canh3
        {
            get { return _canh3; }
            set { _canh3 = value; }
        }
        public int chuvi
        {
            get { return _chuvi ; }
            set { _chuvi = value; }
        }
        public float dientich
        {
            get { return _dientich; }
            set { _dientich = value; }
        }
        public int loaitamgiaic
        {
            get { return _loaitamgiaic; }
            set { _loaitamgiaic = value; }
        }
        public TamGiac()
        {
                canh1= 3;
                canh2 = 4;
                canh3 = -5;
                chuvi = 0;
                dientich = 0;
                loaitamgiaic = 0;
        }
       public TamGiac(int a,int b,int c)
        {
            canh1 = a;
            canh2 = b;
            canh3 = c;
            chuvi = 0;
            dientich = 0;
            loaitamgiaic = 0;

        }
        public int TinhChuVi()
        {
            chuvi = canh1+canh2+canh3;
            return chuvi;
        }
        public float TinhDienTich()
        {
            float p = TinhChuVi() / 2.0f;
            dientich = (float)Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
            return dientich;
        }
        public void thehien()
        {
            Console.WriteLine("canh 1 {0} \ncanh2 {1} \ncanh3 {2} ", canh1, canh2, canh3);
            Console.WriteLine("chu vi hinh chu nhat:{0} ", TinhChuVi());
            Console.WriteLine("dien tich la: {0} ",TinhDienTich());

        }

    }
}
// lam cac phuong thuc con lai va ben progrm
