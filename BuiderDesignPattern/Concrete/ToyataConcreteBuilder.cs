using BuiderDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderDesignPattern.Concrete
{
    public class ToyataConcreteBuilder : ArabaBuilder
    {
        public ToyataConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetMarka()
        {
            araba.Marka = "Toyota";
        }

        public override void SetModel()
        {
            araba.Model = "Corolla";
        }

        public override void SetKM()
        {
            araba.KM = 150;
        }

        public override void SetVites()
        {
            araba.Vites = true;
        }
    }
}
