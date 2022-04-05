

using FacadeDesignPattern;

Facade facade = new Facade();

Musteri musteri1 = new Musteri() { SiparisNumarasi="123a", SicakYemek="Domates Çorbası", SogukYemek="Zeytinyağlı Fasulye" , Icecek="Su"};

facade.SicakSiparisVer(musteri1, musteri1.SicakYemek);
facade.SogukSiparisVer(musteri1, musteri1.SogukYemek);
facade.IcecekSiparisVer(musteri1, musteri1.Icecek);

Console.ReadLine();
