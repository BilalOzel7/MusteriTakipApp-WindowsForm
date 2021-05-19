using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakipApp.DTO
{
   public class SatisDTO
    {
        public int SatisId { get; set; }
        public int FaturaNo { get; set; }
        public string UrunAd { get; set; }
        public string MusteriAd { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Fiyat { get; set; }
    }
}
