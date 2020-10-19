using System;
using System.Text;

namespace Project_1_Dương_Vũ_Hoàng_Việt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            MENUCHINH();
        }
        static void MENUCHINH()
        {
            Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
            Console.SetCursorPosition(25,  8); Console.WriteLine("|____________________________________________________________________|");
            Console.SetCursorPosition(25,  9); Console.WriteLine("|                              MENU                                  |");
            Console.SetCursorPosition(25, 10); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 11); Console.WriteLine("|              1. Quản lý danh sách sản phẩm trong kho.              |");
            Console.SetCursorPosition(25, 12); Console.WriteLine("|              2. Hiển thị hóa đơn nhập kho ngày hôm nay.            |");
            Console.SetCursorPosition(25, 13); Console.WriteLine("|              3. Hiển thị hóa đơn xuất kho ngày hôm nay.            |");
            Console.SetCursorPosition(25, 14); Console.WriteLine("|              4. Hiển thị toàn bộ sản phẩm trong kho.               |");
            Console.SetCursorPosition(25, 15); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 16); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 17); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 18); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 19); Console.WriteLine("|____________________________________________________________________|");
            Console.SetCursorPosition(48, 18); Console.Write("Chọn công cụ số:");
            int chon = int.Parse(Console.ReadLine());Console.Clear();
            if (chon==1)
            {
                HangHoa HH = new HangHoa();
                HH.MENU();
            }
            else if (chon == 2)
            {
                HangHoa HH = new HangHoa();
                HH.Hienthihoadonnhap();
                Console.ReadKey();
            }
            else if (chon == 3)
            {
                HangHoa HH = new HangHoa();
                HH.Hienthihoadonxuat();
                Console.ReadKey();
            }
            else if (chon == 4)
            {
                HangHoa HH = new HangHoa();
                HH.HienThiHangHoa();
                Console.ReadKey();
            }
            else
            {
                MENUCHINH();
            }
            Console.Clear();
            MENUCHINH();
        }
    }
}
