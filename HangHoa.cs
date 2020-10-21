using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project_1_Dương_Vũ_Hoàng_Việt
{
    class HangHoa
    {
        private StreamReader SR;
        private StreamWriter SW;
        private string filename = @"E:\hanghoa.txt";
        public HangHoa()
        {
            
        }
        public void HienThiHangHoa()
        {
            Console.Clear();
            SR =new StreamReader(filename);
            string[] plit;
            string docfile;
            do
            {
                docfile = SR.ReadLine();
                plit = docfile.Split("|");
            }
            while (docfile == null);
            Console.SetCursorPosition(1,1); 
            Console.WriteLine("Mã SP");
            Console.SetCursorPosition(plit[0].Length + 5,1 ); 
            Console.WriteLine("Tên SP");
            Console.SetCursorPosition(plit[0].Length + 5 + plit[1].Length + 6, 1); 
            Console.WriteLine("Đơn giá");
            Console.SetCursorPosition(plit[0].Length + 5 + plit[1].Length + 6 + plit[2].Length + 7, 1 ); 
            Console.WriteLine("Số Lượng");
            Console.SetCursorPosition(plit[0].Length + 5 + plit[1].Length + 6 + plit[2].Length + 7 + plit[3].Length + 8, 1); 
            Console.WriteLine("Đơn vị tính");
            Console.SetCursorPosition(plit[0].Length + 5 + plit[1].Length + 6 + plit[2].Length + 7 + plit[3].Length + 8 + plit[4].Length + 11, 1);
            Console.WriteLine("Thành tiền(VNĐ)");
            
            Console.SetCursorPosition(1, 2); 
            Console.WriteLine(plit[0]);
            Console.SetCursorPosition(plit[0].Length + 5, 2); 
            Console.WriteLine(plit[1]);
            Console.SetCursorPosition(plit[0].Length + 5 + plit[1].Length + 6, 2);
            Console.WriteLine(plit[2]);
            Console.SetCursorPosition(plit[0].Length + 5 + plit[1].Length + 6 + plit[2].Length + 7, 2); 
            Console.WriteLine(plit[3]);
            Console.SetCursorPosition(plit[0].Length + 5 + plit[1].Length + 6 + plit[2].Length + 7 + plit[3].Length + 8, 2); 
            Console.WriteLine(plit[4]);
            Console.SetCursorPosition(plit[0].Length + 5 + plit[1].Length + 6 + plit[2].Length + 7 + plit[3].Length + 8 + plit[4].Length + 11, 2); 
            Console.WriteLine(plit[5]);
            SR.Close();
        }
        public void Themsp()
        {
            Console.Clear();
            SW = new StreamWriter(filename);
            string tensp, masp, donvitinh;
            int dongia, soluong;
            do {
                Console.SetCursorPosition(43,8);
                Console.Write("Nhập Mã SP:"); masp = Console.ReadLine();
            } while (masp == "");
            do
            {
                Console.SetCursorPosition(43, 9);
                Console.Write("Nhập Tên SP:"); tensp = Console.ReadLine();
            } while (tensp == "");
            Console.SetCursorPosition(43, 10);
            Console.Write("Đơn giá:"); dongia = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(43, 11);
            Console.Write("Số lượng:"); soluong = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(43, 12);
            Console.Write("Đơn vị tính:"); donvitinh = Console.ReadLine();
            int thanhtien = dongia * soluong;
            Console.WriteLine($"Thành tiền(VNĐ):{thanhtien}");
            Console.WriteLine("Đã thêm sản phẩm vào kho !");
            SW.WriteLine($"{masp}|{tensp}|{dongia}|{soluong}|{donvitinh}|{thanhtien}");
            SW.Close();
        }
        public void Suasp()
        {
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\t\t\t\t\tNhập Mã SP cần sửa:"); string masp = Console.ReadLine();
            Console.Write("\t\t\t\t\tNhập Mã SP mới:"); string tensp = Console.ReadLine();
            Console.Write("\t\t\t\t\tNhập Tên SP mới:"); string maspmoi = Console.ReadLine();
            Console.Write("\t\t\t\t\tĐơn giá:"); int dongia = int.Parse(Console.ReadLine());
            Console.Write("\t\t\t\t\tSố lượng:"); int soluong = int.Parse(Console.ReadLine());
            Console.Write("\t\t\t\t\tĐơn vị tính:"); string donvitinh = Console.ReadLine();
            Console.WriteLine("\n\n\n\t\t\t\tSản phẩm đã được sửa thành công !");
            int thanhtien = dongia * soluong;
            string temp = "";
            SR = new StreamReader(filename);
            string read;
            while ((read = SR.ReadLine()) != null)
            {
                string[] dlhanghoa = read.Split('|');
                if (dlhanghoa[1] == masp)
                {
                    temp += maspmoi + '|' + tensp + '|' + dongia + '|' + soluong + '|' + donvitinh + '|' + thanhtien + '\n';
                }
                else
                {
                    temp += dlhanghoa[0] + '|' + dlhanghoa[1] + '|' + dlhanghoa[2] + '|' + dlhanghoa[3] + '|' + dlhanghoa[4]+'\n';
                }
            }
            SR.Close();
            SW = new StreamWriter(filename);
            SW.Write(temp);
            SW.Close();
        }
        public void Xoatsp()
        {

        }
        public void TimKiemsp()
        {

        }
        public void NhapvaHienthihoadonnhap()
        {
            Console.SetCursorPosition(25,  8); Console.WriteLine("|____________________________________________________________________|");
            Console.SetCursorPosition(25,  9); Console.WriteLine("|                          HÓA ĐƠN NHẬP KHO                          |");
            Console.SetCursorPosition(25, 10); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 11); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 12); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 13); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 14); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 15); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 16); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 17); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 18); Console.WriteLine("|____________________________________________________________________|");
        }
        public void XuatvaHienthihoadonxuat()
        {
            Console.SetCursorPosition(25,  8); Console.WriteLine("|____________________________________________________________________|");
            Console.SetCursorPosition(25,  9); Console.WriteLine("|                          HÓA ĐƠN XUẤT KHO                          |");
            Console.SetCursorPosition(25, 10); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 11); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 12); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 13); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 14); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 15); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 16); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 17); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 18); Console.WriteLine("|____________________________________________________________________|");
        }
        public void MENU()
        {
            Console.SetCursorPosition(25,  8); Console.WriteLine("|____________________________________________________________________|");
            Console.SetCursorPosition(25,  9); Console.WriteLine("|                    Quản Lý Danh Sách Sản Phẩm                      |");
            Console.SetCursorPosition(25, 10); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 11); Console.WriteLine("|              1. Hiển thị toàn bộ sản phẩm trong kho.               |");
            Console.SetCursorPosition(25, 12); Console.WriteLine("|              2. Thêm sản phẩm vào kho.                             |");
            Console.SetCursorPosition(25, 13); Console.WriteLine("|              3. Sửa sản phẩm trong kho.                            |");
            Console.SetCursorPosition(25, 14); Console.WriteLine("|              4. Xuất sản phẩm trong kho.                           |");
            Console.SetCursorPosition(25, 15); Console.WriteLine("|              5. Tìm Kiếm sản phẩm trong kho.                       |");
            Console.SetCursorPosition(25, 16); Console.WriteLine("|              6. Quay lại.                                          |");
            Console.SetCursorPosition(25, 17); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 18); Console.WriteLine("|____________________________________________________________________|");
            Console.SetCursorPosition(48, 17); Console.Write("Chọn công cụ số:");
            string chon = Console.ReadLine();
            if (chon == "1")
            {
                HienThiHangHoa();
                Console.ReadKey();
            }
            else if (chon == "2")
            {
                Themsp();
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                Suasp();
                Console.ReadKey();
            }
            else if (chon=="6")
            {
                return;
            }
            Console.Clear();
            MENU();
        }
    }
}
