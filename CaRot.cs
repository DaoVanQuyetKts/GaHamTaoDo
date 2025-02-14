using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     public class CaRot : NguyenLieu
     {
         public override string Ten => "Ca Rot";
         public override void TinhDinhDuong()
         {
             Carb = 10;
             Fat = 3;
             FatBaoHoa = 0;
             Protein = 1;
             Calo = 41;
         }
     }
}