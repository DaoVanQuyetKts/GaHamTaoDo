using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     public class DinhDuongHelper
     {
         private const double CALO_MOT_BUA = 600;
         private const double CALO_DOT_CHAY_30_PHUT = 147.5;

         public static void KiemTraDinhDuong(MonAn monAn, double carbMax, double fatMax, double fatBaoHoaMax, double proteinMax, double caloMax)
         {
          var (carb, fat, fatBaoHoa, protein, calo) = monAn.GetDinhDuong();

          Console.WriteLine("\nKết quả kiểm tra dinh dưỡng: ");
          KiemTraVaDeXuat(carb, carbMax, "Carb");
          KiemTraVaDeXuat(fat, fatMax, "Fat");
          KiemTraVaDeXuat(fatBaoHoa, fatBaoHoaMax, "Fat bão hòa");
          KiemTraVaDeXuat(protein, proteinMax, "Protein");
          KiemTraVaDeXuat(calo, caloMax, "Calo");
         }

         private static void KiemTraVaDeXuat(string tenDinhDuong, double giaTri, double gioiHan)
         {
          Console.writeLine($"{tenDinhDuong}: {giaTri:F2}");
          if (giaTri < gioiHan)
          {
               Console.WriteLine($"Cần bổ sung {gioiHan - giaTri:F2} {tenDinhDuong}");
          }
          public static void TinhThoiGianChayBo(MonAn monAn)
          {
               var (_, _, _, _, calo) = monAn.TinhTongDinhDuong();
               dounle caloDu = calo - CALO_MOT_BUA;

               if (caloDu <= 0)
               {
                    Console.WriteLine("Không cần chạy bộ");
                    return;
               }

               double thoiGianChayBo = caloDu / CALO_DOT_CHAY_30_PHUT * 30;
               Console.WriteLine($"Cần chạy bộ {thoiGianChayBo:F2} phút");
          }
         
        
         }
         
             

     }
}