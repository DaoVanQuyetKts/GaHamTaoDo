using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     public class TaoDo : NguyenLieu
     {
         public override string Ten => "TaoDo";
         public override void TinhDinhDuong()
         {
             Carb = 3;
             Fat = 1;
             FatBaoHoa = 0;
             Protein = 1;
             Calo = 52;
         }
     }// thử nghiệm GitHup lần 2 xem có được không
}