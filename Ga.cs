using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     public class Ga : NguyenLieu
     {
         public override string Ten => "Ga";
         public override void TinhDinhDuong()
         {
             Carb = 0;
             Fat = 15;
             FatBaoHoa = 4;
             Protein = 17;
             Calo = 211;
         }
     }
}