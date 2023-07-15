using ObserverDesignPattern.Concrete;
using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.AboneAttach(new BabaObserver());
            ogrenci.AboneAttach(new AnneObserver());
            ogrenci.AboneAttach(new OgretmenObserver());
            ogrenci.DersiAstiMi = true;
            Console.ReadLine();
        }
    }
}
