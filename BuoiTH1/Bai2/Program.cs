using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding = Encoding.UTF8;
            TimMax tm = new TimMax();
            int n;
            Console.Write("nhap n: ");
            n=tm.nhap();
            Console.WriteLine("So lon nhat trong {0} day la: {1}",n,tm.timMax(n));
            Console.ReadLine();
        }
    }
}
