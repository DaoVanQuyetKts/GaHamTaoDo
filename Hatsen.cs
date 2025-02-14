using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     public class Hatsen : NguyenLieu
     {
           public override string Ten => "Hatsen";
           public override void TinhDinhDuong()
           {
                Carb = 17;
                Fat = 0;
                FatBaoHoa = 1;
                Protein = 4;
                Calo = 89;
           }
     }
}