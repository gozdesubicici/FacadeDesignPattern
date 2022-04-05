using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class SicakYemekBolumu
    {
        public void SicakSiparis(Musteri musteri, string sicakSiparis)
        {
            Console.WriteLine(musteri.SiparisNumarasi + " numaralı " + sicakSiparis + " sıcak siparişi alındı." );
        }
    }

    public class SogukYemekBolumu
    {
        public void SogukSiparis(Musteri musteri, string sogukSiparis)
        {
            Console.WriteLine(musteri.SiparisNumarasi + " numaralı " + sogukSiparis + " soğuk siparişi alındı.");
        }
    }

    public class IcecekBolumu
    {
        public void IcecekSiparis(Musteri musteri, string icecek)
        {
            Console.WriteLine(musteri.SiparisNumarasi + " numaralı " + icecek + " içecek siparişi alındı.");
        }

    }
}
