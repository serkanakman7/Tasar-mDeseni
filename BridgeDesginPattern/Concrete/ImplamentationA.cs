using BridgeDesginPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesginPattern.Concrete
{
    public class ImplamentationA : IBridge
    {
        public string OperationImp()
        {
            return "Implamentation A";
        }
    }
}
