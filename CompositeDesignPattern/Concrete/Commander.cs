using CompositeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern.Concrete
{
    public class Commander : SoldierComposite
    {
        private List<Soldier> _soldier = new List<Soldier>();
        public Commander(string name) : base(name)
        {

        }
        public override void AddSoldier(Soldier soldier)
        {
            _soldier.Add(soldier);
        }

        public override void ExecuteOrder()
        {
            Console.WriteLine($"{_name}");
            foreach(var soldiers in _soldier)
            {
                soldiers.ExecuteOrder();
            }
        }

        public override void RemoveSoldier(Soldier soldier)
        {
            _soldier.Remove(soldier);
        }
    }
}
