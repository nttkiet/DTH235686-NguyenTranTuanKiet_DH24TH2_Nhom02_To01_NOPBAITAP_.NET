using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class NhanVien
    {
        private int _DinhDanh;
        private string _HoTen;
        private int _NamSinh;
        private double _BacLuong;
        public double LuongCoBan = 200000;
        private double _Luong;

        public NhanVien()
        {
            dinhdanh = 0;
            hoten = "";
            namsinh = 0;
            bacluong = 0;
            luong = 0;
        }
        public int dinhdanh
        {
            get
            {
                return _DinhDanh;
            }
            set
            {
                _DinhDanh = value;
            }
        }
            public string hoten
        {
            get
            {
                return _HoTen;

            }
            set
            {
                _HoTen = value;
            }
        }
        public int namsinh
        {
            get
            {
                return _NamSinh;
            }
            set
            {
                _NamSinh = value;
            }
        }
        public double bacluong
        {
            get
            {
                return _BacLuong;
            }
            set
            {
                _BacLuong = value;
            }

        }
        public double luong
        {
            get
            {
                return Math.Round((LuongCoBan*bacluong));
            }
            set
            {
                _Luong = value;
            }
        }
        public void nhap()
        {
            Console.Write("nhap dinh danh: ");
            dinhdanh=int.Parse(Console.ReadLine());
            Console.Write("nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("nhap nam sinh: ");
            namsinh = int.Parse(Console.ReadLine());
            Console.Write("nhap bac luong: ");
            bacluong = double.Parse(Console.ReadLine());

        }
        public void xuat()
        {
                       Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", dinhdanh, hoten, namsinh, bacluong, luong);
        }
    }
}
