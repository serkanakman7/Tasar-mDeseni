using ObserverDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Concrete
{
    public class OgretmenObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Öğrenci kaçtı bilgisi öğretmene gönderildi");
        }
    }
}
