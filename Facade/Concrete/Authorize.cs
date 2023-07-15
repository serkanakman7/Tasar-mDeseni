using Facade.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Concrete
{
    public class Authorize : IAuthorize
    {
        void IAuthorize.Authorize()
        {
            Console.WriteLine("Authorized");
        }
    }
}
