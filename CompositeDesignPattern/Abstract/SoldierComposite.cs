using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern.Abstract
{
    public abstract class SoldierComposite : Soldier
    {
        protected SoldierComposite(string name) : base(name)
        {

        }

        public abstract void AddSoldier(Soldier soldier);
        public abstract void RemoveSoldier(Soldier soldier);
    }
}
