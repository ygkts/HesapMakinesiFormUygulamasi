using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3_HesapMakineDatagrideYazma
{
    class Islem
    {
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }
        public string IslemTipi { get; set; }
        public double Sonuc { get; set; }
        public double GetToplam()
        {
            return Sonuc = Convert.ToDouble(Sayi1) + Convert.ToDouble(Sayi2);
        }
        public double GetCikarim()
        {
            return Sonuc = Convert.ToDouble(Sayi1) - Convert.ToDouble(Sayi2);
        }
        public double GetCarpim()
        {
            return Sonuc = Convert.ToDouble(Sayi1) * Convert.ToDouble(Sayi2);
        }
        public double GetBolum()
        {
            return Sonuc = Convert.ToDouble(Sayi1) / Convert.ToDouble(Sayi2);
        }
        public double GetKarekok()
        {
            return Sonuc =Convert.ToDouble(Math.Sqrt(Sayi1));
        }
    }
}
