using BuiderDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderDesignPattern.Concrete
{
    public class OpelConcreteBuilder:ArabaBuilder
    {
        public OpelConcreteBuilder()
        {
            araba = new Araba();
        }

        public override void SetMarka()
        {
            araba.Marka = "Opel";
        }

        public override void SetModel()
        {
            araba.Model = "Astra";
        }

        public override void SetKM()
        {
            araba.KM = 100;
        }

        public override void SetVites()
        {
            araba.Vites = true;
        }
    }
}
