using CompositeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern.Concrete
{
    public class BuckPrivate : Soldier
    {
        public BuckPrivate(string name):base(name)
        {

        }

        public override void ExecuteOrder()
        {
            Console.WriteLine($"{_name}");
        }
    }
}
