using BridgeDesginPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesginPattern.Concrete
{
    public class Abstraction
    {
        private IBridge _bridge;
        public Abstraction(IBridge bridge)
        {
            _bridge = bridge;
        }

        public string Operation()
        {
            return "Abstraction <>" + _bridge.OperationImp();
        }
    }
}
