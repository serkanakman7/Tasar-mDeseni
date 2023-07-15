using BuiderDesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderDesignPattern.Abstract
{
    public abstract class ArabaBuilder
    {
        protected Araba araba;
        public Araba Araba { get; }

        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetVites();
    }
}
