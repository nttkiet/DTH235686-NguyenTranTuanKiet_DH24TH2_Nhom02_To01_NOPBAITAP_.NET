using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class MangSoNguyen
    {
        public int NhapSoDuong()
        {
            int so;
            do
            {
                so = Convert.ToInt32(Console.ReadLine());
            } while (so <= 0);
            return so;
        }
      
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        } 
        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
         
        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(" {0}", a[i]);
        }
       public int TimSoLonNhat(int[] a)
        {
            int max = a[0];
            for (int i = 0; i <a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                } 
            }
            return max;
        }
        public int TimSoNhoNhat(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        public int SapXepTangDan(int[] a)
        {
            int max = a[0];
            for (int i= 0; i < a.Length-1; i++)
            {
                for (int j=i+1;j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        max = a[i];
                        a[i] = a[j];
                        a[j] = max;
                    }

                }
            }
            return max;

        }
        public int TinhTong(int[] a)
        {
            int tong = 0;
            for(int i=0;i<a.Length;i++)
            {
                tong += a[i];
            }
            return tong;
        }

    }
} 
    
