using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     public interface INguyenLieu
     {
         string Ten { get; set; }
         double KhoiLuong { get; set; }
         double GetCarb { get; set; }
         double GetFat { get; set; }
         double GetFatBaoHoa { get; set; }
         double GetProtein { get; set; }
         double GetCalo { get; set; }
         void TinhDinhDuong();
     }
}