using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai3

{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
            GiaiThua tgt=new GiaiThua();
            int n;
            Console.Write("nhap n: ");
            n=tgt.nhap();   
            Console.WriteLine("Giai thua cua {0} la: {1}",n,tgt.tinhgiathua(n));
            Console.ReadLine();
        }
    }
}
