susing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     public class MonAn
     {
          private List<INguyenLieu> nguyenLieu;
          private const double TY_LE_HAP_THU = 0.8;
          public MonAn()
          {
              nguyenLieu = new List<INguyenLieu>();
          }
          public void ThemNguyenLieu(INguyenLieu nl)
          {
              nl.TinhDinhDuong();
              nguyenLieu.Add(nl);
          } 

          public (double carb, double fat, double fatBaoHoa, double protein, double calo) TinhDinhDuong()
          {
               double tongCarb = 0, tongFat = 0, tongFatBaoHoa = 0, tongProtein = 0, tongCalo = 0;

               foreach (var nl in nguyenLieu)
               {
                    tongCarb += nl.GetCarb() * TY_LE_HAP_THU;
                    tongFat += nl.GetFat() * TY_LE_HAP_THU;
                    tongFatBaoHoa += nl.GetFatBaoHoa() * TY_LE_HAP_THU;
                    tongProtein += nl.GetProtein() * TY_LE_HAP_THU;
                    tongCalo += nl.GetCalo() * TY_LE_HAP_THU;
               }

               return (tongCarb, tongFat, tongFatBaoHoa, tongProtein, tongCalo);
          }
     }

}