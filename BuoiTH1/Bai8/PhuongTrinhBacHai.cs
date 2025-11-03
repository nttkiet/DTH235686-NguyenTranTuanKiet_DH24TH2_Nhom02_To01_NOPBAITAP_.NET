using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class PhuongTrinhBacHai
    {
        private int _soa;
        private int _sob;
        private int _soc;

        public int soa
        {
            get { return _soa; }
            set { _soa = value; }
        }
        public int sob
        {
            get { return _sob; }
            set { _sob = value; }
        }
        public int soc
        {
            get { return _soc; }

            set { _soc = value; }
        }
        public PhuongTrinhBacHai()
        {
            soa = 0;
            sob = 0;
            soc = 0;
        }
        public PhuongTrinhBacHai(int a,int b,int c)
        {
            soa = a;
            sob = b;
            soc = c;
        }
        public void nghiempt()
        {
            if (soa==0)
            {
                if(sob==0)
                {
                    if (soc == 0)
                        Console.WriteLine("phuong trinh vo so nhgiem ");
                    else
                        Console.WriteLine("phuong trinh vo nghiem ");
                }
                else
                {
                    float x = -(float)soc / sob;
                    Console.WriteLine("phuong co mot nghiem: {0}", x);
                }
            }
            float delta = sob * sob - 4 * soa * soc;
           if(delta<0)
            {
                Console.WriteLine("phuong trinh vo nghiem ");
            }
           else if(delta==0)
            {
                float x = -(float)soc / sob;
                Console.WriteLine("phuong trinh co mot nghiem: {0}", x);
            }
           else
            {
               float x1 = (float)(-sob + Math.Sqrt(delta)) / (2 * soa);
                float x2 = (float)(-sob - Math.Sqrt(delta)) / (2 * soa);
                Console.WriteLine("phuong trinh co hai nghiem phan biet: x1={0},x2={1}", x1, x2);
            }

        }
        public void TheHien()
        {
            Console.WriteLine("phuong Trinh Bac hai:{0}x^2 + {1}x + {2} = 0", soa, sob, soc);
            nghiempt();
        }
        public void nhap()
        {
            Console.Write("nhap he so a: ");
            soa = int.Parse(Console.ReadLine());
            Console.Write("nhap he so b: ");
            sob = int.Parse(Console.ReadLine());
            Console.Write("nhap he so c: ");
            soc = int.Parse(Console.ReadLine());
        }
    }
}
