namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("nhap so luog nhan vien:");
            n = int.Parse(Console.ReadLine());
            NhanVien[] st = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap thong tin nhan vien thu:" + (i + 1).ToString());
                st[i] = new NhanVien();
                st[i].nhap();
            }
            Console.WriteLine("danh sach nhan vien:");
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", "Dinh Danh", "Ho Ten", "Nam Sin ", "Bac Luong", "Luong");
            for (int i = 0; i < n; i++)
            {
                st[i].xuat();
            }
        }
    }
}
