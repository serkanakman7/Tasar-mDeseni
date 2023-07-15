using ObserverDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Concrete
{
    public class BabaObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Öğrenci kaçtı babasına bilgi gönderildi");
        }
    }
}
