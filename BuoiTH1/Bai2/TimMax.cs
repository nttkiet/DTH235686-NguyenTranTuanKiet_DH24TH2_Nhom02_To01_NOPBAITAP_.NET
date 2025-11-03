using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class TimMax
    {
        public int nhap()
        {
            int so;
            so=Convert.ToInt32(Console.ReadLine());
            return so;
        }
        public int timMax(int n)
        {
            int i = 0;
            int max = 0;
            int sotam;
            do
            {
                Console.WriteLine("nhap so thu {0}", i+1);
                sotam=Convert.ToInt32(Console.ReadLine());
                if (max < sotam)
                    max = sotam;
                i++;
            }while(i<n);
            return max;
        }
    }
}
