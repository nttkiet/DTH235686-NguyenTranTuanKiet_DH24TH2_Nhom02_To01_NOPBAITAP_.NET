namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PhuongTrinhBacHai pt=new PhuongTrinhBacHai();
            pt.nhap();
            pt.TheHien();
        }
    }
}
