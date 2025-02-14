using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Gahamtaodoan
{
     public abstract class NguyenLieu : INguyenLieu
     {
         protected double Carb;
         protected double Fat;
         protected double FatBaoHoa;
         protected double Protein;
         protected double Calo;

         public abstract string Ten { get; }
         public double KhoiLuong { get; set; }  

         public abstract void TinhDinhDuong();

         public double GetCarb() => Carb * KhoiLuong / 100;
         public double GetFat() => Fat * KhoiLuong / 100;
         public double GetFatBaoHoa() => FatBaoHoa * KhoiLuong / 100;
         public double GetProtein() => Protein * KhoiLuong / 100;
         public double GetCalo() => Calo * KhoiLuong / 100;
     }
}