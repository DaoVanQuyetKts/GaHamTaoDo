using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     public class NamDongCo : NguyenLieu
     {
         public override string Ten => "NamDongCo";
         public override void TinhDinhDuong()
         {
             Carb = 1;
             Fat = 0;
             FatBaoHoa = 0;
             Protein = 15;
             Calo = 10;
         }
     }
}