using CompositeDesignPattern.Concrete;
using System;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Commander general = new Commander("Selim");

            general.AddSoldier(new BuckPrivate("Müslüm"));
            general.AddSoldier(new BuckPrivate("Safa"));

            Commander albay = new Commander("Hilmi");
            Commander yarbay = new Commander("Cavit");

            albay.AddSoldier(yarbay);
            general.AddSoldier(albay);
            general.ExecuteOrder();
        }
    }
}
