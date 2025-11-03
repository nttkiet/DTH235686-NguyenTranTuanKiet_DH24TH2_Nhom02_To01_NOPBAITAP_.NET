using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max;
            Console.OutputEncoding = Encoding.UTF8;
            TimSoLonNhat tsln=new TimSoLonNhat();
            Console.WriteLine("Nhap so thu 1:");
            int so1=tsln.nhap();
            Console.WriteLine("Nhap so thu 2:");    
            int so2=tsln.nhap();
            Console.WriteLine("Nhap so thu 3:");
            int so3=tsln.nhap();
            max=tsln.timMax(so1,so2,so3);
            Console.WriteLine("So lon nhat trong {0} ,{1} va {2} la {3} ",so1,so2,so3,max);
            Console.ReadLine();
        }
    }
}
