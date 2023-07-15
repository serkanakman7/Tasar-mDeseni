using ObserverDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Concrete
{
    public class Ogrenci
    {
        public string Isim { get; set; }
        public string SoyAd { get; set; }
        public int Yas { get; set; }
        bool dersiAstiMi;

        public bool DersiAstiMi
        {
            get
            {
                return dersiAstiMi;
            }
            set
            {
                if (dersiAstiMi = value)
                {
                    Notify();
                    dersiAstiMi = value;
                }
                else
                {
                    dersiAstiMi = value;
                }
            }
        }
        List<Observer> _observer = new List<Observer>();
        public void AboneAttach(Observer observer)
        {
            _observer.Add(observer);
        }
        public void AboneRemove(Observer observer)
        {
            _observer.Remove(observer);
        }
        public void Notify()
        {
            _observer.ForEach(g =>
            {
                g.Update();
            });
        }
    }
}
