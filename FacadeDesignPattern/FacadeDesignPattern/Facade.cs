using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Facade
    {
        private SicakYemekBolumu _sicakYemekBolumu;
        private SogukYemekBolumu _sogukYemekBolumu;
        private IcecekBolumu _icecekBolumu;

        public Facade()
        {
            _sicakYemekBolumu = new SicakYemekBolumu();
            _sogukYemekBolumu = new SogukYemekBolumu();
            _icecekBolumu = new IcecekBolumu();
        }

        public void SicakSiparisVer(Musteri musteri, string siparis)
        {
            _sicakYemekBolumu.SicakSiparis(musteri, siparis);
        }

        public void SogukSiparisVer(Musteri musteri, string siparis)
        {
            _sogukYemekBolumu.SogukSiparis(musteri, siparis);
        }

        public void IcecekSiparisVer(Musteri musteri, string icecek)
        {
            _icecekBolumu.IcecekSiparis(musteri, icecek);
        }
    }
}
