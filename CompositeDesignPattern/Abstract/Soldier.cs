using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern.Abstract
{
    public abstract class Soldier
    {
        protected string _name;

        protected Soldier(string name)
        {
            _name = name;
        }

        public abstract void ExecuteOrder();
    }
}
