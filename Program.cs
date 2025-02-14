using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     class Program
     {
          static void Main(string[] args)
          {
               MonAn gaHamTaoDo = new MonAn();
               // Nhập nguyên liệu
               NhapNguyenLieu(gaHamTaoDo);

               //Nhập giới hạn dinh dưỡng
               Console.WriteLine("\nNhập giới hạn dinh dưỡng:");
               Console.Write("Carb tối đa (g): ");
               double carbMax = double.Parse(Console.ReadLine());
               Console.Write("Fat tối đa (g): ");
               double fatMax = double.Parse(Console.ReadLine());
               Console.Write("Fat bão hòa tối đa (g): ");
               double fatBaoHoaMax = double.Parse(Console.ReadLine());
               Console.Write("Protein tối đa (g): ");
               double proteinMax = double.Parse(Console.ReadLine());
               Console.Write("Calo tối đa (kcal): ");
               double caloMax = double.Parse(Console.ReadLine());

               // Kiểm tra dinh dưỡng và tính thời gian chạy bộ
               DinhDuongHelper.KiemTraDinhDuong(gaHamTaoDo, carbMax, fatMax, fatBaoHoaMax, proteinMax, caloMax);
               DinhDuongHelper.TinhThoiGianChayBo(gaHamTaoDo);
          }

          static void NhapNguyenLieu(MonAn monAn)
          {
               Console.WriteLine("Nhập khối lượng gà (g): ");
               var ga = new Ga { KhoiLuong = double.Parse(Console.ReadLine()) };
               monAn.ThemNguyenLieu(ga);
               Console.WriteLine("Nhập khối lượng hạt sen (g): ");
               var hatSen = new HatSen { KhoiLuong = double.Parse(Console.ReadLine()) };
               monAn.ThemNguyenLieu(hatSen);
               Console.WriteLine("Nhập khối lượng Cà rốt (g): ");
               var caRot = new CaRot { KhoiLuong = double.Parse(Console.ReadLine()) };
               monAn.ThemNguyenLieu(caRot);
               Console.WriteLine("Nhập khối lượng Táo đỏ (g): ");
               var taoDo = new TaoDo { KhoiLuong = double.Parse(Console.ReadLine()) };
               monAn.ThemNguyenLieu(taoDo);
               Console.WriteLine("Nhập khối lượng nấm đông cô (g): ");
               var namDongCo = new NamDongCo { KhoiLuong = double.Parse(Console.ReadLine()) };
               monAn.ThemNguyenLieu(namDongCo);
          }
     }
}
/* Cấu trúc này đảm bảo:
Tính kế thừa:
Các lớp con (Ga, HatSen, CaRot) kế thừa từ lớp abstract NguyenLieu
Mỗi lớp con định nghĩa các giá trị dinh dưỡng riêng
Tính đa hình:
Interface INguyenLieu định nghĩa các phương thức chung
Mỗi lớp con override phương thức TinhDinhDuong()
MonAn có thể xử lý bất kỳ nguyên liệu nào thông qua interface
Đóng gói:
Các thuộc tính dinh dưỡng được protected trong NguyenLieu
Logic tính toán được ẩn trong các phương thức
Tính trừu tượng:
NguyenLieu là lớp abstract
Interface INguyenLieu định nghĩa contract chung
*/