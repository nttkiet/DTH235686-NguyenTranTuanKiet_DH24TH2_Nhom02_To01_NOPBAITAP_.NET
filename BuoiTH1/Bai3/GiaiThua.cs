using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class GiaiThua
    {
       public int nhap()
        {
            int so;
           so= Convert.ToInt32(Console.ReadLine());
            return so;

        }
        public long tinhgiathua(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt = gt * i;
            }   
            return gt;
        }

    }
}
